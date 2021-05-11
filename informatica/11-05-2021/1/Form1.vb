Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVrisultati.Columns.Add("nome", "Nome")
        DGVrisultati.Columns.Add("voto", "Voto")
        DGVrisultati.Columns.Add("scuola", "Scuola")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vettore(conta).nome = InputBox("Inserire il nome dello studente.", "Richiesta")
        vettore(conta).voto = InputBox("Inserire il voto di " & vettore(conta).nome & ".", "Richiesta")
        vettore(conta).scuola = InputBox("Inserire la scuola di appartenenza di " & vettore(conta).nome & ".", "Richiesta")
        DGVrisultati.Rows.Add(vettore(conta).nome, vettore(conta).voto, vettore(conta).scuola)
        conta += 1
        ReDim Preserve vettore(conta)
    End Sub

End Class
