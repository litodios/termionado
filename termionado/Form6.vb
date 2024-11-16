Imports MySql.Data.MySqlClient

Public Class Form6
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=;database=taller")

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstadosSiniestro()
        CargarEstadosSeguro()
        CargarEstadosFiltro()
        CargarDatosEnDataGridView()
        CargarRutsCompania() ' Cambié la función para cargar los RUTs desde la tabla compañia
    End Sub

    Private Sub CargarDatosEnDataGridView()
        Dim query As String = "SELECT SiniestroID, Detalle, Estado_Siniestro, Fecha_Siniestro, RutCompania, Rut, Estado_Seguro FROM siniestro"

        Try
            conn.Open()
            Dim adaptador As New MySqlDataAdapter(query, conn)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            dgvSiniestro.DataSource = tabla
        Catch ex As MySqlException
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CargarEstadosSiniestro()
        cmbestado_siniestro.Items.Clear()
        cmbestado_siniestro.Items.Add("Pendiente")
        cmbestado_siniestro.Items.Add("En proceso")
        cmbestado_siniestro.Items.Add("Finalizado")
        cmbestado_siniestro.Items.Add("Activo")
    End Sub

    Private Sub CargarEstadosSeguro()
        cmbestado_seguro.Items.Clear()
        cmbestado_seguro.Items.Add("Seguro Vigente")
        cmbestado_seguro.Items.Add("Seguro No Vigente")
    End Sub

    Private Sub CargarEstadosFiltro()
        cmbFiltroEstado.Items.Clear()
        cmbFiltroEstado.Items.Add("Todos")
        cmbFiltroEstado.Items.Add("Pendiente")
        cmbFiltroEstado.Items.Add("En proceso")
        cmbFiltroEstado.Items.Add("Finalizado")
        cmbFiltroEstado.Items.Add("Activo")
    End Sub

    Private Sub CargarRutsCompania()
        cmbRutCompania.Items.Clear()
        Dim query As String = "SELECT DISTINCT Rut FROM compania" ' Cambié la consulta para obtener Ruts de la tabla compañia

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                cmbRutCompania.Items.Add(reader("Rut").ToString())
            End While
            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error al cargar los RUTs de las compañías: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CargarDatosSiniestroPorID(siniestroID As String)
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM siniestro WHERE SiniestroID = @SiniestroID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@SiniestroID", siniestroID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                txsiniestroid.Text = reader("SiniestroID").ToString()
                txdetalle.Text = reader("Detalle").ToString()
                cmbestado_siniestro.SelectedItem = reader("Estado_Siniestro").ToString()
                dtpFechaSiniestro.Value = Convert.ToDateTime(reader("Fecha_Siniestro"))
                cmbRutCompania.SelectedItem = reader("RutCompania").ToString()
                txrut.Text = reader("Rut").ToString() ' Aquí es un TextBox para el Rut del Cliente
                cmbestado_seguro.SelectedItem = reader("Estado_Seguro").ToString()
            Else
                MessageBox.Show("Siniestro no encontrado.")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error al cargar el siniestro: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btConsultar_Click(sender As Object, e As EventArgs) Handles btconsultar.Click
        Dim siniestroID As String = txsiniestroid.Text.Trim()

        If String.IsNullOrWhiteSpace(siniestroID) Then
            MessageBox.Show("Por favor ingrese un SiniestroID.")
            Return
        End If

        CargarDatosSiniestroPorID(siniestroID)
    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btactualizar.Click
        If ValidarFormulario() Then
            Try
                conn.Open()
                Dim query As String = "UPDATE siniestro SET Detalle = @Detalle, Estado_Siniestro = @Estado_Siniestro, Fecha_Siniestro = @Fecha_Siniestro, RutCompania = @RutCompania, Rut = @Rut, Estado_Seguro = @Estado_Seguro WHERE SiniestroID = @SiniestroID"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SiniestroID", txsiniestroid.Text)
                cmd.Parameters.AddWithValue("@Detalle", txdetalle.Text)
                cmd.Parameters.AddWithValue("@Estado_Siniestro", cmbestado_siniestro.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Fecha_Siniestro", dtpFechaSiniestro.Value)
                cmd.Parameters.AddWithValue("@RutCompania", cmbRutCompania.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Rut", txrut.Text) ' Usamos el TextBox para Rut
                cmd.Parameters.AddWithValue("@Estado_Seguro", cmbestado_seguro.SelectedItem.ToString())

                cmd.ExecuteNonQuery()
                MessageBox.Show("Siniestro actualizado correctamente.")
            Catch ex As MySqlException
                MessageBox.Show("Error al actualizar el siniestro: " & ex.Message)
            Finally
                conn.Close()
                CargarDatosEnDataGridView()
            End Try
        End If
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        If ValidarFormulario() Then
            Try
                conn.Open()
                Dim query As String = "INSERT INTO siniestro (SiniestroID, Detalle, Estado_Siniestro, Fecha_Siniestro, RutCompania, Rut, Estado_Seguro) VALUES (@SiniestroID, @Detalle, @Estado_Siniestro, @Fecha_Siniestro, @RutCompania, @Rut, @Estado_Seguro)"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SiniestroID", txsiniestroid.Text)
                cmd.Parameters.AddWithValue("@Detalle", txdetalle.Text)
                cmd.Parameters.AddWithValue("@Estado_Siniestro", cmbestado_siniestro.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Fecha_Siniestro", dtpFechaSiniestro.Value)
                cmd.Parameters.AddWithValue("@RutCompania", cmbRutCompania.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Rut", txrut.Text) ' Usamos el TextBox para Rut
                cmd.Parameters.AddWithValue("@Estado_Seguro", cmbestado_seguro.SelectedItem.ToString())

                cmd.ExecuteNonQuery()
                MessageBox.Show("Siniestro registrado correctamente.")
            Catch ex As MySqlException
                MessageBox.Show("Error al guardar el siniestro: " & ex.Message)
            Finally
                conn.Close()
                CargarDatosEnDataGridView()
            End Try
        End If
    End Sub

    Private Function ValidarFormulario() As Boolean
        If String.IsNullOrWhiteSpace(txdetalle.Text) OrElse cmbestado_siniestro.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(txrut.Text) OrElse cmbRutCompania.SelectedItem Is Nothing OrElse cmbestado_seguro.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor completa todos los campos obligatorios.")
            Return False
        End If
        Return True
    End Function

    Private Sub btvolver_Click(sender As Object, e As EventArgs) Handles btvolver.Click
        Dim form4 As New Form4()
        form4.Show()
        Me.Hide()
    End Sub
End Class
