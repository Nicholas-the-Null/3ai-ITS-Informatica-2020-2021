Module Module1

    Sub Main()
        Dim nn, n, cp, cn, percp, percn As Integer
        Dim r As String
        nn = 0
        cp = 0
        cn = 0
        Do While True
            Console.WriteLine("Inserire un numero")
            n = Console.ReadLine()
            If n >= 0 Then
                cp = cp + 1
            End If
            If n < 0 Then
                cn = cn + 1
            End If
            nn += 1
            Console.WriteLine("Vuoi uscire dal ciclo?")
            r = Console.ReadLine()
            If LCase(r) = "si" Then
                Exit Do
            End If
        Loop
        percp = cp / nn * 100
        percn = cn / nn * 100
        Console.WriteLine("{0} è il totale dei numeri positivi e {1} di quelli negativi ", cp, cn)
        Console.WriteLine("{0} è la percentuale dei numeri positivi e {1} di quelli negativi ", percp, percn)
        Console.ReadKey()
    End Sub

End Module
