<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        cmbRutCompania = New ComboBox()
        btvolver = New Button()
        Label9 = New Label()
        Label8 = New Label()
        cmbFiltroEstado = New ComboBox()
        txtrutbuscar = New TextBox()
        Btbuscar = New Button()
        btconsultar = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dgvSiniestro = New DataGridView()
        btactualizar = New Button()
        btguardar = New Button()
        cmbestado_seguro = New ComboBox()
        txrut = New TextBox()
        dtpFechaSiniestro = New DateTimePicker()
        cmbestado_siniestro = New ComboBox()
        txdetalle = New TextBox()
        txsiniestroid = New TextBox()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel1.SuspendLayout()
        CType(dgvSiniestro, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Lavender
        Panel1.Controls.Add(cmbRutCompania)
        Panel1.Controls.Add(btvolver)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(cmbFiltroEstado)
        Panel1.Controls.Add(txtrutbuscar)
        Panel1.Controls.Add(Btbuscar)
        Panel1.Controls.Add(btconsultar)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(dgvSiniestro)
        Panel1.Controls.Add(btactualizar)
        Panel1.Controls.Add(btguardar)
        Panel1.Controls.Add(cmbestado_seguro)
        Panel1.Controls.Add(txrut)
        Panel1.Controls.Add(dtpFechaSiniestro)
        Panel1.Controls.Add(cmbestado_siniestro)
        Panel1.Controls.Add(txdetalle)
        Panel1.Controls.Add(txsiniestroid)
        Panel1.Location = New Point(50, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1163, 574)
        Panel1.TabIndex = 0
        ' 
        ' cmbRutCompania
        ' 
        cmbRutCompania.FormattingEnabled = True
        cmbRutCompania.Location = New Point(73, 306)
        cmbRutCompania.Name = "cmbRutCompania"
        cmbRutCompania.Size = New Size(213, 23)
        cmbRutCompania.TabIndex = 25
        ' 
        ' btvolver
        ' 
        btvolver.BackColor = Color.Yellow
        btvolver.Location = New Point(3, 3)
        btvolver.Name = "btvolver"
        btvolver.Size = New Size(91, 32)
        btvolver.TabIndex = 24
        btvolver.Text = "Volver"
        btvolver.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(540, 45)
        Label9.Name = "Label9"
        Label9.Size = New Size(101, 15)
        Label9.TabIndex = 23
        Label9.Text = "Buscar por estado"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(692, 95)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 15)
        Label8.TabIndex = 22
        Label8.Text = "Buscar por rut cliente"
        ' 
        ' cmbFiltroEstado
        ' 
        cmbFiltroEstado.FormattingEnabled = True
        cmbFiltroEstado.Location = New Point(647, 37)
        cmbFiltroEstado.Name = "cmbFiltroEstado"
        cmbFiltroEstado.Size = New Size(156, 23)
        cmbFiltroEstado.TabIndex = 21
        ' 
        ' txtrutbuscar
        ' 
        txtrutbuscar.Cursor = Cursors.IBeam
        txtrutbuscar.Location = New Point(817, 88)
        txtrutbuscar.Name = "txtrutbuscar"
        txtrutbuscar.Size = New Size(138, 23)
        txtrutbuscar.TabIndex = 20
        ' 
        ' Btbuscar
        ' 
        Btbuscar.BackColor = Color.GhostWhite
        Btbuscar.Location = New Point(970, 88)
        Btbuscar.Name = "Btbuscar"
        Btbuscar.Size = New Size(92, 23)
        Btbuscar.TabIndex = 19
        Btbuscar.Text = "Buscar"
        Btbuscar.UseVisualStyleBackColor = False
        ' 
        ' btconsultar
        ' 
        btconsultar.BackColor = Color.DodgerBlue
        btconsultar.Location = New Point(159, 84)
        btconsultar.Name = "btconsultar"
        btconsultar.Size = New Size(93, 31)
        btconsultar.TabIndex = 18
        btconsultar.Text = "Consultar"
        btconsultar.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(73, 416)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 15)
        Label7.TabIndex = 17
        Label7.Text = "ESTADO DEL SEGURO"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(73, 345)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 15)
        Label6.TabIndex = 16
        Label6.Text = "RUT CLIENTE"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(73, 279)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 15)
        Label5.TabIndex = 15
        Label5.Text = "RUT COMPAÑIA"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(73, 217)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 14
        Label4.Text = "FECHA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(73, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 13
        Label3.Text = "ESTADO "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(73, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 12
        Label2.Text = "DETALLE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(73, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(21, 15)
        Label1.TabIndex = 11
        Label1.Text = " ID"
        ' 
        ' dgvSiniestro
        ' 
        dgvSiniestro.BackgroundColor = SystemColors.Info
        dgvSiniestro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSiniestro.Location = New Point(335, 123)
        dgvSiniestro.Name = "dgvSiniestro"
        dgvSiniestro.Size = New Size(727, 323)
        dgvSiniestro.TabIndex = 10
        ' 
        ' btactualizar
        ' 
        btactualizar.BackColor = Color.SkyBlue
        btactualizar.Location = New Point(204, 475)
        btactualizar.Name = "btactualizar"
        btactualizar.Size = New Size(91, 42)
        btactualizar.TabIndex = 9
        btactualizar.Text = "ACTUALIZAR"
        btactualizar.UseVisualStyleBackColor = False
        ' 
        ' btguardar
        ' 
        btguardar.BackColor = Color.SkyBlue
        btguardar.Location = New Point(75, 475)
        btguardar.Name = "btguardar"
        btguardar.Size = New Size(91, 42)
        btguardar.TabIndex = 7
        btguardar.Text = "AGREGAR"
        btguardar.UseVisualStyleBackColor = False
        ' 
        ' cmbestado_seguro
        ' 
        cmbestado_seguro.FormattingEnabled = True
        cmbestado_seguro.Location = New Point(73, 446)
        cmbestado_seguro.Name = "cmbestado_seguro"
        cmbestado_seguro.Size = New Size(213, 23)
        cmbestado_seguro.TabIndex = 6
        ' 
        ' txrut
        ' 
        txrut.Cursor = Cursors.IBeam
        txrut.Location = New Point(73, 378)
        txrut.Name = "txrut"
        txrut.Size = New Size(213, 23)
        txrut.TabIndex = 5
        ' 
        ' dtpFechaSiniestro
        ' 
        dtpFechaSiniestro.Location = New Point(73, 235)
        dtpFechaSiniestro.Name = "dtpFechaSiniestro"
        dtpFechaSiniestro.Size = New Size(213, 23)
        dtpFechaSiniestro.TabIndex = 3
        ' 
        ' cmbestado_siniestro
        ' 
        cmbestado_siniestro.FormattingEnabled = True
        cmbestado_siniestro.Location = New Point(73, 191)
        cmbestado_siniestro.Name = "cmbestado_siniestro"
        cmbestado_siniestro.Size = New Size(213, 23)
        cmbestado_siniestro.TabIndex = 2
        ' 
        ' txdetalle
        ' 
        txdetalle.Cursor = Cursors.IBeam
        txdetalle.Location = New Point(73, 137)
        txdetalle.Name = "txdetalle"
        txdetalle.Size = New Size(213, 23)
        txdetalle.TabIndex = 1
        ' 
        ' txsiniestroid
        ' 
        txsiniestroid.Cursor = Cursors.IBeam
        txsiniestroid.Location = New Point(73, 87)
        txsiniestroid.Name = "txsiniestroid"
        txsiniestroid.Size = New Size(60, 23)
        txsiniestroid.TabIndex = 0
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1240, 648)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form6"
        Text = "Siniestro"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvSiniestro, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txsiniestroid As TextBox
    Friend WithEvents dgvSiniestro As DataGridView
    Friend WithEvents btactualizar As Button
    Friend WithEvents btguardar As Button
    Friend WithEvents cmbestado_seguro As ComboBox
    Friend WithEvents txrut As TextBox
    Friend WithEvents dtpFechaSiniestro As DateTimePicker
    Friend WithEvents cmbestado_siniestro As ComboBox
    Friend WithEvents txdetalle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFiltroEstado As ComboBox
    Friend WithEvents txtrutbuscar As TextBox
    Friend WithEvents Btbuscar As Button
    Friend WithEvents btconsultar As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btvolver As Button
    Friend WithEvents cmbRutCompania As ComboBox
End Class
