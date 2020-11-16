Module Module1

    Sub Main()
        Dim vet(8) As Integer
        Dim n As Integer
        For x = 1 To 8
            n = Val(InputBox("Inserire un numero.", "INPUT"))
            vet(x) = n
        Next
        MsgBox("I numeri pari inseriti sono", MsgBoxStyle.Information, "OUTPUT")
        For x = 1 To 8
            If vet(x) Mod 2 = 0 Then
                Console.Write(vet(x) & " ")
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
