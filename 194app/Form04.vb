Public Class Form04
    Private Sub Form04_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.F5TableAdapter.Fill(Me._194DataSet.f5, d1, d2)
        'Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("d1", d1))
        'Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("d2", d2))
        ' Me.ReportViewer1.RefreshReport()

    End Sub


End Class