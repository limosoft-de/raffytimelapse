Imports System.Globalization
Imports System.Threading
Imports nUpdate.Updating

Module Update

#Region "Only Installer based Updatefunctions"

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

#End Region

#Region "Autoupdate"

    Public Sub AutoUpdate()

        Select Case My.Settings.app_portable
            Case True
                Dim manager As New UpdateManager(New Uri("http://limosoft.bplaced.net/simpletimelapse/nupdate/portable/updates.json"), "<RSAKeyValue><Modulus>ihgEWn3uWQoxwxIw0u9aVIQULEH9SuTg2yFrlIudC8MWug01F1M931ZWzjjPuKEKsdFI0x6oPFpwq8cmD4Om3lYmmgJwekU1yHzJ13S/hEj5egT3eYGzU0c3uW7hx4Y8nrINsBBRAAw31XeMBEEOhFZ9fymU80xhYLGR4y4xJij/r26tzSywZfpinLl79Sw2Dv4BH1mtaDff9RzSCODzxy4uTK041AdAHu9UFYEP6Y85IOKSzSDC32ljOmB4a3nZJ8eCpld3aCQyIvPoDtwYa25iVuVzp0AdWZXTg7OXJXhYUg1XrZWbj4oY15UXNxyGDzvE4nBgYoLn+p0z0U6JpBRLkD1IIDDSU7vdvsNJtehS2+DYQxYjmrXKpdr8TfydLt3pnpYDBq2EQpOCVqvCw2bjHj3Nuo5xhBfk6ufM33d9C+Ni3a0b9Iv8pcoIRUBK1JUHO0MvR6f9fgNAwWY9EFKFcBpVK74jnTuCv1VRl3mFZJkaeq+qNBttF52g3euY8n/ei1yQcrS4ViyMom5mX3NLwqdKDyIMem7DPgLG2CqAQiUnOW2hCFs/09sf6JofdWlR4og0CqGvIh5nLxnR4QV59TkJxsHdfbFpoZL+ARXUpqLo0W0YNtjOp007rUngn7nGvcfYsB2ZIePsepx5lLYz9++ufEajiYqk8k98xtLaIsl9C24cL/Lj/2fFY0z3Lh5CRb7b+51CveYxWBwv7DZvvgMIimP6POF6vfZ/qNuPgEgsuoHuQBnaBB1gOPTBqJmheo4NgZMyZTRBikAJzWqmoWJRA7AyFAtdvmsZcL/Qd1MGW6B6w6qDYNQIkeb4YQahJgoQY/utsmjKhjJ+4/QUPNfNi1MV8HnU8csZdYRiogzAsBt2pQ9/3u50Dq63QDBC8RX9ZcITT6TCOibnJxZIANMzkSj1uZsh/dlEfNxQn89iuIF2hN6iktaMKvn94/47qGiOJM+RMIsPyewXq6x8hPb+px3gxbHW0uCh8B7CTplK03DJqHM8Ws3bCPiF+PB79bvsM9E3Jt4Ta3hyZYaEoxUSvOPKw+2piDhfIps4WA1cDaQJQGMyL/Boj7yjo3M8z0WvvmC4LvX35aoK2z+Ea7SsSkVfj4273HWN4m2UjPyK0xTav9rBH+ESStL6StjMMDX2mOoK4hUQj9DSBCrN1k6bvE90GJtX9z4zEfXsG0McIYJdGkqZ2l7gJn0AtMGMl6fGIuouKEsIh4gn5m+/AzMqgj0JQFWCqYQO2PaoenCUO8/90Fvd9D49Zb0ghMJ+dPQxCMxLsCV3hLUQKAdRQVWK9AnG0AeJdEd09ceDYzrg8ISRwc0QaAnI9k2/Xx09MguIpFwmkYUuUO7AoQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", New CultureInfo(GetCulture))
                Dim updaterUI As New UpdaterUI(manager, SynchronizationContext.Current)
                updaterUI.UseHiddenSearch = True
                updaterUI.ShowUserInterface()
            Case False
                If My.Settings.set_AutoUpdate = True Then

                    For i = 0 To 10
                        Application.DoEvents()
                        Thread.Sleep(100)
                    Next

                    Dim LocalVersion As String() = My.Settings.app_Version.Split(".")

                    If testconnection() = True Then

                        Dim VersionBrowser As New WebBrowser
                        VersionBrowser.Navigate("http://simpletimelapse.sourceforge.net/update/version.txt")
                        Do Until VersionBrowser.ReadyState = WebBrowserReadyState.Complete
                            Application.DoEvents()
                        Loop
                        VersionBrowser.Refresh(WebBrowserRefreshOption.Completely)
                        Dim NewestVersionNr As String = VersionBrowser.Document.Body.InnerText
                        Dim NewestVersion As String() = VersionBrowser.Document.Body.InnerText.Split(".")

                        If CInt(NewestVersion(0)) > CInt(LocalVersion(0)) Then
                            form_AutoUpdate.NewestVersionNr = NewestVersionNr
                            form_AutoUpdate.ShowDialog()
                        ElseIf CInt(NewestVersion(1)) > CInt(LocalVersion(1)) Then
                            form_AutoUpdate.NewestVersionNr = NewestVersionNr
                            form_AutoUpdate.ShowDialog()
                        ElseIf CInt(NewestVersion(2)) > CInt(LocalVersion(2)) Then
                            form_AutoUpdate.NewestVersionNr = NewestVersionNr
                            form_AutoUpdate.ShowDialog()
                        End If
                    End If
                End If
        End Select

    End Sub

#End Region

#Region "Update on Demand"

    Public Function GetCulture() As String

        Dim nupdate_culture As String = "en"

        Select Case My.Settings.set_LanguageCode
            Case "en_US"
                nupdate_culture = "en"
            Case "de_DE"
                nupdate_culture = "de-DE"
        End Select

        Return nupdate_culture

    End Function

    Public Sub UpdateApp()

        Select Case My.Settings.app_portable
            Case False '!!ToDo: Installer Update via nUpdate

                'Dim manager As New UpdateManager(New Uri("http://limosoft.bplaced.net/simpletimelapse/nupdate/installer/updates.json"), "<RSAKeyValue><Modulus>k75k78uuOraeHwNZmbvFL7YINM1UwrEZ7h0lBrHSHui3hbLnqiSj5XtJjZKMS7maJGD/uZgooe07aMIHzHi9IbRc89+v7sOmQUSYxNX9DywY3sKqMF99MysSBjJZshcbrpYQ9JCzvbiGYy6JghPH/sH8mzJwWnFB1HRDD1OkppiGotIFiY7yCq2Di8enRcPaKoscHUsARv1CZmr5picAadaABrf9R8Pbl5IRRiUSqlMfOIXkhBLksFakjdGGTo5vB7TKgdqBZSmxKHBqMpesATqkABzksx6d8OJ8xzpN5bpIKHUSWV2GcRSh3vKLNxq+2TlvI07nr45sHx50DbYbZYVBIKlIxRp/Rwq70Ru9VuZPBK8NZpYPdRjv20GJsQtOGCxR9qGS94FtunHuazqZ5bc8rIfQScHO6sghodJhlX9HDGK+60XRYuoxXvoib34k0+oRKua5u1OdkYCAGub97Q+CoC6S8nxM7fUCktyOOrtzbAs4Vx3QuOZ1P8p+EXv9HTDcGR8KWh7UPe6N3WNIfU/v4yYv7Qhv6Bb4ixl7aqE7nHOCtxq9au1h3igcwJF34tacGwHmdi9XUJBqHJgXosHpJhZ1oHAn6Hp00wZ1NTf/AoO53kOfHiQvWGPnF6MI8NfTqjnfYv2vS8/93I4rSbtzLMkg3G6BmdfMXEwZafn/PMKPFoGyi5A2DaGOg/jNTiDtl3R/3tlIoy6w852ab6Ap9HuBjXMpQt481rPY6h56kv5fV0FBEFDC8TVGAvlmfe4nMQ3ffpC79/DcsYH649ZqedDjIWuIDDel26+0ux1Ek5c6oXJUlS6DzJG15kQsg+KbIusk0tJWBO9Z3sdn8pxnOJtx7ztT5JJYUcf0aTRo7QFiXWOCs5XThsBc7CmemqKAnn1aETY24KUl93Qhk6xJ1jYd9t3O4rMIsuyvs0l1eyE/i926AQ8ZSDinWCi1XIgJPqnvsvNZxm9ImyYP4PUTUEfo54//tB7taAnTJHz1wOnIv1aSt6Isnr2ac8Sn/eT9JSS3d9TEiTq8GuLU83JdiPw5JqC12PiH5L83bmXZEcdnz0LDF+41Ilm9dLw2HTrbQi36EVIZQ/yp6fB/5hSyNKn5MAZOmPfAmrEF7Il6MRhPpPjF1krT7YSyTmSR7YoVZkQ8HVSm8t4Sav9/NgJbgNdM5MDLAPViwOLFNSDSCjoI7gTj4fo6vkOlgN7WZ3hfd5T41dX5C9qPQvdxwtvLoYCHYRTO8kgNLzglY8AksnAl2bcCSN5eApNYKmc9Ai6Tr4cTYSJMZyBmNwHF8NxJ2EsvxqOogaIbsI8GdfazHiwdqb2rvCl8sZb1oSfxgv1bW5tKr/FhjKCCfPv19w==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", New CultureInfo(GetCulture))
                'Dim updaterUI As New UpdaterUI(manager, SynchronizationContext.Current)
                'updaterUI.ShowUserInterface()

                form_update.ShowDialog()

            Case True 'Portable Update
                Dim manager As New UpdateManager(New Uri("http://limosoft.bplaced.net/simpletimelapse/nupdate/portable/updates.json"), "<RSAKeyValue><Modulus>ihgEWn3uWQoxwxIw0u9aVIQULEH9SuTg2yFrlIudC8MWug01F1M931ZWzjjPuKEKsdFI0x6oPFpwq8cmD4Om3lYmmgJwekU1yHzJ13S/hEj5egT3eYGzU0c3uW7hx4Y8nrINsBBRAAw31XeMBEEOhFZ9fymU80xhYLGR4y4xJij/r26tzSywZfpinLl79Sw2Dv4BH1mtaDff9RzSCODzxy4uTK041AdAHu9UFYEP6Y85IOKSzSDC32ljOmB4a3nZJ8eCpld3aCQyIvPoDtwYa25iVuVzp0AdWZXTg7OXJXhYUg1XrZWbj4oY15UXNxyGDzvE4nBgYoLn+p0z0U6JpBRLkD1IIDDSU7vdvsNJtehS2+DYQxYjmrXKpdr8TfydLt3pnpYDBq2EQpOCVqvCw2bjHj3Nuo5xhBfk6ufM33d9C+Ni3a0b9Iv8pcoIRUBK1JUHO0MvR6f9fgNAwWY9EFKFcBpVK74jnTuCv1VRl3mFZJkaeq+qNBttF52g3euY8n/ei1yQcrS4ViyMom5mX3NLwqdKDyIMem7DPgLG2CqAQiUnOW2hCFs/09sf6JofdWlR4og0CqGvIh5nLxnR4QV59TkJxsHdfbFpoZL+ARXUpqLo0W0YNtjOp007rUngn7nGvcfYsB2ZIePsepx5lLYz9++ufEajiYqk8k98xtLaIsl9C24cL/Lj/2fFY0z3Lh5CRb7b+51CveYxWBwv7DZvvgMIimP6POF6vfZ/qNuPgEgsuoHuQBnaBB1gOPTBqJmheo4NgZMyZTRBikAJzWqmoWJRA7AyFAtdvmsZcL/Qd1MGW6B6w6qDYNQIkeb4YQahJgoQY/utsmjKhjJ+4/QUPNfNi1MV8HnU8csZdYRiogzAsBt2pQ9/3u50Dq63QDBC8RX9ZcITT6TCOibnJxZIANMzkSj1uZsh/dlEfNxQn89iuIF2hN6iktaMKvn94/47qGiOJM+RMIsPyewXq6x8hPb+px3gxbHW0uCh8B7CTplK03DJqHM8Ws3bCPiF+PB79bvsM9E3Jt4Ta3hyZYaEoxUSvOPKw+2piDhfIps4WA1cDaQJQGMyL/Boj7yjo3M8z0WvvmC4LvX35aoK2z+Ea7SsSkVfj4273HWN4m2UjPyK0xTav9rBH+ESStL6StjMMDX2mOoK4hUQj9DSBCrN1k6bvE90GJtX9z4zEfXsG0McIYJdGkqZ2l7gJn0AtMGMl6fGIuouKEsIh4gn5m+/AzMqgj0JQFWCqYQO2PaoenCUO8/90Fvd9D49Zb0ghMJ+dPQxCMxLsCV3hLUQKAdRQVWK9AnG0AeJdEd09ceDYzrg8ISRwc0QaAnI9k2/Xx09MguIpFwmkYUuUO7AoQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", New CultureInfo(GetCulture))
                Dim updaterUI As New UpdaterUI(manager, SynchronizationContext.Current)
                updaterUI.ShowUserInterface()
        End Select
    End Sub

#End Region

End Module
