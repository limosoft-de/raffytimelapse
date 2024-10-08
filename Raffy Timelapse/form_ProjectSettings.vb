﻿Public Class form_ProjectSettings

    Dim advancedMode = False

    Private Sub form_ProjectSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_destination.Clear()
        cb_quality.Items.Clear()
        cb_res.Items.Clear()

        TranslateForm()

        LoadValues()
    End Sub

    Private Sub TranslateForm()
        Text = TransString("ProjectSettings")

        lbl_SaveTo.Text = TransString("ProjectSettings_lbl_SaveTo")
        lbl_resolution.Text = TransString("ProjectSettings_lbl_resolution")
        lbl_fps.Text = TransString("ProjectSettings_lbl_fps")
        lbl_quality.Text = TransString("ProjectSettings_lbl_quality")
        lbl_advancedMode.Text = TransString("ProjectSettings_lbl_advancedMode_advanced")

        btn_browse.Text = TransString("ProjectSettings_btn_browse")
        btn_cancel.Text = TransString("_General_cancel")
        btn_ok.Text = TransString("_General_ok")

        With cb_res.Items
            .Add("3.840 x 2.160 (4K)")
            .Add("2.560 x 1.440 (WQHD)")
            .Add("1920 x 1080 (Full-HD)")
            .Add("1280 x 720 (HD)")
            .Add("854 x 480")
            .Add("640 x 360")
            .Add("426 x 240")
            .Add(TransString("ProjectSettings_cb_resolution_OriginalResolution"))
        End With

        With cb_quality.Items
            .Add(TransString("ProjectSettings_cb_quality_hq"))
            .Add(TransString("ProjectSettings_cb_quality_mq"))
            .Add(TransString("ProjectSettings_cb_quality_lq"))
        End With

    End Sub

    Private Sub LoadValues()
        'Default Values
        cb_fps.Text = "25"
        cb_res.Text = TransString("ProjectSettings_cb_resolution_OriginalResolution")
        cb_quality.Text = TransString("ProjectSettings_cb_quality_mq")

        'Previous used Values (overwrite)

        If Not form_main.MovRes = "" Then
            If form_main.MovRes = "{original}" Then
                cb_res.Text = TransString("ProjectSettings_cb_resolution_OriginalResolution")
            Else
                cb_res.Text = form_main.MovRes
            End If
        End If

        If Not form_main.MovFPS = 0 Then
            cb_fps.Text = CStr(form_main.MovFPS)
        End If

        If Not form_main.MovPreset = "" Then
            If form_main.MovPreset = "-crf 1 -preset veryslow -tune film" Then
                cb_quality.Text = TransString("ProjectSettings_cb_quality_hq")
            ElseIf form_main.MovPreset = "-crf 23 -preset medium" Then
                cb_quality.Text = TransString("ProjectSettings_cb_quality_mq")
            ElseIf form_main.MovPreset = "-crf 30 -preset veryfast" Then
                cb_quality.Text = TransString("ProjectSettings_cb_quality_lq")
            End If
        End If
    End Sub

    Private Sub switchMode()
        advancedMode = Not advancedMode

        lbl_advancedMode.Text = TransString(If(advancedMode, "ProjectSettings_lbl_advancedMode_simple", "ProjectSettings_lbl_advancedMode_advanced"))
        cb_res.Visible = Not cb_res.Visible
        cb_fps.Visible = Not cb_fps.Visible
        num_res_height.Visible = Not num_res_height.Visible
        num_res_width.Visible = Not num_res_width.Visible
        num_fps.Visible = Not num_fps.Visible
        lbl_resolutionX.Visible = Not lbl_resolutionX.Visible
    End Sub


    Private Sub lbl_advancedMode_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_advancedMode.LinkClicked
        switchMode()
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click

        Dim FileTrans As String = TransString("_General_file")
        Dim ThisFileName As String = Date.Now.ToString("yyyy-MM-dd_hh-mm-ss")

        dl_SaveMovie.Filter = "MP4 " & FileTrans & "|*.mp4|MOV " & FileTrans & "|*.mov|AVI " & FileTrans & "|*.avi|FLV " & FileTrans & "|*.flv"
        dl_SaveMovie.FileName = ThisFileName
        If dl_SaveMovie.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            tb_destination.Text = dl_SaveMovie.FileName
        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Close()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        '//Storage location
        If tb_destination.Text = "" Or Not tb_destination.Text.Contains("\") Then
            MessageBox.Show(TransString("ProjectSettings_msg_InvalidPath"), TransString("_General_error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim PathAndFile As String() = tb_destination.Text.Split("\")
        Dim Path As String = tb_destination.Text.Replace(PathAndFile(PathAndFile.Length - 1), "")

        If Not My.Computer.FileSystem.DirectoryExists(Path) Then
            MessageBox.Show(TransString("ProjectSettings_msg_InvalidPath"), TransString("_General_error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        form_main.MovPath = tb_destination.Text

        '//Resolution
        If advancedMode Then
            'advanced mode
            form_main.MovWidth = num_res_width.Value : form_main.MovHeight = num_res_height.Value
        Else
            'simple mode
            If cb_res.Text = "" Then
                MessageBox.Show(TransString("ProjectSettings_msg_NoResolution"), TransString("_General_error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Select Case cb_res.Text
                Case "3.840 x 2.160 (4K)"
                    form_main.MovWidth = 3840 : form_main.MovHeight = 2160
                    form_main.MovRes = cb_res.Text 'Not for rendering, only to save project settings
                Case "2.560 x 1.440 (WQHD)"
                    form_main.MovWidth = 2560 : form_main.MovHeight = 1440
                    form_main.MovRes = cb_res.Text
                Case "1920 x 1080 (Full-HD)"
                    form_main.MovWidth = 1920 : form_main.MovHeight = 1080
                    form_main.MovRes = cb_res.Text
                Case "1280 x 720 (HD)"
                    form_main.MovWidth = 1280 : form_main.MovHeight = 720
                    form_main.MovRes = cb_res.Text
                Case "854 x 480"
                    form_main.MovWidth = 854 : form_main.MovHeight = 480
                    form_main.MovRes = cb_res.Text
                Case "640 x 360"
                    form_main.MovWidth = 640 : form_main.MovHeight = 360
                    form_main.MovRes = cb_res.Text
                Case "426 x 240"
                    form_main.MovWidth = 426 : form_main.MovHeight = 240
                    form_main.MovRes = cb_res.Text
                Case TransString("ProjectSettings_cb_resolution_OriginalResolution")
                    form_main.MovWidth = form_main.PicWidth : form_main.MovHeight = form_main.PicHeight
                    form_main.MovRes = "{original}"
            End Select
        End If

        If form_main.MovWidth > form_main.PicWidth Then
            MessageBox.Show(TransString("ProjectSettings_msg_undersize"), TransString("_General_error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf form_main.MovHeight > form_main.PicHeight Then
            MessageBox.Show(TransString("ProjectSettings_msg_undersize"), TransString("_General_error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        '//FPS
        If advancedMode Then
            'advanced mode
            form_main.MovFPS = num_fps.Value
        Else
            'simple mode
            If cb_fps.Text = "" Then
                MessageBox.Show(TransString("ProjectSettings_msg_NoFps"), TransString("_General_error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            form_main.MovFPS = CInt(cb_fps.Text)
        End If


        '//Quality
        If cb_quality.Text = "" Then
            MessageBox.Show(TransString("ProjectSettings_msg_quality"), TransString("_General_error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Select Case cb_quality.Text
            Case TransString("ProjectSettings_cb_quality_hq")
                form_main.MovPreset = "-crf 1 -preset veryslow -tune film"
            Case TransString("ProjectSettings_cb_quality_mq")
                form_main.MovPreset = "-crf 23 -preset medium"
            Case TransString("ProjectSettings_cb_quality_lq")
                form_main.MovPreset = "-crf 30 -preset veryfast"
        End Select

        form_main.StartTask()

    End Sub
End Class