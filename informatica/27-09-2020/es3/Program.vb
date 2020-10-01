Imports System

Module Program
    Sub Main(args As String())
        Dim lato1,lato2,lato3 as Integer 
        Console.WriteLine("inserisci il lato 1 ")
        lato1=Console.ReadLine()
        Console.WriteLine("inserisci il lato 2 ")
        lato2=Console.ReadLine()
        Console.WriteLine("inserisci il lato 3 ")
        lato3=Console.ReadLine()
        
        if (lato1<>lato2) AndAlso (lato2<>lato3) AndAlso (lato3<>lato1) Then 
            Console.WriteLine("è scaleno")
        ElseIf (lato1=lato2) AndAlso (lato2=lato3) Then
            Console.WriteLine("è equilatero")
        Else
            Console.WriteLine("è isoscele")
        Console.ReadLine()

        end If

    End Sub
End Module
