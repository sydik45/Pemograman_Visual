<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdminBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Admin1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Admin2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPemilikBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pemilik1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pemilik2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginBar, Me.LogoutBar, Me.ExitBar})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginBar
        '
        Me.LoginBar.Name = "LoginBar"
        Me.LoginBar.Size = New System.Drawing.Size(112, 22)
        Me.LoginBar.Text = "Login"
        '
        'LogoutBar
        '
        Me.LogoutBar.Name = "LogoutBar"
        Me.LogoutBar.Size = New System.Drawing.Size(112, 22)
        Me.LogoutBar.Text = "Logout"
        '
        'ExitBar
        '
        Me.ExitBar.Name = "ExitBar"
        Me.ExitBar.Size = New System.Drawing.Size(112, 22)
        Me.ExitBar.Text = "Exit"
        '
        'MenuAdminBar
        '
        Me.MenuAdminBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Admin1ToolStripMenuItem, Me.Admin2ToolStripMenuItem})
        Me.MenuAdminBar.Name = "MenuAdminBar"
        Me.MenuAdminBar.Size = New System.Drawing.Size(89, 20)
        Me.MenuAdminBar.Text = "Menu Admin"
        '
        'Admin1ToolStripMenuItem
        '
        Me.Admin1ToolStripMenuItem.Name = "Admin1ToolStripMenuItem"
        Me.Admin1ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.Admin1ToolStripMenuItem.Text = "Lapangan Futsal"
        '
        'Admin2ToolStripMenuItem
        '
        Me.Admin2ToolStripMenuItem.Name = "Admin2ToolStripMenuItem"
        Me.Admin2ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.Admin2ToolStripMenuItem.Text = "Jenis Lapangan"
        '
        'MenuPemilikBar
        '
        Me.MenuPemilikBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pemilik1ToolStripMenuItem, Me.Pemilik2ToolStripMenuItem})
        Me.MenuPemilikBar.Name = "MenuPemilikBar"
        Me.MenuPemilikBar.Size = New System.Drawing.Size(92, 20)
        Me.MenuPemilikBar.Text = "Menu Pemilik"
        '
        'Pemilik1ToolStripMenuItem
        '
        Me.Pemilik1ToolStripMenuItem.Name = "Pemilik1ToolStripMenuItem"
        Me.Pemilik1ToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.Pemilik1ToolStripMenuItem.Text = "Data Pelanggan"
        '
        'Pemilik2ToolStripMenuItem
        '
        Me.Pemilik2ToolStripMenuItem.Name = "Pemilik2ToolStripMenuItem"
        Me.Pemilik2ToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.Pemilik2ToolStripMenuItem.Text = "Data Jenis Lapangan"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuAdminBar, Me.MenuPemilikBar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(694, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Muhammad Rizky Sydik"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "200511013"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "TI20C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(184, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(355, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Aplikasi Jasa Booking Lapangan Futsal"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(694, 448)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginBar As ToolStripMenuItem
    Friend WithEvents LogoutBar As ToolStripMenuItem
    Friend WithEvents ExitBar As ToolStripMenuItem
    Friend WithEvents MenuAdminBar As ToolStripMenuItem
    Friend WithEvents Admin1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Admin2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuPemilikBar As ToolStripMenuItem
    Friend WithEvents Pemilik1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pemilik2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
