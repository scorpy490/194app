<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Date1 = New System.Windows.Forms.DateTimePicker()
        Me.Date2 = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OperatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.operat = New WindowsApplication3._194DataSet1()
        Me.OperatTableAdapter = New WindowsApplication3._194DataSet1TableAdapters.operatTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.OperatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.operat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(889, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 127)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Отчет"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Date1
        '
        Me.Date1.CustomFormat = "dd   MMMM   yyyy     HH:mm:ss"
        Me.Date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date1.Location = New System.Drawing.Point(30, 36)
        Me.Date1.Name = "Date1"
        Me.Date1.Size = New System.Drawing.Size(233, 21)
        Me.Date1.TabIndex = 3
        Me.Date1.Value = New Date(2016, 6, 12, 0, 0, 0, 0)
        '
        'Date2
        '
        Me.Date2.CustomFormat = "dd   MMMM   yyyy     HH:mm:ss"
        Me.Date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date2.Location = New System.Drawing.Point(313, 33)
        Me.Date2.Name = "Date2"
        Me.Date2.Size = New System.Drawing.Size(236, 21)
        Me.Date2.TabIndex = 4
        Me.Date2.Value = New Date(2016, 5, 24, 0, 0, 0, 0)
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(76, 19)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Дневная"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(68, 19)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "Ночная"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 81)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Смена"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(51, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 27)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.OperatBindingSource
        Me.ComboBox1.DisplayMember = "operat"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(30, 211)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(233, 23)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.ValueMember = "Num"
        '
        'OperatBindingSource
        '
        Me.OperatBindingSource.DataMember = "operat"
        Me.OperatBindingSource.DataSource = Me.operat
        '
        'operat
        '
        Me.operat.DataSetName = "operat"
        Me.operat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OperatTableAdapter
        '
        Me.OperatTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(51, 346)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 27)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Показать"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"Общий отчет", "Сводка по операции", "Простои"})
        Me.ListBox1.Location = New System.Drawing.Point(628, 69)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(203, 229)
        Me.ListBox1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(624, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Сводки:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1410, 730)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Date2)
        Me.Controls.Add(Me.Date1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "194app"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.OperatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.operat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Date1 As DateTimePicker
    Friend WithEvents Date2 As DateTimePicker
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents operat As _194DataSet1
    Friend WithEvents OperatBindingSource As BindingSource
    Friend WithEvents OperatTableAdapter As _194DataSet1TableAdapters.operatTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
End Class
