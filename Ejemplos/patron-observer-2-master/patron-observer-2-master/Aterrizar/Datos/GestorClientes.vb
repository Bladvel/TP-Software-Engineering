Public Class GestorClientes
    Private lista As New List(Of Cliente)

    Public Sub Agregar(c As Cliente)
        lista.Add(c)
    End Sub

    Public Function ObtenerTodos() As IList(Of Cliente)
        Return lista
    End Function
End Class
