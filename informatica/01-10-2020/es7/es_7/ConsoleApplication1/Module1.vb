Module Module1

    Sub Main()
        Dim prezzo As Double


        prezzo = InputBox("inserisci prezzo", "Cassa degli sconti", "0", -1, -1)




        




        If (prezzo < 50) Then

            prezzo = prezzo - (prezzo / 100) * 10

            MsgBox("il prezzo scontato è " + CType(prezzo, String), MsgBoxStyle.Information, "sconto")



        ElseIf (prezzo > 50 And prezzo <= 100) Then
            prezzo = prezzo - (prezzo * 20 / 100)
            MsgBox("il prezzo scontato è " + CType(prezzo, String), MsgBoxStyle.Information, "sconto")
        Else
            prezzo = prezzo - (prezzo * 30 / 100)
            MsgBox("il prezzo scontato è " + CType(prezzo, String), MsgBoxStyle.Information, "sconto")



        End If


    End Sub

End Module
