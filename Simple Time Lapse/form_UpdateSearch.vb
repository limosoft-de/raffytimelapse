Imports System.ComponentModel

Public Class form_UpdateSearch

    Private Sub Form_UpdateSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TranslateForm()
    End Sub

    Private Sub TranslateForm()
        Text = TransString("Update")
        lbl_progress.Text = TransString("UpdateSearch_lbl_progress0")
    End Sub

    Private Sub form_UpdateSearch_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Application.DoEvents()
        bw_UpdateSearch.RunWorkerAsync()
    End Sub

    Function testconnection() As Boolean
        Try
            My.Computer.Network.Ping("sourceforge.net")
        Catch ex As Exception
            Return False
            Exit Function
        End Try

        Return True
    End Function


    Private Sub Bw_UpdateSearch_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_UpdateSearch.DoWork

        Dim NewVersionString As String
        Dim Changelog As String


        Application.DoEvents()

        Invoke(Sub()

                   'TEST CONNECTION
                   If testconnection() = False Then
                       bw_UpdateSearch.ReportProgress(-1)
                       Exit Sub
                       Exit Sub
                   End If

                   'GET NEWEST VERSION NUMBER
                   Dim VersionBrowser As New WebBrowser
                   VersionBrowser.Navigate("http://simpletimelapse.sourceforge.net/update/version.txt" & "?Refresh=" & Guid.NewGuid().ToString()) 'USING GUID PARAMETER TO AVOID IE STUPID CACHING
                   Do Until VersionBrowser.ReadyState = WebBrowserReadyState.Complete
                       Application.DoEvents()
                   Loop
                   NewVersionString = VersionBrowser.Document.Body.InnerText

                   'COMPARE VERSIONS
                   Dim LocalVersion As New Version(Application.ProductVersion)
                   Dim NewVersion As New Version(NewVersionString)

                   If LocalVersion = NewVersion Then
                       'ALREADY USING LATEST VERSION
                       bw_UpdateSearch.ReportProgress(1)
                       Exit Sub
                       Exit Sub
                   Else
                       bw_UpdateSearch.ReportProgress(2)
                   End If

                   'GET CHANGELOG
                   Dim ChangelogBrowser As New WebBrowser
                   ChangelogBrowser.Navigate("http://simpletimelapse.sourceforge.net/update/changelog.txt" & "?Refresh=" & Guid.NewGuid().ToString())
                   Do Until ChangelogBrowser.ReadyState = WebBrowserReadyState.Complete
                       Application.DoEvents()
                   Loop
                   ChangelogBrowser.Refresh(WebBrowserRefreshOption.Completely)
                   Changelog = ChangelogBrowser.Document.Body.InnerText

                   Dim UpdateDetails As New form_update(NewVersionString, Changelog)
                   UpdateDetails.ShowDialog()
                   Close()


               End Sub)

    End Sub

    Private Sub bw_UpdateSearch_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bw_UpdateSearch.ProgressChanged

        Select Case e.ProgressPercentage
            Case -1
                lbl_progress.Text = TransString("UpdateSearch_lbl_progress-1")
                Pb_loading.Image = My.Resources.cancel
                bw_UpdateSearch.CancelAsync()
            Case 1
                lbl_progress.Text = TransString("UpdateSearch_lbl_progress1")
                Pb_loading.Image = My.Resources.done
                bw_UpdateSearch.CancelAsync()
            Case 2
                lbl_progress.Text = TransString("UpdateSearch_lbl_progress2")
                Pb_loading.Image = My.Resources.loading
        End Select

    End Sub

End Class