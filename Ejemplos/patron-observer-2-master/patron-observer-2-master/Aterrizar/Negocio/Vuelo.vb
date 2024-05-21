Public Class Vuelo
    Inherits Producto

    Public Producto
    Public Asiento As String

    Public Overrides Sub SetPrecio(p As Double)
        Notificar()
        MyBase.SetPrecio(p)
    End Sub


    Private list As New List(Of IVueloObserver)
    Public Sub Agregar(o As IVueloObserver)
        list.Add(o)
    End Sub

    Public Sub Quitr(o As IVueloObserver)
        list.Remove(o)
    End Sub

    Public Sub Notificar()
        For Each o In list
            o.Update(Me)
        Next
    End Sub
End Class
