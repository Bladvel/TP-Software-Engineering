Public Class frmAterrizar
    Private clientes As New GestorClientes
    Private hoteles As New GestorHoteles
    Private cruceros As New GestorCruceros
    Private vuelos As New GestorVuelos


    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim c As New Cliente
        c.Nombre = Me.txtNombre.Text
        c.Mail = Me.txtMail.Text
        clientes.Agregar(c)

        Me.lstClientes.DataSource = clientes.ObtenerTodos
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarHotel.Click
        Dim h As New Hotel
        h.Nombre = Me.txtNombreHotel.Text
        h.CantidadCamas = Me.txtCamas.Text
        hoteles.Agregar(h)
        Me.lstHoteles.DataSource = hoteles.ObtenerTodos
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAgregarCrucero.Click
        Dim c As New Crucero
        c.Nombre = Me.txtNombreCrucero.Text
        c.Cabina = Me.txtCabina.Text
        cruceros.Agregar(c)
        Me.lstCruceros.DataSource = cruceros.ObtenerTodos
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAgregarVuelo.Click
        Dim a As New Vuelo
        a.Nombre = Me.txtNombreCrucero.Text
        a.Asiento = Me.txtAsiento.Text
        vuelos.Agregar(a)
        Me.lstVuelos.DataSource = vuelos.ObtenerTodos
    End Sub

    Private Sub cmdSuscribirHotel_Click(sender As Object, e As EventArgs) Handles btnSuscribirHotel.Click
        Dim h As Hotel = CType(Me.lstHoteles.SelectedItem, Hotel)
        Dim c As Cliente = CType(Me.lstClientes.SelectedItem, Cliente)

        If h IsNot Nothing Then
            h.Agregar(c)
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSuscribirCrucero.Click
        Dim h As Crucero = CType(Me.lstCruceros.SelectedItem, Crucero)
        Dim c As Cliente = CType(Me.lstClientes.SelectedItem, Cliente)

        If h IsNot Nothing Then
            h.Agregar(c)
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnSuscribirVuelo.Click
        Dim h As Vuelo = CType(Me.lstVuelos.SelectedItem, Vuelo)
        Dim c As Cliente = CType(Me.lstClientes.SelectedItem, Cliente)

        If h IsNot Nothing Then
            h.Agregar(c)
        End If
    End Sub

    Private Sub lstHoteles_DoubleClick(sender As Object, e As EventArgs) Handles lstHoteles.DoubleClick
        Dim h As Hotel = CType(Me.lstHoteles.SelectedItem, Hotel)
        h.SetPrecio(CDbl(InputBox("Ingrese Precio")))
    End Sub

    Private Sub lstCruceros_DoubleClick(sender As Object, e As EventArgs) Handles lstCruceros.DoubleClick
        Dim h As Crucero = CType(Me.lstCruceros.SelectedItem, Crucero)
        h.SetPrecio(CDbl(InputBox("Ingrese Precio")))
    End Sub

    Private Sub lstVuelos_DoubleClick(sender As Object, e As EventArgs) Handles lstVuelos.DoubleClick
        Dim h As Vuelo = CType(Me.lstVuelos.SelectedItem, Vuelo)
        h.SetPrecio(CDbl(InputBox("Ingrese Precio")))
    End Sub
End Class
