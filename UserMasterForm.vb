Public Class UserMasterForm

    Private Sub UserMasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(FormPinjamBuku)
    End Sub

    Private Sub SwitchPanel(ByVal panelArgs As Form)
        Panel1.Controls.Clear()
        panelArgs.TopLevel = False
        Panel1.Controls.Add(panelArgs)
        panelArgs.Show()
    End Sub

    Private Sub PinjamBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinjamBukuToolStripMenuItem.Click
        SwitchPanel(FormPinjamBuku)
    End Sub

    Private Sub KembalikanBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KembalikanBukuToolStripMenuItem.Click
        SwitchPanel(FormKembalikanBuku)
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        SwitchPanel(FormProfileUser)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub
End Class