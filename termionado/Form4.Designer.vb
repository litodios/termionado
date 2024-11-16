<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Button2 = New Button()
        Button1 = New Button()
        btvolver = New Button()
        btventa = New Button()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        btrepuesto = New Button()
        btusuario = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btvolver)
        Panel1.Controls.Add(btventa)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btrepuesto)
        Panel1.Controls.Add(btusuario)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(125, 47)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(560, 677)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(204, 259)
        Button2.Name = "Button2"
        Button2.Size = New Size(134, 45)
        Button2.TabIndex = 10
        Button2.Text = "CLIENTE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Black", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(204, 164)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 45)
        Button1.TabIndex = 9
        Button1.Text = "ESTADOS SINIESTROS"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btvolver
        ' 
        btvolver.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btvolver.Location = New Point(0, 3)
        btvolver.Name = "btvolver"
        btvolver.Size = New Size(105, 41)
        btvolver.TabIndex = 8
        btvolver.Text = "Volver"
        btvolver.UseVisualStyleBackColor = False
        ' 
        ' btventa
        ' 
        btventa.BackColor = Color.Lime
        btventa.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btventa.FlatStyle = FlatStyle.Flat
        btventa.Font = New Font("Yu Gothic", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btventa.Location = New Point(373, 259)
        btventa.Name = "btventa"
        btventa.Size = New Size(134, 45)
        btventa.TabIndex = 7
        btventa.Text = "RESUMEN DE VENTA"
        btventa.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(13, 399)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(209, 203)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(304, 399)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(202, 203)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stencil", 14.25F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(440, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 22)
        Label3.TabIndex = 4
        Label3.Text = "MENU"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 14.25F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(25, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 22)
        Label2.TabIndex = 3
        Label2.Text = "MENU"
        ' 
        ' btrepuesto
        ' 
        btrepuesto.BackColor = Color.Blue
        btrepuesto.FlatStyle = FlatStyle.Popup
        btrepuesto.Font = New Font("Yu Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btrepuesto.Location = New Point(373, 164)
        btrepuesto.Name = "btrepuesto"
        btrepuesto.Size = New Size(133, 45)
        btrepuesto.TabIndex = 2
        btrepuesto.Text = "Repuesto"
        btrepuesto.UseVisualStyleBackColor = False
        ' 
        ' btusuario
        ' 
        btusuario.BackColor = Color.Red
        btusuario.FlatStyle = FlatStyle.Flat
        btusuario.Font = New Font("Yu Gothic", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btusuario.Location = New Point(25, 164)
        btusuario.Name = "btusuario"
        btusuario.Size = New Size(134, 45)
        btusuario.TabIndex = 1
        btusuario.Text = "Usuario"
        btusuario.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Ravie", 15.75F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(25, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(481, 30)
        Label1.TabIndex = 0
        Label1.Text = "BIENVENIDO QUE DESEAS HACER"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(823, 751)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Form4"
        Text = "Menu "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btrepuesto As Button
    Friend WithEvents btusuario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btventa As Button
    Friend WithEvents btvolver As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
