<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarVentasFM
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
        ComboClientes = New ComboBox()
        DataGridViewVentas = New DataGridView()
        ComboProductos = New ComboBox()
        LabelTotalGeneral = New Label()
        TextBoxCantidad = New TextBox()
        ButtonAgregarProducto = New Button()
        ButtonGuardarVenta = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(DataGridViewVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboClientes
        ' 
        ComboClientes.Anchor = AnchorStyles.None
        ComboClientes.FormattingEnabled = True
        ComboClientes.Location = New Point(428, 21)
        ComboClientes.Name = "ComboClientes"
        ComboClientes.Size = New Size(121, 23)
        ComboClientes.TabIndex = 0
        ' 
        ' DataGridViewVentas
        ' 
        DataGridViewVentas.Anchor = AnchorStyles.None
        DataGridViewVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewVentas.Location = New Point(152, 157)
        DataGridViewVentas.Name = "DataGridViewVentas"
        DataGridViewVentas.Size = New Size(678, 150)
        DataGridViewVentas.TabIndex = 1
        ' 
        ' ComboProductos
        ' 
        ComboProductos.Anchor = AnchorStyles.None
        ComboProductos.FormattingEnabled = True
        ComboProductos.Location = New Point(428, 71)
        ComboProductos.Name = "ComboProductos"
        ComboProductos.Size = New Size(121, 23)
        ComboProductos.TabIndex = 2
        ' 
        ' LabelTotalGeneral
        ' 
        LabelTotalGeneral.Anchor = AnchorStyles.None
        LabelTotalGeneral.AutoSize = True
        LabelTotalGeneral.Location = New Point(409, 387)
        LabelTotalGeneral.Name = "LabelTotalGeneral"
        LabelTotalGeneral.Size = New Size(76, 15)
        LabelTotalGeneral.TabIndex = 3
        LabelTotalGeneral.Text = "Mostrar Total"
        ' 
        ' TextBoxCantidad
        ' 
        TextBoxCantidad.Anchor = AnchorStyles.None
        TextBoxCantidad.Location = New Point(428, 116)
        TextBoxCantidad.Name = "TextBoxCantidad"
        TextBoxCantidad.Size = New Size(121, 23)
        TextBoxCantidad.TabIndex = 4
        ' 
        ' ButtonAgregarProducto
        ' 
        ButtonAgregarProducto.Anchor = AnchorStyles.None
        ButtonAgregarProducto.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        ButtonAgregarProducto.ForeColor = Color.White
        ButtonAgregarProducto.Location = New Point(334, 325)
        ButtonAgregarProducto.Name = "ButtonAgregarProducto"
        ButtonAgregarProducto.Size = New Size(240, 49)
        ButtonAgregarProducto.TabIndex = 5
        ButtonAgregarProducto.Text = "Agregar producto"
        ButtonAgregarProducto.UseVisualStyleBackColor = False
        ' 
        ' ButtonGuardarVenta
        ' 
        ButtonGuardarVenta.Anchor = AnchorStyles.None
        ButtonGuardarVenta.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        ButtonGuardarVenta.ForeColor = Color.White
        ButtonGuardarVenta.Location = New Point(334, 416)
        ButtonGuardarVenta.Name = "ButtonGuardarVenta"
        ButtonGuardarVenta.Size = New Size(240, 52)
        ButtonGuardarVenta.TabIndex = 6
        ButtonGuardarVenta.Text = "Guardar venta"
        ButtonGuardarVenta.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(324, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 7
        Label2.Text = "Cantidad "
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(293, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 15)
        Label3.TabIndex = 8
        Label3.Text = "Seleccionar Cliente"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Location = New Point(293, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 15)
        Label4.TabIndex = 9
        Label4.Text = "Selecciona Producto"
        ' 
        ' AgregarVentasFM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(914, 510)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ButtonGuardarVenta)
        Controls.Add(ButtonAgregarProducto)
        Controls.Add(TextBoxCantidad)
        Controls.Add(LabelTotalGeneral)
        Controls.Add(ComboProductos)
        Controls.Add(DataGridViewVentas)
        Controls.Add(ComboClientes)
        Name = "AgregarVentasFM"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AgregarVentasFM"
        CType(DataGridViewVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboClientes As ComboBox
    Friend WithEvents DataGridViewVentas As DataGridView
    Friend WithEvents ComboProductos As ComboBox
    Friend WithEvents LabelTotalGeneral As Label
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents ButtonAgregarProducto As Button
    Friend WithEvents ButtonGuardarVenta As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
