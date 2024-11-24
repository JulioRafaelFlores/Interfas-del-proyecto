<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Preoveedores
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
        Me.lblproveedor = New System.Windows.Forms.Label()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidproveedor = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcoreo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcompañia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Paprosusministrados = New System.Windows.Forms.Panel()
        Me.txtproducto1 = New System.Windows.Forms.TextBox()
        Me.txtproducto2 = New System.Windows.Forms.TextBox()
        Me.txtproducto3 = New System.Windows.Forms.TextBox()
        Me.Txtproducto4 = New System.Windows.Forms.TextBox()
        Me.Txtfecharegistro = New System.Windows.Forms.TextBox()
        Me.lblfecharegistro = New System.Windows.Forms.Label()
        Me.lblenviar1 = New System.Windows.Forms.Button()
        Me.lbllimpiar2 = New System.Windows.Forms.Button()
        Me.lblsalir1 = New System.Windows.Forms.Button()
        Me.Paprosusministrados.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblproveedor
        '
        Me.lblproveedor.AutoSize = True
        Me.lblproveedor.Location = New System.Drawing.Point(125, 32)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.Size = New System.Drawing.Size(112, 13)
        Me.lblproveedor.TabIndex = 0
        Me.lblproveedor.Text = "Nombre del proveedor"
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(253, 29)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(180, 20)
        Me.txtproveedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id del proveedor"
        '
        'txtidproveedor
        '
        Me.txtidproveedor.Location = New System.Drawing.Point(253, 70)
        Me.txtidproveedor.Name = "txtidproveedor"
        Me.txtidproveedor.Size = New System.Drawing.Size(180, 20)
        Me.txtidproveedor.TabIndex = 3
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(253, 113)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(180, 20)
        Me.txttelefono.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Correo electronico"
        '
        'txtcoreo
        '
        Me.txtcoreo.Location = New System.Drawing.Point(253, 151)
        Me.txtcoreo.Name = "txtcoreo"
        Me.txtcoreo.Size = New System.Drawing.Size(180, 20)
        Me.txtcoreo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Compañia del proveedor"
        '
        'txtcompañia
        '
        Me.txtcompañia.Location = New System.Drawing.Point(253, 188)
        Me.txtcompañia.Name = "txtcompañia"
        Me.txtcompañia.Size = New System.Drawing.Size(180, 20)
        Me.txtcompañia.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "  Produtos Suministrados"
        '
        'Paprosusministrados
        '
        Me.Paprosusministrados.Controls.Add(Me.lblfecharegistro)
        Me.Paprosusministrados.Controls.Add(Me.Txtfecharegistro)
        Me.Paprosusministrados.Controls.Add(Me.Txtproducto4)
        Me.Paprosusministrados.Controls.Add(Me.txtproducto3)
        Me.Paprosusministrados.Controls.Add(Me.txtproducto2)
        Me.Paprosusministrados.Controls.Add(Me.txtproducto1)
        Me.Paprosusministrados.Controls.Add(Me.Label5)
        Me.Paprosusministrados.Location = New System.Drawing.Point(1, 214)
        Me.Paprosusministrados.Name = "Paprosusministrados"
        Me.Paprosusministrados.Size = New System.Drawing.Size(348, 150)
        Me.Paprosusministrados.TabIndex = 11
        '
        'txtproducto1
        '
        Me.txtproducto1.Location = New System.Drawing.Point(197, 15)
        Me.txtproducto1.Name = "txtproducto1"
        Me.txtproducto1.Size = New System.Drawing.Size(132, 20)
        Me.txtproducto1.TabIndex = 11
        '
        'txtproducto2
        '
        Me.txtproducto2.Location = New System.Drawing.Point(197, 41)
        Me.txtproducto2.Name = "txtproducto2"
        Me.txtproducto2.Size = New System.Drawing.Size(132, 20)
        Me.txtproducto2.TabIndex = 12
        '
        'txtproducto3
        '
        Me.txtproducto3.Location = New System.Drawing.Point(197, 67)
        Me.txtproducto3.Name = "txtproducto3"
        Me.txtproducto3.Size = New System.Drawing.Size(132, 20)
        Me.txtproducto3.TabIndex = 13
        '
        'Txtproducto4
        '
        Me.Txtproducto4.Location = New System.Drawing.Point(197, 93)
        Me.Txtproducto4.Name = "Txtproducto4"
        Me.Txtproducto4.Size = New System.Drawing.Size(132, 20)
        Me.Txtproducto4.TabIndex = 14
        '
        'Txtfecharegistro
        '
        Me.Txtfecharegistro.Location = New System.Drawing.Point(197, 127)
        Me.Txtfecharegistro.Name = "Txtfecharegistro"
        Me.Txtfecharegistro.Size = New System.Drawing.Size(132, 20)
        Me.Txtfecharegistro.TabIndex = 12
        '
        'lblfecharegistro
        '
        Me.lblfecharegistro.AutoSize = True
        Me.lblfecharegistro.Location = New System.Drawing.Point(64, 134)
        Me.lblfecharegistro.Name = "lblfecharegistro"
        Me.lblfecharegistro.Size = New System.Drawing.Size(89, 13)
        Me.lblfecharegistro.TabIndex = 15
        Me.lblfecharegistro.Text = "Fecha de registro"
        '
        'lblenviar1
        '
        Me.lblenviar1.Location = New System.Drawing.Point(409, 229)
        Me.lblenviar1.Name = "lblenviar1"
        Me.lblenviar1.Size = New System.Drawing.Size(75, 23)
        Me.lblenviar1.TabIndex = 12
        Me.lblenviar1.Text = "Enviar"
        Me.lblenviar1.UseVisualStyleBackColor = True
        '
        'lbllimpiar2
        '
        Me.lbllimpiar2.Location = New System.Drawing.Point(409, 278)
        Me.lbllimpiar2.Name = "lbllimpiar2"
        Me.lbllimpiar2.Size = New System.Drawing.Size(75, 23)
        Me.lbllimpiar2.TabIndex = 13
        Me.lbllimpiar2.Text = "Limpiar"
        Me.lbllimpiar2.UseVisualStyleBackColor = True
        '
        'lblsalir1
        '
        Me.lblsalir1.Location = New System.Drawing.Point(409, 323)
        Me.lblsalir1.Name = "lblsalir1"
        Me.lblsalir1.Size = New System.Drawing.Size(75, 23)
        Me.lblsalir1.TabIndex = 14
        Me.lblsalir1.Text = "Salir"
        Me.lblsalir1.UseVisualStyleBackColor = True
        '
        'Registro_Preoveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblsalir1)
        Me.Controls.Add(Me.lbllimpiar2)
        Me.Controls.Add(Me.lblenviar1)
        Me.Controls.Add(Me.Paprosusministrados)
        Me.Controls.Add(Me.txtcompañia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcoreo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtidproveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.lblproveedor)
        Me.Name = "Registro_Preoveedores"
        Me.Text = "Registro_Preoveedores"
        Me.Paprosusministrados.ResumeLayout(False)
        Me.Paprosusministrados.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblproveedor As Label
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidproveedor As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcoreo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcompañia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Paprosusministrados As Panel
    Friend WithEvents Txtproducto4 As TextBox
    Friend WithEvents txtproducto3 As TextBox
    Friend WithEvents txtproducto2 As TextBox
    Friend WithEvents txtproducto1 As TextBox
    Friend WithEvents lblfecharegistro As Label
    Friend WithEvents Txtfecharegistro As TextBox
    Friend WithEvents lblenviar1 As Button
    Friend WithEvents lbllimpiar2 As Button
    Friend WithEvents lblsalir1 As Button
End Class
