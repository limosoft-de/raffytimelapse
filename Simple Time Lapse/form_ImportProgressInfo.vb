Public Class form_ImportProgressInfo

    Private Sub form_ImportProgressInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TranslateForm()
    End Sub

    Private Sub TranslateForm()

        Me.Text = TransString("")
        btn_cancel.Text = TransString("_General_cancel")

    End Sub

End Class