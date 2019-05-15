Public Class form_help

    Private Sub form_help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_mail.Text = My.Settings.Support_Mail
        TranslateFrom()
    End Sub

    Private Sub TranslateFrom()
        Me.Text = TransString("Help")

        btn_ok.Text = TransString("_General_ok")

        gb_online.Text = TransString("Help_gb_online")
        gb_contact.Text = TransString("Help_gb_contact")

        lbl_online.Text = TransString("Help_lbl_online")
        lbl_contact.Text = TransString("Help_lbl_contact")

        lbl_head_bugs.Text = TransString("Help_lbl_head_bugs")
        lbl_head_feature.Text = TransString("Help_lbl_head_feature")
        lbl_head_general.Text = TransString("Help_lbl_head_general")
        lbl_desc_bugs.Text = TransString("Help_lbl_desc_bugs")
        lbl_desc_feature.Text = TransString("Help_lbl_desc_feature")
        lbl_desc_general.Text = TransString("Help_lbl_desc_general")
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Close()
    End Sub

    Private Sub lbl_head_bugs_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_head_bugs.LinkClicked
        Process.Start(My.Settings.Support_Bugs)
    End Sub

    Private Sub lbl_head_feature_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_head_feature.LinkClicked
        Process.Start(My.Settings.Support_Features)
    End Sub

    Private Sub lbl_head_general_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_head_general.LinkClicked
        Process.Start(My.Settings.Support_General)
    End Sub

    Private Sub lbl_mail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_mail.LinkClicked
        Process.Start("mailto:" & My.Settings.Support_Mail)
    End Sub
End Class