Module Module1

    Sub Main()
        Dim giorno1, mese1, giorno2, mese2, giorno3, mese3 As Integer
        giorno1 = InputBox("Inserire il giorno della prima data", "Calcolatore data")
        mese1 = InputBox("Inserire il mese della prima data", "Calcolatore data")

        giorno2 = InputBox("Inserire il giorno della seconda data", "Calcolatore data")
        mese2 = InputBox("Inserire il giorno della seconda data", "Calcolatore data")

        giorno3 = InputBox("Inserire il giorno della terza data", "Calcolatore data")
        mese3 = InputBox("Inserire il mese della terza data", "Calcolatore data")

        If (mese1 <= mese3 And mese2 >= mese3 Or mese1 >= mese3 And mese2 <= mese3) Then
            MsgBox("La data " + CType(giorno3,String)+"/" + Ctype(mese3,String),MsgBoxStyle.MsgBoxHelp)

        ElseIf (giorno1 <= giorno3 And giorno2 >= giorno3 Or giorno1 >= giorno3 And giorno2 <= giorno3) Then
            MsgBox("La data " + CType(giorno3, String) + "/" + CType(mese3, String), MsgBoxStyle.MsgBoxHelp)

        Else
            MsgBox("le date sono uguali ")

        End If

    End Sub

End Module
