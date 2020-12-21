Module Module1

    Sub Main()
        Dim contatore, centro, numero_da_trovare, centro_su, centro_giu, salva, massimo, numero As Integer
        Dim trovato As Boolean
		
        numero = InputBox("dammi il numero")
        Dim vet(numero) As Integer

        For x = 0 To UBound(vet) - 1
            vet(x) = InputBox("dammi il numero")

        Next
        numero_da_trovare = InputBox("dammi il numero")

        centro = Int(numero / 2)

        contatore = 0
        centro_su = centro + 1
        centro_giu = centro - 1
        massimo = numero - 1

        If vet(centro) = numero_da_trovare Then
            salva = numero - 1
            trovato = True
        End If
        Do
            If vet(contatore) = numero_da_trovare Or vet(massimo) = numero_da_trovare Then
                trovato = True
                Exit Do

            End If

            If vet(centro_giu) = numero_da_trovare Or vet(centro_su) = numero_da_trovare Then
                trovato = True
                Exit Do
            End If


            contatore += 1
            massimo -= 1
            centro_giu -= 1
            centro_su += 1
            salva += 4


        Loop While salva < (numero - 1)

        If trovato = False Then
            MsgBox("numero non trovato")
        Else
            MsgBox("numero trovato")
        End If

    End Sub

End Module
