Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Form8

    'Private connectionString As String = "Server=localhost;Database=pruebademo;Uid=root;Password=dennis;"
    Private Function EsEmailValido(email As String) As Boolean
        ' Expresión regular para validar un correo electrónico
        Dim regex As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        Return regex.IsMatch(email)
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        ' Obtén los datos de los TextBox
        If String.IsNullOrEmpty(TextIDcliente.Text) OrElse
           String.IsNullOrEmpty(TextBox2.Text) OrElse
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

        Dim ModCliente As New Cliente(
            TextIDcliente.Text, 'id
            TextBox2.Text,      'Cliente,
            TextBox3.Text,      'Telefono,
            TextBox4.Text       'Correo
        )

        ' Validar que el ID ingresado sea un número
        If Not Integer.TryParse(TextIDcliente.Text, ModCliente.ID) Then
            MessageBox.Show("Por favor, ingrese un ID válido.")
            Return
        End If

        Dim clienteDB As New ClienteDB()
        If clienteDB.ModificarCliente(ModCliente) Then
            MessageBox.Show("Datos Modificados correctamente.")
        Else
            MessageBox.Show("Error al Modificar los datos.")
        End If


    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class