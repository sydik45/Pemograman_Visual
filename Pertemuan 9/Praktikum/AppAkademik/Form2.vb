Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        oMatakuliah.getAllData(DataGridView2)
    End Sub

    Private Sub txtKodemk_Keydown(sender As Object, e As KeyEventArgs) Handles txtKodemk.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oMatakuliah.Carimatakuliah(txtKodemk.Text)
            If (matakuliah_baru = False) Then
                TampilMatakuliah()
            Else
                MessageBox.Show("Data Tidak Ditemukan")
                matakuliah_baru = True
            End If
        End If

    End Sub

    Private Sub TampilMatakuliah()
        txtKodemk.Text = oMatakuliah.kodemk
        txtNamamk.Text = oMatakuliah.namamk
        txtsks.Text = oMatakuliah.sks
        txtProdi.Text = oMatakuliah.prodi

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearEntry()
    End Sub

    Private Sub ClearEntry()
        txtKodemk.Clear()
        txtNamamk.Clear()
        txtsks.Clear()
        txtProdi.Clear()
        txtKodemk.Focus()
    End Sub

    Private Sub SimpanDatmatakuliah()
        oMatakuliah.kodemk = txtKodemk.Text
        oMatakuliah.namamk = txtNamamk.Text
        oMatakuliah.sks = txtsks.Text
        oMatakuliah.prodi = txtProdi.Text
        oMatakuliah.Simpan()
        Reload()
        If (oMatakuliah.InsertState = True) Then
            MessageBox.Show("Data berhasil Disimpan.")
        ElseIf (oMatakuliah.UpdateState = True) Then
            MessageBox.Show("Data berhasil Diperbarui.")
        Else
            MessageBox.Show("Data gagal disimpan")
        End If
        ClearEntry()

    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtKodemk.Text <> "" And txtNamamk.Text <> "") Then
            SimpanDatmatakuliah()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("nim dan nama tidak boleh kosong!")
        End If

    End Sub

    Private Sub Hapus()
        If (matakuliah_baru = False And txtKodemk.Text <> "") Then
            oMatakuliah.Hapus(txtKodemk.Text)
            ClearEntry()
            Reload()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim jawab As Integer
        jawab = MessageBox.Show("Apakah Data akan dihapus", "Confirm", MessageBoxButtons.YesNo)
        If (jawab = vbYes) Then
            Hapus()
        Else
            MessageBox.Show("Data batal dihapus")
        End If
    End Sub
End Class