Module Module1

    Sub Main()
        Dim n1, n2, appoggio As Integer
        Dim s3 As String = ""

        n1 = InputBox("Inserire la grandezza del primo vettore", "RICHIESTA")
        n2 = InputBox("Inserire la grandezza del secondo vettore", "RICHIESTA")
        If n1 < n2 Then
            appoggio = n1
            n1 = n2
            n2 = appoggio
        End If
        Dim vet1(n1), vet2(n2), vet3(n1) As Integer
        For x = 0 To UBound(vet1) - 1
            vet1(x) = InputBox("Inserire un valore nel primo vettore", "RICHIESTA")
            vet2(x) = InputBox("Inserire un elemento nel secondo vettore", "RICHIESTA")
            If x > n2 Then
                vet3(x) = vet1(x)
                s3 += vet3(x) + " "
            Else
                If x Mod 2 = 0 Then
                    vet3(x) = vet1(x)
                    s3 += vet3(x) + " "
                Else
                    vet3(x) = vet2(x)
                    s3 += vet3(x) + " "
                End If
            End If
        Next

        MsgBox("Il nuovo vettore è : " & s3, MsgBoxStyle.Information, "INFORMAZIONE")
    End Sub

End Module
