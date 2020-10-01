Module Module1

    Sub Main()
        Dim num, num1, appoggio As Int32
        num = InputBox("inserisci il primo numero ")
        num1 = InputBox("inserisci il secondo numero ")
        If (num1 > num) Then
            appoggio = num
            num = num1
            num1 = appoggio
        End If
        appoggio = num - num1
        MsgBox("il numero maggiore è" + CType(num, String
               ) + " quelllo minore è " + CType(num1, String
               ) + " la differenza è " + CType(appoggio, String
               ))





    End Sub

End Module
