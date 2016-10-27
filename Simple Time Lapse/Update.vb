Module Update

    Function testconnection() As Boolean

        Try
            My.Computer.Network.Ping("sourceforge.net")
        Catch ex As Exception
            Return False
            Exit Function
        End Try

        Return True

    End Function

    Function GetNewestVersion() As String

        If testconnection() = True Then

            Dim VersionBrowser As New WebBrowser
            VersionBrowser.Navigate("http://simpletimelapse.sourceforge.net/update/version.txt")
            Do Until VersionBrowser.ReadyState = WebBrowserReadyState.Complete
                Application.DoEvents()
            Loop
            VersionBrowser.Refresh(WebBrowserRefreshOption.Completely)
            Dim NewestVersionNr As String = VersionBrowser.Document.Body.InnerText
            Return NewestVersionNr
        Else
            Return ""
        End If
    End Function

End Module
