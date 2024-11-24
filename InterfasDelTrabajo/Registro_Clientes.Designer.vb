<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Clientes
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
        Me.cmdenviar = New System.Windows.Forms.Button()
        Me.cmdlimpiar = New System.Windows.Forms.Button()
        Me.cmdsalir = New System.Windows.Forms.Button()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtidcliente = New System.Windows.Forms.TextBox()
        Me.lblIdcliente = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.lblntelefono = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdenviar
        '
        Me.cmdenviar.Location = New System.Drawing.Point(48, 318)
        Me.cmdenviar.Name = "cmdenviar"
        Me.cmdenviar.Size = New System.Drawing.Size(75, 23)
        Me.cmdenviar.TabIndex = 11
        Me.cmdenviar.Text = "Enviar"
        Me.cmdenviar.UseVisualStyleBackColor = True
        '
        'cmdlimpiar
        '
        Me.cmdlimpiar.Location = New System.Drawing.Point(235, 318)
        Me.cmdlimpiar.Name = "cmdlimpiar"
        Me.cmdlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdlimpiar.TabIndex = 12
        Me.cmdlimpiar.Text = "Limpiar"
        Me.cmdlimpiar.UseVisualStyleBackColor = True
        '
        'cmdsalir
        '
        Me.cmdsalir.Location = New System.Drawing.Point(429, 318)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdsalir.TabIndex = 13
        Me.cmdsalir.Text = "Salir"
        Me.cmdsalir.UseVisualStyleBackColor = True
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(265, 37)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(190, 20)
        Me.Txtnombre.TabIndex = 2
        '
        'Txtidcliente
        '
        Me.Txtidcliente.Location = New System.Drawing.Point(265, 77)
        Me.Txtidcliente.Name = "Txtidcliente"
        Me.Txtidcliente.Size = New System.Drawing.Size(190, 20)
        Me.Txtidcliente.TabIndex = 4
        '
        'lblIdcliente
        '
        Me.lblIdcliente.AutoSize = True
        Me.lblIdcliente.Location = New System.Drawing.Point(153, 84)
        Me.lblIdcliente.Name = "lblIdcliente"
        Me.lblIdcliente.Size = New System.Drawing.Size(51, 13)
        Me.lblIdcliente.TabIndex = 3
        Me.lblIdcliente.Text = "Id Cliente"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(160, 44)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 1
        Me.lblnombre.Text = "Nombre"
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Location = New System.Drawing.Point(137, 131)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(93, 13)
        Me.lblcorreo.TabIndex = 5
        Me.lblcorreo.Text = "Correo electronico"
        '
        'Txtcorreo
        '
        Me.Txtcorreo.Location = New System.Drawing.Point(265, 124)
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(181, 20)
        Me.Txtcorreo.TabIndex = 6
        '
        'lblntelefono
        '
        Me.lblntelefono.AutoSize = True
        Me.lblntelefono.Location = New System.Drawing.Point(130, 176)
        Me.lblntelefono.Name = "lblntelefono"
        Me.lblntelefono.Size = New System.Drawing.Size(100, 13)
        Me.lblntelefono.TabIndex = 7
        Me.lblntelefono.Text = "Numero de telefono"
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(152, 215)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(52, 13)
        Me.lbldireccion.TabIndex = 9
        Me.lbldireccion.Text = "Dirección"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(265, 169)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(181, 20)
        Me.txtnumero.TabIndex = 8
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(265, 208)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(181, 20)
        Me.txtdireccion.TabIndex = 10
        '
        'Registro_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 353)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lblntelefono)
        Me.Controls.Add(Me.Txtcorreo)
        Me.Controls.Add(Me.lblcorreo)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblIdcliente)
        Me.Controls.Add(Me.Txtidcliente)
        Me.Controls.Add(Me.Txtnombre)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.cmdlimpiar)
        Me.Controls.Add(Me.cmdenviar)
        Me.Name = "Registro_Clientes"
        Me.Text = "Registro_Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdenviar As Button
    Friend WithEvents cmdlimpiar As Button
    Friend WithEvents cmdsalir As Button
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Txtidcliente As TextBox
    Friend WithEvents lblIdcliente As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblcorreo As Label
    Friend WithEvents Txtcorreo As TextBox
    Friend WithEvents lblntelefono As Label
    Friend WithEvents lbldireccion As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents txtdireccion As TextBox
End Class
