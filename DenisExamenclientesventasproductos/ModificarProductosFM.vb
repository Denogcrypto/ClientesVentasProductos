Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DocumentFormat.OpenXml.Drawing
Imports MongoDB.Driver.Core.Configuration
Imports Microsoft.Data.SqlClient

Public Class ModificarProductosFM

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BotonModificarProductos.Click
        Dim ID As Integer

        ' Validar que el ID ingresado sea un número
        If Not Integer.TryParse(TextBoxIDProductos.Text, ID) Then
            MessageBox.Show("Por favor, ingrese un ID válido.")
            Return
        End If

        ' Validación de los datos de los TextBox
        If String.IsNullOrEmpty(TextBoxIDProductos.Text) OrElse
           String.IsNullOrEmpty(TextBoxNombreProducto.Text) OrElse
           String.IsNullOrEmpty(TextBoxPrecioProducto.Text) OrElse
           String.IsNullOrEmpty(TextBoxCategoriaProducto.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return
        End If

        ' Crear el objeto Producto con los datos actualizados
        Dim ModProduct As New Producto(
            ID,                            ' ID (solo para identificar el registro)
            TextBoxNombreProducto.Text,     ' Nombre
            TextBoxPrecioProducto.Text,     ' Precio
            TextBoxCategoriaProducto.Text   ' Categoría
        )

        ' Llamar al método para actualizar el producto en la base de datos
        Dim ProductoDB As New ProductoDB()
        If ProductoDB.ActualizarProducto(ModProduct) Then
            MessageBox.Show("Datos modificados correctamente.")
        Else
            MessageBox.Show("Error al modificar los datos.")
        End If
    End Sub

    Private Sub ModificarProductosFM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Código de carga inicial (si es necesario)
    End Sub
End Class