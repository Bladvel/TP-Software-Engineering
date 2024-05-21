Public Class Crucero 'subject
    Inherits Producto
    Public Cabina As String

    Private list As New List(Of ICruceroObserver)


    Public Overrides Sub SetPrecio(p As Double)
        Notificar()
        MyBase.SetPrecio(p)
    End Sub

    Public Sub Agregar(o As ICruceroObserver)
        list.Add(o)
    End Sub

    Public Sub Quitr(o As ICruceroObserver)
        list.Remove(o)
    End Sub

    Public Sub Notificar()
        For Each o In list
            o.Update(Me)
        Next
    End Sub
End Class
