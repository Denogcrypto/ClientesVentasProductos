Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class BuscarProductosFM
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agregar elementos al ComboBox
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Nombre")
        ComboBox1.Items.Add("Precio")
        ComboBox1.Items.Add("Categoria")
        ComboBox1.SelectedIndex = 0 ' Selecciona el primer filtro por defecto
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles BuscarProducto.Click
        Dim filtro As String = ComboBox1.SelectedItem.ToString()
        Dim query As String = ""

        ' Construir la consulta SQL según el filtro seleccionado
        If filtro = "Nombre" Then
            query = "SELECT * FROM productos WHERE Nombre LIKE @valor"
        ElseIf filtro = "Precio" Then
            query = "SELECT * FROM productos WHERE Precio LIKE @valor"
        ElseIf filtro = "Categoria" Then
            query = "SELECT * FROM productos WHERE Categoria LIKE @valor"
        End If

        Dim valorBusqueda As String = "%" & TextBoxProducto.Text & "%"

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@valor", valorBusqueda)

                    ' Llenar el DataGridView
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        DataGridViewProducto.DataSource = dt
                    End Using
                End Using
            Catch ex As SqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class