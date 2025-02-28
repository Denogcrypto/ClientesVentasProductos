Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clientes As New Form2()
        clientes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim productos As New Form5()
        productos.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Obtener la cadena de conexión desde App.config
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MiConexionMySQL").ConnectionString

        ' Intentar abrir una conexión
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                MessageBox.Show("Conexión exitosa a la base de datos MySQL.")
            Catch ex As Exception
                MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Ventas As New Form11()
        Ventas.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Reportes As New ReporteFM()
        Reportes.Show()
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
        ' Este método está vacío, puedes agregar lógica si es necesario
    End Sub

    ' Método para convertir Byte() a Image
    Private Function ByteArrayToImage(byteArray As Byte()) As Image
        Using ms As New System.IO.MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    ' Método para verificar la conexión y actualizar el PictureBox
    Private Sub VerificarConexion()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MiConexionMySQL").ConnectionString

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                pbEstadoConexion.Image = ByteArrayToImage(My.Resources.verde) ' Convierte Byte() a Image
                pbEstadoConexion.Tag = "Conectado" ' Guardamos estado en el Tag
            Catch ex As Exception
                pbEstadoConexion.Image = ByteArrayToImage(My.Resources.rojo) ' Convierte Byte() a Image
                pbEstadoConexion.Tag = "Desconectado"
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Sub

    ' Evento que se ejecuta cuando carga el formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerificarConexion()
        Timer1.Interval = 30000 ' 30 segundos
        Timer1.Start()
    End Sub

    ' Evento del Timer para verificar cada 30 segundos
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        VerificarConexion()
    End Sub

    ' Si el usuario hace clic en el PictureBox, se verifica la conexión manualmente
    Private Sub pbEstadoConexion_Click(sender As Object, e As EventArgs) Handles pbEstadoConexion.Click
        VerificarConexion()
        MessageBox.Show("Estado de conexión: " & pbEstadoConexion.Tag)
    End Sub

End Class



