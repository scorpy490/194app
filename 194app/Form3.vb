Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet11.Takts". При необходимости она может быть перемещена или удалена.
        Me.OperTableAdapter.Fill(Me._194DataSet.oper, d1, d2, k)
        'MsgBox(d1.ToString & "    " & d2.ToString)
    End Sub


End Class