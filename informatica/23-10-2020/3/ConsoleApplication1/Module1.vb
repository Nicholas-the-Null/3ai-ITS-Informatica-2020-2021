Module Module1

    Sub Main()
        Randomize()
        Dim n, n_ind, n_tent, conta As Integer
        Dim indovinato As Boolean
        Console.WriteLine("Inserire il numero di tentativi per indovinare un numero da 1 a 100")
        n_tent = Console.ReadLine()
        If n_tent <= 0 Then
            Console.WriteLine("E' impossibile indovinare un numero con 0 o  meno tentativi...")
        Else
            n_ind = (Rnd() * 99) + 1
            indovinato = False
            For x = 1 To n_tent
                Console.WriteLine("Prova ad indovinare il numero da 1 a 100")
                n = Console.ReadLine()
                If n = n_ind Then
                    indovinato = True
                    conta = x
                    Exit For
                End If
                Console.WriteLine("Mi dispace il numero non era : " & n)
            Next
            If indovinato = True Then
                Console.WriteLine("Complimenti è stato indovinato il numero " & n & "!!!" & vbNewLine & "Il numero di tentativi impiegati è : " & conta)
            Else
                Console.WriteLine("Mi dispiace il numero di tentativi è esaurito" & vbNewLine & "Il numero da indovinare era " & n_ind)
            End If
        End If
        Console.ReadKey()
    End Sub

End Module
