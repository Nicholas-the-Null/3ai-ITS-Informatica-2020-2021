'costrutto Select
'Testo Sullo stipendio dei dipendenti di una ditta viene applicata una trattenuta fiscale in base alla seguente tabella
'Scaglione 1 trattenuta del 5%
'Scaglione 2 trattenuta del 10%
'Scaglione 3 trattenuta del 15%
'Scaglione 4 trattenuta del 25%
'Scaglione 5 trattenuta del 35%
'Realizza un programma che dato in input lo scaglione di appartenenza di un dipendente, calcoli la trattenuta da versare


Module Module1

    Sub Main()
        Dim Scaglione As Integer
        Scaglione = InputBox("inserisci Scaglione(1-5)", "Calcolatore Scaglione")
        Select Case Scaglione
            Case 1
                MsgBox("lo scaglione è del 5%", MsgBoxStyle.Information, "calcolato")

            Case 2
                MsgBox("lo scaglione è del 10%", MsgBoxStyle.Information, "calcolato")
            Case 3
                MsgBox("lo scaglione è del 15%", MsgBoxStyle.Information, "calcolato")
            Case 4
                MsgBox("lo scaglione è del 25%", MsgBoxStyle.Information, "calcolato")
            Case 5
                MsgBox("lo scaglione è del 35%", MsgBoxStyle.Information, "calcolato")
            Case Else
                MsgBox("il numero non rientra nello scaglione", MsgBoxStyle.Critical, "errore")
        End Select
    End Sub

End Module
