<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BotonModificarProductos = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBoxCategoriaProducto = New TextBox()
        TextBoxPrecioProducto = New TextBox()
        TextBoxNombreProducto = New TextBox()
        TextBoxIDProductos = New TextBox()
        SuspendLayout()
        ' 
        ' BotonModificarProductos
        ' 
        BotonModificarProductos.Anchor = AnchorStyles.None
        BotonModificarProductos.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        BotonModificarProductos.ForeColor = Color.White
        BotonModificarProductos.Location = New Point(332, 334)
        BotonModificarProductos.Name = "BotonModificarProductos"
        BotonModificarProductos.Size = New Size(229, 86)
        BotonModificarProductos.TabIndex = 0
        BotonModificarProductos.Text = "Modificar"
        BotonModificarProductos.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(332, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(255, 15)
        Label1.TabIndex = 1
        Label1.Text = "Ingrese el ID del Producto que quiere Modificar"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(366, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 15)
        Label2.TabIndex = 2
        Label2.Text = "Ingrese Abajo Los nuevos Datos"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(421, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 3
        Label3.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Location = New Point(421, 188)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 15)
        Label4.TabIndex = 4
        Label4.Text = "Precio"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Location = New Point(414, 252)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 5
        Label5.Text = "Categoria"
        ' 
        ' TextBoxCategoriaProducto
        ' 
        TextBoxCategoriaProducto.Anchor = AnchorStyles.None
        TextBoxCategoriaProducto.Location = New Point(398, 282)
        TextBoxCategoriaProducto.Name = "TextBoxCategoriaProducto"
        TextBoxCategoriaProducto.Size = New Size(100, 23)
        TextBoxCategoriaProducto.TabIndex = 6
        ' 
        ' TextBoxPrecioProducto
        ' 
        TextBoxPrecioProducto.Anchor = AnchorStyles.None
        TextBoxPrecioProducto.Location = New Point(398, 215)
        TextBoxPrecioProducto.Name = "TextBoxPrecioProducto"
        TextBoxPrecioProducto.Size = New Size(100, 23)
        TextBoxPrecioProducto.TabIndex = 7
        ' 
        ' TextBoxNombreProducto
        ' 
        TextBoxNombreProducto.Anchor = AnchorStyles.None
        TextBoxNombreProducto.Location = New Point(398, 153)
        TextBoxNombreProducto.Name = "TextBoxNombreProducto"
        TextBoxNombreProducto.Size = New Size(100, 23)
        TextBoxNombreProducto.TabIndex = 8
        ' 
        ' TextBoxIDProductos
        ' 
        TextBoxIDProductos.Anchor = AnchorStyles.None
        TextBoxIDProductos.Location = New Point(398, 58)
        TextBoxIDProductos.Name = "TextBoxIDProductos"
        TextBoxIDProductos.Size = New Size(100, 23)
        TextBoxIDProductos.TabIndex = 9
        ' 
        ' Form13
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(914, 510)
        Controls.Add(TextBoxIDProductos)
        Controls.Add(TextBoxNombreProducto)
        Controls.Add(TextBoxPrecioProducto)
        Controls.Add(TextBoxCategoriaProducto)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BotonModificarProductos)
        Name = "Form13"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ModificarProductos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BotonModificarProductos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxCategoriaProducto As TextBox
    Friend WithEvents TextBoxPrecioProducto As TextBox
    Friend WithEvents TextBoxNombreProducto As TextBox
    Friend WithEvents TextBoxIDProductos As TextBox
End Class
