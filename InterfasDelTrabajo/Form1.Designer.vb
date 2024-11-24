<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ZzzzToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AaaaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AaddaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DdddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DdgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgghToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZzzzToolStripMenuItem, Me.SsToolStripMenuItem, Me.AaddaToolStripMenuItem, Me.DdddToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ZzzzToolStripMenuItem
        '
        Me.ZzzzToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AaaaToolStripMenuItem})
        Me.ZzzzToolStripMenuItem.Name = "ZzzzToolStripMenuItem"
        Me.ZzzzToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.ZzzzToolStripMenuItem.Text = "zzzz"
        '
        'AaaaToolStripMenuItem
        '
        Me.AaaaToolStripMenuItem.Name = "AaaaToolStripMenuItem"
        Me.AaaaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AaaaToolStripMenuItem.Text = "aaaa"
        '
        'SsToolStripMenuItem
        '
        Me.SsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DdgToolStripMenuItem})
        Me.SsToolStripMenuItem.Name = "SsToolStripMenuItem"
        Me.SsToolStripMenuItem.Size = New System.Drawing.Size(29, 20)
        Me.SsToolStripMenuItem.Text = "ss"
        '
        'AaddaToolStripMenuItem
        '
        Me.AaddaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GgghToolStripMenuItem})
        Me.AaddaToolStripMenuItem.Name = "AaddaToolStripMenuItem"
        Me.AaddaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.AaddaToolStripMenuItem.Text = "aadda"
        '
        'DdddToolStripMenuItem
        '
        Me.DdddToolStripMenuItem.Name = "DdddToolStripMenuItem"
        Me.DdddToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.DdddToolStripMenuItem.Text = "dddd"
        '
        'DdgToolStripMenuItem
        '
        Me.DdgToolStripMenuItem.Name = "DdgToolStripMenuItem"
        Me.DdgToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DdgToolStripMenuItem.Text = "ddg"
        '
        'GgghToolStripMenuItem
        '
        Me.GgghToolStripMenuItem.Name = "GgghToolStripMenuItem"
        Me.GgghToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GgghToolStripMenuItem.Text = "gggh"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ZzzzToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AaaaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DdgToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AaddaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgghToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DdddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
