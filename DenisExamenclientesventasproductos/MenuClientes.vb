

Public Class MenuClientes
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ingresoclientes As New IngresoClientesFM()
        ingresoclientes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bajaclientes As New BajaClientesFM()
        bajaclientes.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim modificarclientes As New ModificarClientesFM()
        modificarclientes.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Buscarclientes As New BuscarClientesFM()
        Buscarclientes.Show()
    End Sub
End Class