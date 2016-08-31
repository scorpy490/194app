<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.F1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._194DataSet = New WindowsApplication3._194DataSet()
        Me.F2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.F3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.F4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.F5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.F6BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.F1TableAdapter = New WindowsApplication3._194DataSetTableAdapters.f1TableAdapter()
        Me.F2TableAdapter = New WindowsApplication3._194DataSetTableAdapters.f2TableAdapter()
        Me.F3TableAdapter = New WindowsApplication3._194DataSetTableAdapters.f3TableAdapter()
        Me.F4TableAdapter = New WindowsApplication3._194DataSetTableAdapters.f4TableAdapter()
        Me.F5TableAdapter = New WindowsApplication3._194DataSetTableAdapters.f5TableAdapter()
        Me.F6TableAdapter = New WindowsApplication3._194DataSetTableAdapters.f6TableAdapter()
        CType(Me.F1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._194DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F6BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.DocumentMapWidth = 50
        Me.ReportViewer1.IsDocumentMapWidthFixed = True
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.F1BindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.F2BindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.F3BindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.F4BindingSource
        ReportDataSource5.Name = "DataSet5"
        ReportDataSource5.Value = Me.F5BindingSource
        ReportDataSource6.Name = "DataSet6"
        ReportDataSource6.Value = Me.F6BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication3.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.Size = New System.Drawing.Size(1452, 658)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomPercent = 150
        '
        'F1BindingSource
        '
        Me.F1BindingSource.DataMember = "f1"
        Me.F1BindingSource.DataSource = Me._194DataSet
        '
        '_194DataSet
        '
        Me._194DataSet.DataSetName = "_194DataSet"
        Me._194DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'F2BindingSource
        '
        Me.F2BindingSource.DataMember = "f2"
        Me.F2BindingSource.DataSource = Me._194DataSet
        '
        'F3BindingSource
        '
        Me.F3BindingSource.DataMember = "f3"
        Me.F3BindingSource.DataSource = Me._194DataSet
        '
        'F4BindingSource
        '
        Me.F4BindingSource.DataMember = "f4"
        Me.F4BindingSource.DataSource = Me._194DataSet
        '
        'F5BindingSource
        '
        Me.F5BindingSource.DataMember = "f5"
        Me.F5BindingSource.DataSource = Me._194DataSet
        '
        'F6BindingSource
        '
        Me.F6BindingSource.DataMember = "f6"
        Me.F6BindingSource.DataSource = Me._194DataSet
        '
        'F1TableAdapter
        '
        Me.F1TableAdapter.ClearBeforeFill = True
        '
        'F2TableAdapter
        '
        Me.F2TableAdapter.ClearBeforeFill = True
        '
        'F3TableAdapter
        '
        Me.F3TableAdapter.ClearBeforeFill = True
        '
        'F4TableAdapter
        '
        Me.F4TableAdapter.ClearBeforeFill = True
        '
        'F5TableAdapter
        '
        Me.F5TableAdapter.ClearBeforeFill = True
        '
        'F6TableAdapter
        '
        Me.F6TableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1452, 658)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Отчет"
        CType(Me.F1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._194DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F6BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents F1BindingSource As BindingSource
    Friend WithEvents _194DataSet As _194DataSet
    Friend WithEvents F2BindingSource As BindingSource
    Friend WithEvents F1TableAdapter As _194DataSetTableAdapters.f1TableAdapter
    Friend WithEvents F2TableAdapter As _194DataSetTableAdapters.f2TableAdapter
    Friend WithEvents F3BindingSource As BindingSource
    Friend WithEvents F3TableAdapter As _194DataSetTableAdapters.f3TableAdapter
    Friend WithEvents F4TableAdapter As _194DataSetTableAdapters.f4TableAdapter
    Friend WithEvents F4BindingSource As BindingSource
    Friend WithEvents F5BindingSource As BindingSource
    Friend WithEvents F5TableAdapter As _194DataSetTableAdapters.f5TableAdapter
    Friend WithEvents F6BindingSource As BindingSource
    Friend WithEvents F6TableAdapter As _194DataSetTableAdapters.f6TableAdapter
End Class
