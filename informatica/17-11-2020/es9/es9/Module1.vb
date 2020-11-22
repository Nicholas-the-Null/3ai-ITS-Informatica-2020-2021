Module Module1

    Sub Main()
        Dim vet(21), n As Integer
        Dim svet As String = ""
        For x = 0 To UBound(vet) - 1
            Try
                n = InputBox("Inserire un numero positivo.", "RICHIESTA")
                If n < 0 Then
                    MsgBox("Numero inserito non valido.", MsgBoxStyle.Critical, "ERRORE")
                    x -= 1
                Else
                    vet(x) = n
                    svet += n.ToString + " "
                End If
            Catch ex As Exception
                MsgBox("errore " & ex.Message, MsgBoxStyle.Critical, "Errore")

            End Try
        Next
        MsgBox("Il contenuto del vettore è : " + svet, MsgBoxStyle.Information, "INFORMAZIONE")

    End Sub

End Module
