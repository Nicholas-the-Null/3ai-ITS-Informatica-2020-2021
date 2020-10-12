'Dato in input un numero calcolare la somma di tutti i numeri =< dispari di esso
Module Module1

    Sub Main()
        Dim somma, num As Integer
        num = InputBox("inserisci il numero che vuoi clacolare", "calcolatore")
        For i = 0 To num
            If (i Mod 2 <> 0) Then
                somma += i
            End If
        Next i
        MsgBox("la somma è " & somma)


    End Sub

End Module
