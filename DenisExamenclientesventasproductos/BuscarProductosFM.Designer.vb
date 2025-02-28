<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarProductosFM
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
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        DataGridViewProducto = New DataGridView()
        BuscarProducto = New Button()
        TextBoxProducto = New TextBox()
        Label2 = New Label()
        CType(DataGridViewProducto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(338, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 15)
        Label1.TabIndex = 0
        Label1.Text = "Seleccione Una Opcion"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.None
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(338, 63)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' DataGridViewProducto
        ' 
        DataGridViewProducto.Anchor = AnchorStyles.None
        DataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewProducto.Location = New Point(199, 248)
        DataGridViewProducto.Name = "DataGridViewProducto"
        DataGridViewProducto.Size = New Size(410, 204)
        DataGridViewProducto.TabIndex = 3
        ' 
        ' BuscarProducto
        ' 
        BuscarProducto.Anchor = AnchorStyles.None
        BuscarProducto.AutoEllipsis = True
        BuscarProducto.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        BuscarProducto.ForeColor = Color.White
        BuscarProducto.Location = New Point(294, 190)
        BuscarProducto.Name = "BuscarProducto"
        BuscarProducto.Size = New Size(204, 43)
        BuscarProducto.TabIndex = 4
        BuscarProducto.Text = "Buscar"
        BuscarProducto.TextImageRelation = TextImageRelation.ImageAboveText
        BuscarProducto.UseVisualStyleBackColor = False
        ' 
        ' TextBoxProducto
        ' 
        TextBoxProducto.Anchor = AnchorStyles.None
        TextBoxProducto.Location = New Point(306, 143)
        TextBoxProducto.Name = "TextBoxProducto"
        TextBoxProducto.Size = New Size(182, 23)
        TextBoxProducto.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(166, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(499, 15)
        Label2.TabIndex = 6
        Label2.Text = "Si conoce el Dato ingreselo en caso contrario una ves seleccionada la opcion aprete en buscar"
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(914, 510)
        Controls.Add(Label2)
        Controls.Add(TextBoxProducto)
        Controls.Add(BuscarProducto)
        Controls.Add(DataGridViewProducto)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Name = "Form10"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BuscarProductos"
        CType(DataGridViewProducto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridViewProducto As DataGridView
    Friend WithEvents BuscarProducto As Button
    Friend WithEvents TextBoxProducto As TextBox
    Friend WithEvents Label2 As Label
End Class
