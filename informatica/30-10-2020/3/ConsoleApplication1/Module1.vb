Module Module1

    Sub Main()
        Dim giorno As String
        Console.WriteLine("Inserire un giorno della settimana")
        giorno = Console.ReadLine()
        giorno = UCase(Trim(giorno))
        Select Case giorno
            Case "LUNEDÌ"
                Console.WriteLine("1")
            Case "MARTEDÌ"
                Console.WriteLine("2")
            Case "MERCOLEDÌ"
                Console.WriteLine("3")
            Case "GIOVEDÌ"
                Console.WriteLine("4")
            Case "VENERDÌ"
                Console.WriteLine("5")
            Case "SABATO"
                Console.WriteLine("6")
            Case "DOMENICA"
                Console.WriteLine("7")
            Case Else
                Console.WriteLine("Giorno inserito non valido")
        End Select
        Console.ReadKey()
    End Sub

End Module
