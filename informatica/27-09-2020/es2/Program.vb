Imports System


Module Program
    Sub Main(args As String())
        Dim num as Integer  
        Console.WriteLine("inserisci il numero")
        num =Console.ReadLine()
        If (num=0) Then 
               Console.WriteLine("il numero 0 non è verificabile")
        ElseIf (num Mod 2=0) Then
                Console.WriteLine("il numero è pari ")
        Else
            Console.WriteLine("il numero è dispari ")

        end If
                Console.ReadLine()
    End Sub
End Module
