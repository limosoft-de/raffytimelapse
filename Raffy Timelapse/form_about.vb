Imports System.IO

Public Class form_about

    Private Sub form_about_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        TranslateForm()
        lbl_VersionNr.Text = Application.ProductVersion
        lbl_FfmpegNr.Text = GetFFmpegVersion() & "(" & form_main.FFmpegBit.ToString & " bit)"

    End Sub

    Private Sub form_about_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub TranslateForm()
        Me.Text = TransString("About")

        lbl_version.Text = TransString("About_version")

    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Close()
    End Sub

    Private Function GetFFmpegVersion() As String

        Dim info As New ProcessStartInfo
        info.FileName = form_main.FFmpegPath
        info.Arguments = " -version"
        info.RedirectStandardOutput = True
        info.UseShellExecute = False
        info.WindowStyle = ProcessWindowStyle.Hidden
        info.CreateNoWindow = True
        Dim myProcess As Process = Process.Start(info)
        Dim stmReader As StreamReader = myProcess.StandardOutput

        Dim output As String = stmReader.ReadToEnd

        If output.Contains("ffmpeg version") Then
            Try
                Dim CopyrightSplit As String() = output.Split("Copyright (c)")
                Dim Version As String = CopyrightSplit(0).Replace("ffmpeg version ", "")
                Return Version
            Catch ex As Exception
                Return "n/a"
            End Try
        Else
            Return "n/a"
        End If

    End Function

End Class
