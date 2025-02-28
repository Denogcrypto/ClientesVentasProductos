Public Class EliminarVentasFM
    Private ventas As New Ventas()

    Private Sub EliminarVentasFM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ventas.CargarVentas(DataGridViewVentas)
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Try
            ' Confirmar la eliminación
            Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar las ventas seleccionadas?", "Confirmar", MessageBoxButtons.YesNo)
            If confirmacion <> DialogResult.Yes Then
                Return
            End If

            ' Eliminar las ventas seleccionadas
            ventas.EliminarVentasSeleccionadas(DataGridViewVentas)
            MessageBox.Show("Ventas eliminadas correctamente.")

            ' Recargar la lista de ventas
            ventas.CargarVentas(DataGridViewVentas)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
