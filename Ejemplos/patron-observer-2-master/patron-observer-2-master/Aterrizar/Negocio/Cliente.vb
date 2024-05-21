Imports Aterrizar

Public Class Cliente
    Implements IHotelObserver
    Implements IVueloObserver
    Implements ICruceroObserver



    Public Property Nombre As String
    Public Property Mail As String

    Public Sub Update(h As Hotel) Implements IHotelObserver.Update
        MessageBox.Show("recibiendo mail sobre hoteles")

    End Sub

    Public Sub Update(v As Vuelo) Implements IVueloObserver.Update
        MessageBox.Show("recibiendo mail sobre vuelos")
    End Sub

    Public Sub Update(c As Crucero) Implements ICruceroObserver.Update
        MessageBox.Show("recibiendo mail sobre cruceros")
    End Sub
End Class
