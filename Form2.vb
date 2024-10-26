Public Class Form2
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        If Form1.libro IsNot Nothing Then
            If Form1.libro.EstaDisponible() Then
                lblEstado.Text = "El libro está disponible."
            Else
                lblEstado.Text = "El libro no está disponible."
            End If
        Else
            MessageBox.Show("No hay ningún libro registrado.")
        End If
    End Sub
End Class

