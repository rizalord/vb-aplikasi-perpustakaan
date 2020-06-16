<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CariBukuForm
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
        Me.PanelCariBuku = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PanelCariBuku.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCariBuku
        '
        Me.PanelCariBuku.Controls.Add(Me.Button4)
        Me.PanelCariBuku.Controls.Add(Me.TextBox4)
        Me.PanelCariBuku.Controls.Add(Me.Label4)
        Me.PanelCariBuku.Controls.Add(Me.DataGridView2)
        Me.PanelCariBuku.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCariBuku.Location = New System.Drawing.Point(0, 0)
        Me.PanelCariBuku.Name = "PanelCariBuku"
        Me.PanelCariBuku.Size = New System.Drawing.Size(800, 450)
        Me.PanelCariBuku.TabIndex = 13
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(580, 60)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 24)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Cari"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TextBox4.Location = New System.Drawing.Point(155, 60)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(419, 24)
        Me.TextBox4.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label4.Location = New System.Drawing.Point(362, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cari Buku"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(154, 95)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(512, 277)
        Me.DataGridView2.TabIndex = 0
        '
        'CariBukuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelCariBuku)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CariBukuForm"
        Me.Text = "CariBukuForm"
        Me.PanelCariBuku.ResumeLayout(False)
        Me.PanelCariBuku.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCariBuku As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView2 As DataGridView
End Class
