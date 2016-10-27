Public Class form_update
    Private Sub form_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_update.Enabled = False
        lbl_LocalVersionNr.Text = My.Settings.Version

        TranslateForm()
        CheckForUpdate()
    End Sub

    Private Sub TranslateForm()
        Me.Text = TransString("Update")

        btn_cancel.Text = TransString("_General_cancel")
        btn_update.Text = TransString("Update_btn_update")

        lbl_LocalVersion.Text = TransString("Update_lbl_LocalVersion")
        lbl_NewestVersion.Text = TransString("Update_lbl_NewestVersion")
        lbl_changelog.Text = TransString("Update_lbl_changelog")

    End Sub

    Private Sub CheckForUpdate()

        Dim LocalVersion As String() = My.Settings.Version.Split(".")

        If testconnection() = True Then

            Dim VersionBrowser As New WebBrowser
            VersionBrowser.Navigate("http://simpletimelapse.sourceforge.net/update/version.txt")
            Do Until VersionBrowser.ReadyState = WebBrowserReadyState.Complete
                Application.DoEvents()
            Loop
            VersionBrowser.Refresh(WebBrowserRefreshOption.Completely)

            lbl_NewestVersionNr.Text = VersionBrowser.Document.Body.InnerText
            Dim NewestVersion As String() = VersionBrowser.Document.Body.InnerText.Split(".")

            Dim ChangelogBrowser As New WebBrowser
            ChangelogBrowser.Navigate("http://simpletimelapse.sourceforge.net/update/changelog.txt")
            Do Until ChangelogBrowser.ReadyState = WebBrowserReadyState.Complete
                Application.DoEvents()
            Loop
            ChangelogBrowser.Refresh(WebBrowserRefreshOption.Completely)

            rtb_changelog.Text = ChangelogBrowser.Document.Body.InnerText

            If CInt(NewestVersion(0)) > CInt(LocalVersion(0)) Then
                btn_update.Enabled = True
            ElseIf CInt(NewestVersion(1)) > CInt(LocalVersion(1)) Then
                btn_update.Enabled = True
            ElseIf CInt(NewestVersion(2)) > CInt(LocalVersion(2)) Then
                btn_update.Enabled = True
            End If


        ElseIf testconnection() = False Then
            MessageBox.Show(TransString("Update_msg_NoInternet"), TransString("_General_error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Process.Start(My.Settings.UpdateURL)
    End Sub
End Class