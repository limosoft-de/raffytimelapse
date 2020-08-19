Imports System.Net

Public Class form_main

    Dim DownloadVersion As Version
    Dim NetcheckURL As String = "sourceforge.net"
    Dim ConfigURL As String = "https://simpletimelapse.sourceforge.io/update/update.xml"
    Dim DownloadURL As String = "" 'will be overridden by GetUpdateValues()
    Dim UpdaterPath As String = Application.UserAppDataPath & "\RaffyInstaller"
    Dim UpdaterExtension As String = ".msi" 'will be overridden by GetUpdateValues()
    Dim UpdaterStarted As Boolean = False

#Region "Form Events"

    Private Sub Form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_UpdaterVersion.Text = "v " & Application.ProductVersion

        Dim arguments As String() = Environment.GetCommandLineArgs()

        If arguments.Length > 1 Then
            If Version.TryParse(arguments(1), DownloadVersion) Then
                Lbl_RaffyVersion.Text = "Version: " & arguments(1)
                Lbl_RaffyVersion.Visible = True
            End If
        End If

    End Sub

    Private Sub form_main_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Application.DoEvents()

        If TestConnection() = False Then
            MessageBox.Show("Can't establish connection to the update servers, please try again later. Raffy Timelapse Updater will close now.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
            Exit Sub
        End If

        Lbl_Status.Text = "Locating update server..."
        If GetUpdateValues() = False Then
            MessageBox.Show("Can't establish connection to the configuration server, please try again later. Raffy Timelapse Updater will close now.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
            Exit Sub
        End If

        Lbl_Status.Text = "Downloading update package..."
        DownloadStart()

    End Sub

#End Region

#Region "TestConnection"
    Function TestConnection() As Boolean
        Try
            My.Computer.Network.Ping(NetcheckURL)
        Catch ex As Exception
            Return False
            Exit Function
        End Try
        Return True
    End Function
#End Region

#Region "GetUpdateValues"
    Public Function GetUpdateValues() As Boolean

        Try
            Dim updateXml As XDocument = XDocument.Load(ConfigURL & "?Refresh=" & Guid.NewGuid().ToString()) 'USING GUID PARAMETER TO AVOID IE CACHING
            DownloadURL = updateXml.Root.Element("url").Value
            UpdaterExtension = updateXml.Root.Element("extension").Value

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "Download"
    Public WithEvents Downloader As WebClient
    Public Sub DownloadStart()
        Downloader = New WebClient
        Downloader.DownloadFileAsync(New Uri(DownloadURL), UpdaterPath & UpdaterExtension)
    End Sub

    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged

        Pb_Progress.Value = e.ProgressPercentage

        If e.ProgressPercentage = 100 Then
            Lbl_Status.Text = "Starting Setup..."
            RunUpdater()
        End If

    End Sub
#End Region

#Region "RunUpdater"
    Public Sub RunUpdater()
        If UpdaterStarted = False Then

            UpdaterStarted = True
            Process.Start(UpdaterPath & UpdaterExtension)
            Close()

        End If
    End Sub
#End Region

End Class
