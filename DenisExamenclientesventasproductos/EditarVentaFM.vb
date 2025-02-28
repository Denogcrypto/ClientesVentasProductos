Imports MySql.Data.MySqlClient

Public Class EditarVentaFM
    Private connectionString As String = "Server=localhost;Database=pruebademo;Uid=root;Password=dennis;"
    Private ventaID As Integer

    ' Constructor que recibe el ID de la venta
    Public Sub New(id As Integer)
        InitializeComponent()
        ventaID = id
    End Sub

    ' Evento que se ejecuta al cargar el formulario
    Private Sub EditarVentaFM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosVenta()
    End Sub

    ' Método para cargar los datos de la venta seleccionada en el DataGridView
    Private Sub CargarDatosVenta()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT ID, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal FROM ventasitems WHERE IDVenta = @IDVenta"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IDVenta", ventaID)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridViewVenta.DataSource = table
                End Using
            End Using
        End Using

        ' Configurar el DataGridView para permitir la edición
        DataGridViewVenta.ReadOnly = False
        DataGridViewVenta.AllowUserToAddRows = False
        DataGridViewVenta.AllowUserToDeleteRows = False
        DataGridViewVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Configurar las columnas para permitir o no la edición
        For Each column As DataGridViewColumn In DataGridViewVenta.Columns
            If column.Name = "ID" OrElse column.Name = "IDVenta" OrElse column.Name = "IDProducto" Then
                column.ReadOnly = True ' Columnas de solo lectura
            Else
                column.ReadOnly = False ' Columnas editables
            End If
        Next

        ' Suscribir al evento CellValueChanged para recalcular el PrecioTotal
        AddHandler DataGridViewVenta.CellValueChanged, AddressOf DataGridViewVenta_CellValueChanged
    End Sub

    ' Evento que se ejecuta cuando se modifica el valor de una celda
    Private Sub DataGridViewVenta_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        ' Verificar si la celda editada es PrecioUnitario o Cantidad
        If e.ColumnIndex = DataGridViewVenta.Columns("PrecioUnitario").Index OrElse
           e.ColumnIndex = DataGridViewVenta.Columns("Cantidad").Index Then

            ' Obtener la fila editada
            Dim row As DataGridViewRow = DataGridViewVenta.Rows(e.RowIndex)

            ' Obtener los valores de PrecioUnitario y Cantidad
            Dim precioUnitario As Decimal = Convert.ToDecimal(row.Cells("PrecioUnitario").Value)
            Dim cantidad As Integer = Convert.ToInt32(row.Cells("Cantidad").Value)

            ' Calcular el PrecioTotal
            Dim precioTotal As Decimal = precioUnitario * cantidad

            ' Actualizar el valor de PrecioTotal en el DataGridView
            row.Cells("PrecioTotal").Value = precioTotal
        End If
    End Sub

    ' Método para aplicar los cambios
    Private Sub ButtonAplicar_Click(sender As Object, e As EventArgs) Handles ButtonAplicar.Click
        ' Verificar si hay una fila seleccionada
        If DataGridViewVenta.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un registro para editar.")
            Return
        End If

        ' Obtener los valores editados del DataGridView
        Dim row As DataGridViewRow = DataGridViewVenta.SelectedRows(0)
        Dim nuevoPrecioUnitario As Decimal = Convert.ToDecimal(row.Cells("PrecioUnitario").Value)
        Dim nuevaCantidad As Integer = Convert.ToInt32(row.Cells("Cantidad").Value)
        Dim nuevoPrecioTotal As Decimal = Convert.ToDecimal(row.Cells("PrecioTotal").Value)

        Try
            ' Actualizar el registro en la base de datos
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE ventasitems SET PrecioUnitario = @PrecioUnitario, Cantidad = @Cantidad, PrecioTotal = @PrecioTotal WHERE ID = @ID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@PrecioUnitario", nuevoPrecioUnitario)
                    cmd.Parameters.AddWithValue("@Cantidad", nuevaCantidad)
                    cmd.Parameters.AddWithValue("@PrecioTotal", nuevoPrecioTotal)
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(row.Cells("ID").Value))
                    cmd.ExecuteNonQuery()
                End Using

                ' Actualizar el total en la tabla ventas
                Dim queryVentas As String = "UPDATE ventas SET Total = (SELECT SUM(PrecioTotal) FROM ventasitems WHERE IDVenta = @IDVenta) WHERE ID = @IDVenta"
                Using cmdVentas As New MySqlCommand(queryVentas, conn)
                    cmdVentas.Parameters.AddWithValue("@IDVenta", ventaID)
                    cmdVentas.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Registro actualizado correctamente.")
            Me.Close() ' Cerrar el formulario después de aplicar los cambios
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el registro: " & ex.Message)
        End Try
    End Sub
End Class