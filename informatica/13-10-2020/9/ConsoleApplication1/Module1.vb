Module Module1

    Sub Main()
        Dim n, max, min, c, p_max, p_min As Integer
        Console.WriteLine("Inserire un numero (inserire 0 per terminare il programma)")
        n = Console.ReadLine()
        max = n
        min = n
        c = 1
        p_max = c
        p_min = c
        If n <> 0 Then
            Do
                Console.WriteLine("Inserire un numero (inserire 0 per terminare il programma)")
                n = Console.ReadLine()
                If n = 0 Then
                    Exit Do
                End If
                c = c + 1
                If max < n Then
                    max = n
                    p_max = c
                ElseIf min > n Then
                    min = n
                    p_min = c
                End If
            Loop While n <> 0
            Console.WriteLine("Il numero maggiore è " & max & " alla posizione " & p_max)
            Console.WriteLine("Il numero minore è " & min & " alla posizione " & p_min)
        Else
            Console.WriteLine("E' stato inserito subito 0")
        End If
        Console.ReadKey()
    End Sub

End Module
