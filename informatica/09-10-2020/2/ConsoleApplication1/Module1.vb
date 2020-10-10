Module Module1
    Sub Main()
        Dim peso, altezza, bmi As Double
        Console.WriteLine("Inserire il peso in kilogrammi")
        peso = Console.ReadLine()
        If (peso < 50 Or peso > 120) Then
            Console.WriteLine("Valore peso errato")
        Else
            Console.WriteLine("Inserire l'altezza in metri")
            altezza = Console.ReadLine()
            If (altezza < 1.3 Or altezza > 2.2) Then
                Console.WriteLine("Valore altezza errato")
            Else
                bmi = peso / (altezza * altezza)
                Select Case bmi
                    Case Is < 18
                        Console.WriteLine("Body mass index basso")
                    Case 18 To 25
                        Console.WriteLine("Body mass index corretto")
                    Case Is > 25
                        Console.WriteLine("Body mass index alto")
                End Select
            End If
        End If
        Console.ReadKey()
    End Sub
End Module
