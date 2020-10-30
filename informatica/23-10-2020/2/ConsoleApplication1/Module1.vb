Module Module1

    Sub Main()
        Randomize()
        Dim lan, c As Integer
        c = 0
        Do While True
            lan = Int(Rnd() * 11) + 2
            c += 1
            If lan = 12 Then
                Exit Do
            End If
        Loop
        Console.WriteLine("Il numero di volte necessarie a far apparire 12 è stato " & c)
        Console.ReadKey()
    End Sub

End Module
