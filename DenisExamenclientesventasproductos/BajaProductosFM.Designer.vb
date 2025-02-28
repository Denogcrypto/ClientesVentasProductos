<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BajaProductosFM
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
        TextBox1 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(416, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 0
        Label1.Text = "ID Producto"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.Location = New Point(397, 177)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(367, 233)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 53)
        Button1.TabIndex = 2
        Button1.Text = "Eliminar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' BajaProductosFM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(914, 510)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "BajaProductosFM"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BajadeProductos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
