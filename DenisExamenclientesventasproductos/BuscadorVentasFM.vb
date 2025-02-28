Imports MySql.Data.MySqlClient

Public Class BuscadorVentasFM
    Private connectionString As String = "Server=localhost;Database=pruebademo;Uid=root;Password=dennis;"

    Private Sub BuscadorVentasFM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
    End Sub

    ' Método para cargar los clientes en el ComboBox
    Private Sub CargarClientes()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT ID, Cliente FROM clientes"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    ComboClientes.DataSource = table
                    ComboClientes.DisplayMember = "Cliente"
                    ComboClientes.ValueMember = "ID"
                End Using
            End Using
        End Using
    End Sub

    ' Método para buscar ventas con filtros
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click, ButtonBuscar.Click
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query = "SELECT v.ID, c.Cliente, v.Fecha, v.Total " &
                                  "FROM ventas v " &
                                  "INNER JOIN clientes c ON v.IDCliente = c.ID " &
                                  "WHERE 1=1"

            ' Aplicar filtros
            If ComboClientes.SelectedIndex > -1 Then
                query &= " AND v.IDCliente = @IDCliente"
            End If

            If DateTimePickerDesde.Value <> DateTimePickerHasta.Value Then
                query &= " AND v.Fecha BETWEEN @FechaDesde AND @FechaHasta"
            End If

            If Not String.IsNullOrEmpty(TextBoxTotal.Text) Then
                query &= " AND v.Total >= @Total"
            End If

            Using cmd As New MySqlCommand(query, conn)
                If ComboClientes.SelectedIndex > -1 Then
                    cmd.Parameters.AddWithValue("@IDCliente", ComboClientes.SelectedValue)
                End If

                If DateTimePickerDesde.Value <> DateTimePickerHasta.Value Then
                    cmd.Parameters.AddWithValue("@FechaDesde", DateTimePickerDesde.Value)
                    cmd.Parameters.AddWithValue("@FechaHasta", DateTimePickerHasta.Value)
                End If

                If Not String.IsNullOrEmpty(TextBoxTotal.Text) Then
                    cmd.Parameters.AddWithValue("@Total", Decimal.Parse(TextBoxTotal.Text))
                End If

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable
                    adapter.Fill(table)
                    DataGridViewVentas.DataSource = table
                End Using
            End Using
        End Using
    End Sub

    ' Método para cargar los detalles de la venta seleccionada
    Private Sub DataGridViewVentas_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewVentas.SelectionChanged, DataGridViewVentas.SelectionChanged
        If DataGridViewVentas.SelectedRows.Count > 0 Then
            ' Obtener el ID de la venta seleccionada
            Dim ventaID = Convert.ToInt32(DataGridViewVentas.SelectedRows(0).Cells("ID").Value)
            CargarDetallesVenta(ventaID)
        End If
    End Sub

    ' Método para cargar los productos asociados a la venta seleccionada
    Private Sub CargarDetallesVenta(ventaID As Integer)
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT p.Nombre, vi.PrecioUnitario, vi.Cantidad, vi.PrecioTotal " &
                                  "FROM ventasitems vi " &
                                  "INNER JOIN productos p ON vi.IDProducto = p.ID " &
                                  "WHERE vi.IDVenta = @IDVenta"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IDVenta", ventaID)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridViewDetalles.DataSource = table
                End Using
            End Using
        End Using
    End Sub
End Class