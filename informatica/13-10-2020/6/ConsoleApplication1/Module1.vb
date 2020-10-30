Module Module1

    Sub Main()
        Dim nn, n, cp, cn, percp, percn As Integer
        Console.WriteLine("Inserire il limite")
        nn = Console.ReadLine()
        cp = 0
        cn = 0
        For x = 1 To nn
            Console.WriteLine("Inserire un numero")
            n = Console.ReadLine()
            If n >= 0 Then
                cp = cp + 1
            End If
            If n < 0 Then
                cn = cn + 1
            End If
        Next
        percp = cp / nn * 100
        percn = cn / nn * 100
        Console.WriteLine("{0} è il totale dei numeri positivi e {1} di quelli negativi ", cp, cn)
        Console.WriteLine("{0} è la percentuale dei numeri positivi e {1} di quelli negativi ", percp, percn)
        Console.ReadKey()
    End Sub

End Module
