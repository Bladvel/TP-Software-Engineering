Public Class Hotel  'subject
    Inherits Producto
    Public Property CantidadCamas As String

    Public Overrides Sub SetPrecio(p As Double)
        Notificar()
        MyBase.SetPrecio(p)
    End Sub



    Private list As New List(Of IHotelObserver)
    Public Sub Agregar(o As IHotelObserver)
        list.Add(o)
    End Sub

    Public Sub Quitr(o As IHotelObserver)
        list.Remove(o)
    End Sub

    Public Sub Notificar()
        For Each o In list
            o.Update(Me)
        Next
    End Sub


End Class
