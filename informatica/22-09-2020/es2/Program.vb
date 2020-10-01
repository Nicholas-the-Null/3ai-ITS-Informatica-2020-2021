Imports System


Module Program
    Sub Main()
        Dim base,altezza,perimetro,area,diagonale as Double 
        Console.WriteLine("dammi la base ")
        base=Console.ReadLine()
        Console.WriteLine("dammi altezza ")
        altezza=Console.ReadLine()
        perimetro=(base+altezza)*2
        area=(base*altezza)/2
        diagonale=Math.Sqrt(base^2+altezza^2)
        Console.WriteLine("il perimetro è {0:N3}, l'area è {1:N3}, la diagonale{2:N3} ",perimetro,area,diagonale)
        Console.ReadLine()
    End Sub
End Module
