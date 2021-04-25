Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        citta(conta_citta) = InputBox("Inserire una città.", "Richiesta")
        abitanti(conta_citta) = InputBox("Inserire il numero degli abitanti della città " & citta(conta_citta) & ".", "Richiesta")
        Lstcitta.Items.Add(citta(conta_citta))
        Lstabitanti.Items.Add(abitanti(conta_citta))
        conta_citta += 1
        ReDim Preserve citta(conta_citta)
        ReDim Preserve abitanti(conta_citta)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For x = Lstcitta.SelectedIndex To UBound(citta) - 1
            For i = x + 1 To UBound(citta) - 1
                citta(x) = citta(i)
                abitanti(x) = abitanti(i)
            Next
        Next
        Lstabitanti.Items.RemoveAt(Lstcitta.SelectedIndex)
        Lstcitta.Items.RemoveAt(Lstcitta.SelectedIndex)
        conta_citta -= 1
        ReDim Preserve citta(conta_citta)
        ReDim Preserve abitanti(conta_citta)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form4.Show()
    End Sub
End Class
