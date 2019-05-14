Imports System.IO
Imports System.ComponentModel

Public Class form_main


    Public MultiSelect As Boolean = False
    Public Finished As Boolean = False
    Public FFmpegExists As Boolean = False
    Public Status As String = TransString("_General_wait")

    'If you add something to the projects variables, also add it in ResetProject Sub!

    '/||Projekt-Variablen
    'Dim PicPath As String = ""
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Top = (Me.ClientSize.Height - lbl_drop.Height) / 2 - 30
        TranslateForm()

        lb_pictures.DrawMode = DrawMode.OwnerDrawFixed

    End Sub

    Private Sub form_main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CheckForFFmpeg()
        AutoUpdate()
    End Sub

    Private Sub CheckForFFmpeg()
        If File.Exists(Application.StartupPath & "\ffmpeg.exe") Then
            FFmpegExists = True
        Else
            FFmpegExists = False
            If MessageBox.Show(TransString("Main_msg_ffmpeg"), TransString("_General_error"), MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                Process.Start(My.Settings.url_FFmpeg)
            End If
        End If
    End Sub


    Private Sub form_main_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Panel2.Top = (Me.ClientSize.Height - lbl_drop.Height) / 2 - 30

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

#Region "UI"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_start.Click

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
        Select Case MessageBox.Show(TransString("Main_msg_SingleDelete").Replace("[%1]", "'" & lb_pictures.SelectedItem.ToString & "'"), TransString("_General_warning"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
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
                Dim PreviewFile As String() = lb_pictures.SelectedItem.ToString.Split("\")
                lbl_PreviewFile.Text = PreviewFile(PreviewFile.Length - 1)
            End If
        Else
            'Nothing is selected
            gb_PictureEdit.Enabled = False
        End If


        If lb_pictures.Items.Count = 0 Then
            Panel2.Visible = True
            btn_start.Enabled = False
            lbl_PreviewFile.Text = ""
        Else
            Panel2.Visible = False

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

    'File
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

    'About
    Private Sub ms_about_about_Click(sender As Object, e As EventArgs) Handles ms_about_about.Click
        form_about.ShowDialog()
    End Sub

    Private Sub ms_about_credits_Click(sender As Object, e As EventArgs) Handles ms_about_credits.Click
        form_Credits.ShowDialog()
    End Sub

    Private Sub ms_about_update_Click(sender As Object, e As EventArgs) Handles ms_about_update.Click
        UpdateApp()
    End Sub

    Private Sub ms_about_settings_Click(sender As Object, e As EventArgs) Handles ms_about_settings.Click
        form_Settings.ShowDialog()
    End Sub

    'Help
    Private Sub ms_help_help_Click(sender As Object, e As EventArgs) Handles ms_help_help.Click
        form_help.ShowDialog()
    End Sub

    Private Sub ms_help_SupportUs_Click(sender As Object, e As EventArgs) Handles ms_help_SupportUs.Click
        form_participation.ShowDialog()
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

#Region "Durchsuchen"
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
                If MessageBox.Show(TransString("Main_ImportFiles_msg_DifferentResolution") & " (" & PicWidth & "x" & PicHeight & ")", TransString("_General_error"), MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                    Return False
                    Exit Function
                End If
            End If
        End If

        Img.Dispose()

        '//Bild in Liste aufnehmen
        lb_pictures.Items.Add(path)

        Panel2.Visible = False

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
            pb_preview.BackgroundImage = Image.FromFile(lb_pictures.SelectedItem.ToString)

        Catch ex As Exception
            pb_preview.BackgroundImage = Nothing
        End Try

        UpdateForm()

    End Sub

#End Region

#Region "Backgroundworker: Render/Konvertierung"

    Private Sub bw_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_Rendering.DoWork

        bw_Rendering.ReportProgress(1)

        'Temp Ordner erstellen/leeren
        If My.Computer.FileSystem.DirectoryExists(Application.UserAppDataPath & "\temp") Then
            Directory.Delete(Application.UserAppDataPath.ToString & "\temp", True)
        End If

        Directory.CreateDirectory(Application.UserAppDataPath & "\temp")

        bw_Rendering.ReportProgress(10)

        'Bilder kopieren/umbenennen
        For i = 0 To lb_pictures.Items.Count - 1

            If bw_Rendering.CancellationPending = True Then
                e.Cancel = True
                Exit For
            Else
                Dim FileType As String() = lb_pictures.Items.Item(i).ToString.Split(".")
                FileSystem.FileCopy(lb_pictures.Items.Item(i), Application.UserAppDataPath & "\temp\" & i.ToString & "." & FileType(FileType.Length - 1))
            End If
        Next

        bw_Rendering.ReportProgress(40)

        'Rendern starten
        PicTempPath = (Application.UserAppDataPath & "\temp\")

        If StartRendering() = 0 Then Exit Sub

        bw_Rendering.ReportProgress(75)

        'Konvertierung starten
        If StartConversion() = 0 Then Exit Sub

        bw_Rendering.ReportProgress(100)

    End Sub

    Private Function StartRendering() As Integer
        Control.CheckForIllegalCrossThreadCalls = False
        Dim exepath As String = Application.StartupPath + "\ffmpeg.exe"
        Dim startinfo As New System.Diagnostics.ProcessStartInfo
        Dim sr As StreamReader
        Dim cmd As String = "-y -f image2 -framerate " & MovFPS & " -i " & Chr(34) & PicTempPath & "\%d." & PicFileType & Chr(34) & " " & MovPreset & " " & Chr(34) & PicTempPath & "video.flv" & Chr(34) '//HARDCODED
        Dim ffmpegOutput As String

        startinfo.FileName = exepath
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
        Loop Until Proc.HasExited And ffmpegOutput = Nothing Or ffmpegOutput = ""

        Return 1

    End Function

    Private Function StartConversion() As Integer
        Control.CheckForIllegalCrossThreadCalls = False
        Dim exepath As String = Application.StartupPath + "\ffmpeg.exe"
        Dim startinfo As New System.Diagnostics.ProcessStartInfo
        Dim sr As StreamReader

        Dim cmd As String = " -y -i " & Chr(34) & PicTempPath & "video.flv" & Chr(34) & " -an -vcodec libx264 " & MovPreset & " -s " & MovWidth & "x" & MovHeight & " " & Chr(34) & MovPath & Chr(34)
        Dim ffmpegOutput As String

        startinfo.FileName = exepath
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

            'MsgBox(ffmpegOutput) 'Debug Option

        Loop Until Conv.HasExited And ffmpegOutput = Nothing Or ffmpegOutput = ""

        Return 1

    End Function

    Private Sub bw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bw_Rendering.ProgressChanged

        Select Case e.ProgressPercentage 'Translation
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

End Class