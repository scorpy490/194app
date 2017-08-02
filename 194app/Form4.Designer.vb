<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.F6BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Prostoy = New WindowsApplication3._194DataSet()
        Me.F6TableAdapter = New WindowsApplication3._194DataSetTableAdapters.f6TableAdapter()
        Me.DatetimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrichDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F6BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prostoy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DatetimeDataGridViewTextBoxColumn, Me.OperatDataGridViewTextBoxColumn, Me.TtDataGridViewTextBoxColumn, Me.PrichDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.F6BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(976, 488)
        Me.DataGridView1.TabIndex = 0
        '
        'F6BindingSource
        '
        Me.F6BindingSource.DataMember = "f6"
        Me.F6BindingSource.DataSource = Me.Prostoy
        '
        'Prostoy
        '
        Me.Prostoy.DataSetName = "Prostoy"
        Me.Prostoy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'F6TableAdapter
        '
        Me.F6TableAdapter.ClearBeforeFill = True
        '
        'DatetimeDataGridViewTextBoxColumn
        '
        Me.DatetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime"
        DataGridViewCellStyle1.Format = "G"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DatetimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DatetimeDataGridViewTextBoxColumn.HeaderText = "Дата и время"
        Me.DatetimeDataGridViewTextBoxColumn.Name = "DatetimeDataGridViewTextBoxColumn"
        Me.DatetimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatetimeDataGridViewTextBoxColumn.Width = 150
        '
        'OperatDataGridViewTextBoxColumn
        '
        Me.OperatDataGridViewTextBoxColumn.DataPropertyName = "operat"
        Me.OperatDataGridViewTextBoxColumn.HeaderText = "Операции"
        Me.OperatDataGridViewTextBoxColumn.Name = "OperatDataGridViewTextBoxColumn"
        Me.OperatDataGridViewTextBoxColumn.ReadOnly = True
        Me.OperatDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TtDataGridViewTextBoxColumn
        '
        Me.TtDataGridViewTextBoxColumn.DataPropertyName = "tt"
        Me.TtDataGridViewTextBoxColumn.HeaderText = "Простой"
        Me.TtDataGridViewTextBoxColumn.Name = "TtDataGridViewTextBoxColumn"
        Me.TtDataGridViewTextBoxColumn.ReadOnly = True
        Me.TtDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PrichDataGridViewTextBoxColumn
        '
        Me.PrichDataGridViewTextBoxColumn.DataPropertyName = "prich"
        Me.PrichDataGridViewTextBoxColumn.HeaderText = "Причина"
        Me.PrichDataGridViewTextBoxColumn.Name = "PrichDataGridViewTextBoxColumn"
        Me.PrichDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrichDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 488)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F6BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prostoy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Prostoy As _194DataSet
    Friend WithEvents F6TableAdapter As _194DataSetTableAdapters.f6TableAdapter
    Friend WithEvents F6BindingSource As BindingSource
    Friend WithEvents DatetimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OperatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrichDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
