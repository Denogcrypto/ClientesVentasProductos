Imports MongoDB.Driver.Core.Configuration
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MenuProductos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ingresoproductos As New IngresoProductosFM()
        ingresoproductos.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bajaproductos As New BajaProductosFM()
        bajaproductos.show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim productos As New BuscarProductosFM()
        productos.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Modificarproductos As New ModificarProductosFM()
        Modificarproductos.Show()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class