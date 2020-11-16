Module Module1

    Sub Main()
        Dim vet(8) As Double
        Dim n, prodotto, media As Double
        prodotto = 1
        media = 0
        For x = 1 To 8
            n = Val(InputBox("Inserire un numero.", "INPUT"))
            vet(x) = n
            media += vet(x)
            If vet(x) Mod 2 = 0 Then
                prodotto = prodotto * vet(x)
            End If
        Next
        media = media / 8
        If prodotto = 1 Then
            MsgBox("Non è stato inserito nessun numero pari,quindi non posso fare il prodotto.", MsgBoxStyle.Critical, "ERRORE")
        Else
            MsgBox("Il prodotto è : " & Math.Round(prodotto, 2), MsgBoxStyle.Information, "RISULTATO")
        End If
        MsgBox("La media è : " & Math.Round(media, 2), MsgBoxStyle.Information, "RISULTATO")
        Console.ReadKey()
    End Sub

End Module
