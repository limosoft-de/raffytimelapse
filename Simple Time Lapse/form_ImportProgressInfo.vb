Imports System.IO
Imports System.ComponentModel

Public Class form_ImportProgressInfo

    Private Sub form_ImportProgressInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TranslateForm()
        bw_Importing.RunWorkerAsync()
    End Sub

    Private Sub TranslateForm()

        Text = TransString("Import")
        btn_cancel.Text = TransString("_General_cancel")
        lbl_progress.Text = TransString("Import_lbl_progress1") & " 0 " & TransString("Import_lbl_progress2") & " 0"

    End Sub


    Private Sub bw_Importing_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_Importing.DoWork

        Dim ImportProgress As Integer = 0

        Invoke(Sub()

                   For Each path As String In form_main.ImportFileList
                       If form_main.ImportFiles(path) = False Then
                           bw_Importing.ReportProgress(-1)
                           Exit For
                       End If

                       ImportProgress = ImportProgress + 1
                       Application.DoEvents()
                       bw_Importing.ReportProgress(ImportProgress)

                       If bw_Importing.CancellationPending = True Then
                           bw_Importing.ReportProgress(form_main.ImportFileList.Length)
                           Exit For
                       End If
                   Next

               End Sub)

    End Sub

    Private Sub bw_Importing_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bw_Importing.ProgressChanged

        'CLOSE ON ERROR
        If e.ProgressPercentage = -1 Then
            Close()
        End If

        Dim ProgressPercentage = e.ProgressPercentage / form_main.ImportFileList.Length * 100

        lbl_progress.Text = TransString("Import_lbl_progress1") & " " & e.ProgressPercentage & " " & TransString("Import_lbl_progress2") & " " & form_main.ImportFileList.Length & " (" & Math.Round(ProgressPercentage) & "%)"

        If ProgressPercentage = 100 Then
            Close()
        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        bw_Importing.CancelAsync()
    End Sub
End Class