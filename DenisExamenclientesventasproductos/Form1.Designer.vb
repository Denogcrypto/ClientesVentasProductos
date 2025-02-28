<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        pbEstadoConexion = New PictureBox()
        Timer1 = New Timer(components)
        CType(pbEstadoConexion, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(32, 59)
        Button1.Name = "Button1"
        Button1.Size = New Size(215, 70)
        Button1.TabIndex = 0
        Button1.Text = "Clientes"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(32, 151)
        Button2.Name = "Button2"
        Button2.Size = New Size(215, 70)
        Button2.TabIndex = 1
        Button2.Text = "Productos"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(32, 244)
        Button3.Name = "Button3"
        Button3.Size = New Size(215, 70)
        Button3.TabIndex = 2
        Button3.Text = "Ventas"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom
        Button4.BackColor = SystemColors.ButtonFace
        Button4.Location = New Point(557, 440)
        Button4.Name = "Button4"
        Button4.Size = New Size(274, 58)
        Button4.TabIndex = 3
        Button4.Text = "Estado de Conexion"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.None
        Button5.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(32, 341)
        Button5.Name = "Button5"
        Button5.Size = New Size(215, 70)
        Button5.TabIndex = 4
        Button5.Text = "Reportes"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' pbEstadoConexion
        ' 
        pbEstadoConexion.Anchor = AnchorStyles.Bottom
        pbEstadoConexion.BackColor = Color.Transparent
        pbEstadoConexion.Location = New Point(837, 440)
        pbEstadoConexion.Name = "pbEstadoConexion"
        pbEstadoConexion.Size = New Size(65, 58)
        pbEstadoConexion.SizeMode = PictureBoxSizeMode.Zoom
        pbEstadoConexion.TabIndex = 5
        pbEstadoConexion.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(914, 510)
        Controls.Add(pbEstadoConexion)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inicio"
        CType(pbEstadoConexion, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents pbEstadoConexion As PictureBox
    Friend WithEvents Timer1 As Timer

End Class
