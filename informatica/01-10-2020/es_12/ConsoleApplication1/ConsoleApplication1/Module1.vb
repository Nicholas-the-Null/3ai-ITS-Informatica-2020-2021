Module Module1

    Sub Main()
        Dim età As Integer
        età = InputBox("inserisci l'eta per calcolare lo sconto :) ", "Calcolatore di sconto V3")


        If (età < 5) Then
            MsgBox("congratulazioni il tuo ingresso è gratis", MsgBoxStyle.Information, "prezzo")


        ElseIf (età <= 10) Then
            MsgBox("il tuo ingresso è di 1 misero euro", MsgBoxStyle.Information, "prezzo")
        ElseIf (età <= 17) Then
            MsgBox("il tuo ingresso è di 1.50 euro", MsgBoxStyle.Information, "prezzo")
        ElseIf (età <= 26) Then
            MsgBox("il tuo ingresso è di 2 euro come il prezzo di 2 kaffeeeeee", MsgBoxStyle.Information, "prezzo")
        ElseIf (età > 26) Then
            MsgBox("il tuo ingresso è di 3 euro tondi tondi", MsgBoxStyle.Information, "prezzo")
        End If
        Console.ReadKey()
    End Sub

End Module
