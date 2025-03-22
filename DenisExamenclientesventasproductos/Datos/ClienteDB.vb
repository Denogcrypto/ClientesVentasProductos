Imports System.Configuration
Imports MongoDB.Driver
Imports MongoDB.Driver.Core.Configuration
Imports Microsoft.Data.SqlClient

Friend Class ClienteDB

    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
    Public Sub New()
        End Sub

        Public Property Elimclient As Object

        Friend Function InsertarCliente(client As Cliente) As Boolean



        Dim query As String = "INSERT INTO clientes ( Cliente, Telefono, Correo) VALUES ( @Cliente, @Telefono, @Correo)"

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    ' Asigna los parámetros

                    cmd.Parameters.AddWithValue("@Cliente", client.Nombre)
                    cmd.Parameters.AddWithValue("@Telefono", client.Telefono)
                    cmd.Parameters.AddWithValue("@Correo", client.Correo)


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

    Friend Function EliminarCliente(Elimclient As Cliente) As Boolean
        Dim resultado As Boolean = False

        ' Query para eliminar el cliente
        Dim query As String = "DELETE FROM Clientes WHERE Id = @Id"

        Using conexion As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conexion)
                ' Agregar parámetro para evitar SQL Injection
                cmd.Parameters.AddWithValue("@Id", Elimclient.ID)

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


    Friend Function ModificarCliente(ModCliente As Cliente) As Boolean

        ' Consulta SQL para actualizar los datos
        Dim query As String = "UPDATE clientes SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo WHERE ID = @ID"

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    ' Asigna los parámetros
                    cmd.Parameters.AddWithValue("@ID", ModCliente.ID)
                    cmd.Parameters.AddWithValue("@Cliente", ModCliente.Nombre)
                    cmd.Parameters.AddWithValue("@Telefono", ModCliente.Telefono)
                    cmd.Parameters.AddWithValue("@Correo", ModCliente.Correo)

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


