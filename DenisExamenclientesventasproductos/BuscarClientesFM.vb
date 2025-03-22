Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class BuscarClientesFM
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agregar elementos al ComboBox
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Cliente")
        ComboBox1.Items.Add("Teléfono")
        ComboBox1.Items.Add("Correo")
        ComboBox1.SelectedIndex = 0 ' Selecciona el primer filtro por defecto
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscarcliente.Click
        Dim filtro As String = ComboBox1.SelectedItem.ToString()
        Dim query As String = ""

        ' Construir la consulta SQL según el filtro seleccionado
        If filtro = "Cliente" Then
            query = "SELECT * FROM clientes WHERE Cliente LIKE @valor"
        ElseIf filtro = "Teléfono" Then
            query = "SELECT * FROM clientes WHERE Telefono LIKE @valor"
        ElseIf filtro = "Correo" Then
            query = "SELECT * FROM clientes WHERE Correo LIKE @valor"
        End If

        Dim Busquedaventa As String = "%" & txtBuscar.Text & "%"

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@valor", Busquedaventa)

                    ' Llenar el DataGridView
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        dataGridViewClientes.DataSource = dt
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