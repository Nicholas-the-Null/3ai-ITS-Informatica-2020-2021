Module Module1

    Sub Main()
        Dim vet(10) As Integer
        Dim n As Integer
        For x = 1 To 10
            n = Val(InputBox("Inserire un numero", "INPUT"))
            vet(x) = n
        Next
        MsgBox("I numeri inseriti sono.", MsgBoxStyle.Information)
        For x = 1 To 10
            Console.Write(vet(x) & " ")
        Next
        Console.ReadKey()
    End Sub

End Module
