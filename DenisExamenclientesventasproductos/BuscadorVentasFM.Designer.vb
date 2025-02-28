<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscadorVentasFM
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
        ButtonBuscar = New Button()
        DateTimePickerDesde = New DateTimePicker()
        DateTimePickerHasta = New DateTimePicker()
        DataGridViewDetalles = New DataGridView()
        DataGridViewVentas = New DataGridView()
        TextBoxTotal = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(DataGridViewDetalles, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboClientes
        ' 
        ComboClientes.Anchor = AnchorStyles.None
        ComboClientes.FormattingEnabled = True
        ComboClientes.Location = New Point(382, 120)
        ComboClientes.Name = "ComboClientes"
        ComboClientes.Size = New Size(121, 23)
        ComboClientes.TabIndex = 0
        ' 
        ' ButtonBuscar
        ' 
        ButtonBuscar.Anchor = AnchorStyles.None
        ButtonBuscar.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        ButtonBuscar.ForeColor = Color.White
        ButtonBuscar.Location = New Point(358, 200)
        ButtonBuscar.Name = "ButtonBuscar"
        ButtonBuscar.Size = New Size(157, 35)
        ButtonBuscar.TabIndex = 3
        ButtonBuscar.Text = "Buscar"
        ButtonBuscar.UseVisualStyleBackColor = False
        ' 
        ' DateTimePickerDesde
        ' 
        DateTimePickerDesde.Anchor = AnchorStyles.None
        DateTimePickerDesde.Location = New Point(342, 27)
        DateTimePickerDesde.Name = "DateTimePickerDesde"
        DateTimePickerDesde.Size = New Size(200, 23)
        DateTimePickerDesde.TabIndex = 5
        ' 
        ' DateTimePickerHasta
        ' 
        DateTimePickerHasta.Anchor = AnchorStyles.None
        DateTimePickerHasta.Location = New Point(342, 73)
        DateTimePickerHasta.Name = "DateTimePickerHasta"
        DateTimePickerHasta.Size = New Size(200, 23)
        DateTimePickerHasta.TabIndex = 6
        ' 
        ' DataGridViewDetalles
        ' 
        DataGridViewDetalles.Anchor = AnchorStyles.None
        DataGridViewDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewDetalles.Location = New Point(451, 241)
        DataGridViewDetalles.Name = "DataGridViewDetalles"
        DataGridViewDetalles.Size = New Size(442, 257)
        DataGridViewDetalles.TabIndex = 7
        ' 
        ' DataGridViewVentas
        ' 
        DataGridViewVentas.Anchor = AnchorStyles.None
        DataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewVentas.Location = New Point(12, 241)
        DataGridViewVentas.Name = "DataGridViewVentas"
        DataGridViewVentas.Size = New Size(402, 257)
        DataGridViewVentas.TabIndex = 8
        ' 
        ' TextBoxTotal
        ' 
        TextBoxTotal.Anchor = AnchorStyles.None
        TextBoxTotal.Location = New Point(382, 166)
        TextBoxTotal.Name = "TextBoxTotal"
        TextBoxTotal.PlaceholderText = "Filtrar por Total"
        TextBoxTotal.Size = New Size(121, 23)
        TextBoxTotal.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(186, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 15)
        Label1.TabIndex = 10
        Label1.Text = "Seleccionar Fecha Desde"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(188, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 15)
        Label2.TabIndex = 11
        Label2.Text = "Seleccionar Fecha Hasta"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(38, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(259, 15)
        Label3.TabIndex = 12
        Label3.Text = "Seleccione Apartir De Que Monto Quiere Buscar"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Location = New Point(188, 128)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 15)
        Label4.TabIndex = 13
        Label4.Text = "Seleccione el Cliente"
        ' 
        ' BuscadorVentasFM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(914, 510)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBoxTotal)
        Controls.Add(DataGridViewVentas)
        Controls.Add(DataGridViewDetalles)
        Controls.Add(DateTimePickerHasta)
        Controls.Add(DateTimePickerDesde)
        Controls.Add(ButtonBuscar)
        Controls.Add(ComboClientes)
        Name = "BuscadorVentasFM"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BuscadorVentasFM"
        CType(DataGridViewDetalles, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboClientes As ComboBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents DateTimePickerDesde As DateTimePicker
    Friend WithEvents DateTimePickerHasta As DateTimePicker
    Friend WithEvents DataGridViewDetalles As DataGridView
    Friend WithEvents DataGridViewVentas As DataGridView
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
