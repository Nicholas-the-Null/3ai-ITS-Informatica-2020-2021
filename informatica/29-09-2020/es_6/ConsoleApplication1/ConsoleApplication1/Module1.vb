Module Module1

    Sub Main()
        Dim a, b, c, x1, x2, delta As Double


        Console.WriteLine("Inserire il coefficiente dell'incognita a")
        a = Console.ReadLine()
        Console.WriteLine("Inserire il coefficiente dell'incognita b")
        b = Console.ReadLine()
        Console.WriteLine("Inserire il coefficiente di c")
        c = Console.ReadLine()
        delta = b * b - 4 * a * c
        If (delta < 0.0) Then
            MsgBox("il delta negativo rende equazione impossibile ", MsgBoxStyle.Critical)
        Else
            x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a
            x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a
            Console.WriteLine("Il delta vale " + CType(delta, String) + " x1 = " + CType(x1, String) + " x2 = " + CType(x2, String))


        End If





        Console.ReadKey()




    End Sub

End Module
