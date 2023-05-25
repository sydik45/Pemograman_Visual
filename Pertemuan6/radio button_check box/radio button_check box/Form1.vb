Public Class Form1
    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim TiketMasuk As Decimal
        Dim Member As Decimal
        Dim Total As Decimal

        If rbanak.Checked = True Then
            TiketMasuk = 25000
        ElseIf rbdewasa.Checked = True Then
            TiketMasuk = 35000
        End If

        If cbnonmember.Checked = True Then
            Member = 0
        End If

        If cbmember.Checked = True Then
            Member = (TiketMasuk * 10 / 100)
        End If

        Total = TiketMasuk - Member

        txttotal.Text = Total
    End Sub

End Class
