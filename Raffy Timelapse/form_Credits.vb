Public Class form_Credits

    Private Sub form_Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TranslateForm()
    End Sub

    Private Sub TranslateForm()
        Text = TransString("Credits")
        btn_ok.Text = TransString("_General_ok")
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_icons_desc.Click
        If MessageBox.Show(TransString("Credits_link"), TransString("_General_info"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Process.Start("http://flaticon.com/packs/free-basic-ui-elements")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_ffmpeg_desc.Click
        If MessageBox.Show(TransString("Credits_link"), TransString("_General_info"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Process.Start("https://ffmpeg.org")
        End If
    End Sub
End Class