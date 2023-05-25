Public Class Form3
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKartu.Text
            Case "BEWD" : txtKeterangan.Text = "Blue Eyes White Dragon"

            Case "DMG" : txtKeterangan.Text = "Dark Magician Girl"

            Case "RED" : txtKeterangan.Text = "Red Eyes Dragon"

            Case Else : txtKeterangan.Text = "Kode Kartu Tidak Ditemukan"
        End Select
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class