Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class VentasDB

    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexionMySQL").ConnectionString
    ' Método para obtener todas las ventas
    Public Function ObtenerVentas() As DataTable
        Dim table As New DataTable()

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT v.ID, c.Cliente, v.Fecha, v.Total FROM ventas v INNER JOIN clientes c ON v.IDCliente = c.ID"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        End Using

        Return table
    End Function

    ' Método para eliminar una venta y sus items
    Public Sub EliminarVenta(ventaID As Integer)
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim transaction As MySqlTransaction = conn.BeginTransaction()

            Try
                ' Eliminar los items de la venta (detalle)
                Dim queryDetalle As String = "DELETE FROM ventasitems WHERE IDVenta = @IDVenta"
                Using cmdDetalle As New MySqlCommand(queryDetalle, conn, transaction)
                    cmdDetalle.Parameters.AddWithValue("@IDVenta", ventaID)
                    cmdDetalle.ExecuteNonQuery()
                End Using

                ' Eliminar la venta
                Dim queryVenta As String = "DELETE FROM ventas WHERE ID = @ID"
                Using cmdVenta As New MySqlCommand(queryVenta, conn, transaction)
                    cmdVenta.Parameters.AddWithValue("@ID", ventaID)
                    cmdVenta.ExecuteNonQuery()
                End Using

                transaction.Commit()
            Catch ex As Exception
                transaction.Rollback()
                Throw New Exception("Error al eliminar la venta: " & ex.Message)
            End Try
        End Using
    End Sub





End Class