Imports MySql.Data.MySqlClient

Public Class Form3
    Dim connection As String = "Server=localhost;Database=taller;User ID=root;Password=;"

    Private Sub form3(sender As Object, e As EventArgs) Handles MyBase.Load

        Using connectionString As New MySqlConnection(connection)
            MessageBox.Show("Conexión exitosa!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using

    End Sub

    Private Sub btconsulta_Clic(sender As Object, e As EventArgs) Handles btconsulta.Click
        Dim rut As String = txtrut.Text.Trim()

        If String.IsNullOrWhiteSpace(rut) Then
            Return
        End If

        Using conexion As New MySqlConnection(connection)
            Try
                conexion.Open()
                Dim sql As String = "SELECT rut, correo, contraseña, tipo FROM usuarios WHERE rut = @rut"
                Using cmd As New MySqlCommand(sql, conexion)
                    cmd.Parameters.AddWithValue("@rut", rut)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtrut.Text = reader("rut").ToString()
                            txtusuario.Text = reader("correo").ToString()
                            txtcontraseña.Text = reader("contraseña").ToString()
                            cmbtipo.Text = reader("tipo").ToString()
                        Else
                            MessageBox.Show("No se encontró ninguna persona con el RUT ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al buscar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btagregar_click(sender As Object, e As EventArgs) Handles btagregar.Click
        Dim rut As String = txtrut.Text
        Dim correo As String = txtusuario.Text
        Dim contraseña As String = txtcontraseña.Text
        Dim tipo As String = cmbtipo.SelectedItem?.ToString()

        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(correo) Or String.IsNullOrWhiteSpace(tipo) Or String.IsNullOrWhiteSpace(contraseña) Then
            MessageBox.Show("Por favor, rellene los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conexion As New MySqlConnection(connection)
            Try
                conexion.Open()
                Dim sql As String = "INSERT INTO usuarios(rut, correo, contraseña, tipo) VALUES (@rut, @correo, @contraseña, @tipo)"
                Using cmd As New MySqlCommand(sql, conexion)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    cmd.Parameters.AddWithValue("@correo", correo)
                    cmd.Parameters.AddWithValue("@contraseña", contraseña)
                    cmd.Parameters.AddWithValue("@tipo", tipo)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarDatosEnGrid()
                    txtrut.Clear()
                    txtusuario.Clear()
                    txtcontraseña.Clear()
                    cmbtipo.SelectedIndex = -1
                    txtrut.Focus()
                End Using
            Catch ex As Exception
                MessageBox.Show("No se pudo guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub btborrar_Click(sender As Object, e As EventArgs) Handles btborrar.Click
        Dim rut As String = txtrut.Text

        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Por favor, ingrese un RUT para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conexion As New MySqlConnection(connection)
            Try
                conexion.Open()
                Dim sql As String = "DELETE FROM usuarios WHERE rut = @rut"
                Using cmd As New MySqlCommand(sql, conexion)
                    cmd.Parameters.AddWithValue("@rut", rut)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Datos borrados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarDatosEnGrid()
                        txtrut.Clear()
                        txtusuario.Clear()
                        txtcontraseña.Clear()
                        cmbtipo.SelectedIndex = -1
                        txtrut.Focus()
                    Else
                        MessageBox.Show("No se encontró ninguna persona con ese RUT para borrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("No se pudo borrar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles bteditar.Click
        Dim rut As String = txtrut.Text
        Dim correo As String = txtusuario.Text
        Dim contraseña As String = txtcontraseña.Text
        Dim tipo As String = cmbtipo.SelectedItem?.ToString()

        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(correo) Or String.IsNullOrWhiteSpace(contraseña) Or String.IsNullOrWhiteSpace(tipo) Then
            MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conexion As New MySqlConnection(connection)
            Try
                conexion.Open()
                Dim sql As String = "UPDATE usuarios SET correo = @correo, contraseña = @contraseña, tipo = @tipo WHERE rut = @rut"
                Using cmd As New MySqlCommand(sql, conexion)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    cmd.Parameters.AddWithValue("@correo", correo)
                    cmd.Parameters.AddWithValue("@contraseña", contraseña)
                    cmd.Parameters.AddWithValue("@tipo", tipo)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Datos actualizados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarDatosEnGrid()
                        txtrut.Clear()
                        txtusuario.Clear()
                        txtcontraseña.Clear()
                        cmbtipo.SelectedIndex = -1
                        txtrut.Focus()
                    Else
                        MessageBox.Show("No se encontró persona con ese RUT para actualizar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al actualizar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub btconsulta_Click(sender As Object, e As EventArgs) Handles btconsulta.Click
        Dim rut As String = txtrut.Text.Trim()

        If String.IsNullOrWhiteSpace(rut) Then
            Return
        End If

        Using conexion As New MySqlConnection(connection)
            Try
                conexion.Open()
                Dim sql As String = "SELECT rut, correo, contraseña, tipo FROM usuarios WHERE rut = @rut"
                Using cmd As New MySqlCommand(sql, conexion)
                    cmd.Parameters.AddWithValue("@rut", rut)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtrut.Text = reader("rut").ToString()
                            txtusuario.Text = reader("correo").ToString()
                            txtcontraseña.Text = reader("contraseña").ToString()
                            cmbtipo.Text = reader("tipo").ToString()
                        Else
                            MessageBox.Show("No se encontró ninguna persona con el RUT ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al buscar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MessageBox.Show("Cargando usuarios...")
        Dim conexion As MySqlConnection = GetConnection()

        Try
            conexion.Open()
            Dim command As MySqlCommand = conexion.CreateCommand()
            command.CommandText = "SELECT tipo FROM usuarios"

            Dim reader As MySqlDataReader = command.ExecuteReader()

            cmbtipo.Items.Clear()
            While reader.Read()
                cmbtipo.Items.Add(reader("tipo").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error al cargar usuarios: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
    Private Sub usuarios()
        Dim conexion As MySqlConnection = GetConnection()

        Try
            conexion.Open()
            Dim command As MySqlCommand = conexion.CreateCommand()
            command.CommandText = "SELECT tipo FROM usuarios"

            Dim reader As MySqlDataReader = command.ExecuteReader()

            cmbtipo.Items.Clear()
            While reader.Read()
                cmbtipo.Items.Add(reader("tipo").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error al cargar usuarios: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Function GetConnection() As MySqlConnection
        Dim connectionString As String = "Server=localhost;Database=taller;User ID=root;Password=;"
        Return New MySqlConnection(connectionString)
    End Function

    Private Sub CargarDatosEnGrid()
        Using conexion As New MySqlConnection(connection)
            Try
                conexion.Open()
                Dim sql As String = "SELECT rut, correo, contraseña, tipo FROM usuarios"

                Using adapter As New MySqlDataAdapter(sql, conexion)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al cargar los datos en el DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosEnGrid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btvolver_Click(sender As Object, e As EventArgs) Handles btvolver.Click
        Dim form4 As New Form4()
        form4.Show()
        Me.Hide()
    End Sub
End Class

