<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarVentaFM
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
        DataGridViewVenta = New DataGridView()
        ButtonAplicar = New Button()
        Label1 = New Label()
        CType(DataGridViewVenta, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewVenta
        ' 
        DataGridViewVenta.Anchor = AnchorStyles.None
        DataGridViewVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewVenta.Location = New Point(146, 121)
        DataGridViewVenta.Name = "DataGridViewVenta"
        DataGridViewVenta.Size = New Size(598, 200)
        DataGridViewVenta.TabIndex = 0
        ' 
        ' ButtonAplicar
        ' 
        ButtonAplicar.Anchor = AnchorStyles.None
        ButtonAplicar.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        ButtonAplicar.ForeColor = Color.White
        ButtonAplicar.Location = New Point(350, 342)
        ButtonAplicar.Name = "ButtonAplicar"
        ButtonAplicar.Size = New Size(162, 53)
        ButtonAplicar.TabIndex = 1
        ButtonAplicar.Text = "Actualizar venta"
        ButtonAplicar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(319, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 15)
        Label1.TabIndex = 2
        Label1.Text = "Seleccione los Valores que Necesita Modificar"
        ' 
        ' EditarVentaFM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(914, 510)
        Controls.Add(Label1)
        Controls.Add(ButtonAplicar)
        Controls.Add(DataGridViewVenta)
        Name = "EditarVentaFM"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EditarVentaFM"
        CType(DataGridViewVenta, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridViewVenta As DataGridView
    Friend WithEvents ButtonAplicar As Button
    Friend WithEvents Label1 As Label
End Class
