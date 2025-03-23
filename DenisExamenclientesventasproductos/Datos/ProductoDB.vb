Imports System.Configuration
Imports DocumentFormat.OpenXml.Office2010.Excel
Imports MongoDB.Driver
Imports MongoDB.Driver.Core.Configuration
Imports Microsoft.Data.SqlClient

Friend Class ProductoDB
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
    Public Sub New()
    End Sub



    Friend Function InsertarProducto(product As Producto) As Boolean



        Dim query As String = "INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@Nombre", product.Nombre)
                    cmd.Parameters.AddWithValue("@Precio", product.Precio)
                    cmd.Parameters.AddWithValue("@Categoria", product.Categoria)


                    ' Ejecuta la consulta
                    Dim result As Integer = cmd.ExecuteNonQuery()

                    Return result > 0

                End Using
            Catch ex As SqlException
                MessageBox.Show("Error: " & ex.Message)
                Return False
            Finally
                conn.Close()
            End Try



        End Using
    End Function




    Friend Function EliminarProducto(ElimProducto As Producto)

        Dim resultado As Boolean = False

        ' Query para eliminar el Producto
        Dim query As String = "DELETE FROM productos WHERE Id = @Id"

        Using conexion As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conexion)
                ' Agregar parámetro para evitar SQL Injection
                cmd.Parameters.AddWithValue("@Id", ElimProducto.ID)

                Try
                    ' Abrir la conexión
                    conexion.Open()

                    ' Ejecutar el comando y verificar si se afectó alguna fila
                    If cmd.ExecuteNonQuery() > 0 Then
                        resultado = True
                    End If
                Catch ex As Exception
                    ' Manejar excepciones (puedes logear el error o lanzarlo)
                    Throw New Exception("Error al eliminar el cliente: " & ex.Message)
                Finally
                    ' Cerrar la conexión
                    conexion.Close()
                End Try
            End Using
        End Using

        Return resultado


    End Function




    Friend Function ActualizarProducto(ModProduct As Producto) As Boolean
        ' Consulta SQL para actualizar los datos
        Dim query As String = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE ID = @ID"

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    ' Asigna los parámetros
                    cmd.Parameters.AddWithValue("@ID", ModProduct.ID)
                    cmd.Parameters.AddWithValue("@Nombre", ModProduct.Nombre)
                    cmd.Parameters.AddWithValue("@Precio", ModProduct.Precio)
                    cmd.Parameters.AddWithValue("@Categoria", ModProduct.Categoria)

                    ' Ejecuta la consulta
                    Dim result As Integer = cmd.ExecuteNonQuery()

                    Return result > 0
                End Using


            Catch ex As SqlException
                MessageBox.Show("Error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error inesperado: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Function
End Class



