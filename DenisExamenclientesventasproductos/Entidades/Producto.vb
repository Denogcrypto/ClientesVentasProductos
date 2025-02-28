Friend Class Producto
    Private text As String
    Public Property ID As Integer ' ID del producto
    Public Property Nombre As String ' Nombre del producto
    Public Property Precio As Decimal ' Precio del producto
    Public Property Categoria As String ' Categoria del producto



    Public Sub New(ID As Integer, Nombre As String, Precio As Decimal, Categoria As String)
        Me.ID = ID
        Me.Nombre = Nombre
        Me.Precio = Precio
        Me.Categoria = Categoria
    End Sub

    Public Sub New(text As String)
        Me.text = text
    End Sub
End Class