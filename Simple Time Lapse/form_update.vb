Public Class form_update

    Dim NewestVersion As String
    Dim NewestChangelog As String

    Public Sub New(ByVal VersionNumber As String, ByVal Changelog As String)

        InitializeComponent()

        NewestVersion = VersionNumber
        NewestChangelog = Changelog

    End Sub

    Private Sub form_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_LocalVersionNr.Text = Application.ProductVersion
        lbl_NewestVersionNr.Text = NewestVersion
        rtb_changelog.Text = NewestChangelog

        TranslateForm()

    End Sub

    Private Sub TranslateForm()
        Me.Text = TransString("Update")

        btn_cancel.Text = TransString("_General_cancel")
        btn_update.Text = TransString("Update_btn_update")

        lbl_LocalVersion.Text = TransString("Update_lbl_LocalVersion")
        lbl_NewestVersion.Text = TransString("Update_lbl_NewestVersion")
        lbl_changelog.Text = TransString("Update_lbl_changelog")
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Process.Start(My.Settings.url_update)
    End Sub

End Class