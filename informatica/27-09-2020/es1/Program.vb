Imports System

Module Program
    Sub Main()
    Dim a,b As int32
    Console.WriteLine("Inserire il primo numero")
    a = Console.ReadLine()
    Console.WriteLine("Inserire il secondo numero")
    b = Console.ReadLine()
    If a>b then 
        Console.WriteLine("{0} è maggiore di {1}",a,b)
    ElseIf b>a then 
        Console.WriteLine("{0} è maggiore di {1}",b,a)
    Else 
        Console.WriteLine("i numeri inseriti sono uguali")
    End If
    Console.ReadLine()
    
    End Sub
End Module
