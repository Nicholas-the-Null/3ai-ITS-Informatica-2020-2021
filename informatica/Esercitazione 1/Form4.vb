Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim citta_in_ordine(conta_citta) As String
        Dim scambio As String
        For x = 0 To UBound(citta_in_ordine) - 1
            citta_in_ordine(x) = citta(x)
        Next
        For x = 0 To UBound(citta_in_ordine) - 1
            For i = x + 1 To UBound(citta_in_ordine) - 1
                If abitanti(x) > abitanti(i) Then
                    scambio = citta_in_ordine(x)
                    citta_in_ordine(x) = citta_in_ordine(i)
                    citta_in_ordine(i) = scambio
                End If
            Next
        Next
        For x = 0 To UBound(citta_in_ordine) - 1
            Lstordinecrescente.Items.Add(citta_in_ordine(x))
        Next
        ReDim citta_in_ordine(conta_citta)
    End Sub
End Class