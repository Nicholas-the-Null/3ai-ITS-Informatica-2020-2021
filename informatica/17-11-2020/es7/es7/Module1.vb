Module Module1

    Sub Main()
        Dim nn As Integer
        Dim stringa_a, sb, sc As String
        Do While True
            nn = InputBox("Inserire quanti elementi vuoi nel vettore.", "RICHIESTA")
            If nn > 0 Then
                Exit Do
            Else
                MsgBox("errore valore inserito non valido", MsgBoxStyle.Exclamation, "errore")
            End If
        Loop
        Dim a(nn), b(nn), c(nn) As Integer
        stringa_a = ""
        sb = ""
        sc = ""
        For x = 0 To nn - 1
            a(x) = InputBox("Inserire un elemento del vettore a.", "RICHIESTA")
            b(x) = InputBox("Inserire un elemento del vettore b.", "RICHIESTA")
            c(x) = Math.Round((a(x) + b(x)) / 2, 2)
            stringa_a += a(x).ToString + " "
            sb += b(x).ToString + " "
            sc += c(x).ToString + " "
        Next
        MsgBox("Il vettore a è : " & stringa_a & ".", MsgBoxStyle.Information, "INFORMAZIONE")
        MsgBox("Il vettore b è : " & sb & ".", MsgBoxStyle.Information, "INFORMAZIONE")
        MsgBox("Il vettore c è : " & sc & ".", MsgBoxStyle.Information, "INFORMAZIONE")

    End Sub

End Module
