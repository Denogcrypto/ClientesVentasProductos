<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuProductos
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(321, 61)
        Button1.Name = "Button1"
        Button1.Size = New Size(227, 79)
        Button1.TabIndex = 0
        Button1.Text = "Ingreso de Productos"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(321, 169)
        Button2.Name = "Button2"
        Button2.Size = New Size(227, 79)
        Button2.TabIndex = 1
        Button2.Text = "Baja de Productos"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(321, 279)
        Button3.Name = "Button3"
        Button3.Size = New Size(227, 79)
        Button3.TabIndex = 2
        Button3.Text = "Buscar Productos"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.None
        Button4.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(321, 387)
        Button4.Name = "Button4"
        Button4.Size = New Size(227, 79)
        Button4.TabIndex = 3
        Button4.Text = "Modificar Productos"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(382, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 17)
        Label1.TabIndex = 4
        Label1.Text = "Menu Productos"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(914, 510)
        Controls.Add(Label1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MenuProductos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
End Class
