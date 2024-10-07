Public Class form_Settings

    Dim KeysMove As String()

    Private Sub form_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cb_language.Items.Clear()
        cb_MoveImg.Items.Clear()

        TranslateForm()
        LoadSettings()

    End Sub

    Private Sub TranslateForm()

        Me.Text = TransString("Settings")

        btn_cancel.Text = TransString("_General_cancel")
        btn_ok.Text = TransString("_General_ok")

        'GENERAL
        gb_general.Text = TransString("Settings_gb_general")
        lbl_language.Text = TransString("Settings_general_lbl_language")
        With cb_language.Items
            .Add(TransString("_General_language_en_US"))
            .Add(TransString("_General_language_de_DE"))
            .Add(TransString("_General_language_fr_FR"))
            .Add(TransString("_General_language_pt_PT"))
            .Add(TransString("_General_language_cs_CZ"))
        End With
        cb_AutoUpdate.Text = TransString("Settings_general_cb_AutoUpdate")

        'KEYS
        gb_keys.Text = TransString("Settings_gb_keys")
        lbl_MoveImg.Text = TransString("Settings_keys_lbl_MoveImg")
        KeysMove = TransString("Settings_keys_cb_MoveImg").Split(",")
        For i = 0 To KeysMove.Length - 1
            cb_MoveImg.Items.Add(KeysMove(i))
        Next


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
        cb_AutoUpdate.Checked = My.Settings.set_AutoUpdate

        cb_MoveImg.Text = KeysMove(My.Settings.set_ImgMove)

        'Interface
        cb_language.Text = TransString("_General_language_" & My.Settings.set_LanguageCode)

    End Sub

    Private Sub SaveSettings()
        'General
        ''Autoupdate
        My.Settings.set_AutoUpdate = cb_AutoUpdate.Checked
        ''Keys Move
        My.Settings.set_ImgMove = cb_MoveImg.SelectedIndex
        'Interface
        ''Language
        If cb_language.Text = TransString("_General_language_en_US") Then
            My.Settings.set_LanguageCode = "en_US"
        ElseIf cb_language.Text = TransString("_General_language_de_DE") Then
            My.Settings.set_LanguageCode = "de_DE"
        ElseIf cb_language.Text = TransString("_General_language_pt_PT") Then
            My.Settings.set_LanguageCode = "pt_PT"
        ElseIf cb_language.Text = TransString("_General_language_fr_FR") Then
            My.Settings.set_LanguageCode = "fr_FR"
        ElseIf cb_language.Text = TransString("_General_language_cs_CZ") Then
            My.Settings.set_LanguageCode = "cs_CZ"
        End If
    End Sub


End Class