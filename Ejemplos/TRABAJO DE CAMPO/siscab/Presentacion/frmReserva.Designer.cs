namespace Presentacion
{
    partial class frmReserva
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
            lbl_Habitaciones = new Label();
            dateTimeEntrada = new DateTimePicker();
            dateTimeSalida = new DateTimePicker();
            lbl_entrada = new Label();
            lbl_Salida = new Label();
            lbl_cantHuesp = new Label();
            cb_Huspedes = new ComboBox();
            btn_buscar_alojamiento = new Button();
            dgv_habDisp = new DataGridView();
            grb_busqueda = new GroupBox();
            lbl_precio = new Label();
            gb_informacion = new GroupBox();
            lbl_numero = new Label();
            lbl_total_estadia = new Label();
            lbl_cant_noche = new Label();
            lbl_tipo = new Label();
            lbl_masinfo = new Label();
            btn_iniciar_reserva = new Button();
            lbl_dni = new Label();
            txt_dni = new TextBox();
            grb_Datos = new GroupBox();
            btn_iniciarFacturacion = new Button();
            btn_cancelar = new Button();
            btn_salir = new Button();
            btn_crearCliente = new Button();
            btn_serializacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_habDisp).BeginInit();
            grb_busqueda.SuspendLayout();
            gb_informacion.SuspendLayout();
            grb_Datos.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Habitaciones
            // 
            lbl_Habitaciones.AutoSize = true;
            lbl_Habitaciones.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Habitaciones.Location = new Point(14, 181);
            lbl_Habitaciones.Name = "lbl_Habitaciones";
            lbl_Habitaciones.Size = new Size(233, 25);
            lbl_Habitaciones.TabIndex = 0;
            lbl_Habitaciones.Text = "Habitaciones disponibles";
            // 
            // dateTimeEntrada
            // 
            dateTimeEntrada.CustomFormat = "dd/MM/yyyy";
            dateTimeEntrada.Format = DateTimePickerFormat.Custom;
            dateTimeEntrada.Location = new Point(105, 22);
            dateTimeEntrada.Name = "dateTimeEntrada";
            dateTimeEntrada.Size = new Size(103, 23);
            dateTimeEntrada.TabIndex = 1;
            dateTimeEntrada.Value = new DateTime(2023, 7, 24, 0, 0, 0, 0);
            // 
            // dateTimeSalida
            // 
            dateTimeSalida.CustomFormat = "dd/MM/yyyy";
            dateTimeSalida.Format = DateTimePickerFormat.Custom;
            dateTimeSalida.Location = new Point(103, 51);
            dateTimeSalida.Name = "dateTimeSalida";
            dateTimeSalida.Size = new Size(105, 23);
            dateTimeSalida.TabIndex = 2;
            dateTimeSalida.Value = new DateTime(2023, 10, 22, 0, 0, 0, 0);
            // 
            // lbl_entrada
            // 
            lbl_entrada.AutoSize = true;
            lbl_entrada.Location = new Point(2, 28);
            lbl_entrada.Name = "lbl_entrada";
            lbl_entrada.Size = new Size(97, 15);
            lbl_entrada.TabIndex = 3;
            lbl_entrada.Text = "Fecha de Entrada";
            // 
            // lbl_Salida
            // 
            lbl_Salida.AutoSize = true;
            lbl_Salida.Location = new Point(11, 57);
            lbl_Salida.Name = "lbl_Salida";
            lbl_Salida.Size = new Size(88, 15);
            lbl_Salida.TabIndex = 4;
            lbl_Salida.Text = "Fecha de Salida";
            // 
            // lbl_cantHuesp
            // 
            lbl_cantHuesp.AutoSize = true;
            lbl_cantHuesp.Location = new Point(247, 31);
            lbl_cantHuesp.Name = "lbl_cantHuesp";
            lbl_cantHuesp.Size = new Size(65, 15);
            lbl_cantHuesp.TabIndex = 5;
            lbl_cantHuesp.Text = "Huéspedes";
            // 
            // cb_Huspedes
            // 
            cb_Huspedes.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Huspedes.FormattingEnabled = true;
            cb_Huspedes.Location = new Point(317, 28);
            cb_Huspedes.Name = "cb_Huspedes";
            cb_Huspedes.Size = new Size(41, 23);
            cb_Huspedes.TabIndex = 6;
            // 
            // btn_buscar_alojamiento
            // 
            btn_buscar_alojamiento.Location = new Point(241, 96);
            btn_buscar_alojamiento.Name = "btn_buscar_alojamiento";
            btn_buscar_alojamiento.Size = new Size(127, 42);
            btn_buscar_alojamiento.TabIndex = 7;
            btn_buscar_alojamiento.Text = "Buscar Habitaciones";
            btn_buscar_alojamiento.UseVisualStyleBackColor = true;
            btn_buscar_alojamiento.Click += btn_buscar_alojamiento_Click;
            // 
            // dgv_habDisp
            // 
            dgv_habDisp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_habDisp.Location = new Point(14, 209);
            dgv_habDisp.Name = "dgv_habDisp";
            dgv_habDisp.RowTemplate.Height = 25;
            dgv_habDisp.Size = new Size(446, 161);
            dgv_habDisp.TabIndex = 8;
            dgv_habDisp.CellClick += dgv_habDisp_CellClick;
            // 
            // grb_busqueda
            // 
            grb_busqueda.Controls.Add(dateTimeSalida);
            grb_busqueda.Controls.Add(dateTimeEntrada);
            grb_busqueda.Controls.Add(btn_buscar_alojamiento);
            grb_busqueda.Controls.Add(lbl_entrada);
            grb_busqueda.Controls.Add(cb_Huspedes);
            grb_busqueda.Controls.Add(lbl_Salida);
            grb_busqueda.Controls.Add(lbl_cantHuesp);
            grb_busqueda.Location = new Point(12, 34);
            grb_busqueda.Name = "grb_busqueda";
            grb_busqueda.Size = new Size(389, 144);
            grb_busqueda.TabIndex = 9;
            grb_busqueda.TabStop = false;
            grb_busqueda.Text = "Panel de busqueda";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(12, 47);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(100, 15);
            lbl_precio.TabIndex = 11;
            lbl_precio.Text = "Precio por noche:";
            // 
            // gb_informacion
            // 
            gb_informacion.Controls.Add(lbl_numero);
            gb_informacion.Controls.Add(lbl_total_estadia);
            gb_informacion.Controls.Add(lbl_cant_noche);
            gb_informacion.Controls.Add(lbl_tipo);
            gb_informacion.Controls.Add(lbl_precio);
            gb_informacion.Location = new Point(14, 376);
            gb_informacion.Name = "gb_informacion";
            gb_informacion.Size = new Size(387, 103);
            gb_informacion.TabIndex = 12;
            gb_informacion.TabStop = false;
            gb_informacion.Text = "Información (el precio no incluye el valor del I.V.A.)";
            // 
            // lbl_numero
            // 
            lbl_numero.AutoSize = true;
            lbl_numero.Location = new Point(12, 17);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(132, 15);
            lbl_numero.TabIndex = 15;
            lbl_numero.Text = "Número de habitación: ";
            // 
            // lbl_total_estadia
            // 
            lbl_total_estadia.AutoSize = true;
            lbl_total_estadia.Location = new Point(12, 77);
            lbl_total_estadia.Name = "lbl_total_estadia";
            lbl_total_estadia.Size = new Size(103, 15);
            lbl_total_estadia.TabIndex = 14;
            lbl_total_estadia.Text = "Total de la estadía:";
            // 
            // lbl_cant_noche
            // 
            lbl_cant_noche.AutoSize = true;
            lbl_cant_noche.Location = new Point(12, 62);
            lbl_cant_noche.Name = "lbl_cant_noche";
            lbl_cant_noche.Size = new Size(115, 15);
            lbl_cant_noche.TabIndex = 13;
            lbl_cant_noche.Text = "Cantidad de noches:";
            // 
            // lbl_tipo
            // 
            lbl_tipo.AutoSize = true;
            lbl_tipo.Location = new Point(12, 32);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(108, 15);
            lbl_tipo.TabIndex = 12;
            lbl_tipo.Text = "Tipo de habitación:";
            // 
            // lbl_masinfo
            // 
            lbl_masinfo.AutoSize = true;
            lbl_masinfo.Location = new Point(253, 189);
            lbl_masinfo.Name = "lbl_masinfo";
            lbl_masinfo.Size = new Size(131, 15);
            lbl_masinfo.TabIndex = 13;
            lbl_masinfo.Text = "(Seleccione un registro)";
            // 
            // btn_iniciar_reserva
            // 
            btn_iniciar_reserva.Location = new Point(20, 485);
            btn_iniciar_reserva.Name = "btn_iniciar_reserva";
            btn_iniciar_reserva.Size = new Size(101, 38);
            btn_iniciar_reserva.TabIndex = 14;
            btn_iniciar_reserva.Text = "Iniciar reserva de habitación";
            btn_iniciar_reserva.UseVisualStyleBackColor = true;
            btn_iniciar_reserva.Click += btn_iniciar_reserva_Click;
            // 
            // lbl_dni
            // 
            lbl_dni.AutoSize = true;
            lbl_dni.Location = new Point(6, 27);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(30, 15);
            lbl_dni.TabIndex = 19;
            lbl_dni.Text = "DNI:";
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(39, 19);
            txt_dni.MaxLength = 9;
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(73, 23);
            txt_dni.TabIndex = 20;
            txt_dni.TextAlign = HorizontalAlignment.Right;
            txt_dni.KeyPress += txt_dni_KeyPress;
            // 
            // grb_Datos
            // 
            grb_Datos.Controls.Add(txt_dni);
            grb_Datos.Controls.Add(lbl_dni);
            grb_Datos.Location = new Point(121, 489);
            grb_Datos.Name = "grb_Datos";
            grb_Datos.Size = new Size(130, 53);
            grb_Datos.TabIndex = 21;
            grb_Datos.TabStop = false;
            grb_Datos.Text = "Dato del Cliente";
            // 
            // btn_iniciarFacturacion
            // 
            btn_iniciarFacturacion.Location = new Point(257, 489);
            btn_iniciarFacturacion.Name = "btn_iniciarFacturacion";
            btn_iniciarFacturacion.Size = new Size(101, 38);
            btn_iniciarFacturacion.TabIndex = 22;
            btn_iniciarFacturacion.Text = "Iniciar Facturación";
            btn_iniciarFacturacion.UseVisualStyleBackColor = true;
            btn_iniciarFacturacion.Click += btn_iniciarFacturacion_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(257, 533);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(101, 38);
            btn_cancelar.TabIndex = 23;
            btn_cancelar.Text = "Cancelar reserva";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(377, 556);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(91, 30);
            btn_salir.TabIndex = 24;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_crearCliente
            // 
            btn_crearCliente.BackColor = SystemColors.ActiveCaptionText;
            btn_crearCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_crearCliente.ForeColor = SystemColors.ButtonHighlight;
            btn_crearCliente.Location = new Point(377, 520);
            btn_crearCliente.Name = "btn_crearCliente";
            btn_crearCliente.Size = new Size(91, 30);
            btn_crearCliente.TabIndex = 25;
            btn_crearCliente.Text = "Alta Cliente";
            btn_crearCliente.UseVisualStyleBackColor = false;
            btn_crearCliente.Click += btn_crearCliente_Click;
            // 
            // btn_serializacion
            // 
            btn_serializacion.BackColor = SystemColors.ActiveCaptionText;
            btn_serializacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_serializacion.ForeColor = SystemColors.ButtonHighlight;
            btn_serializacion.Location = new Point(378, 489);
            btn_serializacion.Name = "btn_serializacion";
            btn_serializacion.Size = new Size(91, 30);
            btn_serializacion.TabIndex = 26;
            btn_serializacion.Text = "Serializar";
            btn_serializacion.UseVisualStyleBackColor = false;
            btn_serializacion.Click += btn_serializacion_Click;
            // 
            // frmReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 598);
            Controls.Add(btn_serializacion);
            Controls.Add(btn_crearCliente);
            Controls.Add(btn_salir);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_iniciarFacturacion);
            Controls.Add(grb_Datos);
            Controls.Add(btn_iniciar_reserva);
            Controls.Add(lbl_masinfo);
            Controls.Add(gb_informacion);
            Controls.Add(grb_busqueda);
            Controls.Add(dgv_habDisp);
            Controls.Add(lbl_Habitaciones);
            MaximumSize = new Size(496, 637);
            MinimumSize = new Size(496, 637);
            Name = "frmReserva";
            Text = "frmReserva";
            FormClosing += frmReserva_FormClosing;
            Load += frmReserva_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_habDisp).EndInit();
            grb_busqueda.ResumeLayout(false);
            grb_busqueda.PerformLayout();
            gb_informacion.ResumeLayout(false);
            gb_informacion.PerformLayout();
            grb_Datos.ResumeLayout(false);
            grb_Datos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Habitaciones;
        private DateTimePicker dateTimeEntrada;
        private DateTimePicker dateTimeSalida;
        private Label lbl_entrada;
        private Label lbl_Salida;
        private Label lbl_cantHuesp;
        private ComboBox cb_Huspedes;
        private Button btn_buscar_alojamiento;
        private DataGridView dgv_habDisp;
        private GroupBox grb_busqueda;
        private Label lbl_precio;
        private GroupBox gb_informacion;
        private Label lbl_total_estadia;
        private Label lbl_cant_noche;
        private Label lbl_tipo;
        private Label lbl_numero;
        private Label lbl_masinfo;
        private Button btn_iniciar_reserva;
        private Label lbl_dni;
        private TextBox txt_dni;
        private GroupBox grb_Datos;
        private Button btn_iniciarFacturacion;
        private Button btn_cancelar;
        private Button btn_salir;
        private Button btn_crearCliente;
        private Button btn_serializacion;
    }
}