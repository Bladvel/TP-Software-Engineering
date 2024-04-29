namespace Presentacion
{
    partial class frmFacturarReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_reservas = new DataGridView();
            panel1 = new Panel();
            lbl_observacion = new Label();
            txt_deposito = new TextBox();
            lbl_deposito = new Label();
            txt_lugar = new TextBox();
            txt_fecha = new TextBox();
            txt_total = new TextBox();
            txt_iva = new TextBox();
            txt_subtotal = new TextBox();
            lbl_total = new Label();
            lbl_iva = new Label();
            lbl_subtotal = new Label();
            txt_precio = new TextBox();
            txt_noches = new TextBox();
            lbl_precio = new Label();
            lbl_noches = new Label();
            txt_descripcion = new TextBox();
            lbl_descripcion = new Label();
            txt_email = new TextBox();
            txt_telefono_fijo = new TextBox();
            txt_telefono_movil = new TextBox();
            txt_domicilio = new TextBox();
            txt_dni = new TextBox();
            txt_apellido = new TextBox();
            txt_nombre = new TextBox();
            lbl_lugar = new Label();
            lbl_fecha = new Label();
            lbl_email = new Label();
            lbl_telefono_fijo = new Label();
            lbl_dni = new Label();
            lbl_telefono_movil = new Label();
            lbl_direccion = new Label();
            lbl_apellido = new Label();
            lbl_nombre = new Label();
            lbl_facturacion = new Label();
            lbl_datos = new Label();
            btn_facturar = new Button();
            btn_cancelar = new Button();
            btn_salir = new Button();
            gb_pago = new GroupBox();
            cb_banco = new ComboBox();
            lbl_banco = new Label();
            lbl_cuotas = new Label();
            txt_cuotas = new TextBox();
            cb_tipo = new ComboBox();
            lbl_tipo = new Label();
            datetimerVencimiento = new DateTimePicker();
            lbl_codigo = new Label();
            lbl_vencimiento = new Label();
            lbl_numero = new Label();
            txt_codigo = new TextBox();
            txt_numerotarjeta = new TextBox();
            lbl_procesador = new Label();
            cb_tarjeta = new ComboBox();
            btn_serializacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_reservas).BeginInit();
            panel1.SuspendLayout();
            gb_pago.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_reservas
            // 
            dgv_reservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_reservas.Location = new Point(24, 32);
            dgv_reservas.Name = "dgv_reservas";
            dgv_reservas.RowHeadersVisible = false;
            dgv_reservas.RowTemplate.Height = 25;
            dgv_reservas.Size = new Size(559, 139);
            dgv_reservas.TabIndex = 0;
            dgv_reservas.CellClick += dgv_reservas_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(lbl_observacion);
            panel1.Controls.Add(txt_deposito);
            panel1.Controls.Add(lbl_deposito);
            panel1.Controls.Add(txt_lugar);
            panel1.Controls.Add(txt_fecha);
            panel1.Controls.Add(txt_total);
            panel1.Controls.Add(txt_iva);
            panel1.Controls.Add(txt_subtotal);
            panel1.Controls.Add(lbl_total);
            panel1.Controls.Add(lbl_iva);
            panel1.Controls.Add(lbl_subtotal);
            panel1.Controls.Add(txt_precio);
            panel1.Controls.Add(txt_noches);
            panel1.Controls.Add(lbl_precio);
            panel1.Controls.Add(lbl_noches);
            panel1.Controls.Add(txt_descripcion);
            panel1.Controls.Add(lbl_descripcion);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_telefono_fijo);
            panel1.Controls.Add(txt_telefono_movil);
            panel1.Controls.Add(txt_domicilio);
            panel1.Controls.Add(txt_dni);
            panel1.Controls.Add(txt_apellido);
            panel1.Controls.Add(txt_nombre);
            panel1.Controls.Add(lbl_lugar);
            panel1.Controls.Add(lbl_fecha);
            panel1.Controls.Add(lbl_email);
            panel1.Controls.Add(lbl_telefono_fijo);
            panel1.Controls.Add(lbl_dni);
            panel1.Controls.Add(lbl_telefono_movil);
            panel1.Controls.Add(lbl_direccion);
            panel1.Controls.Add(lbl_apellido);
            panel1.Controls.Add(lbl_nombre);
            panel1.Location = new Point(24, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 352);
            panel1.TabIndex = 1;
            // 
            // lbl_observacion
            // 
            lbl_observacion.AutoSize = true;
            lbl_observacion.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_observacion.Location = new Point(7, 330);
            lbl_observacion.Name = "lbl_observacion";
            lbl_observacion.Size = new Size(247, 15);
            lbl_observacion.TabIndex = 32;
            lbl_observacion.Text = "*Corresponde a un 10% del total de la estadía";
            // 
            // txt_deposito
            // 
            txt_deposito.Location = new Point(405, 315);
            txt_deposito.Name = "txt_deposito";
            txt_deposito.ReadOnly = true;
            txt_deposito.Size = new Size(80, 23);
            txt_deposito.TabIndex = 31;
            txt_deposito.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_deposito
            // 
            lbl_deposito.AutoSize = true;
            lbl_deposito.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbl_deposito.Location = new Point(302, 323);
            lbl_deposito.Name = "lbl_deposito";
            lbl_deposito.Size = new Size(102, 15);
            lbl_deposito.TabIndex = 30;
            lbl_deposito.Text = "*Total a depositar:";
            // 
            // txt_lugar
            // 
            txt_lugar.Location = new Point(344, 12);
            txt_lugar.Name = "txt_lugar";
            txt_lugar.ReadOnly = true;
            txt_lugar.Size = new Size(197, 23);
            txt_lugar.TabIndex = 29;
            // 
            // txt_fecha
            // 
            txt_fecha.Location = new Point(71, 12);
            txt_fecha.Name = "txt_fecha";
            txt_fecha.ReadOnly = true;
            txt_fecha.Size = new Size(146, 23);
            txt_fecha.TabIndex = 28;
            // 
            // txt_total
            // 
            txt_total.Location = new Point(405, 283);
            txt_total.Name = "txt_total";
            txt_total.ReadOnly = true;
            txt_total.Size = new Size(80, 23);
            txt_total.TabIndex = 27;
            txt_total.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_iva
            // 
            txt_iva.Location = new Point(405, 253);
            txt_iva.Name = "txt_iva";
            txt_iva.ReadOnly = true;
            txt_iva.Size = new Size(80, 23);
            txt_iva.TabIndex = 26;
            txt_iva.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_subtotal
            // 
            txt_subtotal.Location = new Point(405, 226);
            txt_subtotal.Name = "txt_subtotal";
            txt_subtotal.ReadOnly = true;
            txt_subtotal.Size = new Size(80, 23);
            txt_subtotal.TabIndex = 25;
            txt_subtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(359, 290);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(35, 15);
            lbl_total.TabIndex = 24;
            lbl_total.Text = "Total:";
            // 
            // lbl_iva
            // 
            lbl_iva.AutoSize = true;
            lbl_iva.Location = new Point(357, 261);
            lbl_iva.Name = "lbl_iva";
            lbl_iva.Size = new Size(37, 15);
            lbl_iva.TabIndex = 23;
            lbl_iva.Text = "I.V.A.:";
            // 
            // lbl_subtotal
            // 
            lbl_subtotal.AutoSize = true;
            lbl_subtotal.Location = new Point(345, 234);
            lbl_subtotal.Name = "lbl_subtotal";
            lbl_subtotal.Size = new Size(54, 15);
            lbl_subtotal.TabIndex = 22;
            lbl_subtotal.Text = "Subtotal:";
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(255, 258);
            txt_precio.Name = "txt_precio";
            txt_precio.ReadOnly = true;
            txt_precio.Size = new Size(67, 23);
            txt_precio.TabIndex = 21;
            txt_precio.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_noches
            // 
            txt_noches.Location = new Point(255, 226);
            txt_noches.Name = "txt_noches";
            txt_noches.ReadOnly = true;
            txt_noches.Size = new Size(44, 23);
            txt_noches.TabIndex = 20;
            txt_noches.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(144, 261);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(100, 15);
            lbl_precio.TabIndex = 19;
            lbl_precio.Text = "Precio por noche:";
            // 
            // lbl_noches
            // 
            lbl_noches.AutoSize = true;
            lbl_noches.Location = new Point(129, 234);
            lbl_noches.Name = "lbl_noches";
            lbl_noches.Size = new Size(115, 15);
            lbl_noches.TabIndex = 18;
            lbl_noches.Text = "Cantidad de noches:";
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(96, 156);
            txt_descripcion.Multiline = true;
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.ReadOnly = true;
            txt_descripcion.Size = new Size(433, 47);
            txt_descripcion.TabIndex = 17;
            // 
            // lbl_descripcion
            // 
            lbl_descripcion.AutoSize = true;
            lbl_descripcion.Location = new Point(11, 158);
            lbl_descripcion.Name = "lbl_descripcion";
            lbl_descripcion.Size = new Size(72, 15);
            lbl_descripcion.TabIndex = 16;
            lbl_descripcion.Text = "Descripción:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(365, 79);
            txt_email.Name = "txt_email";
            txt_email.ReadOnly = true;
            txt_email.Size = new Size(164, 23);
            txt_email.TabIndex = 15;
            // 
            // txt_telefono_fijo
            // 
            txt_telefono_fijo.Location = new Point(358, 117);
            txt_telefono_fijo.Name = "txt_telefono_fijo";
            txt_telefono_fijo.ReadOnly = true;
            txt_telefono_fijo.Size = new Size(125, 23);
            txt_telefono_fijo.TabIndex = 14;
            // 
            // txt_telefono_movil
            // 
            txt_telefono_movil.Location = new Point(123, 117);
            txt_telefono_movil.Name = "txt_telefono_movil";
            txt_telefono_movil.ReadOnly = true;
            txt_telefono_movil.Size = new Size(125, 23);
            txt_telefono_movil.TabIndex = 13;
            // 
            // txt_domicilio
            // 
            txt_domicilio.Location = new Point(70, 79);
            txt_domicilio.Name = "txt_domicilio";
            txt_domicilio.ReadOnly = true;
            txt_domicilio.Size = new Size(229, 23);
            txt_domicilio.TabIndex = 12;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(380, 47);
            txt_dni.Name = "txt_dni";
            txt_dni.ReadOnly = true;
            txt_dni.Size = new Size(97, 23);
            txt_dni.TabIndex = 11;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(237, 47);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.ReadOnly = true;
            txt_apellido.Size = new Size(101, 23);
            txt_apellido.TabIndex = 10;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(70, 47);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.ReadOnly = true;
            txt_nombre.Size = new Size(101, 23);
            txt_nombre.TabIndex = 9;
            // 
            // lbl_lugar
            // 
            lbl_lugar.AutoSize = true;
            lbl_lugar.Location = new Point(298, 20);
            lbl_lugar.Name = "lbl_lugar";
            lbl_lugar.Size = new Size(40, 15);
            lbl_lugar.TabIndex = 8;
            lbl_lugar.Text = "Lugar:";
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.Location = new Point(23, 20);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(41, 15);
            lbl_fecha.TabIndex = 7;
            lbl_fecha.Text = "Fecha:";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(320, 87);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(39, 15);
            lbl_email.TabIndex = 6;
            lbl_email.Text = "Email:";
            // 
            // lbl_telefono_fijo
            // 
            lbl_telefono_fijo.AutoSize = true;
            lbl_telefono_fijo.Location = new Point(277, 125);
            lbl_telefono_fijo.Name = "lbl_telefono_fijo";
            lbl_telefono_fijo.Size = new Size(75, 15);
            lbl_telefono_fijo.TabIndex = 5;
            lbl_telefono_fijo.Text = "Teléfono fijo:";
            // 
            // lbl_dni
            // 
            lbl_dni.AutoSize = true;
            lbl_dni.Location = new Point(344, 55);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(30, 15);
            lbl_dni.TabIndex = 4;
            lbl_dni.Text = "DNI:";
            // 
            // lbl_telefono_movil
            // 
            lbl_telefono_movil.AutoSize = true;
            lbl_telefono_movil.Location = new Point(10, 125);
            lbl_telefono_movil.Name = "lbl_telefono_movil";
            lbl_telefono_movil.Size = new Size(88, 15);
            lbl_telefono_movil.TabIndex = 3;
            lbl_telefono_movil.Text = "Teléfono móvil:";
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Location = new Point(10, 87);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(60, 15);
            lbl_direccion.TabIndex = 2;
            lbl_direccion.Text = "Dirección:";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(177, 55);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(54, 15);
            lbl_apellido.TabIndex = 1;
            lbl_apellido.Text = "Apellido:";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(10, 55);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(54, 15);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre:";
            // 
            // lbl_facturacion
            // 
            lbl_facturacion.AutoSize = true;
            lbl_facturacion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_facturacion.Location = new Point(24, 187);
            lbl_facturacion.Name = "lbl_facturacion";
            lbl_facturacion.Size = new Size(275, 20);
            lbl_facturacion.TabIndex = 2;
            lbl_facturacion.Text = "Facturación de la reserva seleccionada:";
            // 
            // lbl_datos
            // 
            lbl_datos.AutoSize = true;
            lbl_datos.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_datos.Location = new Point(24, 9);
            lbl_datos.Name = "lbl_datos";
            lbl_datos.Size = new Size(144, 20);
            lbl_datos.TabIndex = 3;
            lbl_datos.Text = "Reservas a facturar:";
            // 
            // btn_facturar
            // 
            btn_facturar.Location = new Point(14, 233);
            btn_facturar.Name = "btn_facturar";
            btn_facturar.Size = new Size(89, 27);
            btn_facturar.TabIndex = 4;
            btn_facturar.Text = "  Facturar ";
            btn_facturar.UseVisualStyleBackColor = true;
            btn_facturar.Click += btn_facturar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(109, 234);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(89, 27);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(715, 541);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(89, 27);
            btn_salir.TabIndex = 6;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // gb_pago
            // 
            gb_pago.Controls.Add(cb_banco);
            gb_pago.Controls.Add(lbl_banco);
            gb_pago.Controls.Add(lbl_cuotas);
            gb_pago.Controls.Add(txt_cuotas);
            gb_pago.Controls.Add(cb_tipo);
            gb_pago.Controls.Add(lbl_tipo);
            gb_pago.Controls.Add(datetimerVencimiento);
            gb_pago.Controls.Add(lbl_codigo);
            gb_pago.Controls.Add(lbl_vencimiento);
            gb_pago.Controls.Add(lbl_numero);
            gb_pago.Controls.Add(txt_codigo);
            gb_pago.Controls.Add(txt_numerotarjeta);
            gb_pago.Controls.Add(lbl_procesador);
            gb_pago.Controls.Add(cb_tarjeta);
            gb_pago.Controls.Add(btn_facturar);
            gb_pago.Controls.Add(btn_cancelar);
            gb_pago.Location = new Point(596, 237);
            gb_pago.Name = "gb_pago";
            gb_pago.Size = new Size(221, 286);
            gb_pago.TabIndex = 7;
            gb_pago.TabStop = false;
            gb_pago.Text = "Módulo Pago";
            // 
            // cb_banco
            // 
            cb_banco.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_banco.FormattingEnabled = true;
            cb_banco.Location = new Point(14, 102);
            cb_banco.Name = "cb_banco";
            cb_banco.Size = new Size(175, 23);
            cb_banco.TabIndex = 26;
            // 
            // lbl_banco
            // 
            lbl_banco.AutoSize = true;
            lbl_banco.Location = new Point(14, 84);
            lbl_banco.Name = "lbl_banco";
            lbl_banco.Size = new Size(43, 15);
            lbl_banco.TabIndex = 25;
            lbl_banco.Text = "Banco:";
            // 
            // lbl_cuotas
            // 
            lbl_cuotas.AutoSize = true;
            lbl_cuotas.Location = new Point(148, 191);
            lbl_cuotas.Name = "lbl_cuotas";
            lbl_cuotas.Size = new Size(47, 15);
            lbl_cuotas.TabIndex = 24;
            lbl_cuotas.Text = "Cuotas:";
            // 
            // txt_cuotas
            // 
            txt_cuotas.Location = new Point(150, 209);
            txt_cuotas.MaxLength = 3;
            txt_cuotas.Name = "txt_cuotas";
            txt_cuotas.Size = new Size(39, 23);
            txt_cuotas.TabIndex = 23;
            txt_cuotas.KeyPress += txt_cuotas_KeyPress;
            // 
            // cb_tipo
            // 
            cb_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipo.FormattingEnabled = true;
            cb_tipo.Location = new Point(10, 45);
            cb_tipo.Name = "cb_tipo";
            cb_tipo.Size = new Size(75, 23);
            cb_tipo.TabIndex = 22;
            cb_tipo.SelectedValueChanged += cb_tipo_SelectedValueChanged;
            // 
            // lbl_tipo
            // 
            lbl_tipo.AutoSize = true;
            lbl_tipo.Location = new Point(6, 27);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(86, 15);
            lbl_tipo.TabIndex = 21;
            lbl_tipo.Text = "Tipo de Tarjeta:";
            // 
            // datetimerVencimiento
            // 
            datetimerVencimiento.CustomFormat = "MM/yy";
            datetimerVencimiento.Format = DateTimePickerFormat.Custom;
            datetimerVencimiento.Location = new Point(19, 206);
            datetimerVencimiento.Name = "datetimerVencimiento";
            datetimerVencimiento.Size = new Size(57, 23);
            datetimerVencimiento.TabIndex = 20;
            // 
            // lbl_codigo
            // 
            lbl_codigo.AutoSize = true;
            lbl_codigo.Location = new Point(148, 139);
            lbl_codigo.Name = "lbl_codigo";
            lbl_codigo.Size = new Size(49, 15);
            lbl_codigo.TabIndex = 19;
            lbl_codigo.Text = "Código:";
            // 
            // lbl_vencimiento
            // 
            lbl_vencimiento.AutoSize = true;
            lbl_vencimiento.Location = new Point(19, 188);
            lbl_vencimiento.Name = "lbl_vencimiento";
            lbl_vencimiento.Size = new Size(76, 15);
            lbl_vencimiento.TabIndex = 18;
            lbl_vencimiento.Text = "Vencimiento:";
            // 
            // lbl_numero
            // 
            lbl_numero.AutoSize = true;
            lbl_numero.Location = new Point(19, 139);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(107, 15);
            lbl_numero.TabIndex = 17;
            lbl_numero.Text = "Número de Tarjeta:";
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(150, 157);
            txt_codigo.MaxLength = 3;
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(39, 23);
            txt_codigo.TabIndex = 16;
            txt_codigo.KeyPress += txt_codigo_KeyPress;
            // 
            // txt_numerotarjeta
            // 
            txt_numerotarjeta.Location = new Point(19, 157);
            txt_numerotarjeta.MaxLength = 16;
            txt_numerotarjeta.Name = "txt_numerotarjeta";
            txt_numerotarjeta.Size = new Size(108, 23);
            txt_numerotarjeta.TabIndex = 10;
            txt_numerotarjeta.KeyPress += txt_numerotarjeta_KeyPress;
            // 
            // lbl_procesador
            // 
            lbl_procesador.AutoSize = true;
            lbl_procesador.Location = new Point(98, 27);
            lbl_procesador.Name = "lbl_procesador";
            lbl_procesador.Size = new Size(44, 15);
            lbl_procesador.TabIndex = 9;
            lbl_procesador.Text = "Tarjeta:";
            // 
            // cb_tarjeta
            // 
            cb_tarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tarjeta.FormattingEnabled = true;
            cb_tarjeta.Location = new Point(98, 45);
            cb_tarjeta.Name = "cb_tarjeta";
            cb_tarjeta.Size = new Size(111, 23);
            cb_tarjeta.TabIndex = 8;
            // 
            // btn_serializacion
            // 
            btn_serializacion.BackColor = SystemColors.ActiveCaptionText;
            btn_serializacion.ForeColor = SystemColors.ButtonHighlight;
            btn_serializacion.Location = new Point(630, 133);
            btn_serializacion.Name = "btn_serializacion";
            btn_serializacion.Size = new Size(161, 38);
            btn_serializacion.TabIndex = 8;
            btn_serializacion.Text = "Deserialización -RollBack";
            btn_serializacion.UseVisualStyleBackColor = false;
            btn_serializacion.Click += btn_serializacion_Click;
            // 
            // frmFacturarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 581);
            Controls.Add(btn_serializacion);
            Controls.Add(gb_pago);
            Controls.Add(btn_salir);
            Controls.Add(lbl_datos);
            Controls.Add(lbl_facturacion);
            Controls.Add(panel1);
            Controls.Add(dgv_reservas);
            MaximumSize = new Size(845, 620);
            MinimumSize = new Size(845, 620);
            Name = "frmFacturarReserva";
            Text = "frmFacturarReserva";
            FormClosing += frmFacturarReserva_FormClosing;
            Load += frmFacturarReserva_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_reservas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gb_pago.ResumeLayout(false);
            gb_pago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_reservas;
        private Panel panel1;
        private TextBox txt_descripcion;
        private Label lbl_descripcion;
        private TextBox txt_email;
        private TextBox txt_telefono_fijo;
        private TextBox txt_telefono_movil;
        private TextBox txt_domicilio;
        private TextBox txt_dni;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private Label lbl_lugar;
        private Label lbl_fecha;
        private Label lbl_email;
        private Label lbl_telefono_fijo;
        private Label lbl_dni;
        private Label lbl_telefono_movil;
        private Label lbl_direccion;
        private Label lbl_apellido;
        private Label lbl_nombre;
        private Label lbl_facturacion;
        private Label lbl_precio;
        private Label lbl_noches;
        private Label lbl_datos;
        private Label lbl_total;
        private Label lbl_iva;
        private Label lbl_subtotal;
        private TextBox txt_precio;
        private TextBox txt_noches;
        private Button btn_facturar;
        private TextBox txt_total;
        private TextBox txt_iva;
        private TextBox txt_subtotal;
        private TextBox txt_lugar;
        private TextBox txt_fecha;
        private TextBox txt_deposito;
        private Label lbl_deposito;
        private Label lbl_observacion;
        private Button btn_cancelar;
        private Button btn_salir;
        private GroupBox gb_pago;
        private TextBox txt_numerotarjeta;
        private Label lbl_procesador;
        private ComboBox cb_tarjeta;
        private Label lbl_codigo;
        private Label lbl_vencimiento;
        private Label lbl_numero;
        private TextBox txt_codigo;
        private DateTimePicker datetimerVencimiento;
        private ComboBox cb_tipo;
        private Label lbl_tipo;
        private Label lbl_cuotas;
        private TextBox txt_cuotas;
        private Label lbl_banco;
        private ComboBox cb_banco;
        private Button btn_serializacion;
    }
}