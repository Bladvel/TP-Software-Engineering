Public Class GestorCruceros
    Private lista As New List(Of Crucero)

    Public Sub Agregar(c As Crucero)
        lista.Add(c)
    End Sub

    Public Function ObtenerTodos() As IList(Of Crucero)
        Return lista
    End Function
End Class
