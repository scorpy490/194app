<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._194DataSet = New WindowsApplication3._194DataSet()
        Me.OperBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperTableAdapter = New WindowsApplication3._194DataSetTableAdapters.operTableAdapter()
        Me.OreratDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatetimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaktDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._194DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OreratDataGridViewTextBoxColumn, Me.DatetimeDataGridViewTextBoxColumn, Me.TaktDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OperBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(766, 457)
        Me.DataGridView1.TabIndex = 0
        '
        '_194DataSet
        '
        Me._194DataSet.DataSetName = "_194DataSet"
        Me._194DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OperBindingSource
        '
        Me.OperBindingSource.DataMember = "oper"
        Me.OperBindingSource.DataSource = Me._194DataSet
        '
        'OperTableAdapter
        '
        Me.OperTableAdapter.ClearBeforeFill = True
        '
        'OreratDataGridViewTextBoxColumn
        '
        Me.OreratDataGridViewTextBoxColumn.DataPropertyName = "orerat"
        Me.OreratDataGridViewTextBoxColumn.HeaderText = "orerat"
        Me.OreratDataGridViewTextBoxColumn.Name = "OreratDataGridViewTextBoxColumn"
        Me.OreratDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatetimeDataGridViewTextBoxColumn
        '
        Me.DatetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime"
        Me.DatetimeDataGridViewTextBoxColumn.HeaderText = "datetime"
        Me.DatetimeDataGridViewTextBoxColumn.Name = "DatetimeDataGridViewTextBoxColumn"
        Me.DatetimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TaktDataGridViewTextBoxColumn
        '
        Me.TaktDataGridViewTextBoxColumn.DataPropertyName = "takt"
        Me.TaktDataGridViewTextBoxColumn.HeaderText = "takt"
        Me.TaktDataGridViewTextBoxColumn.Name = "TaktDataGridViewTextBoxColumn"
        Me.TaktDataGridViewTextBoxColumn.ReadOnly = True
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
        CType(Me._194DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OreratDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatetimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaktDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OperBindingSource As BindingSource
    Friend WithEvents _194DataSet As _194DataSet
    Friend WithEvents OperTableAdapter As _194DataSetTableAdapters.operTableAdapter
End Class
