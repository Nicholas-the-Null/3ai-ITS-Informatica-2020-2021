Module Module1

    Sub Main()
        Dim comando, contatore, posizione As Integer
        contatore = 0
        Dim vet_contatti(contatore), vet_num(contatore), servitore As String
        Dim verificatore As Boolean
        Do While True
            Console.WriteLine()
            Console.WriteLine("---------------------------------------")
            For g = 0 To UBound(vet_contatti) - 1
                Console.Write(vet_contatti(g) & " ")

            Next

            Console.WriteLine()
            For g = 0 To UBound(vet_num) - 1
                Console.Write(vet_num(g) & " ")

            Next


            Try
                comando = Int(InputBox("inserisci il comando 1-inserisci contatto,2-elimina contatto,3cerca contatto da nome,0-esci"))
            Catch ex As Exception
                MsgBox("Errore di " & ex.Message, MsgBoxStyle.Critical)
                comando = 5

            End Try


            Select Case comando
                Case 0
                    MsgBox("Sto uscendo", MsgBoxStyle.Information)
                    Exit Do

                Case 1
                    vet_contatti(contatore) = InputBox("inserisci il nome", "Agenda 3.0")
                    vet_num(contatore) = InputBox("inserisci il numero ", "Agenda 3.0")
                    contatore += 1
                    ReDim Preserve vet_contatti(contatore), vet_num(contatore)

                Case 2
                    verificatore = False
                    servitore = InputBox("Inserire il nome del contatto da cancellare", "RICHIESTA")
                    For x = 0 To UBound(vet_contatti) - 1
                        If servitore = vet_contatti(x) Then
                            verificatore = True
                            For i = x To UBound(vet_contatti) - 1
                                vet_contatti(i) = vet_contatti(i + 1)
                            Next i
                            For i = x To UBound(vet_contatti) - 1
                                vet_num(i) = vet_num(i + 1)
                            Next i
                            contatore -= 1
                            ReDim Preserve vet_contatti(contatore), vet_num(contatore)
                        End If
                    Next x
                    If verificatore = False Then
                        MsgBox("Nome non trovato",MsgBoxStyle.Critical)
                    Else
                        MsgBox("occorenza eliminata ", MsgBoxStyle.Information)
                    End If


                Case 3
                    verificatore = False
                    posizione = 0
                    servitore = InputBox("dammi il nome")
                    For i = 0 To UBound(vet_contatti) - 1
                        If servitore = vet_contatti(i) Then
                            posizione = i
                            verificatore = True
                        End If
                    Next

                    If verificatore = True Then
                        For x = 0 To UBound(vet_num)
                            If x = posizione Then
                                MsgBox("il numero di telefono di " & servitore & " è " & vet_num(x), MsgBoxStyle.Information)
                                Exit For
                            End If
                        Next
                    Else
                        MsgBox("ERRORE!!! utente non trovato", MsgBoxStyle.Critical)
                    End If


                Case Else
                    MsgBox("ERRORE!!! Comando inserito non valido.", MsgBoxStyle.Critical, "ERRORE")
            End Select


        Loop

    End Sub

End Module
