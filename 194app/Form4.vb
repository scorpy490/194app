Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.F6TableAdapter.Fill(Me.Prostoy.f6, d1, d2)
    End Sub
End Class