﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        TXUSUARIO = New TextBox()
        TXCONTRASEÑA = New TextBox()
        Panel1 = New Panel()
        BTINGRESAR = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        MenuStrip2 = New MenuStrip()
        MENUEMPLEADOToolStripMenuItem = New ToolStripMenuItem()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        Panel1.SuspendLayout()
        MenuStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TXUSUARIO
        ' 
        TXUSUARIO.Location = New Point(176, 146)
        TXUSUARIO.Name = "TXUSUARIO"
        TXUSUARIO.Size = New Size(217, 23)
        TXUSUARIO.TabIndex = 0
        ' 
        ' TXCONTRASEÑA
        ' 
        TXCONTRASEÑA.Location = New Point(176, 190)
        TXCONTRASEÑA.Name = "TXCONTRASEÑA"
        TXCONTRASEÑA.Size = New Size(217, 23)
        TXCONTRASEÑA.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.White
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(BTINGRESAR)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TXUSUARIO)
        Panel1.Controls.Add(TXCONTRASEÑA)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(MenuStrip2)
        Panel1.Location = New Point(3, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(431, 329)
        Panel1.TabIndex = 2
        ' 
        ' BTINGRESAR
        ' 
        BTINGRESAR.AutoSize = True
        BTINGRESAR.BackColor = Color.Silver
        BTINGRESAR.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTINGRESAR.ForeColor = SystemColors.ButtonFace
        BTINGRESAR.Location = New Point(115, 230)
        BTINGRESAR.Name = "BTINGRESAR"
        BTINGRESAR.Size = New Size(205, 51)
        BTINGRESAR.TabIndex = 6
        BTINGRESAR.Text = "INGRESAR"
        BTINGRESAR.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.LightGray
        Label4.Font = New Font("Yu Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(218, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 21)
        Label4.TabIndex = 5
        Label4.Text = "MENU"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Yu Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(178, 21)
        Label3.TabIndex = 4
        Label3.Text = "INGRESO DE TALLER"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(53, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 17)
        Label2.TabIndex = 3
        Label2.Text = "CONTRASEÑA:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(84, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 17)
        Label1.TabIndex = 2
        Label1.Text = "USUARIO:"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Silver
        MenuStrip1.Location = New Point(0, 24)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(431, 24)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.DimGray
        MenuStrip2.Items.AddRange(New ToolStripItem() {MENUEMPLEADOToolStripMenuItem, MenuToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(431, 24)
        MenuStrip2.TabIndex = 8
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' MENUEMPLEADOToolStripMenuItem
        ' 
        MENUEMPLEADOToolStripMenuItem.BackColor = Color.Gray
        MENUEMPLEADOToolStripMenuItem.Name = "MENUEMPLEADOToolStripMenuItem"
        MENUEMPLEADOToolStripMenuItem.Size = New Size(117, 20)
        MENUEMPLEADOToolStripMenuItem.Text = "MENU EMPLEADO"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.BackColor = Color.Silver
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(100, 20)
        MenuToolStripMenuItem.Text = "MENU CLIENTE"
        ' 
        ' Form1
        ' 
        AcceptButton = BTINGRESAR
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(435, 345)
        Controls.Add(Panel1)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        Text = "Login_usuario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TXUSUARIO As TextBox
    Friend WithEvents TXCONTRASEÑA As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTINGRESAR As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MENUEMPLEADOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem

End Class
