Imports MySql.Data.MySqlClient

Public Class Form7
    Dim connectionString As String = "Server=localhost;Database=taller;Uid=root;Pwd=;"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRepuestos()
        CargarVentas()
        CargarFiltroRepuestos()
        CargarStock()

    End Sub

    Private Sub CargarRepuestos()
        Dim query As String = "SELECT NombreRepuesto FROM repuestos"
        Using cmd As New MySqlCommand(query, connection)
            connection.Open()
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbNombreRepuesto.Items.Add(reader("NombreRepuesto").ToString())
                End While
            End Using
            connection.Close()
        End Using
    End Sub

    Private Sub CargarFiltroRepuestos()
        Dim query As String = "SELECT NombreRepuesto FROM repuestos"
        Using cmd As New MySqlCommand(query, connection)
            connection.Open()
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                cmbFiltroRepuesto.Items.Clear()
                While reader.Read()
                    cmbFiltroRepuesto.Items.Add(reader("NombreRepuesto").ToString())
                End While
            End Using
            connection.Close()
        End Using
    End Sub

    Private Sub CargarVentas()
        Dim query As String = "SELECT * FROM VentasRepuestos"
        Dim dt As New DataTable()

        Using cmd As New MySqlCommand(query, connection)
            connection.Open()
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
            connection.Close()
        End Using

        DataGridView1.DataSource = dt
    End Sub

    Private Sub CargarStock()
        Dim query As String = "SELECT NombreRepuesto, CantidadStock FROM repuestos"
        Dim dt As New DataTable()

        Using cmd As New MySqlCommand(query, connection)
            connection.Open()
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
            connection.Close()
        End Using

        DataGridView2.DataSource = dt
    End Sub

    Private Sub cmbNombreRepuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombreRepuesto.SelectedIndexChanged
        Dim precioUnitario As String = ObtenerPrecioUnitario(cmbNombreRepuesto.Text).ToString()
        txttotal.Tag = precioUnitario
    End Sub

    Private Function ObtenerPrecioUnitario(nombreRepuesto As String) As String
        Dim precio As String = "0"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("SELECT PrecioUnitario FROM repuestos WHERE NombreRepuesto = @nombre", connection)
            command.Parameters.AddWithValue("@nombre", nombreRepuesto)
            connection.Open()

            Dim result = command.ExecuteScalar()
            If result IsNot Nothing Then
                precio = result.ToString()
            End If
        End Using

        Return precio
    End Function

    Private Function ObtenerStockActual(nombreRepuesto As String) As Integer
        Dim stock As Integer = 0

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("SELECT CantidadStock FROM repuestos WHERE NombreRepuesto = @nombre", connection)
            command.Parameters.AddWithValue("@nombre", nombreRepuesto)
            connection.Open()

            Dim result = command.ExecuteScalar()
            If result IsNot Nothing Then
                stock = Convert.ToInt32(result)
            End If
        End Using

        Return stock
    End Function

    Private Sub txtCantidadVendida_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadVendida.TextChanged
        CalcularTotal()
    End Sub

    Private Sub CalcularTotal()
        Dim cantidad As Integer
        Dim precioUnitario As String = If(txttotal.Tag IsNot Nothing, txttotal.Tag.ToString(), "0")

        If Integer.TryParse(txtCantidadVendida.Text, cantidad) AndAlso Not String.IsNullOrEmpty(precioUnitario) Then
            Dim total As Decimal = cantidad * Convert.ToDecimal(precioUnitario)
            txttotal.Text = total.ToString("0.##")
        Else
            txttotal.Text = String.Empty
        End If
    End Sub

    Private Sub btventarepuesto_Click(sender As Object, e As EventArgs) Handles btventarepuesto.Click

        If String.IsNullOrWhiteSpace(cmbNombreRepuesto.Text) Then
            MessageBox.Show("Seleccione un repuesto.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtCantidadVendida.Text) OrElse Not IsNumeric(txtCantidadVendida.Text) Then
            MessageBox.Show("Ingrese una cantidad válida.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtCliente.Text) Then
            MessageBox.Show("Ingrese el nombre del cliente.")
            Return
        End If

        Dim stockActual As Integer = ObtenerStockActual(cmbNombreRepuesto.Text)
        Dim cantidadVendida As Integer = CInt(txtCantidadVendida.Text)

        If cantidadVendida > stockActual Then
            MessageBox.Show("No hay suficiente stock disponible.")
            Return
        End If

        Dim totalString As String = txttotal.Text.Replace(".", "").Replace(",", ".").Trim()
        Dim total As Decimal

        If Not Decimal.TryParse(totalString, total) Then
            MessageBox.Show("Error al convertir el total. Verifique el formato.")
            Return
        End If

        GuardarVenta(cmbNombreRepuesto.Text, cantidadVendida, txtCliente.Text, DateTimePicker1.Value, total)

        ActualizarStock(cmbNombreRepuesto.Text, stockActual - cantidadVendida)
    End Sub

    Private Sub GuardarVenta(nombreRepuesto As String, cantidadVendida As Integer, cliente As String, fechaVenta As Date, total As Decimal)
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("INSERT INTO VentasRepuestos (NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total) VALUES (@nombre, @cantidad, @cliente, @fecha, @total)", connection)
            command.Parameters.AddWithValue("@nombre", nombreRepuesto)
            command.Parameters.AddWithValue("@cantidad", cantidadVendida)
            command.Parameters.AddWithValue("@cliente", cliente)
            command.Parameters.AddWithValue("@fecha", fechaVenta)
            command.Parameters.AddWithValue("@total", total)

            connection.Open()
            Try
                command.ExecuteNonQuery()
                MessageBox.Show("Venta registrada exitosamente.")
                CargarVentas()
                cmbNombreRepuesto.Items.Clear()
                CargarRepuestos()
            Catch ex As Exception
                MessageBox.Show("Error al registrar la venta: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ActualizarStock(nombreRepuesto As String, nuevoStock As Integer)
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("UPDATE repuestos SET CantidadStock = @nuevoStock WHERE NombreRepuesto = @nombre", connection)
            command.Parameters.AddWithValue("@nuevoStock", nuevoStock)
            command.Parameters.AddWithValue("@nombre", nombreRepuesto)

            connection.Open()
            Try
                command.ExecuteNonQuery()
                CargarStock()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar el stock: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        CargarVentas()


        Dim fecha As Date = DateTimePicker2.Value.Date
        Dim repuesto As String = cmbFiltroRepuesto.Text
        Dim cliente As String = txtFiltroCliente.Text


        Dim query As String = "SELECT * FROM VentasRepuestos WHERE 1=1"


        If Not String.IsNullOrWhiteSpace(repuesto) Then
            query += " AND NombreRepuesto = @repuesto"
        End If

        If Not String.IsNullOrWhiteSpace(cliente) Then
            query += " AND Cliente LIKE @cliente"
        End If

        query += " AND FechaVenta = @fecha"


        Using connection As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, connection)
                If Not String.IsNullOrWhiteSpace(repuesto) Then
                    cmd.Parameters.AddWithValue("@repuesto", repuesto)
                End If

                If Not String.IsNullOrWhiteSpace(cliente) Then
                    cmd.Parameters.AddWithValue("@cliente", "%" & cliente & "%")
                End If


                cmd.Parameters.AddWithValue("@fecha", fecha)


                Dim dt As New DataTable()
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error en la consulta: " & ex.Message)
                Finally
                    connection.Close()
                End Try

                DataGridView1.DataSource = dt
            End Using
        End Using
    End Sub
    Private Sub btnLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltros.Click

        cmbFiltroRepuesto.SelectedIndex = -1
        txtFiltroCliente.Clear()
        DateTimePicker2.Value = DateTime.Now

        CargarVentas()
    End Sub

    Private Sub btvolver_Click(sender As Object, e As EventArgs) Handles btvolver.Click
        Dim form4 As New Form4()
        form4.Show()
        Me.Hide()
    End Sub
End Class