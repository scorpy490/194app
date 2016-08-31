Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProstoyTableAdapter.Fill(Me.Prostoy_po_sl.prostoy, d1, d2)
    End Sub
End Class