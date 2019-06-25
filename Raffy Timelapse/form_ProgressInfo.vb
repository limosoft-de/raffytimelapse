Imports System.ComponentModel

Public Class form_ProgressInfo

    Private Sub UserDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        form_main.Enabled = False

        Text = TransString("ProgressInfo")
        btn_cancel.Text = TransString("_General_cancel")
        btn_ok.Text = TransString("_General_ok")
        lbl_errorlog.Text = TransString("ProgressInfo_lbl_errorlog")

        btn_ok.Enabled = False
        AcceptButton = btn_cancel
        form_main.Finished = False


    End Sub

    Private Sub tm_CheckState_Tick(sender As Object, e As EventArgs) Handles tm_CheckState.Tick
        lbl_status.Text = form_main.Status

        If form_main.Finished = True Then
            'RENDERING COMPLETED
            If form_main.Status = TransString("Main_bw_Rendering_Progress_100") Then
                pb.Image = My.Resources.done
                btn_ok.Enabled = True
                AcceptButton = btn_ok
                btn_ok.Select()

                'ERROR
            ElseIf form_main.Status = TransString("Main_bw_Rendering_Progress_-1") Or
                form_main.Status = TransString("Main_bw_Rendering_Progress_-2") Then

                pb.Image = My.Resources.cancel
                lbl_errorlog.Visible = True
                btn_ok.Enabled = True
                AcceptButton = btn_ok
                btn_ok.Select()
            End If
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        If form_main.bw_Rendering.WorkerSupportsCancellation = True Then
            form_main.bw_Rendering.CancelAsync()
        End If
        Close()
    End Sub

    Private Sub form_ProgressInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If form_main.bw_Rendering.IsBusy Then
            form_main.bw_Rendering.CancelAsync()
        End If

        form_main.Finished = False

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Close()
    End Sub

    Private Sub form_ProgressInfo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        form_main.Enabled = True
    End Sub

    Private Sub Lbl_errorlog_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_errorlog.LinkClicked
        form_main.LogOpen()
    End Sub
End Class