Public Class form_participation

    Private Sub form_participation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TranslateForm()
    End Sub

    Private Sub TranslateForm()
        Me.Text = TransString("Participation")

        btn_ok.Text = TransString("_General_ok")

        lbl_head.Text = TransString("Participation_lbl_head")
        lbl_desc.Text = TransString("Participation_lbl_desc")
        lbl_link.Text = TransString("Participation_lbl_link")
    End Sub

    Private Sub lbl_link_Click(sender As Object, e As EventArgs) Handles lbl_link.Click
        Process.Start(My.Settings.url_translation)
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Close()
    End Sub
End Class