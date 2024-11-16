Imports MySql.Data.MySqlClient

Public Class Form5
    Private connectionString As String = "Server=localhost;Database=taller;Uid=root;Pwd=;"

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComboBoxes()
        CargarRepuestos()
    End Sub

    Private Sub CargarComboBoxes()
        Dim query As String = "SELECT RepuestoID, NombreRepuesto FROM repuestos"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            cmbidrepuesto.Items.Clear()

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim repuesto As New Repuesto(reader("RepuestoID"), reader("NombreRepuesto").ToString())
                    cmbidrepuesto.Items.Add(repuesto)

                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error al cargar los repuestos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub CargarRepuestos()
        Dim query As String = "SELECT * FROM repuestos"

        Using connection As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim dt As New DataTable()

            Try
                connection.Open()
                adapter.Fill(dt)
                DataGridViewrepuestos.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al cargar repuestos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        If Not ValidarCampos() Then Return

        Dim query As String = "INSERT INTO repuestos (RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor) VALUES (@RepuestoID, @NombreRepuesto, @CantidadStock, @PrecioUnitario, @Proveedor)"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@RepuestoID", Convert.ToInt32(txtidproducto.Text))
            command.Parameters.AddWithValue("@NombreRepuesto", txtnombre.Text)
            command.Parameters.AddWithValue("@CantidadStock", Convert.ToInt32(txtstock.Text))
            command.Parameters.AddWithValue("@PrecioUnitario", Convert.ToDecimal(txtprecio.Text))
            command.Parameters.AddWithValue("@Proveedor", txtproveedor.Text)

            Try
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Repuesto registrado correctamente.")
                CargarComboBoxes()
                CargarRepuestos()
            Catch ex As Exception
                MessageBox.Show("Error al registrar el repuesto: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btactulizar.Click
        If Not ValidarCampos() Then Return

        Dim query As String = "UPDATE repuestos SET NombreRepuesto = @NombreRepuesto, CantidadStock = @CantidadStock, PrecioUnitario = @PrecioUnitario, Proveedor = @Proveedor WHERE RepuestoID = @RepuestoID"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@RepuestoID", Convert.ToInt32(txtidproducto.Text))
            command.Parameters.AddWithValue("@NombreRepuesto", txtnombre.Text)
            command.Parameters.AddWithValue("@CantidadStock", Convert.ToInt32(txtstock.Text))
            command.Parameters.AddWithValue("@PrecioUnitario", Convert.ToDecimal(txtprecio.Text))
            command.Parameters.AddWithValue("@Proveedor", txtproveedor.Text)

            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Repuesto actualizado correctamente.")
                    CargarComboBoxes()
                    CargarRepuestos()
                Else
                    MessageBox.Show("No se encontró el repuesto para actualizar.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al actualizar el repuesto: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles bteliminar.Click
        If String.IsNullOrWhiteSpace(txtidproducto.Text) Then
            MessageBox.Show("Por favor, ingresa el ID del producto para eliminar.")
            Return
        End If

        Dim query As String = "DELETE FROM repuestos WHERE RepuestoID = @RepuestoID"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@RepuestoID", Convert.ToInt32(txtidproducto.Text))

            Try
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Repuesto eliminado correctamente.")
                CargarComboBoxes()
                CargarRepuestos()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el repuesto: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btbuscar.Click
        Dim query As String = "SELECT * FROM repuestos WHERE 1=1"
        Dim parameters As New List(Of MySqlParameter)()

        If Not String.IsNullOrWhiteSpace(txtidproducto.Text) Then
            query += " AND RepuestoID = @RepuestoID"
            parameters.Add(New MySqlParameter("@RepuestoID", Convert.ToInt32(txtidproducto.Text)))
        End If

        If Not String.IsNullOrWhiteSpace(txtnombre.Text) Then
            query += " AND NombreRepuesto LIKE @NombreRepuesto"
            parameters.Add(New MySqlParameter("@NombreRepuesto", "%" & txtnombre.Text & "%"))
        End If

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddRange(parameters.ToArray())

            Dim adapter As New MySqlDataAdapter(command)
            Dim dt As New DataTable()

            Try
                connection.Open()
                adapter.Fill(dt)
                DataGridViewrepuestos.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error al buscar repuestos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(txtidproducto.Text) OrElse
           String.IsNullOrWhiteSpace(txtnombre.Text) OrElse
           String.IsNullOrWhiteSpace(txtstock.Text) OrElse
           String.IsNullOrWhiteSpace(txtprecio.Text) OrElse
           String.IsNullOrWhiteSpace(txtproveedor.Text) Then
            MessageBox.Show("Todos los campos son obligatorios.")
            Return False
        End If

        ' Validar que el ID del producto sea un número
        Dim id As Integer
        If Not Integer.TryParse(txtidproducto.Text, id) Then
            MessageBox.Show("El ID del producto debe ser un número.")
            Return False
        End If

        Return True
    End Function

    Private Sub cmbidrepuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbidrepuesto.SelectedIndexChanged
        Dim selectedRepuesto As Repuesto = CType(cmbidrepuesto.SelectedItem, Repuesto)
        CargarDetalles(selectedRepuesto.RepuestoID)
    End Sub

    Private Sub CargarDetalles(repuestoID As Integer)
        Dim query As String = "SELECT RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor FROM repuestos WHERE RepuestoID = @RepuestoID"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@RepuestoID", repuestoID)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    txtidproducto.Text = reader("RepuestoID").ToString()
                    txtnombre.Text = reader("NombreRepuesto").ToString()
                    txtstock.Text = reader("CantidadStock").ToString()
                    txtprecio.Text = reader("PrecioUnitario").ToString()
                    txtproveedor.Text = reader("Proveedor").ToString()
                End If
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error al cargar detalles: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Class Repuesto
        Public Property RepuestoID As Integer
        Public Property NombreRepuesto As String

        Public Sub New(id As Integer, nombre As String)
            RepuestoID = id
            NombreRepuesto = nombre
        End Sub

        Public Overrides Function ToString() As String
            Return NombreRepuesto ' Esto define cómo se mostrará el objeto en el ComboBox
        End Function
    End Class

    Private Sub btvolver_Click(sender As Object, e As EventArgs) Handles btvolver.Click
        Dim form4 As New Form4()
        form4.Show()
        Me.Hide()
    End Sub
End Class