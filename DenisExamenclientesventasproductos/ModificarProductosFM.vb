Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DocumentFormat.OpenXml.Drawing
Imports MongoDB.Driver.Core.Configuration
Imports MySql.Data.MySqlClient

Public Class ModificarProductosFM
    'Private connectionString As String = "Server=localhost;Database=pruebademo;Uid=root;Password=dennis;"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BotonModificarProductos.Click
        Dim ID As Integer

        'Validar que el ID ingresado sea un número
        If Not Integer.TryParse(TextBoxIDProductos.Text, ID) Then
            MessageBox.Show("Por favor, ingrese un ID válido.")
            Return
        End If


        ' validacion de los datos de los TextBox
        If String.IsNullOrEmpty(TextBoxIDProductos.Text) OrElse
            String.IsNullOrEmpty(TextBoxNombreProducto.Text) OrElse
            String.IsNullOrEmpty(TextBoxPrecioProducto.Text) OrElse
            String.IsNullOrEmpty(TextBoxCategoriaProducto.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return
        End If


        Dim ModProduct As New Producto(
            TextBoxIDProductos.Text,        'id
            TextBoxNombreProducto.Text,     'Nombre,
            TextBoxPrecioProducto.Text,     'Precio,
            TextBoxCategoriaProducto.Text   'Categoria
        )

        Dim ProductoDB As New ProductoDB()
        If ProductoDB.ActualizarProducto(ModProduct) Then
            MessageBox.Show("Datos Modificados correctamente.")
        Else
            MessageBox.Show("Error al Modificar los datos.")
        End If


    End Sub


End Class