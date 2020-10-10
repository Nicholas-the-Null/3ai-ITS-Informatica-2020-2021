Module Module1

    Sub Main()
        Dim data As Date
        Console.WriteLine("Inserire la data")
        data = Console.ReadLine()
        data = data.AddDays(1)
        Console.WriteLine("La data è " & data)
        Console.ReadKey()
    End Sub

End Module
