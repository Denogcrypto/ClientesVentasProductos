Imports Microsoft.Data.SqlClient
Imports Mysqlx.XDevAPI
Imports System.Configuration
Imports System.Text.RegularExpressions




Public Class IngresoClientesFM


    Private Function EsEmailValido(email As String) As Boolean
        ' Expresión regular para validar un correo electrónico
        Dim regex As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        Return regex.IsMatch(email)
    End Function


    ' Cadena de conexión, ajusta según tu configuración






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'validacion pára campos vacios

        If String.IsNullOrEmpty(TextBox2.Text) OrElse
           String.IsNullOrEmpty(TextBox3.Text) OrElse
           String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return
        End If
        'validacion para el arroba

        If Not EsEmailValido(TextBox4.Text) Then
            MessageBox.Show("Por favor, ingrese un correo electrónico válido.")
            Return
        End If

        ' Obtén los datos de los TextBox



        Dim client As New Cliente(TextBox3.Text, ' Nombre
            TextBox2.Text, ' Teléfono
            TextBox4.Text  ' Correo
)



        Dim clienteDB As New ClienteDB()
        If clienteDB.InsertarCliente(client) Then
            MessageBox.Show("Datos insertados correctamente.")
        Else
            MessageBox.Show("Error al insertar los datos.")
        End If


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class