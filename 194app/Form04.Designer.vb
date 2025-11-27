<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form04
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
        Me.F5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._194DataSet = New WindowsApplication3._194DataSet()
        Me.DataSet1 = New WindowsApplication3.DataSet1()
        Me._194DataSet1 = New WindowsApplication3._194DataSet1()
        Me.F5TableAdapter = New WindowsApplication3._194DataSetTableAdapters.f5TableAdapter()
        Me._194DataSet2 = New WindowsApplication3._194DataSet()
        CType(Me.F5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._194DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._194DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._194DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'F5BindingSource
        '
        Me.F5BindingSource.DataMember = "f5"
        Me.F5BindingSource.DataSource = Me._194DataSet
        '
        '_194DataSet
        '
        Me._194DataSet.DataSetName = "_194DataSet"
        Me._194DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_194DataSet1
        '
        Me._194DataSet1.DataSetName = "_194DataSet1"
        Me._194DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'F5TableAdapter
        '
        Me.F5TableAdapter.ClearBeforeFill = True
        '
        '_194DataSet2
        '
        Me._194DataSet2.DataSetName = "_194DataSet"
        Me._194DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "Form04"
        Me.Text = "Form04"
        CType(Me.F5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._194DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._194DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._194DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents _194DataSet1 As _194DataSet1
    Friend WithEvents F5TableAdapter As _194DataSetTableAdapters.f5TableAdapter
    Friend WithEvents _194DataSet2 As _194DataSet
    Friend WithEvents F5BindingSource As BindingSource
    Friend WithEvents _194DataSet As _194DataSet
End Class
