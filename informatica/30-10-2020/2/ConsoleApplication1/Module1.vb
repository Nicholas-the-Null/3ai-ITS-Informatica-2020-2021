Module Module1

    Sub Main()
        Dim n As Integer
        Dim s As String
        Console.WriteLine("Inserire una stringa")
        s = Console.ReadLine()
        Console.WriteLine("Inserire un numero")
        n = Console.ReadLine()
        s = Mid(s, n, 5)
        Console.WriteLine("La nuova stringa è : " + s)
        Console.ReadKey()
    End Sub

End Module
