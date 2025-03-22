Friend Class Cliente
    Private text As String
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Telefono As String
    Public Property Correo As String

    Public Sub New(iD As Integer, Nombre As String, Telefono As String, Correo As String)
        Me.ID = iD
        Me.Nombre = Nombre
        Me.Telefono = Telefono
        Me.Correo = Correo
    End Sub

    Public Sub New(Nombre As String, Telefono As String, Correo As String)

        Me.Nombre = Nombre
        Me.Telefono = Telefono
        Me.Correo = Correo
    End Sub



    Public Sub New(text As String)
        Me.text = text
    End Sub
End Class


