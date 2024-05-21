Public Class GestorVuelos
    Private lista As New List(Of Vuelo)

    Public Sub Agregar(c As Vuelo)
        lista.Add(c)
    End Sub

    Public Function ObtenerTodos() As IList(Of Vuelo)
        Return lista
    End Function
End Class
