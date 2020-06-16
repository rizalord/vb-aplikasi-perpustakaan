Public Class AdminMasterForm

    Private Sub DaftarBukuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DaftarBukuToolStripMenuItem1.Click
        SwitchPanel(FormDaftarBuku)
    End Sub

    Private Sub CariBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CariBukuToolStripMenuItem.Click
        SwitchPanel(CariBukuForm)
    End Sub

    Sub SwitchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub AdminMasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(FormDaftarBuku)
    End Sub
End Class