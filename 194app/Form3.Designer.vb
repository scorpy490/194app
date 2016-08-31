<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DatetimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaktsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New WindowsApplication3.DataSet1()
        Me.TaktsTableAdapter = New WindowsApplication3.DataSet1TableAdapters.TaktsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaktsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DatetimeDataGridViewTextBoxColumn, Me.TDataGridViewTextBoxColumn, Me.OperatDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TaktsBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(766, 457)
        Me.DataGridView1.TabIndex = 0
        '
        'DatetimeDataGridViewTextBoxColumn
        '
        Me.DatetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime"
        DataGridViewCellStyle3.Format = "g"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DatetimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DatetimeDataGridViewTextBoxColumn.HeaderText = "Дата и время"
        Me.DatetimeDataGridViewTextBoxColumn.Name = "DatetimeDataGridViewTextBoxColumn"
        Me.DatetimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatetimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DatetimeDataGridViewTextBoxColumn.Width = 180
        '
        'TDataGridViewTextBoxColumn
        '
        Me.TDataGridViewTextBoxColumn.DataPropertyName = "t"
        Me.TDataGridViewTextBoxColumn.HeaderText = "Такты"
        Me.TDataGridViewTextBoxColumn.Name = "TDataGridViewTextBoxColumn"
        Me.TDataGridViewTextBoxColumn.ReadOnly = True
        Me.TDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'OperatDataGridViewTextBoxColumn
        '
        Me.OperatDataGridViewTextBoxColumn.DataPropertyName = "operat"
        Me.OperatDataGridViewTextBoxColumn.HeaderText = "Операции"
        Me.OperatDataGridViewTextBoxColumn.Name = "OperatDataGridViewTextBoxColumn"
        Me.OperatDataGridViewTextBoxColumn.ReadOnly = True
        Me.OperatDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TaktsBindingSource1
        '
        Me.TaktsBindingSource1.DataMember = "Takts"
        Me.TaktsBindingSource1.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaktsTableAdapter
        '
        Me.TaktsTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 457)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Просмотр операций"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaktsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TaktsTableAdapter As DataSet1TableAdapters.TaktsTableAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents TaktsBindingSource1 As BindingSource
    Friend WithEvents DatetimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OperatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
