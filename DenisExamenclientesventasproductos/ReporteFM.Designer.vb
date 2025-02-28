<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteFM
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
        ButtonGenerarReporteVentas = New Button()
        ButtonGenerarReporteProductos = New Button()
        SuspendLayout()
        ' 
        ' ButtonGenerarReporteVentas
        ' 
        ButtonGenerarReporteVentas.Anchor = AnchorStyles.None
        ButtonGenerarReporteVentas.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        ButtonGenerarReporteVentas.ForeColor = Color.White
        ButtonGenerarReporteVentas.Location = New Point(270, 119)
        ButtonGenerarReporteVentas.Name = "ButtonGenerarReporteVentas"
        ButtonGenerarReporteVentas.Size = New Size(369, 66)
        ButtonGenerarReporteVentas.TabIndex = 0
        ButtonGenerarReporteVentas.Text = "Generar Reporte de Ventas"
        ButtonGenerarReporteVentas.UseVisualStyleBackColor = False
        ' 
        ' ButtonGenerarReporteProductos
        ' 
        ButtonGenerarReporteProductos.Anchor = AnchorStyles.None
        ButtonGenerarReporteProductos.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        ButtonGenerarReporteProductos.ForeColor = Color.White
        ButtonGenerarReporteProductos.Location = New Point(270, 261)
        ButtonGenerarReporteProductos.Name = "ButtonGenerarReporteProductos"
        ButtonGenerarReporteProductos.Size = New Size(369, 66)
        ButtonGenerarReporteProductos.TabIndex = 1
        ButtonGenerarReporteProductos.Text = "Generar Reporte de Productos"
        ButtonGenerarReporteProductos.UseVisualStyleBackColor = False
        ' 
        ' ReporteFM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(914, 510)
        Controls.Add(ButtonGenerarReporteProductos)
        Controls.Add(ButtonGenerarReporteVentas)
        Name = "ReporteFM"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReporteFM"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ButtonGenerarReporteVentas As Button
    Friend WithEvents ButtonGenerarReporteProductos As Button
End Class
