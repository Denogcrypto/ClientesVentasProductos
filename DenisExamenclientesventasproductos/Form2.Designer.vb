<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Button1.Location = New Point(338, 62)
        Button1.Name = "Button1"
        Button1.Size = New Size(227, 79)
        Button1.TabIndex = 3
        Button1.Text = "Ingreso de Clientes"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(338, 161)
        Button2.Name = "Button2"
        Button2.Size = New Size(227, 79)
        Button2.TabIndex = 4
        Button2.Text = "Baja de Clientes"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(338, 265)
        Button3.Name = "Button3"
        Button3.Size = New Size(227, 79)
        Button3.TabIndex = 5
        Button3.Text = "Buscar Clientes"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.None
        Button4.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(338, 377)
        Button4.Name = "Button4"
        Button4.Size = New Size(227, 79)
        Button4.TabIndex = 6
        Button4.Text = "Modificar Cliente"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(407, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 17)
        Label1.TabIndex = 7
        Label1.Text = "Menu Clientes"
        ' 
        ' Form2
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
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menuclientes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
End Class
