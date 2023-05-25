Public Class Form4
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtWarung.Text
            Case "TP" : txtKeterangan.Text = "Teh Pucuk"

            Case "CC" : txtKeterangan.Text = "Coca - Cola"

            Case "TG" : txtKeterangan.Text = "Teh Gelas"

            Case "PS" : txtKeterangan.Text = "Pocary Sweet"

            Case Else : txtKeterangan.Text = "Kode Minuman Warung Tidak Ditemukan"
        End Select
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class