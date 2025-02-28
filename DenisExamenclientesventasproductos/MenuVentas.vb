Public Class MenuVentas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IngresoVentass As New AgregarVentasFM()
        IngresoVentass.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim EliminarVentas As New EliminarVentasFM()
        EliminarVentas.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim EliminarVentas As New BuscadorVentasFM()
        EliminarVentas.Show()
    End Sub


    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ModificarVentas As New ModificarVentasFM()
        ModificarVentas.Show()
    End Sub
End Class