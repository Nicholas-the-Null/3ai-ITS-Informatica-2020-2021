Module Module1

    'Data una stringa stmapre le vocali
    Sub Main()
        Dim s As String = LCase(InputBox("Dammi la stringa", "Calcola Stringa", "default"))
        Dim vocale As String = ""


        For Each c In s
            If c = "a" Or c = "i" Or c = "u" Or c = "e" Or c = "o" Then
                vocale += c
            End If
        Next

        MsgBox("le lettere sono " + vocale, MsgBoxStyle.Information)

    End Sub

End Module
