'Un agenzia immobiliare decide di fare una tabella
'Centro          1200$ * m^2
'Zona1          1000$ * m^2
'Zona2         900$ * m^2
'Zona3          750$ * m^2
'Periferia       600$ * m^2
'realizza un programma con il costrutto select che dato in input area e i metri determini il prezzo


Module Module1

    Sub Main()
        Dim prezzo, metri As Integer
        Dim zona As String
        zona = UCase(InputBox("dammi la zona o digita help per la tabella", "Calcolatore di prezzo ", "HELP"))

        Select Case zona
            Case "HELP"
                MsgBox("Le zone sono Centro, Zona 1, Zona 2, Zona 3,Periferia", MsgBoxStyle.Information, "help")

            Case "CENTRO"
                prezzo = 1200
            Case "ZONA 1"
                prezzo = 1000
            Case "ZONA 2"
                prezzo = 900
            Case "ZONA 3"
                prezzo = 750
            Case "PERIFERIA"
                prezzo = 600
            Case Else
                prezzo = 0

        End Select

        If prezzo = 0 AndAlso zona <> "HELP" Then


            MsgBox("errore non hai inserito una zona valida", MsgBoxStyle.Critical, "errore")


        ElseIf prezzo = 0 Then

            Console.ReadKey()


        Else
            metri = InputBox("Dammi i metri ", "Metri")
            prezzo = prezzo * metri
            MsgBox("Il costo totale è di " + CType(prezzo, String), MsgBoxStyle.Information, "finish")




        End If



    End Sub

End Module
