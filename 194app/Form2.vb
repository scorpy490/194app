Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "_194DataSet.f2". При необходимости она может быть перемещена или удалена.

        Me.f1TableAdapter.Fill(Me._194DataSet.f1, d1, d2)
        Me.F2TableAdapter.Fill(Me._194DataSet.f2, d1, d2)
        Me.F3TableAdapter.Fill(Me._194DataSet.f3, d1, d2)
        Me.F4TableAdapter.Fill(Me._194DataSet.f4, d1, d2)
        Me.F5TableAdapter.Fill(Me._194DataSet.f5, d1, d2)
        Me.F6TableAdapter.Fill(Me._194DataSet.f6, d1, d2)
        'Me.f1TableAdapter.FillBy(Me._194DataSet.f1, CType(Form1.D1ToolStripTextBox.Text, Date), CType(Form1.D2ToolStripTextBox.Text, Date))
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("d1", d1))
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("d2", d2))
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("msg1", msg1))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub
End Class