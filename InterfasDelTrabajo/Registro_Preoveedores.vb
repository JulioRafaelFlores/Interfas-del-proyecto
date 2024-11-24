Public Class Registro_Preoveedores
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtproveedor.TextChanged

    End Sub

    Private Sub lblproveedor_Click(sender As Object, e As EventArgs) Handles lblproveedor.Click

    End Sub

    Private Sub lblsalir1_Click(sender As Object, e As EventArgs) Handles lblsalir1.Click

        Me.Close()

    End Sub

    Private Sub lbllimpiar2_Click(sender As Object, e As EventArgs) Handles lbllimpiar2.Click
        txtproveedor.Clear()
        txtidproveedor.Clear()
        txttelefono.Clear()
        txtcoreo.Clear()
        txtcompañia.Clear()
        txtproducto1.Clear()
        txtproducto2.Clear()
        txtproducto3.Clear()
        Txtproducto4.Clear()
        Txtfecharegistro.Clear()

    End Sub
End Class