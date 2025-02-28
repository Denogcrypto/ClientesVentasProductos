<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        txtBuscar = New TextBox()
        btnBuscarcliente = New Button()
        dataGridViewClientes = New DataGridView()
        Label2 = New Label()
        CType(dataGridViewClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.None
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(284, 49)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(271, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(351, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 15)
        Label1.TabIndex = 1
        Label1.Text = "Seleccione una Opción"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Anchor = AnchorStyles.None
        txtBuscar.Location = New Point(351, 121)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(128, 23)
        txtBuscar.TabIndex = 2
        ' 
        ' btnBuscarcliente
        ' 
        btnBuscarcliente.Anchor = AnchorStyles.None
        btnBuscarcliente.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(41))
        btnBuscarcliente.ForeColor = Color.White
        btnBuscarcliente.Location = New Point(295, 165)
        btnBuscarcliente.Name = "btnBuscarcliente"
        btnBuscarcliente.Size = New Size(234, 44)
        btnBuscarcliente.TabIndex = 3
        btnBuscarcliente.Text = "Buscar"
        btnBuscarcliente.UseVisualStyleBackColor = False
        ' 
        ' dataGridViewClientes
        ' 
        dataGridViewClientes.Anchor = AnchorStyles.None
        dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewClientes.Location = New Point(164, 231)
        dataGridViewClientes.Name = "dataGridViewClientes"
        dataGridViewClientes.Size = New Size(502, 201)
        dataGridViewClientes.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(183, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(506, 15)
        Label2.TabIndex = 5
        Label2.Text = "Si conoce el dato, ingréselo. En caso contrario, una vez seleccionada la opción, presione Buscar"
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(914, 510)
        Controls.Add(Label2)
        Controls.Add(dataGridViewClientes)
        Controls.Add(btnBuscarcliente)
        Controls.Add(txtBuscar)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Name = "Form9"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BuscarClientes"
        CType(dataGridViewClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscarcliente As Button
    Friend WithEvents dataGridViewClientes As DataGridView
    Friend WithEvents Label2 As Label
End Class
