﻿Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtmasakerja.Text) >= 20) Then
            txtketerangan.Text = "Anda mendapat bonus berupa motor"

        ElseIf (txtmasakerja.Text >= 15) Then
            txtketerangan.Text = "Anda mendapat bonus sepeda gunung"

        ElseIf (txtmasakerja.Text >= 10) Then
            txtketerangan.Text = "Anda mendapat binus cincin emas 5gr"

        ElseIf (txtmasakerja.Text >= 5) Then
            txtketerangan.Text = "Anda mendapat voucher belanja Rp.500rb"

        Else
            txtketerangan.Text = "Maaf anda belum layak dapat bonus"
        End If
    End Sub
End Class