<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jenis_lapangan
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtjnl = New System.Windows.Forms.TextBox()
        Me.txtkdl = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(346, 186)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 93
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(70, 186)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 92
        Me.btnAdd.Text = "Simpan"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(81, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 91
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Jenis Lapangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Kode Lapangan"
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(196, 140)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(197, 20)
        Me.txtharga.TabIndex = 87
        '
        'txtjnl
        '
        Me.txtjnl.Location = New System.Drawing.Point(196, 96)
        Me.txtjnl.Name = "txtjnl"
        Me.txtjnl.Size = New System.Drawing.Size(197, 20)
        Me.txtjnl.TabIndex = 86
        '
        'txtkdl
        '
        Me.txtkdl.Location = New System.Drawing.Point(196, 54)
        Me.txtkdl.Name = "txtkdl"
        Me.txtkdl.Size = New System.Drawing.Size(197, 20)
        Me.txtkdl.TabIndex = 85
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(213, 186)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 84
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(43, 217)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(420, 209)
        Me.dgvData.TabIndex = 83
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(147, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(212, 20)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "JENIS LAPANGAN FUTSAL"
        '
        'Jenis_lapangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(477, 424)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtjnl)
        Me.Controls.Add(Me.txtkdl)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Jenis_lapangan"
        Me.Text = "Jenis_Lapangan"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtjnl As TextBox
    Friend WithEvents txtkdl As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label8 As Label
End Class
