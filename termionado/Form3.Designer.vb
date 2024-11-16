<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        panel1 = New Panel()
        btvolver = New Button()
        DataGridView1 = New DataGridView()
        btconsulta = New Button()
        Label4 = New Label()
        txtrut = New TextBox()
        btborrar = New Button()
        bteditar = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cmbtipo = New ComboBox()
        btagregar = New Button()
        txtcontraseña = New TextBox()
        txtusuario = New TextBox()
        panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panel1
        ' 
        panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        panel1.Controls.Add(btvolver)
        panel1.Controls.Add(DataGridView1)
        panel1.Controls.Add(btconsulta)
        panel1.Controls.Add(Label4)
        panel1.Controls.Add(txtrut)
        panel1.Controls.Add(btborrar)
        panel1.Controls.Add(bteditar)
        panel1.Controls.Add(Label3)
        panel1.Controls.Add(Label2)
        panel1.Controls.Add(Label1)
        panel1.Controls.Add(cmbtipo)
        panel1.Controls.Add(btagregar)
        panel1.Controls.Add(txtcontraseña)
        panel1.Controls.Add(txtusuario)
        panel1.Location = New Point(34, 35)
        panel1.Name = "panel1"
        panel1.Size = New Size(503, 623)
        panel1.TabIndex = 1
        ' 
        ' btvolver
        ' 
        btvolver.ImeMode = ImeMode.NoControl
        btvolver.Location = New Point(5, 3)
        btvolver.Name = "btvolver"
        btvolver.Size = New Size(81, 34)
        btvolver.TabIndex = 13
        btvolver.Text = "Volver"
        btvolver.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Lavender
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(34, 374)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(439, 228)
        DataGridView1.TabIndex = 12
        ' 
        ' btconsulta
        ' 
        btconsulta.Font = New Font("Yu Gothic", 11.25F, FontStyle.Bold)
        btconsulta.ImeMode = ImeMode.NoControl
        btconsulta.Location = New Point(373, 27)
        btconsulta.Name = "btconsulta"
        btconsulta.Size = New Size(114, 43)
        btconsulta.TabIndex = 11
        btconsulta.Text = "CONSULTAR" & vbCrLf & " "
        btconsulta.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic Medium", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ImeMode = ImeMode.NoControl
        Label4.Location = New Point(34, 49)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 21)
        Label4.TabIndex = 10
        Label4.Text = "RUT"
        ' 
        ' txtrut
        ' 
        txtrut.Location = New Point(167, 47)
        txtrut.Name = "txtrut"
        txtrut.Size = New Size(163, 23)
        txtrut.TabIndex = 9
        ' 
        ' btborrar
        ' 
        btborrar.Font = New Font("Yu Gothic", 11.25F, FontStyle.Bold)
        btborrar.ImeMode = ImeMode.NoControl
        btborrar.Location = New Point(66, 263)
        btborrar.Name = "btborrar"
        btborrar.Size = New Size(114, 43)
        btborrar.TabIndex = 8
        btborrar.Text = "BORRAR"
        btborrar.UseVisualStyleBackColor = True
        ' 
        ' bteditar
        ' 
        bteditar.Font = New Font("Yu Gothic", 11.25F, FontStyle.Bold)
        bteditar.ImeMode = ImeMode.NoControl
        bteditar.Location = New Point(216, 263)
        bteditar.Name = "bteditar"
        bteditar.Size = New Size(114, 43)
        bteditar.TabIndex = 7
        bteditar.Text = "EDITAR"
        bteditar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic Medium", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ImeMode = ImeMode.NoControl
        Label3.Location = New Point(34, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 21)
        Label3.TabIndex = 6
        Label3.Text = "TIPO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic Medium", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ImeMode = ImeMode.NoControl
        Label2.Location = New Point(22, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 21)
        Label2.TabIndex = 5
        Label2.Text = "CONSTRASEÑA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic Medium", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(22, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 21)
        Label1.TabIndex = 4
        Label1.Text = "USUARIO"
        ' 
        ' cmbtipo
        ' 
        cmbtipo.FormattingEnabled = True
        cmbtipo.Location = New Point(167, 189)
        cmbtipo.Name = "cmbtipo"
        cmbtipo.Size = New Size(176, 23)
        cmbtipo.TabIndex = 3
        ' 
        ' btagregar
        ' 
        btagregar.Font = New Font("Yu Gothic", 11.25F, FontStyle.Bold)
        btagregar.ImeMode = ImeMode.NoControl
        btagregar.Location = New Point(361, 263)
        btagregar.Name = "btagregar"
        btagregar.Size = New Size(114, 43)
        btagregar.TabIndex = 2
        btagregar.Text = "AGREGAR"
        btagregar.UseVisualStyleBackColor = True
        ' 
        ' txtcontraseña
        ' 
        txtcontraseña.Location = New Point(167, 147)
        txtcontraseña.Name = "txtcontraseña"
        txtcontraseña.Size = New Size(163, 23)
        txtcontraseña.TabIndex = 1
        ' 
        ' txtusuario
        ' 
        txtusuario.Location = New Point(167, 100)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(234, 23)
        txtusuario.TabIndex = 0
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(571, 692)
        Controls.Add(panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form3"
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panel1 As Panel
    Friend WithEvents btvolver As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btconsulta As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtrut As TextBox
    Friend WithEvents btborrar As Button
    Friend WithEvents bteditar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents btagregar As Button
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents txtusuario As TextBox
End Class
