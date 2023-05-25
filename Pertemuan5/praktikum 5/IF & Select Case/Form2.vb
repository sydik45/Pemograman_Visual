Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtKoin.Text) >= 200) Then
            txtKeterangan.Text = "Anda Mendapatkan Panci"

        ElseIf (txtKoin.Text >= 150) Then
            txtKeterangan.Text = "Anda Mendapatkan Payung"

        ElseIf (txtKoin.Text >= 100) Then
            txtKeterangan.Text = "Anda Mendapatkan Piring"

        ElseIf (txtKoin.Text >= 50) Then
            txtKeterangan.Text = "Anda Mendapatkan Gelas"

        Else
            txtKeterangan.Text = "Maaf Token Anda Kurang"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class