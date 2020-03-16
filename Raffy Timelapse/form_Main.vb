Imports System.IO
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class form_main


    Public MultiSelect As Boolean = False
    Public Finished As Boolean = False
    Public FFmpegExists As Boolean = False
    Public FFmpegPath As String = Application.StartupPath + "\ffmpeg.exe"
    Public FFmpegBit As Integer = 32
    Public Status As String = TransString("_General_wait")

    'PROGRESS
    Public TotalFrames As Integer = 0
    Public RenderProgress As Integer = 0
    Public ConvertProgress As Integer = 0

    'If you add something to the projects variables, also add it in ResetProject Sub!

    '/||Projekt-Variablen
    Public ImportFileList As String()

    Dim PicFileType As String = ""
    Dim PicTempPath As String = ""
    Public PicWidth As Integer = 0
    Public PicHeight As Integer = 0
    Dim PicFiles As String() = Nothing
    Dim PicImportedFiles As List(Of String) = Nothing

    Public MovPath As String = ""
    Public MovFileType As String = ""
    Public MovFPS As Integer = 0
    Public MovWidth As Integer
    Public MovHeight As Integer
    Public MovRes As String = ""
    Public MovPreset As String = ""
    '||\Projekt-Variablen


#Region "Form-Ereignisse"

    Private Sub form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pnl_TimelineOverlay.Top = (ClientSize.Height - lbl_drop.Height) / 2 - 30
        TranslateForm()
    End Sub

    Private Sub form_main_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Check64bit()
        CheckForFFmpeg()

        If My.Settings.set_AutoUpdate = True Then
            bw_AutoUpdate.RunWorkerAsync()
        End If

    End Sub

    Private Sub form_main_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Pnl_TimelineOverlay.Top = (Me.ClientSize.Height - lbl_drop.Height) / 2 - 30

    End Sub

    Private Sub form_main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If lb_pictures.Items.Count > 0 Then
            If MessageBox.Show(TransString("Main_msg_closing"), TransString("_General_warning"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                e.Cancel = True
            End If
        End If

    End Sub

#End Region

#Region "Translation"

    Public Sub TranslateForm()

        lbl_timeline.Text = TransString("Main_lbl_timeline")
        lbl_preview.Text = TransString("Main_lbl_preview")
        lbl_drop.Text = TransString("Main_lbl_drop")

        gb_PictureEdit.Text = TransString("Main_gb_PictureEdit")

        btn_del.Text = TransString("Main_btn_del")
        btn_drop.Text = TransString("Main_btn_drop")
        btn_MoveDwn.Text = TransString("Main_btn_MoveDwn")
        btn_MoveUp.Text = TransString("Main_btn_MoveUp")
        btn_MultiSelect.Text = TransString("Main_btn_MultiSelect")
        btn_start.Text = TransString("Main_btn_start")

        ms_file.Text = TransString("Main_ms_file")
        ms_file_new.Text = TransString("Main_ms_file_new")
        ms_file_new_project.Text = TransString("Main_ms_file_new_project")
        ms_file_new_window.Text = TransString("Main_ms_file_new_window")
        ms_file_import.Text = TransString("Main_ms_file_import")
        ms_file_exit.Text = TransString("Main_ms_file_exit")
        ms_about.Text = TransString("Main_ms_about")
        ms_about_about.Text = TransString("Main_ms_about_about")
        ms_about_credits.Text = TransString("Main_ms_about_credits")
        ms_about_settings.Text = TransString("Main_ms_about_settings")
        ms_about_update.Text = TransString("Main_ms_about_update")
        ms_help.Text = TransString("Main_ms_help")
        ms_help_help.Text = TransString("Main_ms_help_help")
        ms_help_SupportUs.Text = TransString("Main_ms_help_SupportUs")

    End Sub

#End Region

#Region "Reset Project"

    Private Sub ResetProject()

        If lb_pictures.Items.Count > 0 Then
            If MessageBox.Show(TransString("Main_msg_NewProject"), TransString("_General_warning"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Exit Sub
            End If
        End If

        PicFileType = ""
        PicTempPath = ""
        PicWidth = 0
        PicHeight = 0
        PicFiles = Nothing
        PicImportedFiles = Nothing

        MovPath = ""
        MovFileType = ""
        MovFPS = 0
        MovWidth = 0
        MovHeight = 0
        MovRes = ""
        MovPreset = ""

        Try
            pb_preview.BackgroundImage.Dispose()
        Catch ex As Exception
        End Try

        pb_preview.BackgroundImage = Nothing
        lb_pictures.Items.Clear()

        MultiSelect = False
        btn_MultiSelect.Image = My.Resources.multi_black

        UpdateForm()

    End Sub

#End Region

#Region "FFmpeg/64bit Check"

    Private Sub Check64bit()
        If Environment.Is64BitOperatingSystem = True Then
            FFmpegPath = Application.StartupPath + "\ffmpeg64.exe"
            FFmpegBit = 64
        Else
            FFmpegPath = Application.StartupPath + "\ffmpeg.exe"
            FFmpegBit = 32
        End If
    End Sub

    Private Sub CheckForFFmpeg()
        If File.Exists(FFmpegPath) Then
            FFmpegExists = True
        Else
            If FFmpegBit = 64 And File.Exists(Application.StartupPath + "\ffmpeg.exe") Then
                FFmpegPath = Application.StartupPath + "\ffmpeg.exe"
                FFmpegExists = True
                FFmpegBit = 32
                Exit Sub
            End If
            FFmpegExists = False
                If MessageBox.Show(TransString("Main_msg_ffmpeg"), TransString("_General_error"), MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                    Process.Start(My.Settings.url_FFmpeg)
                Else
                    Close()
                End If
            End If
    End Sub

#End Region

#Region "UI"

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        If FFmpegExists = False Then
            CheckForFFmpeg()
            Exit Sub
        End If

        form_ProjectSettings.ShowDialog()

    End Sub

    Private Sub btn_MoveUp_Click(sender As Object, e As EventArgs) Handles btn_MoveUp.Click
        ImgMoveUp()
    End Sub

    Private Sub btn_MoveDwn_Click(sender As Object, e As EventArgs) Handles btn_MoveDwn.Click
        ImgMoveDown()
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click

        If lb_pictures.SelectedItems.Count = 1 Then
            SingleDelete()
        ElseIf lb_pictures.SelectedItems.Count > 1 Then
            MultiDelete()
        End If

    End Sub

    Private Sub lb_pictures_KeyDown(sender As Object, e As KeyEventArgs) Handles lb_pictures.KeyDown
        If e.KeyCode = Keys.Delete Then 'delte image(s) in listbox
            If lb_pictures.SelectedItems.Count = 1 Then
                SingleDelete()
            ElseIf lb_pictures.SelectedItems.Count > 1 Then
                MultiDelete()
            End If
        End If

        Select Case My.Settings.set_ImgMove 'move image up or down
            Case 0
                If e.KeyCode = Keys.NumPad2 Then
                    ImgMoveDown()
                ElseIf e.KeyCode = Keys.NumPad8 Then
                    ImgMoveUp()
                End If
            Case 1
                If e.KeyCode = Keys.S Then
                    ImgMoveDown()
                ElseIf e.KeyCode = Keys.W Then
                    ImgMoveUp()
                End If
        End Select

    End Sub

    Private Sub btn_MultiSelect_Click_1(sender As Object, e As EventArgs) Handles btn_MultiSelect.Click

        Select Case MultiSelect
            Case False
                MultiSelect = True
                btn_MultiSelect.Image = My.Resources.multi_white
                btn_MoveUp.Enabled = False
                btn_MoveDwn.Enabled = False
                btn_start.Enabled = False
                lb_pictures.SelectionMode = SelectionMode.MultiExtended
            Case True
                MultiSelect = False
                btn_MultiSelect.Image = My.Resources.multi_black
                btn_MoveUp.Enabled = True
                btn_MoveDwn.Enabled = True
                btn_del.Enabled = True
                btn_MultiSelect.Enabled = True
                btn_start.Enabled = True
                lb_pictures.SelectionMode = SelectionMode.One
        End Select

    End Sub

    Private Sub ImgMoveUp()
        Try
            Dim i = lb_pictures.SelectedIndex - 1
            lb_pictures.Items.Insert(i, lb_pictures.SelectedItem)
            lb_pictures.Items.RemoveAt(lb_pictures.SelectedIndex)
            lb_pictures.SelectedIndex = i
        Catch 'only one image
        End Try
    End Sub

    Private Sub ImgMoveDown()
        Try
            Dim i = lb_pictures.SelectedIndex + 2
            lb_pictures.Items.Insert(i, lb_pictures.SelectedItem)
            lb_pictures.Items.RemoveAt(lb_pictures.SelectedIndex)
            lb_pictures.SelectedIndex = i - 1
        Catch 'only one image
        End Try
    End Sub

    Private Sub SingleDelete()
        Select Case MessageBox.Show(TransString("Main_msg_SingleDelete").Replace("[%1]", "'" & getFilename(lb_pictures.SelectedItem.ToString, False) & "'"), TransString("_General_warning"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Dim i As Integer = lb_pictures.SelectedIndex
                lb_pictures.Items.Remove(lb_pictures.SelectedItem)
                Try
                    lb_pictures.SelectedIndex = i
                Catch ex1 As Exception
                    Try
                        lb_pictures.SelectedIndex = i - 1
                    Catch ex2 As Exception
                    End Try
                End Try

            Case DialogResult.No
                Exit Sub
        End Select

        If lb_pictures.Items.Count = 0 Then
            gb_PictureEdit.Enabled = False
            btn_start.Enabled = False
        Else
            gb_PictureEdit.Enabled = True
            btn_start.Enabled = True
        End If

    End Sub

    Private Sub MultiDelete()


        Select Case MessageBox.Show(TransString("Main_msg_MultiDelete"), TransString("_General_warning"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Dim i As Integer = lb_pictures.SelectedIndex

                For n As Integer = lb_pictures.SelectedItems.Count - 1 To 0 Step -1 'Each item In lb_pictures.SelectedItems
                    lb_pictures.Items.Remove(lb_pictures.SelectedItems(n))
                Next

                Try
                    lb_pictures.SelectedIndex = i
                Catch ex1 As Exception
                    Try
                        lb_pictures.SelectedIndex = i - 1
                    Catch ex2 As Exception
                    End Try
                End Try

            Case DialogResult.No
                Exit Sub
        End Select

        MultiSelect = False
        btn_MultiSelect.Image = My.Resources.multi_black
        lb_pictures.SelectionMode = SelectionMode.One

        If lb_pictures.Items.Count = 0 Then
            gb_PictureEdit.Enabled = False
            btn_start.Enabled = False
        Else
            gb_PictureEdit.Enabled = True
            btn_start.Enabled = True
        End If


    End Sub

    Private Sub UpdateForm()
        If lb_pictures.SelectedIndex >= 0 Then
            'Something is selected
            If Not MultiSelect = True Then
                gb_PictureEdit.Enabled = True
                lbl_PreviewFile.Text = getFilename(lb_pictures.SelectedItem.ToString, False)
            End If
        Else
            'Nothing is selected
            gb_PictureEdit.Enabled = False
        End If


        If lb_pictures.Items.Count = 0 Then
            Pnl_TimelineOverlay.Visible = True
            btn_start.Enabled = False
            lbl_PreviewFile.Text = ""
        Else
            Pnl_TimelineOverlay.Visible = False

            If MultiSelect = True Then
                btn_start.Enabled = False
                btn_MultiSelect.Image = My.Resources.multi_white
            ElseIf MultiSelect = False Then
                btn_start.Enabled = True
                btn_MultiSelect.Image = My.Resources.multi_black
            End If


        End If

    End Sub

#End Region

#Region "Menu Strip"

    'FILE
    Private Sub ms_file_new_project_Click(sender As Object, e As EventArgs) Handles ms_file_new_project.Click
        ResetProject()
    End Sub

    Private Sub ms_file_new_window_Click(sender As Object, e As EventArgs) Handles ms_file_new_window.Click
        Process.Start(Application.StartupPath & "\" & System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & ".exe")
    End Sub

    Private Sub ImportImagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ms_file_import.Click
        BrowseImages()
    End Sub

    Private Sub ms_file_exit_Click(sender As Object, e As EventArgs) Handles ms_file_exit.Click
        Close()
    End Sub

    'ABOUT
    Private Sub ms_about_about_Click(sender As Object, e As EventArgs) Handles ms_about_about.Click
        Dim RaffyAbout As New form_about
        RaffyAbout.ShowDialog()
    End Sub

    Private Sub ms_about_credits_Click(sender As Object, e As EventArgs) Handles ms_about_credits.Click
        Dim RaffyCredits As New form_Credits
        RaffyCredits.ShowDialog()
    End Sub

    Private Sub ms_about_update_Click(sender As Object, e As EventArgs) Handles ms_about_update.Click
        Dim UpdateSearch As New form_UpdateSearch()
        UpdateSearch.ShowDialog()
    End Sub

    Private Sub ms_about_settings_Click(sender As Object, e As EventArgs) Handles ms_about_settings.Click
        Dim RaffySettings As New form_Settings
        RaffySettings.ShowDialog()
    End Sub

    'HELP
    Private Sub ms_help_help_Click(sender As Object, e As EventArgs) Handles ms_help_help.Click
        Dim RaffyHelp As New form_help
        RaffyHelp.ShowDialog()
    End Sub

    Private Sub ms_help_SupportUs_Click(sender As Object, e As EventArgs) Handles ms_help_SupportUs.Click
        Dim RaffyParticipation As New form_participation
        RaffyParticipation.ShowDialog()
    End Sub

#End Region

#Region "Drag and Drop"

    Private Sub lb_pictures_DragEnter(sender As Object, e As DragEventArgs) Handles lb_pictures.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub lb_pictures_DragDrop(sender As Object, e As DragEventArgs) Handles lb_pictures.DragDrop

        Focus()
        Activate()
        ImportFileList = e.Data.GetData(DataFormats.FileDrop)
        form_ImportProgressInfo.ShowDialog()

        ImportDone()
        lb_pictures.Select()

    End Sub

    Private Sub lbl_drop_DragEnter(sender As Object, e As DragEventArgs) Handles lbl_drop.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub



    Private Sub lbl_drop_DragDrop(sender As Object, e As DragEventArgs) Handles lbl_drop.DragDrop

        Focus()
        Activate()
        ImportFileList = e.Data.GetData(DataFormats.FileDrop)
        form_ImportProgressInfo.ShowDialog()

        ImportDone()
        lb_pictures.Select()

    End Sub

#End Region

#Region "Browse"
    Private Sub btn_drop_Click(sender As Object, e As EventArgs) Handles btn_drop.Click
        BrowseImages()
    End Sub

    Private Sub BrowseImages()

        Dim ofd As New OpenFileDialog
        ofd.Filter = TransString("_General_AllPicturefiles") & "|*.jpg;*.jpeg;*.png;*.bmp|JPG " & TransString("_General_files") & "| *.jpg;*.jpeg|PNG " & TransString("_General_files") & "|*.png|BMP " & TransString("_General_files") & "|*.bmp"
        ofd.FileName = ""
        ofd.Multiselect = True
        If ofd.ShowDialog() = DialogResult.OK Then

            ImportFileList = ofd.FileNames
            form_ImportProgressInfo.ShowDialog()

            ImportDone()

        End If


    End Sub

#End Region

#Region "Import"

    Public Function ImportFiles(ByVal path As String) As Boolean

        '//Auf Bilddateien überprüfen
        Dim FileType As String() = path.Split(".")
        Dim FileNameSplit As String() = path.Split("\")
        Dim FileName As String = FileNameSplit(FileNameSplit.Length - 1)

        '///Unterstützte Dateitypen
        Select Case FileType(1).ToLower
            Case "jpg"
            Case "jpeg"
            Case "png"
            Case "bmp"
            Case Else
                MessageBox.Show(TransString("Main_ImportFiles_msg_UnsupportedFiletype") & " (" & path & ")", TransString("_General_error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
                Exit Function
        End Select

        PicFileType = FileType(1).ToLower

        '//Größe der Bilder speichern/vergeleichen
        Dim Img As Image = Image.FromFile(path)

        If lb_pictures.Items.Count = 0 Then
            PicWidth = Img.Width
            PicHeight = Img.Height
        Else
            If Img.Width <> PicWidth Or Img.Height <> PicHeight Then
                If MessageBox.Show(TransString("Main_ImportFiles_msg_DifferentResolution") & " (" & PicWidth & "x" & PicHeight & ")", TransString("_General_error"), MessageBoxButtons.OK, MessageBoxIcon.Error) = DialogResult.OK Then
                    Return False
                    Exit Function
                End If
            End If
        End If

        Img.Dispose()

        '//Bild in Liste aufnehmen
        lb_pictures.Items.Add(FileName + " - """ + path + """")

        Pnl_TimelineOverlay.Visible = False

        Return True

    End Function

    Private Sub ImportDone()
        Try
            lb_pictures.SelectedItems.Add(lb_pictures.Items.Item(0))
        Catch ex As Exception
            MessageBox.Show(TransString("Main_ImportFiles_msg_NoPictures"), TransString("_General_warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        btn_start.Enabled = True

    End Sub

#End Region

#Region "Listbox"

    Private Sub lb_pictures_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_pictures.SelectedIndexChanged

        Try
            pb_preview.BackgroundImage.Dispose()
        Catch ex As Exception
        End Try

        Try
            pb_preview.BackgroundImage = Image.FromFile(getFilename(lb_pictures.SelectedItem.ToString, True))

        Catch ex As Exception
            pb_preview.BackgroundImage = Nothing
        End Try

        UpdateForm()

    End Sub

#End Region

#Region "Log File"

    Public Sub LogNew()
        If File.Exists(Application.UserAppDataPath & "\log.txt") Then
            File.Delete(Application.UserAppDataPath & "\log.txt")
        End If
    End Sub

    Public Sub LogWrite(ByVal Line As String)
        Dim LogFile As StreamWriter
        LogFile = My.Computer.FileSystem.OpenTextFileWriter(Application.UserAppDataPath & "\log.txt", True)
        LogFile.WriteLine(Line)
        LogFile.Close()
    End Sub

    Public Sub LogOpen()
        Process.Start(Application.UserAppDataPath & "\log.txt")
    End Sub

#End Region

#Region "Backgroundworker: Render/Konvertierung"

    Dim totalDuration As Double

    Private Sub bw_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_Rendering.DoWork

        'RESET PROGRESS
        RenderProgress = 0
        ConvertProgress = 0
        TotalFrames = lb_pictures.Items.Count

        PicTempPath = (Application.UserAppDataPath & "\temp\")
        bw_Rendering.ReportProgress(1)


        'Empty and create new Temp folder
        If My.Computer.FileSystem.DirectoryExists(PicTempPath) Then
            Directory.Delete(PicTempPath, True)
        End If
        Directory.CreateDirectory(PicTempPath)

        bw_Rendering.ReportProgress(10)

        'Rename/copy images
        For i = 0 To lb_pictures.Items.Count - 1

            If bw_Rendering.CancellationPending = True Then
                e.Cancel = True
                Exit Sub
            Else
                Dim FileType As String() = getFilename(lb_pictures.Items.Item(i).ToString, False).Split(".")
                FileSystem.FileCopy(getFilename(lb_pictures.Items.Item(i).ToString, True), PicTempPath & i.ToString & "." & FileType(FileType.Length - 1))
            End If
        Next

        bw_Rendering.ReportProgress(40)

        'Start Rendering
        Dim RenderResult As Integer = StartRendering()
        Select Case RenderResult
            Case 0 'cancel by user
                Exit Sub
            Case -1 'general error
                bw_Rendering.ReportProgress(-1)
                Exit Sub
            Case -2 'malloc error
                bw_Rendering.ReportProgress(-2)
                Exit Sub
        End Select

        bw_Rendering.ReportProgress(75)

        'Start Conversion
        Dim ConvertResult As Integer = StartConversion()
        Select Case ConvertResult
            Case 0 'cancel by user
                Exit Sub
            Case -1 'general error
                bw_Rendering.ReportProgress(-1)
                Exit Sub
            Case -2 'malloc error
                bw_Rendering.ReportProgress(-2)
                Exit Sub
        End Select

        LogWrite("Completed: " & Date.Now.ToString)
        bw_Rendering.ReportProgress(100)

    End Sub

    Private Function StartRendering() As Integer
        Control.CheckForIllegalCrossThreadCalls = False
        Dim startinfo As New System.Diagnostics.ProcessStartInfo
        Dim sr As StreamReader
        Dim cmd As String = "-y -f image2 -framerate " & MovFPS & " -i " & Chr(34) & PicTempPath & "\%d." & PicFileType & Chr(34) & " " & Chr(34) & PicTempPath & "video.flv" & Chr(34) '//HARDCODED
        Dim ffmpegOutput As String

        'CREATE LOG FILE
        LogNew()
        LogWrite("Rendering started: " & Date.Now.ToString)
        LogWrite("Command passed: " & cmd)
        LogWrite("")
        LogWrite("--- FFMPEG RENDER OUTPUT ---")
        LogWrite("")

        startinfo.FileName = FFmpegPath
        startinfo.Arguments = cmd
        startinfo.UseShellExecute = False
        startinfo.WindowStyle = ProcessWindowStyle.Hidden
        startinfo.RedirectStandardError = True
        startinfo.CreateNoWindow = True

        Dim Proc As New Process
        Proc.StartInfo = startinfo
        Proc.Start()
        sr = Proc.StandardError


        Do
            If bw_Rendering.CancellationPending Then
                Return 0
                Exit Function
            End If

            ffmpegOutput = sr.ReadLine
            LogWrite(ffmpegOutput)

            'PROGRESS REPORTING
            If Not ffmpegOutput Is Nothing Then
                If ffmpegOutput.Contains("frame=") Then
                    Dim progressMatch As Match = Regex.Match(ffmpegOutput, "frame=\s+([0-9]{1,10})")
                    Dim progressFrames As Integer = CInt(progressMatch.Groups(1).Value)
                    RenderProgress = Math.Round(progressFrames / TotalFrames * 100)
                End If
            End If

            'ERROR REPORTING
            If Not ffmpegOutput = Nothing Then
                If ffmpegOutput.Contains("[error]") And ffmpegOutput.Contains("malloc") Then
                    Proc.Kill()
                    Return -2
                    Exit Function
                ElseIf ffmpegOutput.Contains("[error]") Then
                    Proc.Kill()
                    Return -1
                    Exit Function
                End If
            End If

        Loop Until Proc.HasExited And ffmpegOutput = Nothing Or ffmpegOutput = ""

        Return 1

    End Function

    Private Function StartConversion() As Integer
        Control.CheckForIllegalCrossThreadCalls = False
        Dim startinfo As New System.Diagnostics.ProcessStartInfo
        Dim sr As StreamReader
        Dim cmd As String = " -y -i " & Chr(34) & PicTempPath & "video.flv" & Chr(34) & " -an -vcodec libx264 " & MovPreset & " -s " & MovWidth & "x" & MovHeight & " " & Chr(34) & MovPath & Chr(34)
        Dim ffmpegOutput As String

        'UPDATING LOG FILE
        LogWrite("")
        LogWrite("Conversion started: " & Date.Now.ToString)
        LogWrite("64 bit: " & Environment.Is64BitOperatingSystem.ToString)
        LogWrite("Command passed: " & cmd)
        LogWrite("")
        LogWrite("--- FFMPEG CONVERT OUTPUT ---")
        LogWrite("")

        startinfo.FileName = FFmpegPath
        startinfo.Arguments = cmd
        startinfo.UseShellExecute = False
        startinfo.WindowStyle = ProcessWindowStyle.Hidden
        startinfo.RedirectStandardError = True
        startinfo.CreateNoWindow = True

        Dim Conv As New Process
        Conv.StartInfo = startinfo
        Conv.Start()
        sr = Conv.StandardError

        Do
            If bw_Rendering.CancellationPending Then
                Return 0
                Exit Function
            End If

            ffmpegOutput = sr.ReadLine
            LogWrite(ffmpegOutput)

            'PROGRESS REPORTING
            If Not ffmpegOutput Is Nothing Then
                If ffmpegOutput.Contains("frame=") Then
                    Dim progressMatch As Match = Regex.Match(ffmpegOutput, "frame=\s+([0-9]{1,10})")
                    Dim progressFrames As Integer = CInt(progressMatch.Groups(1).Value)
                    ConvertProgress = Math.Round(progressFrames / TotalFrames * 100)
                End If
            End If


            'ERROR REPORTING
            If Not ffmpegOutput = Nothing Then
                If ffmpegOutput.Contains("[error]") And ffmpegOutput.Contains("malloc") Then
                    Conv.Kill()
                    Return -2
                    Exit Function
                ElseIf ffmpegOutput.Contains("[error]") Then
                    Conv.Kill()
                    Return -1
                    Exit Function
                End If
            End If

        Loop Until Conv.HasExited And ffmpegOutput = Nothing Or ffmpegOutput = ""

        Return 1

    End Function

    Private Sub bw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bw_Rendering.ProgressChanged

        Select Case e.ProgressPercentage
            Case 1
                Status = TransString("Main_bw_Rendering_Progress_1")
            Case 10
                Status = TransString("Main_bw_Rendering_Progress_10")
            Case 40
                Status = TransString("Main_bw_Rendering_Progress_40")
            Case 75
                Status = TransString("Main_bw_Rendering_Progress_75")
            Case 100
                Status = TransString("Main_bw_Rendering_Progress_100")
                Finished = True
                DeleteTemp()

            'ERRORS
            Case -1
                Status = TransString("Main_bw_Rendering_Progress_-1")
                Finished = True
                DeleteTemp()
            Case -2
                Status = TransString("Main_bw_Rendering_Progress_-2")
                Finished = True
                DeleteTemp()
        End Select

    End Sub

    Private Sub bw_Disposed(sender As Object, e As EventArgs) Handles bw_Rendering.Disposed
        Me.Enabled = True
    End Sub

    Public Sub StartTask()

        form_ProjectSettings.Close()

        Dim Progress As Form = New form_ProgressInfo
        Progress.Owner = Me
        Progress.Show()

        Application.DoEvents()
        Progress.Activate()

        If Not bw_Rendering.IsBusy = True Then
            bw_Rendering.RunWorkerAsync()
        End If
    End Sub

    Public Sub DeleteTemp()
        If My.Computer.FileSystem.DirectoryExists(Application.UserAppDataPath & "\temp\") Then
            My.Computer.FileSystem.DeleteDirectory(Application.UserAppDataPath & "\temp\", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub

#End Region

#Region "Backgroundworker: Autoupdate"

    Private Sub Bw_AutoUpdate_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_AutoUpdate.DoWork

        Dim NewVersionString As String

        Application.DoEvents()
        Threading.Thread.Sleep(300)

        Invoke(Sub()

                   'TEST CONNECTION
                   Try
                       My.Computer.Network.Ping("sourceforge.net")
                   Catch ex As Exception
                       Exit Sub
                   End Try

                   'GET LATEST VERSION NUMBER
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
                       Exit Sub
                   Else
                       Dim FullUpdateSearch As New form_UpdateSearch
                       form_UpdateSearch.ShowDialog()
                   End If

               End Sub)
    End Sub

#End Region

#Region "General Functions"

    Public Function getFilename(ByVal filename As String, ByVal includePath As Boolean)

        If includePath = False Then
            Dim regexMatch As Match = Regex.Match(filename, "(.*) - """)
            Return regexMatch.Groups(1).Value
        Else
            Dim regexMatch As Match = Regex.Match(filename, """(.*)""")
            Return regexMatch.Groups(1).Value
        End If

    End Function

#End Region

End Class