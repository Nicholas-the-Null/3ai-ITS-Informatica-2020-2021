Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        media = 0
        For x = 0 To UBound(citta) - 1
            media += abitanti(x)
        Next
        media /= conta_citta
        Lblmedia.Text = media.ToString
    End Sub
End Class