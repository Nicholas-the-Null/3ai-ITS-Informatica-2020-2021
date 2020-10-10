Module Module1

    Sub Main()
        Dim genere, allenamento As String
        Dim fabbisogno As Integer
        Console.WriteLine("Inserire il genere della persona")
        genere = Console.ReadLine()
        Console.WriteLine("Inserire l'allenamento della persona segliendo tra leggero,medio e pesante.")
        allenamento = Console.ReadLine()
        genere = LCase(genere)
        allenamento = LCase(allenamento)
        If (genere = "uomo") Then
            Select Case allenamento
                Case "leggero"
                    fabbisogno = 42 * 24
                    Console.WriteLine("Il fabbisogno giornaliero è " & fabbisogno)
                Case "medio"
                    fabbisogno = 46 * 24
                    Console.WriteLine("Il fabbisogno giornaliero è " & fabbisogno)
                Case "pesante"
                    fabbisogno = 54 * 24
                    Console.WriteLine("Il fabbisogno giornaliero è " & fabbisogno)
                Case Else
                    Console.WriteLine("Allenamento inserito non valido")
            End Select
        ElseIf (genere = "donna") Then
            Select Case allenamento
                Case "leggero"
                    fabbisogno = 36 * 24
                    Console.WriteLine("Il fabbisogno giornaliero è " & fabbisogno)
                Case "medio"
                    fabbisogno = 40 * 24
                    Console.WriteLine("Il fabbisogno giornaliero è " & fabbisogno)
                Case "pesante"
                    fabbisogno = 46 * 24
                    Console.WriteLine("Il fabbisogno giornaliero è " & fabbisogno)
                Case Else
                    Console.WriteLine("Allenamento inserito non valido")
            End Select
        Else
            Console.WriteLine("Genere inserito non valido")
        End If
        Console.ReadKey()
    End Sub

End Module
