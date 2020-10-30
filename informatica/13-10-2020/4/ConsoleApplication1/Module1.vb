Module Module1

    Sub Main()
        Dim n, p As Integer
        Console.WriteLine("Inserire un numero")
        n = Console.ReadLine()
        p = 0
        For x = 0 To n
            If (x Mod n = 0) Then
                p = p + 1
            End If
        Next
        If (p = 2) Then
            Console.WriteLine("Il numero è un numero primo")
        Else
            Console.WriteLine("Il numero non è un numero primo")
        End If
        Console.ReadKey()
    End Sub

End Module
