Module Module1

    Sub Main()
        Dim nn, n, max, min As Integer
        Console.WriteLine("Inserire il limite")
        nn = Console.ReadLine()
        Console.WriteLine("Inserire un numero")
        n = Console.ReadLine()
        max = n
        min = n
        For x = 1 To nn - 1
            Console.WriteLine("Inserire un numero")
            n = Console.ReadLine()
            If n > max Then
                max = n
            End If
            If (n < min) Then
                min = n
            End If
        Next
        Console.WriteLine("{0} è il numero massimo, {1} è il numero minimo", max, min)
        Console.ReadKey()
    End Sub

End Module
