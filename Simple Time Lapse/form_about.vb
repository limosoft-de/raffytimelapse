Public Class form_about

    Private Sub form_about_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TranslateForm()

        Dim portable As String

        If My.Settings.app_portable = True Then
            portable = " (portable)"
        Else
            portable = ""
        End If

        lbl_VersionNr.Text = Application.ProductVersion & portable
        Lbl_Copyright.Text = My.Application.Info.Copyright

    End Sub

    Private Sub TranslateForm()
        Me.Text = TransString("About")

        lbl_close.Text = TransString("_General_close")
        lbl_version.Text = TransString("About_version")

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_close.LinkClicked
        Close()
    End Sub
End Class
