Module Module1

    Sub Main()
        Dim numero_elementi, n As Integer
        Dim a As Boolean = False
        Do While True
            numero_elementi = InputBox("Inserire quanti elementi vuoi nel vettore.", "RICHIESTA")
            If numero_elementi > 0 Then
                Exit Do
            Else
                MsgBox("errore valore inserito non valido", MsgBoxStyle.Exclamation, "errore")
            End If
        Loop

        Dim vet(numero_elementi) As Integer
        For x = 0 To UBound(vet) - 1
            vet(x) = InputBox("Inserire un numero.", "RICHIESTA")
        Next
        n = InputBox("Inserire il numero da cercare nel vettore.", "RICHIESTA")
        For x = 0 To UBound(vet) - 1
            If vet(x) = n Then
                MsgBox("Il numero " & n & " si trova alla posizione " & x, MsgBoxStyle.Information, "INFORMAZIONE")
                a = True
                Exit For
            End If
        Next
        If a = False Then
            MsgBox("Indice non valido", MsgBoxStyle.Critical, "ERRORE")
        End If

    End Sub

End Module
