Module Module1

    Sub Main()
        Dim cilindrata, giorni, prezzo As Integer
        Dim navigatore As String = ""


        MsgBox("Scegliere cilindrata 1-piccola, 2-media, 3-grande uso i numeri", MsgBoxStyle.Information, "Cilindrata")

        cilindrata = InputBox("inserisci cilindrata", "Calcolatore Cilindrata ")

        Select Case cilindrata
            Case 1
                prezzo = 30
            Case 2
                prezzo = 50
            Case 3
                prezzo = 90
                navigatore = LCase(InputBox("vuoi il navigatore y/n"))

            Case Else
                MsgBox("Cilindrata non valida pertanto di defaul verrà inserito la grande", MsgBoxStyle.Critical)
                prezzo = 90


        End Select

        giorni = InputBox("inserisci i giorni ")

        If giorni > 7 Then
            prezzo = prezzo - (prezzo / 100) * 10




        End If

        prezzo = prezzo * giorni

        If navigatore = "y" Then
            prezzo += 35

        End If

        MsgBox("Il prezzo è " + CType(prezzo, String),MsgBoxStyle.Information)

    End Sub

End Module
