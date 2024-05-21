<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAterrizar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstClientes = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.lstHoteles = New System.Windows.Forms.ListBox()
        Me.btnAgregarHotel = New System.Windows.Forms.Button()
        Me.txtCamas = New System.Windows.Forms.TextBox()
        Me.txtNombreHotel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAgregarCrucero = New System.Windows.Forms.Button()
        Me.txtCabina = New System.Windows.Forms.TextBox()
        Me.txtNombreCrucero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstCruceros = New System.Windows.Forms.ListBox()
        Me.btnAgregarVuelo = New System.Windows.Forms.Button()
        Me.txtAsiento = New System.Windows.Forms.TextBox()
        Me.txtNombreAvion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstVuelos = New System.Windows.Forms.ListBox()
        Me.txtPrecioHotel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txrPrecioCrucero = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPrecioVuelo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSuscribirHotel = New System.Windows.Forms.Button()
        Me.btnSuscribirCrucero = New System.Windows.Forms.Button()
        Me.btnSuscribirVuelo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstClientes
        '
        Me.lstClientes.FormattingEnabled = True
        Me.lstClientes.Location = New System.Drawing.Point(12, 148)
        Me.lstClientes.Name = "lstClientes"
        Me.lstClientes.Size = New System.Drawing.Size(228, 277)
        Me.lstClientes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mail"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(68, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(171, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(67, 64)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(171, 20)
        Me.txtMail.TabIndex = 4
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(68, 102)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(110, 27)
        Me.cmdAgregar.TabIndex = 5
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'lstHoteles
        '
        Me.lstHoteles.FormattingEnabled = True
        Me.lstHoteles.Location = New System.Drawing.Point(303, 187)
        Me.lstHoteles.Name = "lstHoteles"
        Me.lstHoteles.Size = New System.Drawing.Size(177, 238)
        Me.lstHoteles.TabIndex = 7
        '
        'btnAgregarHotel
        '
        Me.btnAgregarHotel.Location = New System.Drawing.Point(338, 138)
        Me.btnAgregarHotel.Name = "btnAgregarHotel"
        Me.btnAgregarHotel.Size = New System.Drawing.Size(110, 27)
        Me.btnAgregarHotel.TabIndex = 13
        Me.btnAgregarHotel.Text = "Agregar Hotel"
        Me.btnAgregarHotel.UseVisualStyleBackColor = True
        '
        'txtCamas
        '
        Me.txtCamas.Location = New System.Drawing.Point(355, 64)
        Me.txtCamas.Name = "txtCamas"
        Me.txtCamas.Size = New System.Drawing.Size(125, 20)
        Me.txtCamas.TabIndex = 12
        '
        'txtNombreHotel
        '
        Me.txtNombreHotel.Location = New System.Drawing.Point(356, 36)
        Me.txtNombreHotel.Name = "txtNombreHotel"
        Me.txtNombreHotel.Size = New System.Drawing.Size(124, 20)
        Me.txtNombreHotel.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Camas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(300, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nombre"
        '
        'btnAgregarCrucero
        '
        Me.btnAgregarCrucero.Location = New System.Drawing.Point(530, 138)
        Me.btnAgregarCrucero.Name = "btnAgregarCrucero"
        Me.btnAgregarCrucero.Size = New System.Drawing.Size(110, 27)
        Me.btnAgregarCrucero.TabIndex = 19
        Me.btnAgregarCrucero.Text = "Agregar Crucero"
        Me.btnAgregarCrucero.UseVisualStyleBackColor = True
        '
        'txtCabina
        '
        Me.txtCabina.Location = New System.Drawing.Point(554, 64)
        Me.txtCabina.Name = "txtCabina"
        Me.txtCabina.Size = New System.Drawing.Size(125, 20)
        Me.txtCabina.TabIndex = 18
        '
        'txtNombreCrucero
        '
        Me.txtNombreCrucero.Location = New System.Drawing.Point(555, 36)
        Me.txtNombreCrucero.Name = "txtNombreCrucero"
        Me.txtNombreCrucero.Size = New System.Drawing.Size(124, 20)
        Me.txtNombreCrucero.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(499, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Cabina"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(499, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Nombre"
        '
        'lstCruceros
        '
        Me.lstCruceros.FormattingEnabled = True
        Me.lstCruceros.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lstCruceros.Location = New System.Drawing.Point(502, 187)
        Me.lstCruceros.Name = "lstCruceros"
        Me.lstCruceros.Size = New System.Drawing.Size(177, 238)
        Me.lstCruceros.TabIndex = 14
        '
        'btnAgregarVuelo
        '
        Me.btnAgregarVuelo.Location = New System.Drawing.Point(734, 138)
        Me.btnAgregarVuelo.Name = "btnAgregarVuelo"
        Me.btnAgregarVuelo.Size = New System.Drawing.Size(110, 27)
        Me.btnAgregarVuelo.TabIndex = 25
        Me.btnAgregarVuelo.Text = "Agregar Vuelo"
        Me.btnAgregarVuelo.UseVisualStyleBackColor = True
        '
        'txtAsiento
        '
        Me.txtAsiento.Location = New System.Drawing.Point(755, 64)
        Me.txtAsiento.Name = "txtAsiento"
        Me.txtAsiento.Size = New System.Drawing.Size(125, 20)
        Me.txtAsiento.TabIndex = 24
        '
        'txtNombreAvion
        '
        Me.txtNombreAvion.Location = New System.Drawing.Point(756, 36)
        Me.txtNombreAvion.Name = "txtNombreAvion"
        Me.txtNombreAvion.Size = New System.Drawing.Size(124, 20)
        Me.txtNombreAvion.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(700, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Asiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(700, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Nombre"
        '
        'lstVuelos
        '
        Me.lstVuelos.FormattingEnabled = True
        Me.lstVuelos.Location = New System.Drawing.Point(703, 187)
        Me.lstVuelos.Name = "lstVuelos"
        Me.lstVuelos.Size = New System.Drawing.Size(177, 238)
        Me.lstVuelos.TabIndex = 20
        '
        'txtPrecioHotel
        '
        Me.txtPrecioHotel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.txtPrecioHotel.Location = New System.Drawing.Point(356, 90)
        Me.txtPrecioHotel.Name = "txtPrecioHotel"
        Me.txtPrecioHotel.Size = New System.Drawing.Size(125, 20)
        Me.txtPrecioHotel.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(301, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Precio"
        '
        'txrPrecioCrucero
        '
        Me.txrPrecioCrucero.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.txrPrecioCrucero.Location = New System.Drawing.Point(554, 90)
        Me.txrPrecioCrucero.Name = "txrPrecioCrucero"
        Me.txrPrecioCrucero.Size = New System.Drawing.Size(125, 20)
        Me.txrPrecioCrucero.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(499, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Precio"
        '
        'txtPrecioVuelo
        '
        Me.txtPrecioVuelo.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.txtPrecioVuelo.Location = New System.Drawing.Point(755, 90)
        Me.txtPrecioVuelo.Name = "txtPrecioVuelo"
        Me.txtPrecioVuelo.Size = New System.Drawing.Size(125, 20)
        Me.txtPrecioVuelo.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(700, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Precio"
        '
        'btnSuscribirHotel
        '
        Me.btnSuscribirHotel.Location = New System.Drawing.Point(303, 431)
        Me.btnSuscribirHotel.Name = "btnSuscribirHotel"
        Me.btnSuscribirHotel.Size = New System.Drawing.Size(173, 22)
        Me.btnSuscribirHotel.TabIndex = 32
        Me.btnSuscribirHotel.Text = "Suscribir"
        Me.btnSuscribirHotel.UseVisualStyleBackColor = True
        '
        'btnSuscribirCrucero
        '
        Me.btnSuscribirCrucero.Location = New System.Drawing.Point(502, 431)
        Me.btnSuscribirCrucero.Name = "btnSuscribirCrucero"
        Me.btnSuscribirCrucero.Size = New System.Drawing.Size(173, 22)
        Me.btnSuscribirCrucero.TabIndex = 33
        Me.btnSuscribirCrucero.Text = "Suscribir"
        Me.btnSuscribirCrucero.UseVisualStyleBackColor = True
        '
        'btnSuscribirVuelo
        '
        Me.btnSuscribirVuelo.Location = New System.Drawing.Point(707, 431)
        Me.btnSuscribirVuelo.Name = "btnSuscribirVuelo"
        Me.btnSuscribirVuelo.Size = New System.Drawing.Size(173, 22)
        Me.btnSuscribirVuelo.TabIndex = 34
        Me.btnSuscribirVuelo.Text = "Suscribir"
        Me.btnSuscribirVuelo.UseVisualStyleBackColor = True
        '
        'frmAterrizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 461)
        Me.Controls.Add(Me.btnSuscribirVuelo)
        Me.Controls.Add(Me.btnSuscribirCrucero)
        Me.Controls.Add(Me.btnSuscribirHotel)
        Me.Controls.Add(Me.txtPrecioVuelo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txrPrecioCrucero)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPrecioHotel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAgregarVuelo)
        Me.Controls.Add(Me.txtAsiento)
        Me.Controls.Add(Me.txtNombreAvion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstVuelos)
        Me.Controls.Add(Me.btnAgregarCrucero)
        Me.Controls.Add(Me.txtCabina)
        Me.Controls.Add(Me.txtNombreCrucero)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstCruceros)
        Me.Controls.Add(Me.btnAgregarHotel)
        Me.Controls.Add(Me.txtCamas)
        Me.Controls.Add(Me.txtNombreHotel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstHoteles)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstClientes)
        Me.Name = "frmAterrizar"
        Me.Text = "Aterrizar.com"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstClientes As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents cmdAgregar As Button
    Friend WithEvents lstHoteles As ListBox
    Friend WithEvents btnAgregarHotel As Button
    Friend WithEvents txtCamas As TextBox
    Friend WithEvents txtNombreHotel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAgregarCrucero As Button
    Friend WithEvents txtCabina As TextBox
    Friend WithEvents txtNombreCrucero As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lstCruceros As ListBox
    Friend WithEvents btnAgregarVuelo As Button
    Friend WithEvents txtAsiento As TextBox
    Friend WithEvents txtNombreAvion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lstVuelos As ListBox
    Friend WithEvents txtPrecioHotel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txrPrecioCrucero As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPrecioVuelo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSuscribirHotel As Button
    Friend WithEvents btnSuscribirCrucero As Button
    Friend WithEvents btnSuscribirVuelo As Button
End Class
