﻿Public Class form_about

    Private Sub form_about_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        TranslateForm()

        lbl_VersionNr.Text = Application.ProductVersion

    End Sub

    Private Sub TranslateForm()
        Me.Text = TransString("About")

        lbl_version.Text = TransString("About_version")

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_close.LinkClicked
        Close()
    End Sub

End Class