Public Class form_about

    Private Sub form_about_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        TranslateForm()
        lbl_VersionNr.Text = Application.ProductVersion

    End Sub

    Private Sub form_about_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub TranslateForm()
        Me.Text = TransString("About")

        lbl_version.Text = TransString("About_version")

    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Close()
    End Sub

End Class
