Module Module1

    Sub Main()
        Dim nc, nn, n, cp, cn, percp, percn As Integer
        nn = 1
        nc = 0
        cp = 0
        cn = 0
        While nn <> 0
            Console.WriteLine("Inserire un numero")
            n = Console.ReadLine()
            If n >= 0 Then
                cp = cp + 1
            End If
            If n < 0 Then
                cn = cn + 1
            End If
            nc = nc + 1
            Console.WriteLine("Per terminare digitare 0")
            nn = Console.ReadLine()
        End While
        percp = cp / nc * 100
        percn = cn / nc * 100
        Console.WriteLine("{0} è il totale dei numeri positivi e {1} di quelli negativi ", cp, cn)
        Console.WriteLine("{0} è la percentuale dei numeri positivi e {1} di quelli negativi ", percp, percn)
        Console.ReadKey()
    End Sub

End Module