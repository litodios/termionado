<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Panel1 = New Panel()
        btvolver = New Button()
        btbuscar = New Button()
        Label2 = New Label()
        txtidproducto = New TextBox()
        btguardar = New Button()
        btactulizar = New Button()
        bteliminar = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtstock = New TextBox()
        txtprecio = New TextBox()
        txtproveedor = New TextBox()
        txtnombre = New TextBox()
        DataGridViewrepuestos = New DataGridView()
        Label3 = New Label()
        Label1 = New Label()
        cmbidrepuesto = New ComboBox()
        Panel1.SuspendLayout()
        CType(DataGridViewrepuestos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.Controls.Add(btvolver)
        Panel1.Controls.Add(btbuscar)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtidproducto)
        Panel1.Controls.Add(btguardar)
        Panel1.Controls.Add(btactulizar)
        Panel1.Controls.Add(bteliminar)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtstock)
        Panel1.Controls.Add(txtprecio)
        Panel1.Controls.Add(txtproveedor)
        Panel1.Controls.Add(txtnombre)
        Panel1.Controls.Add(DataGridViewrepuestos)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(cmbidrepuesto)
        Panel1.Location = New Point(38, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(895, 783)
        Panel1.TabIndex = 0
        ' 
        ' btvolver
        ' 
        btvolver.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btvolver.Location = New Point(0, 3)
        btvolver.Name = "btvolver"
        btvolver.Size = New Size(94, 29)
        btvolver.TabIndex = 24
        btvolver.Text = "Volver"
        btvolver.UseVisualStyleBackColor = False
        ' 
        ' btbuscar
        ' 
        btbuscar.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btbuscar.Font = New Font("Yu Gothic", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btbuscar.Location = New Point(652, 232)
        btbuscar.Name = "btbuscar"
        btbuscar.Size = New Size(103, 47)
        btbuscar.TabIndex = 23
        btbuscar.Text = "BUSCAR"
        btbuscar.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Algerian", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(354, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 18)
        Label2.TabIndex = 22
        Label2.Text = "ID DEL PRODUCTO"
        ' 
        ' txtidproducto
        ' 
        txtidproducto.Location = New Point(497, 136)
        txtidproducto.Name = "txtidproducto"
        txtidproducto.Size = New Size(149, 23)
        txtidproducto.TabIndex = 21
        ' 
        ' btguardar
        ' 
        btguardar.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btguardar.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btguardar.ForeColor = Color.Black
        btguardar.Location = New Point(652, 47)
        btguardar.Name = "btguardar"
        btguardar.Size = New Size(103, 44)
        btguardar.TabIndex = 20
        btguardar.Text = "GUARDAR"
        btguardar.UseVisualStyleBackColor = False
        ' 
        ' btactulizar
        ' 
        btactulizar.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btactulizar.Font = New Font("Yu Gothic", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btactulizar.Location = New Point(652, 110)
        btactulizar.Name = "btactulizar"
        btactulizar.Size = New Size(103, 44)
        btactulizar.TabIndex = 19
        btactulizar.Text = "ACTUALIZAR"
        btactulizar.UseVisualStyleBackColor = False
        ' 
        ' bteliminar
        ' 
        bteliminar.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        bteliminar.Font = New Font("Yu Gothic", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        bteliminar.Location = New Point(652, 172)
        bteliminar.Name = "bteliminar"
        bteliminar.Size = New Size(103, 44)
        bteliminar.TabIndex = 18
        bteliminar.Text = "ELIMINAR"
        bteliminar.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Black", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(277, 368)
        Label8.Name = "Label8"
        Label8.Size = New Size(266, 30)
        Label8.TabIndex = 15
        Label8.Text = "LISTA DE REPUESTOS"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Algerian", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(21, 223)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 18)
        Label7.TabIndex = 13
        Label7.Text = "PROVEEDOR"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Algerian", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(4, 169)
        Label6.Name = "Label6"
        Label6.Size = New Size(136, 18)
        Label6.TabIndex = 12
        Label6.Text = "PRECIO UNITARIO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Algerian", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(3, 120)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 18)
        Label5.TabIndex = 11
        Label5.Text = "CANTIDAD STOCK"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Algerian", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(0, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(151, 18)
        Label4.TabIndex = 10
        Label4.Text = "NOMBRE REPUESTO"
        ' 
        ' txtstock
        ' 
        txtstock.Location = New Point(152, 115)
        txtstock.Name = "txtstock"
        txtstock.Size = New Size(181, 23)
        txtstock.TabIndex = 9
        ' 
        ' txtprecio
        ' 
        txtprecio.Location = New Point(152, 164)
        txtprecio.Name = "txtprecio"
        txtprecio.Size = New Size(181, 23)
        txtprecio.TabIndex = 8
        ' 
        ' txtproveedor
        ' 
        txtproveedor.Location = New Point(152, 215)
        txtproveedor.Name = "txtproveedor"
        txtproveedor.Size = New Size(181, 23)
        txtproveedor.TabIndex = 7
        ' 
        ' txtnombre
        ' 
        txtnombre.Location = New Point(152, 59)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(181, 23)
        txtnombre.TabIndex = 6
        ' 
        ' DataGridViewrepuestos
        ' 
        DataGridViewrepuestos.BackgroundColor = Color.Maroon
        DataGridViewrepuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewrepuestos.Location = New Point(21, 520)
        DataGridViewrepuestos.Name = "DataGridViewrepuestos"
        DataGridViewrepuestos.Size = New Size(559, 238)
        DataGridViewrepuestos.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Algerian", 14.25F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(91, 414)
        Label3.Name = "Label3"
        Label3.Size = New Size(603, 21)
        Label3.TabIndex = 4
        Label3.Text = "BUSQUE EN EL ID DEL PRODUCTO O EL NOMBRE DEL PRODUCTO"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(91, 305)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 21)
        Label1.TabIndex = 2
        Label1.Text = "ID DE PRODUCTO"
        ' 
        ' cmbidrepuesto
        ' 
        cmbidrepuesto.FormattingEnabled = True
        cmbidrepuesto.Location = New Point(288, 303)
        cmbidrepuesto.Name = "cmbidrepuesto"
        cmbidrepuesto.Size = New Size(228, 23)
        cmbidrepuesto.TabIndex = 1
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(936, 796)
        Controls.Add(Panel1)
        MdiChildrenMinimizedAnchorBottom = False
        Name = "Form5"
        Text = "TALLER"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridViewrepuestos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbidrepuesto As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewrepuestos As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents btguardar As Button
    Friend WithEvents btactulizar As Button
    Friend WithEvents bteliminar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents btbuscar As Button
    Friend WithEvents btvolver As Button
End Class
