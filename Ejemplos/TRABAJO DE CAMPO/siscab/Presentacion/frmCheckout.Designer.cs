namespace Presentacion
{
    partial class frmCheckout
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
            this.lbl_dniConsulta = new System.Windows.Forms.Label();
            this.txt_dniConsulta = new System.Windows.Forms.TextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.btn_registrarCheckout = new System.Windows.Forms.Button();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_cantHuespedes = new System.Windows.Forms.TextBox();
            this.lbl_cantidadHuespedes = new System.Windows.Forms.Label();
            this.txt_checkout = new System.Windows.Forms.TextBox();
            this.txt_checkin = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_idEstadia = new System.Windows.Forms.TextBox();
            this.lbl_checkout = new System.Windows.Forms.Label();
            this.lbl_checkin = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_dniConsulta
            // 
            this.lbl_dniConsulta.AutoSize = true;
            this.lbl_dniConsulta.Location = new System.Drawing.Point(12, 22);
            this.lbl_dniConsulta.Name = "lbl_dniConsulta";
            this.lbl_dniConsulta.Size = new System.Drawing.Size(89, 15);
            this.lbl_dniConsulta.TabIndex = 0;
            this.lbl_dniConsulta.Text = "DNI del Cliente:";
            // 
            // txt_dniConsulta
            // 
            this.txt_dniConsulta.Location = new System.Drawing.Point(107, 14);
            this.txt_dniConsulta.Name = "txt_dniConsulta";
            this.txt_dniConsulta.Size = new System.Drawing.Size(100, 23);
            this.txt_dniConsulta.TabIndex = 1;
            this.txt_dniConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dniConsulta_KeyPress);
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_consultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_consultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_consultar.Location = new System.Drawing.Point(213, 7);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(91, 34);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.txt_estado);
            this.panel1.Controls.Add(this.btn_registrarCheckout);
            this.panel1.Controls.Add(this.lbl_estado);
            this.panel1.Controls.Add(this.txt_cantHuespedes);
            this.panel1.Controls.Add(this.lbl_cantidadHuespedes);
            this.panel1.Controls.Add(this.txt_checkout);
            this.panel1.Controls.Add(this.txt_checkin);
            this.panel1.Controls.Add(this.txt_dni);
            this.panel1.Controls.Add(this.txt_apellido);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.txt_idEstadia);
            this.panel1.Controls.Add(this.lbl_checkout);
            this.panel1.Controls.Add(this.lbl_checkin);
            this.panel1.Controls.Add(this.lbl_dni);
            this.panel1.Controls.Add(this.lbl_apellido);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Location = new System.Drawing.Point(19, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 172);
            this.panel1.TabIndex = 3;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(412, 97);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(100, 23);
            this.txt_estado.TabIndex = 15;
            // 
            // btn_registrarCheckout
            // 
            this.btn_registrarCheckout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registrarCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_registrarCheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_registrarCheckout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_registrarCheckout.Location = new System.Drawing.Point(380, 135);
            this.btn_registrarCheckout.Name = "btn_registrarCheckout";
            this.btn_registrarCheckout.Size = new System.Drawing.Size(132, 34);
            this.btn_registrarCheckout.TabIndex = 6;
            this.btn_registrarCheckout.Text = "Registrar Checkout";
            this.btn_registrarCheckout.UseVisualStyleBackColor = false;
            this.btn_registrarCheckout.Click += new System.EventHandler(this.btn_registrarCheckout_Click);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_estado.Location = new System.Drawing.Point(345, 99);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(65, 21);
            this.lbl_estado.TabIndex = 14;
            this.lbl_estado.Text = "Estado:";
            // 
            // txt_cantHuespedes
            // 
            this.txt_cantHuespedes.Location = new System.Drawing.Point(88, 77);
            this.txt_cantHuespedes.Name = "txt_cantHuespedes";
            this.txt_cantHuespedes.ReadOnly = true;
            this.txt_cantHuespedes.Size = new System.Drawing.Size(35, 23);
            this.txt_cantHuespedes.TabIndex = 13;
            // 
            // lbl_cantidadHuespedes
            // 
            this.lbl_cantidadHuespedes.AutoSize = true;
            this.lbl_cantidadHuespedes.Location = new System.Drawing.Point(15, 85);
            this.lbl_cantidadHuespedes.Name = "lbl_cantidadHuespedes";
            this.lbl_cantidadHuespedes.Size = new System.Drawing.Size(68, 15);
            this.lbl_cantidadHuespedes.TabIndex = 12;
            this.lbl_cantidadHuespedes.Text = "Huéspedes:";
            // 
            // txt_checkout
            // 
            this.txt_checkout.Location = new System.Drawing.Point(437, 7);
            this.txt_checkout.Name = "txt_checkout";
            this.txt_checkout.ReadOnly = true;
            this.txt_checkout.Size = new System.Drawing.Size(75, 23);
            this.txt_checkout.TabIndex = 11;
            // 
            // txt_checkin
            // 
            this.txt_checkin.Location = new System.Drawing.Point(260, 7);
            this.txt_checkin.Name = "txt_checkin";
            this.txt_checkin.ReadOnly = true;
            this.txt_checkin.Size = new System.Drawing.Size(75, 23);
            this.txt_checkin.TabIndex = 10;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(412, 43);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.ReadOnly = true;
            this.txt_dni.Size = new System.Drawing.Size(100, 23);
            this.txt_dni.TabIndex = 9;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(260, 43);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.ReadOnly = true;
            this.txt_apellido.Size = new System.Drawing.Size(100, 23);
            this.txt_apellido.TabIndex = 8;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(88, 43);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_idEstadia
            // 
            this.txt_idEstadia.Location = new System.Drawing.Point(88, 13);
            this.txt_idEstadia.Name = "txt_idEstadia";
            this.txt_idEstadia.ReadOnly = true;
            this.txt_idEstadia.Size = new System.Drawing.Size(100, 23);
            this.txt_idEstadia.TabIndex = 6;
            // 
            // lbl_checkout
            // 
            this.lbl_checkout.AutoSize = true;
            this.lbl_checkout.Location = new System.Drawing.Point(370, 15);
            this.lbl_checkout.Name = "lbl_checkout";
            this.lbl_checkout.Size = new System.Drawing.Size(61, 15);
            this.lbl_checkout.TabIndex = 5;
            this.lbl_checkout.Text = "Checkout:";
            // 
            // lbl_checkin
            // 
            this.lbl_checkin.AutoSize = true;
            this.lbl_checkin.Location = new System.Drawing.Point(201, 15);
            this.lbl_checkin.Name = "lbl_checkin";
            this.lbl_checkin.Size = new System.Drawing.Size(53, 15);
            this.lbl_checkin.TabIndex = 4;
            this.lbl_checkin.Text = "Checkin:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(376, 51);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(30, 15);
            this.lbl_dni.TabIndex = 3;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(200, 51);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(54, 15);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(15, 51);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(13, 21);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(60, 15);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Id Estadía:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(394, 22);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(41, 15);
            this.lbl_fecha.TabIndex = 4;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(441, 14);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(100, 23);
            this.txt_fecha.TabIndex = 5;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(455, 259);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(86, 27);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 298);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.txt_dniConsulta);
            this.Controls.Add(this.lbl_dniConsulta);
            this.MaximumSize = new System.Drawing.Size(579, 337);
            this.MinimumSize = new System.Drawing.Size(579, 337);
            this.Name = "frmCheckout";
            this.Text = "frmCheckout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCheckout_FormClosing);
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_dniConsulta;
        private TextBox txt_dniConsulta;
        private Button btn_consultar;
        private Panel panel1;
        private Label lbl_dni;
        private Label lbl_apellido;
        private Label lbl_nombre;
        private Label lbl_id;
        private TextBox txt_checkout;
        private TextBox txt_checkin;
        private TextBox txt_dni;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private TextBox txt_idEstadia;
        private Label lbl_checkout;
        private Label lbl_checkin;
        private Label lbl_fecha;
        private TextBox txt_fecha;
        private TextBox txt_cantHuespedes;
        private Label lbl_cantidadHuespedes;
        private TextBox txt_estado;
        private Button btn_registrarCheckout;
        private Label lbl_estado;
        private Button btn_salir;
    }
}