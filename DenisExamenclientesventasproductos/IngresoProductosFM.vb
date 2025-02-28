Imports MongoDB.Driver.Core.Configuration
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI

Public Class IngresoProductosFM

    ' Cadena de conexión, ajusta según tu configuración


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Obtén los datos de los TextBox
        Dim product As New Producto(
            TextBox1.Text, ' ID
            TextBox2.Text, ' Nombre
            TextBox3.Text, ' Precio
            TextBox4.Text  ' Categoria
        )

        ' validacion de los datos de los TextBox
        If String.IsNullOrEmpty(TextBox1.Text) OrElse
           String.IsNullOrEmpty(TextBox2.Text) OrElse
           String.IsNullOrEmpty(TextBox3.Text) OrElse
           String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return
        End If

        ' Validar que el ID sea un número
        If Not Integer.TryParse(TextBox1.Text, product.ID) Then
            MessageBox.Show("Por favor, ingrese un ID válido.")
            Return
        End If

        ' Consulta SQL para insertar datos
        Dim productoDB As New ProductoDB()
        If productoDB.InsertarProducto(product) Then
            MessageBox.Show("Datos insertados correctamente.")
        Else
            MessageBox.Show("Error al insertar los datos.")
        End If


    End Sub

    Private Sub IngresoProductosFM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class