Module Module1

    Sub Main()
        Dim anno_imm, anno, n As Integer
        Dim targa, persona, a As String
        Console.WriteLine("Inserire il limite")
        n = Console.ReadLine()
        a = ""
        If n <= 0 Then
            Console.WriteLine("Essendo che ha inserito 0 o meno non entro nel ciclo")
        Else
            Console.WriteLine("Inserire l'anno limite")
            anno_imm = Console.ReadLine()
            For x = 1 To n
                Console.WriteLine("Inserire il proprio nome")
                persona = Console.ReadLine()
                Console.WriteLine("Inserire la targa")
                targa = Console.ReadLine()
                Console.WriteLine("Inserire l'anno di immatricolazione")
                anno = Console.ReadLine()
                If anno < anno_imm Then
                    a = a + " nome : " + persona + " targa : " + targa + vbNewLine
                End If
            Next
            Console.WriteLine(a)
        End If
        Console.ReadKey()
    End Sub

End Module
