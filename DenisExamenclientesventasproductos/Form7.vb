Imports DocumentFormat.OpenXml.Office2010.Excel
Imports MongoDB.Driver.Core.Configuration
Imports MySql.Data.MySqlClient

Public Class Form7



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ElimProducto As New Producto(
           TextBox1.Text   'id
          )

        ' Validar que el ID sea un número
        If Not Integer.TryParse(TextBox1.Text, ElimProducto.ID) Then
            MessageBox.Show("Por favor, ingrese un ID válido.")
            Return
        End If


        Dim ProductoDB As New ProductoDB()
        If ProductoDB.EliminarProducto(ElimProducto) Then
            MessageBox.Show("Datos Eliminados correctamente.")
        Else
            MessageBox.Show("Error al eliminar los datos.")
        End If



    End Sub


End Class