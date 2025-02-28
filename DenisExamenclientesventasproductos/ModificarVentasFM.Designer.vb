<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarVentasFM
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
        DataGridViewVentas = New DataGridView()
        ButtonModificar = New Button()
        CType(DataGridViewVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewVentas
        ' 
        DataGridViewVentas.Anchor = AnchorStyles.None
        DataGridViewVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewVentas.Location = New Point(155, 73)
        DataGridViewVentas.Name = "DataGridViewVentas"
        DataGridViewVentas.Size = New Size(578, 150)
        DataGridViewVentas.TabIndex = 0
        ' 
        ' ButtonModificar
        ' 
        ButtonModificar.Anchor = AnchorStyles.None
        ButtonModificar.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        ButtonModificar.ForeColor = Color.White
        ButtonModificar.Location = New Point(333, 285)
        ButtonModificar.Name = "ButtonModificar"
        ButtonModificar.Size = New Size(211, 85)
        ButtonModificar.TabIndex = 1
        ButtonModificar.Text = "Modificar Ventas"
        ButtonModificar.UseVisualStyleBackColor = False
        ' 
        ' ModificarVentasFM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(914, 510)
        Controls.Add(ButtonModificar)
        Controls.Add(DataGridViewVentas)
        Name = "ModificarVentasFM"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ModificarVentas"
        CType(DataGridViewVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridViewVentas As DataGridView
    Friend WithEvents ButtonModificar As Button
End Class
