Imports MySql.Data.MySqlClient
Imports Mysqlx.Expect.Open.Types
Imports System.Configuration

Public Class Form1
    Dim connectionString As String = "Server=localhost;Database=taller;User ID=root;Password=;"
    Dim contador As Integer = 0 ' Mueve el contador aquí para que sea un campo de clase

    Private Function ValidarCredenciales(usuario As String, contraseña As String) As Boolean
        Using conexion As New MySqlConnection(connectionString)
            Try
                conexion.Open()
                Dim sql As String = "SELECT COUNT(*) FROM usuarios WHERE correo = @usuario AND contraseña = @contraseña"
                Using cmd As New MySqlCommand(sql, conexion)
                    cmd.Parameters.AddWithValue("@usuario", usuario)
                    cmd.Parameters.AddWithValue("@contraseña", contraseña)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al validar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Private Sub BTINGRESAR_Click(sender As Object, e As EventArgs) Handles BTINGRESAR.Click
        Using conexion As New MySqlConnection(connectionString)
            Dim usuario As String = TXUSUARIO.Text.Trim()
            Dim contraseña As String = TXCONTRASEÑA.Text.Trim()
            If String.IsNullOrWhiteSpace(usuario) OrElse String.IsNullOrWhiteSpace(contraseña) Then
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If ValidarCredenciales(usuario, contraseña) Then
                Dim form4 As New Form4()
                form4.Show()
                Me.Hide()
            Else
                contador += 1
                If contador >= 20 Then
                    MessageBox.Show("Demasiados intentos fallidos. El acceso ha sido bloqueado.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TXUSUARIO.Enabled = False
                    TXCONTRASEÑA.Enabled = False
                    BTINGRESAR.Enabled = False
                Else
                    MessageBox.Show("Datos incorrectos. Por favor, verifica el usuario y la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTINGRESAR.Enabled = False
    End Sub

    Private Sub TextFields_TextChanged(sender As Object, e As EventArgs) Handles TXUSUARIO.TextChanged, TXCONTRASEÑA.TextChanged
        ValidarCampos()
    End Sub

    Private Sub ValidarCampos()
        BTINGRESAR.Enabled = Not String.IsNullOrWhiteSpace(TXUSUARIO.Text) AndAlso Not String.IsNullOrWhiteSpace(TXCONTRASEÑA.Text)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class

