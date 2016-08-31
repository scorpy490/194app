<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОкнаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДанныеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыборПериодаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.ОкнаToolStripMenuItem, Me.ДанныеToolStripMenuItem, Me.ОПрограммеToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.ОкнаToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1140, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОткрытьToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "&Файл"
        '
        'ОкнаToolStripMenuItem
        '
        Me.ОкнаToolStripMenuItem.Name = "ОкнаToolStripMenuItem"
        Me.ОкнаToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ОкнаToolStripMenuItem.Text = "&Окна"
        '
        'ОткрытьToolStripMenuItem
        '
        Me.ОткрытьToolStripMenuItem.Name = "ОткрытьToolStripMenuItem"
        Me.ОткрытьToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ОткрытьToolStripMenuItem.Text = "&Закрыть"
        '
        'ДанныеToolStripMenuItem
        '
        Me.ДанныеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ВыборПериодаToolStripMenuItem})
        Me.ДанныеToolStripMenuItem.Name = "ДанныеToolStripMenuItem"
        Me.ДанныеToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ДанныеToolStripMenuItem.Text = "Данные"
        '
        'ВыборПериодаToolStripMenuItem
        '
        Me.ВыборПериодаToolStripMenuItem.Name = "ВыборПериодаToolStripMenuItem"
        Me.ВыборПериодаToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ВыборПериодаToolStripMenuItem.Text = "Выбор периода"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе"
        '
        'Form_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 552)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_main"
        Me.Text = "Form_main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОткрытьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОкнаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДанныеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыборПериодаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As ToolStripMenuItem
End Class
