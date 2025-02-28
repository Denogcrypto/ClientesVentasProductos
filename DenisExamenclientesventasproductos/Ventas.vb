Public Class Ventas
    Private ventasDB As New VentasDB()

    ' Método para cargar las ventas en un DataGridView
    Public Sub CargarVentas(dataGridView As DataGridView)
        Dim table As DataTable = ventasDB.ObtenerVentas()
        dataGridView.DataSource = table

        ' Configurar el DataGridView
        dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataGridView.MultiSelect = True
        dataGridView.ReadOnly = True ' Evitar edición directa
    End Sub

    ' Método para eliminar ventas seleccionadas
    Public Sub EliminarVentasSeleccionadas(dataGridView As DataGridView)
        ' Verificar si hay filas seleccionadas
        If dataGridView.SelectedRows.Count = 0 Then
            Throw New Exception("Por favor, seleccione una o más ventas para eliminar.")
        End If

        ' Eliminar las ventas seleccionadas
        For Each row As DataGridViewRow In dataGridView.SelectedRows
            Dim ventaID As Integer = Convert.ToInt32(row.Cells("ID").Value)
            ventasDB.EliminarVenta(ventaID)
        Next
    End Sub
End Class