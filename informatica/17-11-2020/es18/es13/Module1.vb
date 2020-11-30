Module Module1

    Sub Main()
        Dim s As String = InputBox("Inserire una stringa", "RICHIESTA")
        Dim save As String
        Dim n, conta_numeri As Integer
        n = InputBox("Inserire il valore ascii", "RICHIESTA")
        For x = 0 To Len(s) - 1
            If Asc(s(x)) > n Then
                conta_numeri += 1
                save += s(x) + " "
            End If
        Next
        MsgBox("I caratteri che hanno un valore in codice ASCII maggiore di " & n & " sono : " & conta_numeri & ".", MsgBoxStyle.Information, "Informazione")
        MsgBox("log lettere" & save)
    End Sub




End Module
