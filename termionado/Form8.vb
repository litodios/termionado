Imports MySql.Data.MySqlClient

Public Class Form8
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=;database=taller")

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosEnDataGridView()
        CargarTelefonos()
        CargarComunas()
    End Sub

    ' Cargar los datos en el DataGridView
    Private Sub CargarDatosEnDataGridView()
        Dim query As String = "SELECT Rut, Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna FROM clientes"

        Try
            conn.Open()
            Dim adaptador As New MySqlDataAdapter(query, conn)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            dgvClientes.DataSource = tabla
        Catch ex As MySqlException
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Cargar el ComboBox de teléfonos con el prefijo +569
    Private Sub CargarTelefonos()
        cmTelefono.Items.Clear()
        For i As Integer = 0 To 9
            cmTelefono.Items.Add("+569" & i)
        Next
    End Sub

    ' Cargar el ComboBox de comunas (Región Metropolitana)
    Private Sub CargarComunas()
        cmComuna.Items.Clear()
        Dim comunas As New List(Of String) From {
            "Cerrillos", "Cerro Navia", "Conchalí", "El Bosque", "Estación Central", "Huechuraba", "Independencia",
            "La Cisterna", "La Florida", "La Granja", "La Pintana", "Las Condes", "Lo Barnechea", "Lo Espejo",
            "Lo Prado", "Macul", "Maipú", "Ñuñoa", "Pedro Aguirre Cerda", "Peñalolén", "Providencia", "Pudahuel",
            "Quilicura", "Quinta Normal", "Recoleta", "Renca", "San Bernardo", "San Joaquín", "San Miguel",
            "San Ramón", "Vitacura"
        }

        ' Agregar las comunas al ComboBox
        For Each comuna As String In comunas
            cmComuna.Items.Add(comuna)
        Next
    End Sub

    ' Función para validar el formulario
    Private Function ValidarFormulario() As Boolean
        If String.IsNullOrWhiteSpace(txRut.Text) OrElse String.IsNullOrWhiteSpace(txNombre.Text) OrElse String.IsNullOrWhiteSpace(txApellidoP.Text) OrElse String.IsNullOrWhiteSpace(txApellidoM.Text) OrElse String.IsNullOrWhiteSpace(txDireccion.Text) OrElse cmComuna.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor completa todos los campos.")
            Return False
        End If
        Return True
    End Function
    ' Agregar un nuevo cliente


    ' Actualizar un cliente existente
    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        If ValidarFormulario() Then
            Try
                conn.Open()
                Dim query As String = "UPDATE clientes SET Nombre = @Nombre, ApellidoP = @ApellidoP, ApellidoM = @ApellidoM, Direccion = @Direccion, Telefono = @Telefono, Comuna = @Comuna WHERE Rut = @Rut"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Rut", txRut.Text)
                cmd.Parameters.AddWithValue("@Nombre", txNombre.Text)
                cmd.Parameters.AddWithValue("@ApellidoP", txApellidoP.Text)
                cmd.Parameters.AddWithValue("@ApellidoM", txApellidoM.Text)
                cmd.Parameters.AddWithValue("@Direccion", txDireccion.Text)
                cmd.Parameters.AddWithValue("@Telefono", cmTelefono.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Comuna", cmComuna.SelectedItem.ToString())

                cmd.ExecuteNonQuery()
                MessageBox.Show("Cliente actualizado correctamente.")
                CargarDatosEnDataGridView()
            Catch ex As MySqlException
                MessageBox.Show("Error al actualizar el cliente: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    ' Eliminar un cliente

    ' Cuando se selecciona una fila del DataGridView
    Private Sub dgvClientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvClientes.SelectionChanged
        If dgvClientes.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvClientes.SelectedRows(0)

            txRut.Text = row.Cells("Rut").Value.ToString()
            txNombre.Text = row.Cells("Nombre").Value.ToString()
            txApellidoP.Text = row.Cells("ApellidoP").Value.ToString()
            txApellidoM.Text = row.Cells("ApellidoM").Value.ToString()
            txDireccion.Text = row.Cells("Direccion").Value.ToString()
            cmTelefono.SelectedItem = row.Cells("Telefono").Value.ToString()
            cmComuna.SelectedItem = row.Cells("Comuna").Value.ToString()
        End If
    End Sub

    Private Sub btAgregar_Click_Click(sender As Object, e As EventArgs) Handles btAgregar_Click.Click
        If ValidarFormulario() Then
            Try
                conn.Open()
                Dim query As String = "INSERT INTO clientes (Rut, Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna) VALUES (@Rut, @Nombre, @ApellidoP, @ApellidoM, @Direccion, @Telefono, @Comuna)"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Rut", txRut.Text)
                cmd.Parameters.AddWithValue("@Nombre", txNombre.Text)
                cmd.Parameters.AddWithValue("@ApellidoP", txApellidoP.Text)
                cmd.Parameters.AddWithValue("@ApellidoM", txApellidoM.Text)
                cmd.Parameters.AddWithValue("@Direccion", txDireccion.Text)
                cmd.Parameters.AddWithValue("@Telefono", cmTelefono.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Comuna", cmComuna.SelectedItem.ToString())

                cmd.ExecuteNonQuery()
                MessageBox.Show("Cliente agregado correctamente.")
                CargarDatosEnDataGridView()
            Catch ex As MySqlException
                MessageBox.Show("Error al agregar el cliente: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btEliminar_Click_Click(sender As Object, e As EventArgs) Handles btEliminar_Click.Click
        If String.IsNullOrWhiteSpace(txRut.Text) Then
            MessageBox.Show("Por favor ingrese un Rut para eliminar.")
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "DELETE FROM clientes WHERE Rut = @Rut"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Rut", txRut.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Cliente eliminado correctamente.")
            CargarDatosEnDataGridView()
        Catch ex As MySqlException
            MessageBox.Show("Error al eliminar el cliente: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
