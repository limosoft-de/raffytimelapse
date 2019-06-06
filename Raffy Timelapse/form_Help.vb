Public Class form_help

    Private Sub form_help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llbl_mail.Text = My.Settings.url_mail
        TranslateFrom()
    End Sub

    Private Sub TranslateFrom()

        Me.Text = TransString("Help")

        btn_ok.Text = TransString("_General_ok")

        gb_wiki.Text = TransString("Help_gb_wiki")
        lbl_wiki.Text = TransString("Help_lbl_wiki")
        llbl_wiki.Text = TransString("Help_llbl_wiki")


        gb_support.Text = TransString("Help_gb_support")
        lbl_support.Text = TransString("Help_lbl_support")
        llbl_support.Text = TransString("Help_llbl_support")

        gb_contact.Text = TransString("Help_gb_contact")
        lbl_contact.Text = TransString("Help_lbl_contact")

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Close()
    End Sub

    Private Sub Llbl_wiki_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_wiki.LinkClicked
        Process.Start(My.Settings.url_wiki)
    End Sub

    Private Sub llbl_support_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_support.LinkClicked
        Process.Start(My.Settings.url_support)
    End Sub

    Private Sub llbl_mail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_mail.LinkClicked
        Process.Start("mailto:" & My.Settings.url_mail & "?body=%0D%0A-------SYSTEM%20INFORMATION-------%0D%0A" &
                                                         "Raffy%20Timelapse%20Version:%20" & Application.ProductVersion &
                                                         "%0D%0AOS%20Version:%20" & My.Computer.Info.OSFullName.ToString)
    End Sub
End Class