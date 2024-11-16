<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvClientes = New DataGridView()
        txRut = New TextBox()
        txNombre = New TextBox()
        txApellidoM = New TextBox()
        txApellidoP = New TextBox()
        txDireccion = New TextBox()
        cmTelefono = New ComboBox()
        cmComuna = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btAgregar_Click = New Button()
        btActualizar = New Button()
        btEliminar_Click = New Button()
        CType(dgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvClientes
        ' 
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvClientes.Location = New Point(271, 39)
        dgvClientes.Name = "dgvClientes"
        dgvClientes.Size = New Size(444, 288)
        dgvClientes.TabIndex = 0
        ' 
        ' txRut
        ' 
        txRut.Location = New Point(27, 39)
        txRut.Name = "txRut"
        txRut.Size = New Size(162, 23)
        txRut.TabIndex = 1
        ' 
        ' txNombre
        ' 
        txNombre.Location = New Point(27, 84)
        txNombre.Name = "txNombre"
        txNombre.Size = New Size(162, 23)
        txNombre.TabIndex = 2
        ' 
        ' txApellidoM
        ' 
        txApellidoM.Location = New Point(27, 191)
        txApellidoM.Name = "txApellidoM"
        txApellidoM.Size = New Size(162, 23)
        txApellidoM.TabIndex = 3
        ' 
        ' txApellidoP
        ' 
        txApellidoP.Location = New Point(27, 138)
        txApellidoP.Name = "txApellidoP"
        txApellidoP.Size = New Size(162, 23)
        txApellidoP.TabIndex = 4
        ' 
        ' txDireccion
        ' 
        txDireccion.Location = New Point(27, 247)
        txDireccion.Name = "txDireccion"
        txDireccion.Size = New Size(162, 23)
        txDireccion.TabIndex = 5
        ' 
        ' cmTelefono
        ' 
        cmTelefono.FormattingEnabled = True
        cmTelefono.Location = New Point(27, 304)
        cmTelefono.Name = "cmTelefono"
        cmTelefono.Size = New Size(162, 23)
        cmTelefono.TabIndex = 6
        ' 
        ' cmComuna
        ' 
        cmComuna.FormattingEnabled = True
        cmComuna.Location = New Point(27, 357)
        cmComuna.Name = "cmComuna"
        cmComuna.Size = New Size(162, 23)
        cmComuna.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 8
        Label1.Text = "Rut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 9
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 15)
        Label3.TabIndex = 10
        Label3.Text = "Apellido Paterno"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 15)
        Label4.TabIndex = 11
        Label4.Text = "Apellido Materno"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 12
        Label5.Text = "Direccion"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(27, 273)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 15)
        Label6.TabIndex = 13
        Label6.Text = "Telefono"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(27, 330)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 15)
        Label7.TabIndex = 14
        Label7.Text = "Comuna"
        ' 
        ' btAgregar_Click
        ' 
        btAgregar_Click.Location = New Point(12, 411)
        btAgregar_Click.Name = "btAgregar_Click"
        btAgregar_Click.Size = New Size(95, 34)
        btAgregar_Click.TabIndex = 15
        btAgregar_Click.Text = "Guardar"
        btAgregar_Click.UseVisualStyleBackColor = True
        ' 
        ' btActualizar
        ' 
        btActualizar.Location = New Point(128, 411)
        btActualizar.Name = "btActualizar"
        btActualizar.Size = New Size(95, 34)
        btActualizar.TabIndex = 16
        btActualizar.Text = "Actulizar"
        btActualizar.UseVisualStyleBackColor = True
        ' 
        ' btEliminar_Click
        ' 
        btEliminar_Click.Location = New Point(247, 411)
        btEliminar_Click.Name = "btEliminar_Click"
        btEliminar_Click.Size = New Size(95, 34)
        btEliminar_Click.TabIndex = 17
        btEliminar_Click.Text = "Eliminar"
        btEliminar_Click.UseVisualStyleBackColor = True
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(762, 487)
        Controls.Add(btEliminar_Click)
        Controls.Add(btActualizar)
        Controls.Add(btAgregar_Click)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmComuna)
        Controls.Add(cmTelefono)
        Controls.Add(txDireccion)
        Controls.Add(txApellidoP)
        Controls.Add(txApellidoM)
        Controls.Add(txNombre)
        Controls.Add(txRut)
        Controls.Add(dgvClientes)
        Name = "Form8"
        Text = "Form8"
        CType(dgvClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents txRut As TextBox
    Friend WithEvents txNombre As TextBox
    Friend WithEvents txApellidoM As TextBox
    Friend WithEvents txApellidoP As TextBox
    Friend WithEvents txDireccion As TextBox
    Friend WithEvents cmTelefono As ComboBox
    Friend WithEvents cmComuna As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btAgregar_Click As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btEliminar_Click As Button
End Class
