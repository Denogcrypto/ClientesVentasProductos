Imports System.Configuration
Imports MySql.Data.MySqlClient



Public Class AgregarVentasFM

    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexionMySQL").ConnectionString

    Private totalGeneral As Decimal = 0

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Configurar las columnas del DataGridView
        DataGridViewVentas.Columns.Clear()
        DataGridViewVentas.Columns.Add("ID", "ID")
        DataGridViewVentas.Columns.Add("Nombre", "Nombre")
        DataGridViewVentas.Columns.Add("Cantidad", "Cantidad")
        DataGridViewVentas.Columns.Add("PrecioUnitario", "Precio Unitario")
        DataGridViewVentas.Columns.Add("PrecioTotal", "Precio Total")

        ' Cargar clientes y productos
        CargarClientes()
        CargarProductos()

    End Sub

    Private Sub CargarClientes()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT ID, Cliente FROM clientes"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ComboClientes.Items.Add(New With {.ID = reader("ID"), .Cliente = reader("Cliente")})
                    End While
                End Using
            End Using
        End Using
        ComboClientes.DisplayMember = "Cliente"
        ComboClientes.ValueMember = "ID"
    End Sub

    Private Sub CargarProductos()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT ID, Nombre, Precio FROM productos"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ComboProductos.Items.Add(New With {.ID = reader("ID"), .Nombre = reader("Nombre"), .Precio = reader("Precio")})
                    End While
                End Using
            End Using
        End Using
        ComboProductos.DisplayMember = "Nombre"
        ComboProductos.ValueMember = "ID"
    End Sub

    Private Sub ButtonAgregarProducto_Click(sender As Object, e As EventArgs) Handles ButtonAgregarProducto.Click
        Dim productoSeleccionado = ComboProductos.SelectedItem
        Dim cantidad As Integer
        If Integer.TryParse(TextBoxCantidad.Text, cantidad) AndAlso productoSeleccionado IsNot Nothing Then
            Dim precioUnitario As Decimal = productoSeleccionado.Precio
            Dim totalItem As Decimal = cantidad * precioUnitario
            totalGeneral += totalItem

            DataGridViewVentas.Rows.Add(productoSeleccionado.ID, productoSeleccionado.Nombre, cantidad, precioUnitario, totalItem)
            LabelTotalGeneral.Text = "Total General: " & totalGeneral.ToString("C")
        Else
            MessageBox.Show("Por favor, seleccione un producto e ingrese una cantidad válida.")
        End If
    End Sub

    Private Sub ButtonGuardarVenta_Click(sender As Object, e As EventArgs) Handles ButtonGuardarVenta.Click
        If ComboClientes.SelectedItem Is Nothing OrElse DataGridViewVentas.Rows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un cliente y agregue productos a la venta.")
            Return
        End If

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim transaction As MySqlTransaction = conn.BeginTransaction()

            Try
                ' Guardar la venta
                Dim clienteID As Integer = ComboClientes.SelectedItem.ID
                Dim queryVenta As String = "INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@IDCliente, @Fecha, @Total); SELECT LAST_INSERT_ID();"
                Using cmdVenta As New MySqlCommand(queryVenta, conn, transaction)
                    cmdVenta.Parameters.AddWithValue("@IDCliente", clienteID)
                    cmdVenta.Parameters.AddWithValue("@Fecha", DateTime.Now)
                    cmdVenta.Parameters.AddWithValue("@Total", totalGeneral)
                    Dim ventaID As Integer = Convert.ToInt32(cmdVenta.ExecuteScalar())

                    ' Guardar los detalles de la venta
                    For Each row As DataGridViewRow In DataGridViewVentas.Rows
                        Dim productoID As Integer = row.Cells("ID").Value
                        Dim cantidad As Integer = row.Cells("Cantidad").Value
                        Dim precioUnitario As Decimal = row.Cells("PrecioUnitario").Value
                        Dim totalItem As Decimal = row.Cells("PrecioTotal").Value

                        Dim queryDetalle As String = "INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"
                        Using cmdDetalle As New MySqlCommand(queryDetalle, conn, transaction)
                            cmdDetalle.Parameters.AddWithValue("@IDVenta", ventaID)
                            cmdDetalle.Parameters.AddWithValue("@IDProducto", productoID)
                            cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", precioUnitario)
                            cmdDetalle.Parameters.AddWithValue("@Cantidad", cantidad)
                            cmdDetalle.Parameters.AddWithValue("@PrecioTotal", totalItem)
                            cmdDetalle.ExecuteNonQuery()
                        End Using
                    Next

                    transaction.Commit()
                    MessageBox.Show("Venta guardada correctamente.")
                    LimpiarFormulario()
                End Using
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error al guardar la venta: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LimpiarFormulario()
        ComboClientes.SelectedIndex = -1
        ComboProductos.SelectedIndex = -1
        TextBoxCantidad.Clear()
        DataGridViewVentas.Rows.Clear()
        totalGeneral = 0
        LabelTotalGeneral.Text = "Total General: $0.00"
    End Sub

    Private Sub TextBoxCantidad_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCantidad.TextChanged

    End Sub
End Class