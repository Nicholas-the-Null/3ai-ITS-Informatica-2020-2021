Module Module1

    Sub Main()
        Dim nn, nn_save, numero, conta As Integer
        Dim duplicate As Boolean
        conta = 0
        nn_save = 0

        Do While True
            nn = InputBox("dammi la grandezza dei vettori >Oe minore di 50")
            If nn > 0 And nn < 51 Then
                Exit Do
            Else
                MsgBox("errore valore inserito non valido", MsgBoxStyle.Exclamation, "errore")

            End If
        Loop
        nn_save = nn
        Dim vet(nn), vet_Duplicate(nn) As Integer

        For x = 0 To nn - 1
            numero = InputBox("dammi il numero da inserire")
            vet(x) = numero
        Next


        For x = 0 To UBound(vet) - 1
            duplicate = False
            nn = vet(x)
            For s = x + 1 To UBound(vet) - 1
                If vet(s) = nn Then
                    duplicate = True

                End If
            Next s
            If duplicate = False Then
                vet_Duplicate(conta) = nn
                conta += 1
            End If

        Next x

        For x = 0 To UBound(vet_Duplicate) - (nn_save - conta + 1)
            Console.Write(vet_Duplicate(x) & " ")
        Next
        Console.ReadKey()

    End Sub

End Module
