Module Module1

    Sub Main()
        Dim n, vetp(0), vetn(0), counter_pos, counter_neg As Integer
        Dim out_pos, out_neg As String
        out_pos = ""
        out_neg = ""
        counter_pos = 0
        counter_neg = 0
        For x = 0 To 59
            Try
                n = Int(InputBox("Inserisci il numero da inserire", "Inserire"))
                If n > 0 Then
                    out_pos += n.ToString + ";"
                    vetp(x) = n
                    counter_pos += 1
                    ReDim Preserve vetp(counter_pos)
                ElseIf n < 0 Then
                    out_neg += n.ToString + ";"
                    vetn(x) = n
                    counter_neg += 1
                    ReDim Preserve vetn(counter_neg)
                End If
            Catch ex As Exception
                MsgBox("errore di " & ex.Message, MsgBoxStyle.Critical, "Errore")
                x -= 1

            End Try
        Next
        MsgBox("array positivi " & out_pos, MsgBoxStyle.Information)
        MsgBox("array negativi " & out_neg, MsgBoxStyle.Information)

    End Sub

End Module
