Imports System

Module Program
    Sub Main()
        Dim prezzo,sconto,iva,prezzo_senza_iva,prezzo_senza_sconto as Single  
        Console.WriteLine("inserisci il prezzo")
        prezzo=Console.ReadLine()
        prezzo_senza_iva=prezzo
        Console.WriteLine("inserisci iva")
        iva=Console.ReadLine()
        prezzo=prezzo*(1+iva/100) 'formula ridotta del calcolo dell'iva
        prezzo_senza_sconto=prezzo
        Console.WriteLine("inserisci lo sconto ")
        sconto=Console.ReadLine()
        prezzo=prezzo-(prezzo/100)*sconto
        Console.WriteLine(vbCrLf+"il prezzo originario del prodotto è {0:N3} il prezzo con l'iva è {1:N3} il prezzo scontato è {2:N3}",prezzo_senza_iva,prezzo_senza_sconto,prezzo)
        Console.ReadLine()


    End Sub
End Module
