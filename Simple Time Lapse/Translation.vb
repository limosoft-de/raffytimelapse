Imports System.Resources
Module Translation

    Public Function TransString(ByVal StringName As String) As String
        Dim Translation As New ResourceManager("Simple_Time_Lapse.strings_" & My.Settings.set_LanguageCode, GetType(form_main).Assembly)
        Dim TempString As String = Translation.GetString(StringName)

        If TempString = "" Then
            Dim DefaultTranslation As New ResourceManager("Simple_Time_Lapse.strings_" & My.Settings.app_DefaultLanguageCode, GetType(form_main).Assembly)
            TempString = DefaultTranslation.GetString(StringName)
        End If

        Return TempString
    End Function

End Module
