Public Class GestorHoteles
    Private lista As New List(Of Hotel)

    Public Sub Agregar(c As Hotel)
        lista.Add(c)
    End Sub

    Public Function ObtenerTodos() As IList(Of Hotel)
        Return lista
    End Function
End Class
