namespace Presentacion
{
    partial class frmFacturarHospedaje
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
            this.dgv_estadias = new System.Windows.Forms.DataGridView();
            this.lbl_dniConsulta = new System.Windows.Forms.Label();
            this.txt_dniConsulta = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_telefonomovil = new System.Windows.Forms.TextBox();
            this.txt_telefonofijo = new System.Windows.Forms.TextBox();
            this.lbl_telefono_movil = new System.Windows.Forms.Label();
            this.lbl_telefono_fijo = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_lugar = new System.Windows.Forms.TextBox();
            this.lbl_lugar = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_deposito = new System.Windows.Forms.Label();
            this.lbl_diferencia = new System.Windows.Forms.Label();
            this.txt_total_estadia = new System.Windows.Forms.TextBox();
            this.txt_deposito = new System.Windows.Forms.TextBox();
            this.txt_total_pagar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_metodo_pago = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_generarFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadias)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_estadias
            // 
            this.dgv_estadias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_estadias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estadias.Location = new System.Drawing.Point(13, 47);
            this.dgv_estadias.Name = "dgv_estadias";
            this.dgv_estadias.RowTemplate.Height = 25;
            this.dgv_estadias.Size = new System.Drawing.Size(840, 224);
            this.dgv_estadias.TabIndex = 0;
            this.dgv_estadias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_estadias_CellClick);
            // 
            // lbl_dniConsulta
            // 
            this.lbl_dniConsulta.AutoSize = true;
            this.lbl_dniConsulta.Location = new System.Drawing.Point(13, 16);
            this.lbl_dniConsulta.Name = "lbl_dniConsulta";
            this.lbl_dniConsulta.Size = new System.Drawing.Size(71, 15);
            this.lbl_dniConsulta.TabIndex = 1;
            this.lbl_dniConsulta.Text = "Ingrese DNI:";
            // 
            // txt_dniConsulta
            // 
            this.txt_dniConsulta.Location = new System.Drawing.Point(90, 8);
            this.txt_dniConsulta.Name = "txt_dniConsulta";
            this.txt_dniConsulta.Size = new System.Drawing.Size(100, 23);
            this.txt_dniConsulta.TabIndex = 2;
            this.txt_dniConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dniConsulta_KeyPress);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buscar.Location = new System.Drawing.Point(206, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(105, 27);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txt_descripcion);
            this.panel1.Controls.Add(this.lbl_descripcion);
            this.panel1.Controls.Add(this.txt_telefonomovil);
            this.panel1.Controls.Add(this.txt_telefonofijo);
            this.panel1.Controls.Add(this.lbl_telefono_movil);
            this.panel1.Controls.Add(this.lbl_telefono_fijo);
            this.panel1.Controls.Add(this.txt_direccion);
            this.panel1.Controls.Add(this.txt_dni);
            this.panel1.Controls.Add(this.txt_apellido);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.lbl_direccion);
            this.panel1.Controls.Add(this.lbl_dni);
            this.panel1.Controls.Add(this.lbl_apellido);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Controls.Add(this.txt_lugar);
            this.panel1.Controls.Add(this.lbl_lugar);
            this.panel1.Controls.Add(this.txt_fecha);
            this.panel1.Controls.Add(this.lbl_fecha);
            this.panel1.Location = new System.Drawing.Point(16, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 153);
            this.panel1.TabIndex = 4;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(101, 109);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ReadOnly = true;
            this.txt_descripcion.Size = new System.Drawing.Size(690, 28);
            this.txt_descripcion.TabIndex = 17;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(23, 122);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(72, 15);
            this.lbl_descripcion.TabIndex = 16;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // txt_telefonomovil
            // 
            this.txt_telefonomovil.Location = new System.Drawing.Point(348, 71);
            this.txt_telefonomovil.Name = "txt_telefonomovil";
            this.txt_telefonomovil.ReadOnly = true;
            this.txt_telefonomovil.Size = new System.Drawing.Size(139, 23);
            this.txt_telefonomovil.TabIndex = 15;
            // 
            // txt_telefonofijo
            // 
            this.txt_telefonofijo.Location = new System.Drawing.Point(101, 71);
            this.txt_telefonofijo.Name = "txt_telefonofijo";
            this.txt_telefonofijo.ReadOnly = true;
            this.txt_telefonofijo.Size = new System.Drawing.Size(139, 23);
            this.txt_telefonofijo.TabIndex = 14;
            // 
            // lbl_telefono_movil
            // 
            this.lbl_telefono_movil.AutoSize = true;
            this.lbl_telefono_movil.Location = new System.Drawing.Point(254, 79);
            this.lbl_telefono_movil.Name = "lbl_telefono_movil";
            this.lbl_telefono_movil.Size = new System.Drawing.Size(88, 15);
            this.lbl_telefono_movil.TabIndex = 13;
            this.lbl_telefono_movil.Text = "Teléfono Movil:";
            // 
            // lbl_telefono_fijo
            // 
            this.lbl_telefono_fijo.AutoSize = true;
            this.lbl_telefono_fijo.Location = new System.Drawing.Point(18, 79);
            this.lbl_telefono_fijo.Name = "lbl_telefono_fijo";
            this.lbl_telefono_fijo.Size = new System.Drawing.Size(77, 15);
            this.lbl_telefono_fijo.TabIndex = 12;
            this.lbl_telefono_fijo.Text = "Teléfono Fijo:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(588, 41);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.ReadOnly = true;
            this.txt_direccion.Size = new System.Drawing.Size(177, 23);
            this.txt_direccion.TabIndex = 11;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(403, 41);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.ReadOnly = true;
            this.txt_dni.Size = new System.Drawing.Size(92, 23);
            this.txt_dni.TabIndex = 10;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(246, 41);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.ReadOnly = true;
            this.txt_apellido.Size = new System.Drawing.Size(100, 23);
            this.txt_apellido.TabIndex = 9;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(74, 41);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre.TabIndex = 8;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(522, 49);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(60, 15);
            this.lbl_direccion.TabIndex = 7;
            this.lbl_direccion.Text = "Dirección:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(367, 49);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(30, 15);
            this.lbl_dni.TabIndex = 6;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(186, 49);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(54, 15);
            this.lbl_apellido.TabIndex = 5;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(14, 49);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_lugar
            // 
            this.txt_lugar.Location = new System.Drawing.Point(348, 9);
            this.txt_lugar.Name = "txt_lugar";
            this.txt_lugar.ReadOnly = true;
            this.txt_lugar.Size = new System.Drawing.Size(198, 23);
            this.txt_lugar.TabIndex = 3;
            // 
            // lbl_lugar
            // 
            this.lbl_lugar.AutoSize = true;
            this.lbl_lugar.Location = new System.Drawing.Point(302, 17);
            this.lbl_lugar.Name = "lbl_lugar";
            this.lbl_lugar.Size = new System.Drawing.Size(40, 15);
            this.lbl_lugar.TabIndex = 2;
            this.lbl_lugar.Text = "Lugar:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(61, 9);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(188, 23);
            this.txt_fecha.TabIndex = 1;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(14, 17);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(41, 15);
            this.lbl_fecha.TabIndex = 0;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(87, 12);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(75, 15);
            this.lbl_total.TabIndex = 18;
            this.lbl_total.Text = "Total Estadía:";
            // 
            // lbl_deposito
            // 
            this.lbl_deposito.AutoSize = true;
            this.lbl_deposito.Location = new System.Drawing.Point(105, 41);
            this.lbl_deposito.Name = "lbl_deposito";
            this.lbl_deposito.Size = new System.Drawing.Size(57, 15);
            this.lbl_deposito.TabIndex = 19;
            this.lbl_deposito.Text = "Deposito:";
            // 
            // lbl_diferencia
            // 
            this.lbl_diferencia.AutoSize = true;
            this.lbl_diferencia.Location = new System.Drawing.Point(55, 69);
            this.lbl_diferencia.Name = "lbl_diferencia";
            this.lbl_diferencia.Size = new System.Drawing.Size(112, 15);
            this.lbl_diferencia.TabIndex = 20;
            this.lbl_diferencia.Text = "Diferencia a abonar:";
            // 
            // txt_total_estadia
            // 
            this.txt_total_estadia.Location = new System.Drawing.Point(173, 4);
            this.txt_total_estadia.Name = "txt_total_estadia";
            this.txt_total_estadia.ReadOnly = true;
            this.txt_total_estadia.Size = new System.Drawing.Size(76, 23);
            this.txt_total_estadia.TabIndex = 21;
            // 
            // txt_deposito
            // 
            this.txt_deposito.Location = new System.Drawing.Point(173, 33);
            this.txt_deposito.Name = "txt_deposito";
            this.txt_deposito.ReadOnly = true;
            this.txt_deposito.Size = new System.Drawing.Size(76, 23);
            this.txt_deposito.TabIndex = 22;
            // 
            // txt_total_pagar
            // 
            this.txt_total_pagar.Location = new System.Drawing.Point(173, 61);
            this.txt_total_pagar.Name = "txt_total_pagar";
            this.txt_total_pagar.ReadOnly = true;
            this.txt_total_pagar.Size = new System.Drawing.Size(76, 23);
            this.txt_total_pagar.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.txt_total_estadia);
            this.panel2.Controls.Add(this.txt_total_pagar);
            this.panel2.Controls.Add(this.lbl_diferencia);
            this.panel2.Controls.Add(this.lbl_total);
            this.panel2.Controls.Add(this.txt_deposito);
            this.panel2.Controls.Add(this.lbl_deposito);
            this.panel2.Location = new System.Drawing.Point(283, 465);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 91);
            this.panel2.TabIndex = 24;
            // 
            // btn_metodo_pago
            // 
            this.btn_metodo_pago.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_metodo_pago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_metodo_pago.ForeColor = System.Drawing.Color.White;
            this.btn_metodo_pago.Location = new System.Drawing.Point(733, 498);
            this.btn_metodo_pago.Name = "btn_metodo_pago";
            this.btn_metodo_pago.Size = new System.Drawing.Size(120, 31);
            this.btn_metodo_pago.TabIndex = 25;
            this.btn_metodo_pago.Text = "Método de Pago";
            this.btn_metodo_pago.UseVisualStyleBackColor = false;
            this.btn_metodo_pago.Click += new System.EventHandler(this.btn_metodo_pago_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(733, 531);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(120, 30);
            this.btn_salir.TabIndex = 26;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_generarFactura
            // 
            this.btn_generarFactura.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_generarFactura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_generarFactura.ForeColor = System.Drawing.Color.White;
            this.btn_generarFactura.Location = new System.Drawing.Point(733, 464);
            this.btn_generarFactura.Name = "btn_generarFactura";
            this.btn_generarFactura.Size = new System.Drawing.Size(120, 31);
            this.btn_generarFactura.TabIndex = 27;
            this.btn_generarFactura.Text = "Generar Factura";
            this.btn_generarFactura.UseVisualStyleBackColor = false;
            this.btn_generarFactura.Click += new System.EventHandler(this.btn_generarFactura_Click);
            // 
            // frmFacturarHospedaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 574);
            this.Controls.Add(this.btn_generarFactura);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_metodo_pago);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_dniConsulta);
            this.Controls.Add(this.lbl_dniConsulta);
            this.Controls.Add(this.dgv_estadias);
            this.MaximumSize = new System.Drawing.Size(881, 613);
            this.MinimumSize = new System.Drawing.Size(881, 613);
            this.Name = "frmFacturarHospedaje";
            this.Text = "frmFacturarHospedaje";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFacturarHospedaje_FormClosing);
            this.Load += new System.EventHandler(this.frmFacturarHospedaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_estadias;
        private Label lbl_dniConsulta;
        private TextBox txt_dniConsulta;
        private Button btn_buscar;
        private Panel panel1;
        private TextBox txt_fecha;
        private Label lbl_fecha;
        private TextBox txt_lugar;
        private Label lbl_lugar;
        private Label lbl_direccion;
        private Label lbl_dni;
        private Label lbl_apellido;
        private Label lbl_nombre;
        private TextBox txt_direccion;
        private TextBox txt_dni;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private TextBox txt_telefonomovil;
        private TextBox txt_telefonofijo;
        private Label lbl_telefono_movil;
        private Label lbl_telefono_fijo;
        private TextBox txt_descripcion;
        private Label lbl_descripcion;
        private Label lbl_total;
        private Label lbl_deposito;
        private Label lbl_diferencia;
        private TextBox txt_total_estadia;
        private TextBox txt_deposito;
        private TextBox txt_total_pagar;
        private Panel panel2;
        private Button btn_metodo_pago;
        private Button btn_salir;
        private Button btn_generarFactura;
    }
}