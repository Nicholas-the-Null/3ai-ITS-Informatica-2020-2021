Module Module1

    Sub Main()
        Dim n, somma As Integer
        Console.WriteLine("Inserire il limite")
        n = Console.ReadLine
        somma = 0
        If n >= 100 Then
            Console.WriteLine("Numero inserito troppo grande riprovare con uno minore di 100")
        Else
            For x = 0 To n
                If (x Mod 2 <> 0) Then
                    somma = somma + x
                End If
            Next
            Console.WriteLine("La somma è " & somma)
        End If
        Console.ReadKey()
    End Sub

End Module
