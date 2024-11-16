Public Class Form4
    Private Sub btusuario_Click(sender As Object, e As EventArgs) Handles btusuario.Click
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub btrepuesto_Click(sender As Object, e As EventArgs) Handles btrepuesto.Click
        Dim form5 As New Form5()
        form5.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btventa.Click
        Dim form7 As New Form7()
        form7.Show()
        Me.Hide()
    End Sub

    Private Sub btvolver_Click(sender As Object, e As EventArgs) Handles btvolver.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form6 As New Form6()
        form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form8 As New Form8()
        form8.Show()
        Me.Hide()
    End Sub
End Class