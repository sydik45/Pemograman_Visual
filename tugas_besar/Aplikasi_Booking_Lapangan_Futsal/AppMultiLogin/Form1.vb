Public Class Form1
    Private Sub Admin1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Admin1ToolStripMenuItem.Click
        Jasa_Futsal.ShowDialog()
    End Sub

    Private Sub Admin2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Admin2ToolStripMenuItem.Click
        Jenis_lapangan.ShowDialog()
    End Sub

    Private Sub Pemilik1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pemilik1ToolStripMenuItem.Click
        Pemilik.ShowDialog()
    End Sub

    Private Sub Pemilik2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pemilik2ToolStripMenuItem.Click
        Pemilik2.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MatikanSemuaMenu()

    End Sub

    Private Sub MatikanSemuaMenu()
        MenuAdminBar.Visible = False
        MenuPemilikBar.Visible = False
        LoginBar.Visible = True
        LogoutBar.Visible = False
    End Sub

    Private Sub LoginBar_Click(sender As Object, e As EventArgs) Handles LoginBar.Click
        Login.ShowDialog()

    End Sub

    Private Sub LogoutBar_Click(sender As Object, e As EventArgs) Handles LogoutBar.Click
        MatikanSemuaMenu()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Jika user login adalah Admin
        If (admin_role = True) Then
            MenuAdminBar.Visible = True
            MenuPemilikBar.Visible = False
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If

        'Jika user login adalah Pemilik
        If (pemilik_role = True) Then
            MenuAdminBar.Visible = False
            MenuPemilikBar.Visible = True
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If

    End Sub

    Private Sub ExitBar_Click(sender As Object, e As EventArgs) Handles ExitBar.Click
        End
    End Sub

End Class
