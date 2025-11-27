Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "_194DataSet1.operat". При необходимости она может быть перемещена или удалена.
        Me.OperatTableAdapter.Fill(Me.operat.operat)
        Dim days = Microsoft.VisualBasic.DateAndTime.Day(Now)
        Me.Date1.Value = DateSerial(Year(Now), Month(Now), (Now).Day).AddHours(7).AddMinutes(30)
        Me.Date2.Value = DateSerial(Year(Now), Month(Now), (Now).Day).AddHours(19).AddMinutes(30)
        Me.ListBox1.SelectedIndex = 0
        Me.Update()
        'Date2.Refresh()

    End Sub



    Public Sub Button1_Click(sender As Object, e As EventArgs)
        d1 = CStr(Me.Date1.Value)
        d2 = CStr(Me.Date2.Value)
        Call for_stat("194app " & d1.ToString)
        Dim NewMDIChild As New Form2()
        'Set the parent form of the child window.
        NewMDIChild.MdiParent = Form_main
        'Display the new form.
        NewMDIChild.Show()

    End Sub


    Private Function t1(ByVal dt)
        'dt = CDate(Format(Me.Date1.Value, "short date") & "  " & Format(Me.Time1.Text, "hh:mm:ss"))
        Dim s, cn, dt1, dt2
        dt1 = DateAdd(DateInterval.Minute, -15, dt)
        dt2 = DateAdd(DateInterval.Minute, 15, dt)

        s = "select MAX([takts].[datetime]) from [takts] where oper=33 AND t=0 AND [datetime] Between '" & dt1 & "' AND '" & dt2 & "'"
        cn = CreateObject("ADODB.Connection")
        cn.ConnectionString = "Provider=SQLOLEDB;Server=srv-otk;Database=194;Trusted_Connection=yes;Integrated Security=SSPI;Persist Security Info=False"
        cn.open
        t1 = cn.execute(s).fields(0).value
        If t1 Is DBNull.Value Then
            t1 = dt
            msg1 = "Смена не закрыта"
        Else msg1 = "Смена закрыта"
        End If
        cn.close

    End Function


    Private Sub CorrectDate() Handles RadioButton2.Click, RadioButton1.Click, Date1.CloseUp
        Dim daysk = Microsoft.VisualBasic.DateAndTime.Day(Me.Date1.Value)
        Me.Date1.Value = DateSerial(Year(Me.Date1.Value), Month(Me.Date1.Value), daysk)
        Me.Date2.Value = Me.Date1.Value
        If Me.RadioButton1.Checked = True Then
            Date1.Value = Me.Date1.Value.AddHours(7).AddMinutes(30)
            Me.Date2.Value = DateSerial(Year(Me.Date2.Value), Month(Me.Date2.Value), daysk)
            Date2.Value = Date2.Value.AddHours(19).AddMinutes(30)
        Else
            Date1.Value = Date1.Value.AddHours(19).AddMinutes(30)
            Date2.Value = Date2.Value.AddHours(7).AddMinutes(30).AddDays(1)
        End If
        Me.Date1.Value = t1(Me.Date1.Value).AddSeconds(2)
        Me.Date2.Value = t1(Me.Date2.Value).AddSeconds(1)
        ' Me.Date1.Update()
        ' Me.Date2.Update()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Date1.CloseUp, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        'Dim days = Microsoft.VisualBasic.DateAndTime.Day(Me.Date1.Value)
        If Me.RadioButton1.Checked = True Then
            Me.Date1.Value = DateSerial(Year(Me.Date1.Value), Month(Me.Date1.Value), Me.Date1.Value.Day).AddHours(7).AddMinutes(30)
            Me.Date2.Value = DateSerial(Year(Me.Date1.Value), Month(Me.Date1.Value), Me.Date1.Value.Day).AddHours(19).AddMinutes(30)
        Else
            Me.Date1.Value = DateSerial(Year(Me.Date1.Value), Month(Me.Date1.Value), Me.Date1.Value.Day).AddHours(19).AddMinutes(30)
            Me.Date2.Value = DateSerial(Year(Me.Date1.Value), Month(Me.Date1.Value), Me.Date1.Value.Day + 1).AddHours(7).AddMinutes(30)

        End If
        Me.Date1.Value = t1(Me.Date1.Value)
        Me.Date2.Value = t1(Me.Date2.Value)
        Me.Update()
        Me.Refresh()
    End Sub

    Private Sub for_stat(z)
        Dim s, cn
        s = "Insert into statistic ([date], title, name) select getdate(), '" & z & "','" & Environment.UserName & "'"
        cn = CreateObject("ADODB.Connection")
        cn.ConnectionString = "Provider=SQLOLEDB;Server=srv-otk;Database=194;Trusted_Connection=yes;Integrated Security=SSPI;Persist Security Info=False"
        cn.open
        cn.execute(s)
        cn.close
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        d1 = CStr(Me.Date1.Value)
        d2 = CStr(Me.Date2.Value)
        k = Me.ComboBox1.SelectedValue
        Call for_stat("просмотр операции ")
        Dim NewMDIChild As New Form3()
        'Set the parent form of the child window.
        NewMDIChild.MdiParent = Form_main
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub Button1DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick, Button1.Click
        d1 = CStr(Me.Date1.Value)
        d2 = CStr(Me.Date2.Value)
        Call for_stat("194app " & ListBox1.SelectedItem.ToString)
        Select Case ListBox1.SelectedIndex
            Case 0
                Dim NewMDIChild As New Form2()
                'Set the parent form of the child window.
                NewMDIChild.MdiParent = Form_main
                'Display the new form.
                NewMDIChild.Show()
            Case 1
                k = Me.ComboBox1.SelectedValue
                Dim NewMDIChild As New Form3()
                NewMDIChild.MdiParent = Form_main
                NewMDIChild.Show()
            Case 2
                Dim NewMDIChild As New Form4()
                NewMDIChild.MdiParent = Form_main
                NewMDIChild.Show()
            Case 3
                Dim NewMDIChild As New Form5()
                NewMDIChild.MdiParent = Form_main
                NewMDIChild.Show()
            Case 4
                Dim NewMDIChild As New Form2t()
                'Set the parent form of the child window.
                NewMDIChild.MdiParent = Form_main
                'Display the new form.
                NewMDIChild.Show()
        End Select
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        Me.ListBox1.SelectedIndex = 1
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        If Me.ListBox1.SelectedIndex = 1 Then ComboBox1.Visible = True Else ComboBox1.Visible = False
    End Sub
End Class
