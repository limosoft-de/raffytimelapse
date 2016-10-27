Public Class form_Settings

    Private Sub form_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cb_language.Items.Clear()

        tc.SelectedTab = tc_general

        TranslateForm()
        LoadSettings()

    End Sub

    Private Sub TranslateForm()

        Me.Text = TransString("Settings")

        tc_general.Text = TransString("Settings_tc_general")
        tc_interface.Text = TransString("Settings_tc_interface")

        btn_cancel.Text = TransString("_General_cancel")
        btn_ok.Text = TransString("_General_ok")

        'General
        gb_updates.Text = TransString("Settings_tc_general_gb_updates")
        cb_AutoUpdate.Text = TransString("Settings_tc_general_cb_AutoUpdate")

        'Interface
        lbl_language.Text = TransString("Settings_tc_interface_lbl_language")

        With cb_language.Items
            .Add(TransString("_General_language_en_US"))
            .Add(TransString("_General_language_de_DE"))
        End With

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        SaveSettings()
        form_main.TranslateForm()
        Close()

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Close()
    End Sub

    Private Sub LoadSettings()

        'General
        cb_AutoUpdate.Checked = My.Settings.AutoUpdate
        'Interface
        cb_language.Text = TransString("_General_language_" & My.Settings.LanguageCode)

    End Sub

    Private Sub SaveSettings()
        'General
        ''Autoupdate
        My.Settings.AutoUpdate = cb_AutoUpdate.Checked

        'Interface
        ''Language
        If cb_language.Text = TransString("_General_language_en_US") Then
            My.Settings.LanguageCode = "en_US"
        ElseIf cb_language.Text = TransString("_General_language_de_DE") Then
            My.Settings.LanguageCode = "de_DE"
        End If
    End Sub


End Class