Public MustInherit Class Producto
    Dim _precio As Double

    Public Property Nombre As String
    Public Function GetPrecio()
        Return _precio
    End Function

    Public Overridable Sub SetPrecio(p As Double)
        _precio = p
    End Sub


End Class
