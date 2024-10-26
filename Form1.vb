Public Class Form1
    Public Shared libro As Libro

    Private Sub btnPrestar_Click(sender As Object, e As EventArgs) Handles btnPrestar.Click
        Dim titulo As String = txtTitulo.Text
        Dim autor As String = txtAutor.Text
        Dim anioPublicacion As Integer

        If Integer.TryParse(txtAnioPublicacion.Text, anioPublicacion) Then
            libro = New Libro(titulo, autor, anioPublicacion)
            libro.Prestar()
            MessageBox.Show("El libro ha sido prestado.")
        Else
            MessageBox.Show("Por favor, ingrese un año de publicación válido.")
        End If
    End Sub

    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        If libro IsNot Nothing Then
            libro.Devolver()
            MessageBox.Show("El libro ha sido devuelto y está disponible.")
        Else
            MessageBox.Show("No hay ningún libro registrado.")
        End If
    End Sub
End Class
