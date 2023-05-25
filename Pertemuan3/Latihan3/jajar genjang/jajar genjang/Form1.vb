Public Class Form1
    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim a, t, b, luas, keliling As Integer

        a = Val(txtalas.Text)
        t = Val(txttinggi.Text)
        b = Val(txtsisimiring.Text)

        luas = a * t
        keliling = 2 * (a + b)

        txtluas.Text = Str(luas)
        txtkeliling.Text = Str(keliling)

    End Sub

End Class
