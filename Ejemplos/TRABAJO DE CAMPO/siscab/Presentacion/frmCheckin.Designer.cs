namespace Presentacion
{
    partial class frmCheckin
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
            this.lbl_factura = new System.Windows.Forms.Label();
            this.txt_numeroFactura = new System.Windows.Forms.TextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_fechaHoy = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_checkin = new System.Windows.Forms.Button();
            this.txt_estadia = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_deposito = new System.Windows.Forms.TextBox();
            this.lbl_deposito = new System.Windows.Forms.Label();
            this.txt_noches = new System.Windows.Forms.TextBox();
            this.lbl_noches = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_huespedes = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_tipohabitacion = new System.Windows.Forms.TextBox();
            this.lbl_tipoHabitacion = new System.Windows.Forms.Label();
            this.txt_fechasalida = new System.Windows.Forms.TextBox();
            this.lbl_salida = new System.Windows.Forms.Label();
            this.txt_fechaingreso = new System.Windows.Forms.TextBox();
            this.lbl_ingreso = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_factura
            // 
            this.lbl_factura.AutoSize = true;
            this.lbl_factura.Location = new System.Drawing.Point(148, 19);
            this.lbl_factura.Name = "lbl_factura";
            this.lbl_factura.Size = new System.Drawing.Size(112, 15);
            this.lbl_factura.TabIndex = 0;
            this.lbl_factura.Text = "Número de Factura:";
            // 
            // txt_numeroFactura
            // 
            this.txt_numeroFactura.Location = new System.Drawing.Point(266, 11);
            this.txt_numeroFactura.MaxLength = 10;
            this.txt_numeroFactura.Name = "txt_numeroFactura";
            this.txt_numeroFactura.Size = new System.Drawing.Size(100, 23);
            this.txt_numeroFactura.TabIndex = 1;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(383, 11);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(87, 23);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(7, 20);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(41, 15);
            this.lbl_fecha.TabIndex = 3;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // txt_fechaHoy
            // 
            this.txt_fechaHoy.Location = new System.Drawing.Point(54, 12);
            this.txt_fechaHoy.Name = "txt_fechaHoy";
            this.txt_fechaHoy.ReadOnly = true;
            this.txt_fechaHoy.Size = new System.Drawing.Size(86, 23);
            this.txt_fechaHoy.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_checkin);
            this.panel1.Controls.Add(this.txt_estadia);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.txt_deposito);
            this.panel1.Controls.Add(this.lbl_deposito);
            this.panel1.Controls.Add(this.txt_noches);
            this.panel1.Controls.Add(this.lbl_noches);
            this.panel1.Controls.Add(this.txt_cantidad);
            this.panel1.Controls.Add(this.lbl_huespedes);
            this.panel1.Controls.Add(this.txt_numero);
            this.panel1.Controls.Add(this.lbl_numero);
            this.panel1.Controls.Add(this.txt_tipohabitacion);
            this.panel1.Controls.Add(this.lbl_tipoHabitacion);
            this.panel1.Controls.Add(this.txt_fechasalida);
            this.panel1.Controls.Add(this.lbl_salida);
            this.panel1.Controls.Add(this.txt_fechaingreso);
            this.panel1.Controls.Add(this.lbl_ingreso);
            this.panel1.Controls.Add(this.txt_dni);
            this.panel1.Controls.Add(this.txt_apellido);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.lbl_dni);
            this.panel1.Controls.Add(this.lbl_apellido);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 194);
            this.panel1.TabIndex = 5;
            // 
            // btn_checkin
            // 
            this.btn_checkin.BackColor = System.Drawing.Color.Lime;
            this.btn_checkin.Enabled = false;
            this.btn_checkin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_checkin.Location = new System.Drawing.Point(450, 144);
            this.btn_checkin.Name = "btn_checkin";
            this.btn_checkin.Size = new System.Drawing.Size(164, 34);
            this.btn_checkin.TabIndex = 24;
            this.btn_checkin.Text = "Realizar Checkin";
            this.btn_checkin.UseVisualStyleBackColor = false;
            this.btn_checkin.Click += new System.EventHandler(this.btn_checkin_Click);
            // 
            // txt_estadia
            // 
            this.txt_estadia.Location = new System.Drawing.Point(277, 123);
            this.txt_estadia.Name = "txt_estadia";
            this.txt_estadia.ReadOnly = true;
            this.txt_estadia.Size = new System.Drawing.Size(75, 23);
            this.txt_estadia.TabIndex = 21;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_total.Location = new System.Drawing.Point(151, 122);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(109, 20);
            this.lbl_total.TabIndex = 20;
            this.lbl_total.Text = "Total Estadía $:";
            // 
            // txt_deposito
            // 
            this.txt_deposito.Location = new System.Drawing.Point(277, 152);
            this.txt_deposito.Name = "txt_deposito";
            this.txt_deposito.ReadOnly = true;
            this.txt_deposito.Size = new System.Drawing.Size(75, 23);
            this.txt_deposito.TabIndex = 19;
            // 
            // lbl_deposito
            // 
            this.lbl_deposito.AutoSize = true;
            this.lbl_deposito.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_deposito.Location = new System.Drawing.Point(175, 155);
            this.lbl_deposito.Name = "lbl_deposito";
            this.lbl_deposito.Size = new System.Drawing.Size(85, 20);
            this.lbl_deposito.TabIndex = 18;
            this.lbl_deposito.Text = "Depósito $:";
            // 
            // txt_noches
            // 
            this.txt_noches.Location = new System.Drawing.Point(482, 43);
            this.txt_noches.Name = "txt_noches";
            this.txt_noches.ReadOnly = true;
            this.txt_noches.Size = new System.Drawing.Size(35, 23);
            this.txt_noches.TabIndex = 17;
            // 
            // lbl_noches
            // 
            this.lbl_noches.AutoSize = true;
            this.lbl_noches.Location = new System.Drawing.Point(426, 49);
            this.lbl_noches.Name = "lbl_noches";
            this.lbl_noches.Size = new System.Drawing.Size(50, 15);
            this.lbl_noches.TabIndex = 16;
            this.lbl_noches.Text = "Noches:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(574, 80);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.ReadOnly = true;
            this.txt_cantidad.Size = new System.Drawing.Size(35, 23);
            this.txt_cantidad.TabIndex = 15;
            // 
            // lbl_huespedes
            // 
            this.lbl_huespedes.AutoSize = true;
            this.lbl_huespedes.Location = new System.Drawing.Point(433, 83);
            this.lbl_huespedes.Name = "lbl_huespedes";
            this.lbl_huespedes.Size = new System.Drawing.Size(135, 15);
            this.lbl_huespedes.TabIndex = 14;
            this.lbl_huespedes.Text = "Cantidad de Huéspedes:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(391, 80);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(35, 23);
            this.txt_numero.TabIndex = 13;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(254, 83);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(131, 15);
            this.lbl_numero.TabIndex = 12;
            this.lbl_numero.Text = "Número de Habitación:";
            // 
            // txt_tipohabitacion
            // 
            this.txt_tipohabitacion.Location = new System.Drawing.Point(123, 80);
            this.txt_tipohabitacion.Name = "txt_tipohabitacion";
            this.txt_tipohabitacion.ReadOnly = true;
            this.txt_tipohabitacion.Size = new System.Drawing.Size(109, 23);
            this.txt_tipohabitacion.TabIndex = 11;
            // 
            // lbl_tipoHabitacion
            // 
            this.lbl_tipoHabitacion.AutoSize = true;
            this.lbl_tipoHabitacion.Location = new System.Drawing.Point(7, 83);
            this.lbl_tipoHabitacion.Name = "lbl_tipoHabitacion";
            this.lbl_tipoHabitacion.Size = new System.Drawing.Size(110, 15);
            this.lbl_tipoHabitacion.TabIndex = 10;
            this.lbl_tipoHabitacion.Text = "Tipo de Habitación:";
            // 
            // txt_fechasalida
            // 
            this.txt_fechasalida.Location = new System.Drawing.Point(314, 43);
            this.txt_fechasalida.Name = "txt_fechasalida";
            this.txt_fechasalida.ReadOnly = true;
            this.txt_fechasalida.Size = new System.Drawing.Size(85, 23);
            this.txt_fechasalida.TabIndex = 9;
            // 
            // lbl_salida
            // 
            this.lbl_salida.AutoSize = true;
            this.lbl_salida.Location = new System.Drawing.Point(217, 46);
            this.lbl_salida.Name = "lbl_salida";
            this.lbl_salida.Size = new System.Drawing.Size(91, 15);
            this.lbl_salida.TabIndex = 8;
            this.lbl_salida.Text = "Fecha de Salida:";
            // 
            // txt_fechaingreso
            // 
            this.txt_fechaingreso.Location = new System.Drawing.Point(113, 43);
            this.txt_fechaingreso.Name = "txt_fechaingreso";
            this.txt_fechaingreso.ReadOnly = true;
            this.txt_fechaingreso.Size = new System.Drawing.Size(85, 23);
            this.txt_fechaingreso.TabIndex = 7;
            // 
            // lbl_ingreso
            // 
            this.lbl_ingreso.AutoSize = true;
            this.lbl_ingreso.Location = new System.Drawing.Point(7, 46);
            this.lbl_ingreso.Name = "lbl_ingreso";
            this.lbl_ingreso.Size = new System.Drawing.Size(99, 15);
            this.lbl_ingreso.TabIndex = 6;
            this.lbl_ingreso.Text = "Fecha de Ingreso:";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(464, 5);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.ReadOnly = true;
            this.txt_dni.Size = new System.Drawing.Size(100, 23);
            this.txt_dni.TabIndex = 5;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(277, 5);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.ReadOnly = true;
            this.txt_apellido.Size = new System.Drawing.Size(134, 23);
            this.txt_apellido.TabIndex = 4;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(63, 5);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(134, 23);
            this.txt_nombre.TabIndex = 3;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(428, 13);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(30, 15);
            this.lbl_dni.TabIndex = 2;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(217, 13);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(54, 15);
            this.lbl_apellido.TabIndex = 1;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(3, 13);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(548, 254);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(88, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frmCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 298);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_fechaHoy);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.txt_numeroFactura);
            this.Controls.Add(this.lbl_factura);
            this.MaximumSize = new System.Drawing.Size(676, 337);
            this.MinimumSize = new System.Drawing.Size(676, 337);
            this.Name = "frmCheckin";
            this.Text = "frmCheckin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCheckin_FormClosing);
            this.Load += new System.EventHandler(this.frmCheckin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_factura;
        private TextBox txt_numeroFactura;
        private Button btn_consultar;
        private Label lbl_fecha;
        private TextBox txt_fechaHoy;
        private Panel panel1;
        private Label lbl_apellido;
        private Label lbl_nombre;
        private TextBox txt_cantidad;
        private Label lbl_huespedes;
        private TextBox txt_numero;
        private Label lbl_numero;
        private TextBox txt_tipohabitacion;
        private Label lbl_tipoHabitacion;
        private TextBox txt_fechasalida;
        private Label lbl_salida;
        private TextBox txt_fechaingreso;
        private Label lbl_ingreso;
        private TextBox txt_dni;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private Label lbl_dni;
        private TextBox txt_noches;
        private Label lbl_noches;
        private TextBox txt_estadia;
        private Label lbl_total;
        private TextBox txt_deposito;
        private Label lbl_deposito;
        private Button btn_checkin;
        private Button btn_salir;
    }
}