Module Module1

    Sub Main()
        Dim n As Integer
        Console.WriteLine("Inserire il limite")
        n = Console.ReadLine
        For x = 0 To n
            If (x Mod 2 <> 0) Then
                Console.WriteLine(x)
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
