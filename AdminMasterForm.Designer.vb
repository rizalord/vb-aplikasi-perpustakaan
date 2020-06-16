<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminMasterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DaftarBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarBukuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CariBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarBukuToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.PenggunaToolStripMenuItem, Me.ProfileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DaftarBukuToolStripMenuItem
        '
        Me.DaftarBukuToolStripMenuItem.Checked = True
        Me.DaftarBukuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DaftarBukuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarBukuToolStripMenuItem1, Me.CariBukuToolStripMenuItem})
        Me.DaftarBukuToolStripMenuItem.Name = "DaftarBukuToolStripMenuItem"
        Me.DaftarBukuToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DaftarBukuToolStripMenuItem.Text = "Buku"
        '
        'DaftarBukuToolStripMenuItem1
        '
        Me.DaftarBukuToolStripMenuItem1.Name = "DaftarBukuToolStripMenuItem1"
        Me.DaftarBukuToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DaftarBukuToolStripMenuItem1.Text = "Daftar Buku"
        '
        'CariBukuToolStripMenuItem
        '
        Me.CariBukuToolStripMenuItem.Name = "CariBukuToolStripMenuItem"
        Me.CariBukuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CariBukuToolStripMenuItem.Text = "Cari Buku"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.PenggunaToolStripMenuItem.Text = "Administration"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 387)
        Me.Panel1.TabIndex = 2
        '
        'AdminMasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 411)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminMasterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DaftarBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenggunaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarBukuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CariBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
