
Imports MySql.Data.MySqlClient

    Public Class ModificarVentasFM
        Private connectionString As String = "Server=localhost;Database=pruebademo;Uid=root;Password=dennis;"

        Private Sub ModificarVentasFM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CargarVentas()
        End Sub

        ' Método para cargar las ventas en el DataGridView
        Private Sub CargarVentas()
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT v.ID, c.Cliente, v.Fecha, v.Total FROM ventas v INNER JOIN clientes c ON v.IDCliente = c.ID"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        DataGridViewVentas.DataSource = table
                    End Using
                End Using
            End Using

            ' Configurar el DataGridView
            DataGridViewVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridViewVentas.MultiSelect = False
            DataGridViewVentas.ReadOnly = True ' Evitar edición directa
        End Sub

        ' Método para modificar la venta seleccionada
        Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
            ' Verificar si hay una fila seleccionada
            If DataGridViewVentas.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione una venta para modificar.")
                Return
            End If

            ' Obtener el ID de la venta seleccionada
            Dim ventaID As Integer = Convert.ToInt32(DataGridViewVentas.SelectedRows(0).Cells("ID").Value)

        ' Abrir el formulario de edición
        Dim editarVentaForm As New EditarVentaFM(ventaID)
        editarVentaForm.ShowDialog()

        ' Recargar las ventas después de la edición
        CargarVentas()
        End Sub
    End Class
