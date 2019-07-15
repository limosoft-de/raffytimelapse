Public Class form_Credits

    Private Sub form_Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TranslateForm()
    End Sub

    Private Sub TranslateForm()
        Text = TransString("Credits")
        btn_ok.Text = TransString("_General_ok")
        lbl_translators_head.Text = TransString("Credits_lbl_translators_head")
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Close()
    End Sub

    Private Sub lbl_icons_desc_Click(sender As Object, e As EventArgs) Handles lbl_icons_desc.Click
        If MessageBox.Show(TransString("Credits_link"), TransString("_General_info"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Process.Start("https://www.flaticon.com/packs/free-basic-ui-elements")
        End If
    End Sub

    Private Sub lbl_ffmpeg_desc_Click(sender As Object, e As EventArgs) Handles lbl_ffmpeg_desc.Click
        If MessageBox.Show(TransString("Credits_link"), TransString("_General_info"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Process.Start("https://ffmpeg.org")
        End If
    End Sub

    Private Sub Lbl_translators_desc_Click(sender As Object, e As EventArgs) Handles lbl_translators_desc.Click
        Dim TranslateForm As New form_participation
        TranslateForm.ShowDialog()
    End Sub
End Class