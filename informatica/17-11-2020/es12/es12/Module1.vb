Module Module1

    Sub Main()
        Dim numero_a, numero_b, numero_c, appoggio As Integer
        Dim sa, sb, sc As String
        sa = ""
        sb = ""
        sc = ""
        numero_a = InputBox("Inserire il numero di elementi del primo vettore", "RICHIESTA")
        numero_b = InputBox("Inserire il numero di elementi del secondo vettore", "RICHIESTA")
        Dim veta(numero_a), vetb(numero_b), vetc(0) As Integer

        For x = 0 To numero_a + numero_b
            If x < UBound(veta) Then
                veta(x) = InputBox("Inserire l'elemento numero " & x & " del primo vettore", "RICHIESTA")
                sa += veta(x).ToString + " "
                vetc(numero_c) = veta(x)
                numero_c += 1
                ReDim Preserve vetc(numero_c)
            End If

            If x < UBound(vetb) Then
                vetb(x) = InputBox("Inserire l'elemento numero " & x & " del secondo vettore", "RICHIESTA")
                sb += vetb(x).ToString + " "
                vetc(numero_c) = vetb(x)
                numero_c += 1
                ReDim Preserve vetc(numero_c)
            End If


        Next

        For i = 0 To UBound(vetc) - 2
            For j = i + 1 To UBound(vetc) - 1
                If vetc(i) > vetc(j) Then
                    appoggio = vetc(i)
                    vetc(i) = vetc(j)
                    vetc(j) = appoggio
                End If
            Next
            sc += vetc(i).ToString + " "
        Next

        sc += vetc(UBound(vetc) - 1).ToString
        MsgBox("Il primo vettore è : " & sa, MsgBoxStyle.Information, "INFORMAZIONE")
        MsgBox("Il secondo vettore è : " & sb, MsgBoxStyle.Information, "INFORMAZIONE")
        MsgBox("Il terzo vettore è : " & sc, MsgBoxStyle.Information, "INFORMAZIONE")

    End Sub

End Module
