Public Class Form1
    Private Sub GgghToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgghToolStripMenuItem.Click

    End Sub

    Private Sub AaaaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AaaaToolStripMenuItem.Click
        Dim Registro_Clientes As New Registro_Clientes
        Registro_Clientes.Show()


    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim Registro_Proveedores As New Registro_Preoveedores
        Registro_Proveedores.Show()

    End Sub
End Class
