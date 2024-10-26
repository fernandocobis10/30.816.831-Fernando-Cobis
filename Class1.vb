Public Class Libro
    Public Property Titulo As String
    Public Property Autor As String
    Public Property AnioPublicacion As Integer
    Private Property Prestado As Boolean

    Public Sub New(titulo As String, autor As String, anioPublicacion As Integer)
        Me.Titulo = titulo
        Me.Autor = autor
        Me.AnioPublicacion = anioPublicacion
        Me.Prestado = False
    End Sub

    Public Function ObtenerDescripcion() As String
        Return $"{Titulo}, escrito por {Autor} en {AnioPublicacion}."
    End Function

    Public Sub Prestar()
        Prestado = True
    End Sub

    Public Sub Devolver()
        Prestado = False
    End Sub

    Public Function EstaDisponible() As Boolean
        Return Not Prestado
    End Function
End Class
