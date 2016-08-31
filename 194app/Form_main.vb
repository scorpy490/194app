Public Class Form_main
    Private Sub Form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NewMDIChild As New Form1()
        'Set the parent form of the child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ВыборПериодаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыборПериодаToolStripMenuItem.Click
        Dim NewMDIChild As New Form1()
        'Set the parent form of the child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        AboutBox194.ShowDialog()
    End Sub
End Class