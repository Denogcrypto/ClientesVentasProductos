Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class VentasDB

    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
    ' Método para obtener todas las ventas
    Public Function ObtenerVentas() As DataTable
        Dim table As New DataTable()

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT v.ID, c.Cliente, v.Fecha, v.Total FROM ventas v INNER JOIN clientes c ON v.IDCliente = c.ID"
            Using cmd As New SqlCommand(query, conn)
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        End Using

        Return table
    End Function

    ' Método para eliminar una venta y sus items
    Public Sub EliminarVenta(ventaID As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim transaction As SqlTransaction = conn.BeginTransaction()

            Try
                ' Eliminar los items de la venta (detalle)
                Dim queryDetalle As String = "DELETE FROM ventasitems WHERE IDVenta = @IDVenta"
                Using cmdDetalle As New SqlCommand(queryDetalle, conn, transaction)
                    cmdDetalle.Parameters.AddWithValue("@IDVenta", ventaID)
                    cmdDetalle.ExecuteNonQuery()
                End Using

                ' Eliminar la venta
                Dim queryVenta As String = "DELETE FROM ventas WHERE ID = @ID"
                Using cmdVenta As New SqlCommand(queryVenta, conn, transaction)
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