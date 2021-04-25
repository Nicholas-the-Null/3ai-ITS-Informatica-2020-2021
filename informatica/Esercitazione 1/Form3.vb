Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim citta_piu_abitanti = ""
        Dim conta As Integer
        For x = 0 To UBound(citta) - 1
            If x = 0 Then
                citta_piu_abitanti = citta(x)
                conta = x
            ElseIf abitanti(x) > abitanti(conta) Then
                citta_piu_abitanti = citta(x)
                conta = x
            End If
        Next
        Lblcittapiuabitanti.Text = citta_piu_abitanti
    End Sub
End Class