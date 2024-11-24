Public Class Registro_Clientes
    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Registro_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdlimpiar_Click(sender As Object, e As EventArgs) Handles cmdlimpiar.Click
        txtdireccion.Clear()
        txtnumero.Clear()
        Txtcorreo.Clear()
        Txtidcliente.Clear()
        Txtnombre.Clear()


    End Sub

    Private Sub Txtnombre_TextChanged(sender As Object, e As EventArgs) Handles Txtnombre.TextChanged

    End Sub
End Class