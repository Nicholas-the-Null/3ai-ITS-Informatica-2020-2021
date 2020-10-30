Module Module1

    Sub Main()
        Dim v1, v2, n As Integer
        Randomize()
        Console.WriteLine("Inserire il limite minimo")
        v1 = Console.ReadLine()
        Console.WriteLine("Inserire il limite massimo")
        v2 = Console.ReadLine()
        If v1 <= v2 Then
            n = Int(Rnd() * (v2 - v1 + 1)) + v1
        Else
            n = Int(Rnd() * (v1 - v2 + 1)) + v2
        End If
        If n Mod 2 = 0 Then
            Console.WriteLine("Il numero generato è " & n & " ed è pari")
        Else
            Console.WriteLine("Il numero generato è " & n & " ed è dispari")
        End If
        Console.ReadKey()
    End Sub

End Module
