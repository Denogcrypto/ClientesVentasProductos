<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarVentasFM
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
        ButtonEliminar = New Button()
        CType(DataGridViewVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewVentas
        ' 
        DataGridViewVentas.Anchor = AnchorStyles.None
        DataGridViewVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewVentas.Location = New Point(40, 23)
        DataGridViewVentas.Name = "DataGridViewVentas"
        DataGridViewVentas.Size = New Size(747, 332)
        DataGridViewVentas.TabIndex = 0
        ' 
        ' ButtonEliminar
        ' 
        ButtonEliminar.Anchor = AnchorStyles.None
        ButtonEliminar.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        ButtonEliminar.ForeColor = Color.White
        ButtonEliminar.Location = New Point(336, 381)
        ButtonEliminar.Name = "ButtonEliminar"
        ButtonEliminar.Size = New Size(156, 67)
        ButtonEliminar.TabIndex = 1
        ButtonEliminar.Text = "Eliminar"
        ButtonEliminar.UseVisualStyleBackColor = False
        ' 
        ' EliminarVentasFM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(914, 510)
        Controls.Add(ButtonEliminar)
        Controls.Add(DataGridViewVentas)
        Name = "EliminarVentasFM"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EliminarVentas"
        CType(DataGridViewVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridViewVentas As DataGridView
    Friend WithEvents ButtonEliminar As Button
End Class
