Module Module1

    Sub Main()
        Dim s1 As String
        Dim s2 As Char
        Dim c As Integer
        Console.WriteLine("Inserire una stringa")
        s1 = Console.ReadLine()
        Console.WriteLine("Inserire un carattere")
        s2 = Console.ReadLine()
        c = 0
        For x = 1 To Len(s1)
            If s2 = Mid(s1, x, 1) Then
                c += 1
            End If
        Next
        If c = 1 Then
            Console.WriteLine("Il carattere è contenuto {0} volta", c)
        Else
            Console.WriteLine("Il carattere è contenuto {0} volte", c)
        End If
        Console.ReadKey()
    End Sub

End Module
