Imports MongoDB.Driver.Core.Configuration
Imports Microsoft.Data.SqlClient
Imports Mysqlx.XDevAPI

Public Class IngresoProductosFM

    ' Cadena de conexión, ajusta según tu configuración


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Obtén los datos de los TextBox
        Dim product As New Producto(TextBox2.Text, ' Nombre
            TextBox3.Text, ' Precio
            TextBox4.Text  ' Categoria
        )

        ' validacion de los datos de los TextBox
        If String.IsNullOrEmpty(TextBox2.Text) OrElse
           String.IsNullOrEmpty(TextBox3.Text) OrElse
           String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.")
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