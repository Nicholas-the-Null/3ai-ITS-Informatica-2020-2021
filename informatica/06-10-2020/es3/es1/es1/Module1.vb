Module Module1

    Sub Main()
        Dim giorno1, mese1, anno1, giorno2, mese2, anno2 As Integer
        giorno1 = InputBox("inserisci il giorno della prima data da analizzare", "Calcolatore date")
        mese1 = InputBox("inserisci il mese della prima data da analizzare", "Calcolatore date")
        anno1 = InputBox("inserisci l'anno della prima data da analizzare", "Calcolatore date")

        giorno2 = InputBox("inserisci il giorno della seconda data da analizzare", "Calcolatore date")
        mese2 = InputBox("inserisci il mese della seconda data da analizzare", "Calcolatore date")
        anno2 = InputBox("inserisci il giorno della seconda data da analizzare", "Calcolatore date")

        If (anno1 > anno2) Then
            MsgBox("La data più recente è " & giorno1 & "/" & mese1 & "/" & anno1,MsgBoxStyle.Information)
        ElseIf (anno1 < anno2) Then
            MsgBox("La data più recente è " & giorno2 & "/" & mese2 & "/" & anno2, MsgBoxStyle.Information)

        Else
            If (mese1 > mese2) Then
                MsgBox("La data più recente è " & giorno1 & "/" & mese1 & "/" & anno1, MsgBoxStyle.Information)
            ElseIf (mese1 < mese2) Then
                MsgBox("La data più recente è " & giorno2 & "/" & mese2 & "/" & anno2, MsgBoxStyle.Information)

            Else
                If (giorno1 > giorno2) Then
                    MsgBox("La data più recente è " & giorno1 & "/" & mese1 & "/" & anno1, MsgBoxStyle.Information)
                ElseIf (giorno1 < giorno2) Then
                    MsgBox("La data più recente è " & giorno2 & "/" & mese2 & "/" & anno2, MsgBoxStyle.Information)
                Else
                    MsgBox("Le due date sono uguali", MsgBoxStyle.Information)
                End If
            End If
        End If

    End Sub

End Module
