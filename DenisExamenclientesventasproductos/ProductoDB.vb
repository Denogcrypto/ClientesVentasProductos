Imports System.Configuration
Imports DocumentFormat.OpenXml.Office2010.Excel
Imports MongoDB.Driver
Imports MongoDB.Driver.Core.Configuration
Imports MySql.Data.MySqlClient

Friend Class ProductoDB
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexionMySQL").ConnectionString
    Public Sub New()
    End Sub



    Friend Function InsertarProducto(product As Producto) As Boolean



        Dim query As String = "INSERT INTO productos (ID, Nombre, Precio, Categoria) VALUES (@ID, @Nombre, @Precio, @Categoria)"

        Using conn As New MySqlConnection(ConnectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    ' Asigna los parámetros
                    cmd.Parameters.AddWithValue("@ID", product.ID)
                    cmd.Parameters.AddWithValue("@Nombre", product.Nombre)
                    cmd.Parameters.AddWithValue("@Precio", product.Precio)
                    cmd.Parameters.AddWithValue("@Categoria", product.Categoria)


                    ' Ejecuta la consulta
                    Dim result As Integer = cmd.ExecuteNonQuery()

                    Return result > 0

                End Using
            Catch ex As MySqlException
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

        Using conexion As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conexion)
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
        Dim query As String = "UPDATE productos SET ID = @ID, Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE ID = @ID"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    ' Asigna los parámetros
                    cmd.Parameters.AddWithValue("@ID", ModProduct.ID)
                    cmd.Parameters.AddWithValue("@Nombre", ModProduct.Nombre)
                    cmd.Parameters.AddWithValue("@Precio", ModProduct.Precio)
                    cmd.Parameters.AddWithValue("@Categoria", ModProduct.Categoria)

                    ' Ejecuta la consulta
                    Dim result As Integer = cmd.ExecuteNonQuery()

                    Return result > 0
                End Using


            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error inesperado: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Function
End Class