Public Class form_AutoUpdate

    Public NewestVersionNr As String

    Private Sub form_AutoUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TranslateForm()

        If Not NewestVersionNr = "" Then
            lbl_NewestVersionNr.Text = NewestVersionNr
        Else
            If Not GetNewestVersion() = "" Then
                lbl_NewestVersionNr.Text = GetNewestVersion()
            Else
                Close()
                Exit Sub
            End If
        End If

    End Sub

    Private Sub TranslateForm()
        Me.Text = TransString("AutoUpdate")

        lbl_info.Text = TransString("AutoUpdate_lbl_info")
        lbl_NewestVersion.Text = TransString("AutoUpdate_lbl_NewestVersion")
        lbl_MoreInfo.Text = TransString("AutoUpdate_lbl_MoreInfo")

        btn_cancel.Text = TransString("_General_cancel")
        btn_update.Text = TransString("AutoUpdate_btn_update")

    End Sub

    Private Sub lbl_MoreInfo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_MoreInfo.LinkClicked
        Close()
        form_update.ShowDialog()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Process.Start(My.Settings.url_update)
    End Sub
End Class