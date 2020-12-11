Module Module1

    Sub Main()
        Dim scelta As Integer

        scelta = InputBox("scegli cosa vuoi fare 1-gioco del indovinare i numeri, 2-somma quadrati-3trovare il massimo")

        Select Case scelta
            Case 1
                Randomize()
                Dim tentativi, numero, segreto As Integer
                segreto = Int(Rnd() * (100 - 1 + 1)) + 1
                Do While True
                    Try
                        tentativi = InputBox("dammi il numero di tentativi")
                    Catch ex As Exception
                        MsgBox("hai scritto una stringa")

                    End Try

                    If tentativi <= 0 Then
                        MsgBox("numero non valido", MsgBoxStyle.Critical)
                    Else
                        Exit Do

                    End If
                Loop
                For x = 1 To tentativi
                    numero = InputBox("dammi il numero che vuoi provare")
                    If numero = segreto Then
                        MsgBox("congratulazioni hai vinto con " & x & " tentativi", MsgBoxStyle.Information)
                    ElseIf numero > segreto Then
                        MsgBox("il tuo numero " & numero & " è maggiore del numero da indovinare ti rimangono " & tentativi - x & " tentativi", MsgBoxStyle.Information)
                    Else
                        MsgBox("il tuo numero " & numero & " è minore del numero da indovinare ti rimangono " & tentativi - x & " tentativi", MsgBoxStyle.Information)
                    End If
                Next

                If numero <> segreto Then
                    MsgBox("il numero era " & segreto, MsgBoxStyle.Information)
                End If

            Case 2
                Dim k, n, somma_quadrati, quadrato As Integer
                k = InputBox("dammi il numero ")
                n = InputBox("di quanti numeri vuoi la somma di quadrati")
                k += 1
                For x = 1 To n
                    quadrato = k * k
                    somma_quadrati += quadrato
                    k += 1
                Next
                MsgBox("la somma di quadrati è " & somma_quadrati, MsgBoxStyle.Information)
            Case 3
                Dim minimo, pos_minimo, massimo, pos_massimo, numero, conta As Integer
                minimo = InputBox("dammi il primo numero")
                pos_massimo = 1
                pos_minimo = 1
                conta = 1
                massimo = minimo
                Do While True
                    numero = InputBox("dammi il numero ")
                    If numero < 0 Then
                        Exit Do
                    ElseIf numero > massimo Then
                        massimo = numero
                        pos_massimo = conta
                    ElseIf numero < minimo Then
                        minimo = numero
                        pos_minimo = conta
                    End If
                    conta += 1
                Loop
                MsgBox("il massimo è " & massimo & " la sua posizione è " & pos_massimo, MsgBoxStyle.Information)
                MsgBox("il minimo è " & minimo & " la sua posizione è " & pos_minimo, MsgBoxStyle.Information)

            Case Else
                MsgBox("errore numero non valido", MsgBoxStyle.Critical, "errore")
        End Select

    End Sub

End Module
