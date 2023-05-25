Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtLembur.Text) >= 20) Then
            txtKeterangan.Text = "Bonus Uang Lembur RP.400.000"

        ElseIf (txtLembur.Text >= 15) Then
            txtKeterangan.Text = "Bonus Uang Lembur RP.300.000"

        ElseIf (txtLembur.Text >= 10) Then
            txtKeterangan.Text = "Bonus Uang Lembur RP.200.000"

        ElseIf (txtLembur.Text >= 5) Then
            txtKeterangan.Text = "Bonus Uang Lembur RP.100.000"

        Else
            txtKeterangan.Text = "Maaf anda belum layak dapat bonus"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class