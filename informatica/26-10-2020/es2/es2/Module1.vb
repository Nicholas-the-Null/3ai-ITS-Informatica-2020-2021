Module Module1

    Sub Main()
        Dim lan, conta As Integer
        Dim log As String

        log = LCase(InputBox("vuoi attivare i log per vedere i numeri generati Y/N"))


        conta = 0
        Randomize()
        Do While True
            lan = (12 * Rnd() + 1)
            If log = "y" Then
                Console.WriteLine(lan)
            End If
            conta += 1
            If lan = 12 Then
                Exit Do
            End If
        Loop
        MsgBox("Il numero di volte necontaessarie a far apparire 12 è stato " & conta,MsgBoxStyle.Information)
        Console.ReadKey()

    End Sub

End Module
