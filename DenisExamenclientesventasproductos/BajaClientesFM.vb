Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MongoDB.Driver.Core.Configuration
Imports Microsoft.Data.SqlClient
Imports Mysqlx.XDevAPI



Public Class BajaClientesFM


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Obtén los datos de los TextBox
        Dim Elimclient As New Cliente(
           TextBox1.Text 'id
          )

        ' Validar que el ID sea un número
        If Not Integer.TryParse(TextBox1.Text, Elimclient.ID) Then
            MessageBox.Show("Por favor, ingrese un ID válido.")
            Return
        End If


        Dim clienteDB As New ClienteDB()
        If clienteDB.EliminarCliente(Elimclient) Then
            MessageBox.Show("Datos Eliminados correctamente.")
        Else
            MessageBox.Show("Error al eliminar los datos.")
        End If


    End Sub

    Private Sub BajaClientesFM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class