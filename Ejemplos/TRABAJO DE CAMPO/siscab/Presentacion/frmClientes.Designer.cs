namespace Presentacion
{
    partial class frmClientes
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_telefono_fijo = new System.Windows.Forms.TextBox();
            this.txt_telefono_movil = new System.Windows.Forms.TextBox();
            this.txt_domicilio = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_telefonoFijo = new System.Windows.Forms.Label();
            this.lbl_telefonoMovil = new System.Windows.Forms.Label();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.gb_abm = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.gb_listas = new System.Windows.Forms.GroupBox();
            this.lbl_listados = new System.Windows.Forms.Label();
            this.btn_borrados = new System.Windows.Forms.Button();
            this.btn_activos = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.gb_abm.SuspendLayout();
            this.gb_listas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(113, 22);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(126, 23);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(113, 49);
            this.txt_apellido.MaxLength = 50;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(126, 23);
            this.txt_apellido.TabIndex = 1;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(113, 78);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(88, 23);
            this.txt_dni.TabIndex = 2;
            // 
            // txt_telefono_fijo
            // 
            this.txt_telefono_fijo.Location = new System.Drawing.Point(113, 104);
            this.txt_telefono_fijo.MaxLength = 16;
            this.txt_telefono_fijo.Name = "txt_telefono_fijo";
            this.txt_telefono_fijo.Size = new System.Drawing.Size(88, 23);
            this.txt_telefono_fijo.TabIndex = 3;
            // 
            // txt_telefono_movil
            // 
            this.txt_telefono_movil.Location = new System.Drawing.Point(113, 133);
            this.txt_telefono_movil.MaxLength = 16;
            this.txt_telefono_movil.Name = "txt_telefono_movil";
            this.txt_telefono_movil.Size = new System.Drawing.Size(126, 23);
            this.txt_telefono_movil.TabIndex = 4;
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.Location = new System.Drawing.Point(113, 162);
            this.txt_domicilio.MaxLength = 50;
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Size = new System.Drawing.Size(126, 23);
            this.txt_domicilio.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(113, 191);
            this.txt_email.MaxLength = 50;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(126, 23);
            this.txt_email.TabIndex = 6;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(22, 25);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombre.TabIndex = 7;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(22, 57);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(51, 15);
            this.lbl_apellido.TabIndex = 8;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(22, 86);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_dni.TabIndex = 9;
            this.lbl_dni.Text = "DNI";
            // 
            // lbl_telefonoFijo
            // 
            this.lbl_telefonoFijo.AutoSize = true;
            this.lbl_telefonoFijo.Location = new System.Drawing.Point(22, 112);
            this.lbl_telefonoFijo.Name = "lbl_telefonoFijo";
            this.lbl_telefonoFijo.Size = new System.Drawing.Size(74, 15);
            this.lbl_telefonoFijo.TabIndex = 10;
            this.lbl_telefonoFijo.Text = "Teléfono Fijo";
            // 
            // lbl_telefonoMovil
            // 
            this.lbl_telefonoMovil.AutoSize = true;
            this.lbl_telefonoMovil.Location = new System.Drawing.Point(22, 141);
            this.lbl_telefonoMovil.Name = "lbl_telefonoMovil";
            this.lbl_telefonoMovil.Size = new System.Drawing.Size(85, 15);
            this.lbl_telefonoMovil.TabIndex = 11;
            this.lbl_telefonoMovil.Text = "Teléfono Móvil";
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.Location = new System.Drawing.Point(22, 170);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(58, 15);
            this.lbl_domicilio.TabIndex = 12;
            this.lbl_domicilio.Text = "Domicilio";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(22, 199);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(36, 15);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "Email";
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(12, 91);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.RowTemplate.Height = 25;
            this.dgv_clientes.Size = new System.Drawing.Size(566, 151);
            this.dgv_clientes.TabIndex = 14;
            this.dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellClick);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.btn_cancelar);
            this.gb_abm.Controls.Add(this.btn_borrar);
            this.gb_abm.Controls.Add(this.btn_modificar);
            this.gb_abm.Controls.Add(this.btn_agregar);
            this.gb_abm.Controls.Add(this.btn_nuevo);
            this.gb_abm.Controls.Add(this.txt_nombre);
            this.gb_abm.Controls.Add(this.txt_apellido);
            this.gb_abm.Controls.Add(this.lbl_email);
            this.gb_abm.Controls.Add(this.txt_dni);
            this.gb_abm.Controls.Add(this.lbl_domicilio);
            this.gb_abm.Controls.Add(this.txt_telefono_fijo);
            this.gb_abm.Controls.Add(this.lbl_telefonoMovil);
            this.gb_abm.Controls.Add(this.txt_telefono_movil);
            this.gb_abm.Controls.Add(this.lbl_telefonoFijo);
            this.gb_abm.Controls.Add(this.txt_domicilio);
            this.gb_abm.Controls.Add(this.lbl_dni);
            this.gb_abm.Controls.Add(this.txt_email);
            this.gb_abm.Controls.Add(this.lbl_apellido);
            this.gb_abm.Controls.Add(this.lbl_nombre);
            this.gb_abm.Location = new System.Drawing.Point(12, 282);
            this.gb_abm.Name = "gb_abm";
            this.gb_abm.Size = new System.Drawing.Size(407, 230);
            this.gb_abm.TabIndex = 15;
            this.gb_abm.TabStop = false;
            this.gb_abm.Text = "ABM - Cliente";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(296, 195);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(105, 23);
            this.btn_cancelar.TabIndex = 18;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(296, 151);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(105, 23);
            this.btn_borrar.TabIndex = 17;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(296, 103);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(105, 23);
            this.btn_modificar.TabIndex = 16;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(296, 57);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(105, 23);
            this.btn_agregar.TabIndex = 15;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(296, 22);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(105, 23);
            this.btn_nuevo.TabIndex = 14;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(462, 489);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(105, 23);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // gb_listas
            // 
            this.gb_listas.Controls.Add(this.lbl_listados);
            this.gb_listas.Controls.Add(this.btn_borrados);
            this.gb_listas.Controls.Add(this.btn_activos);
            this.gb_listas.Controls.Add(this.btn_total);
            this.gb_listas.Location = new System.Drawing.Point(12, 14);
            this.gb_listas.Name = "gb_listas";
            this.gb_listas.Size = new System.Drawing.Size(444, 71);
            this.gb_listas.TabIndex = 17;
            this.gb_listas.TabStop = false;
            this.gb_listas.Text = "Listar Clientes";
            // 
            // lbl_listados
            // 
            this.lbl_listados.AutoSize = true;
            this.lbl_listados.Location = new System.Drawing.Point(21, 48);
            this.lbl_listados.Name = "lbl_listados";
            this.lbl_listados.Size = new System.Drawing.Size(120, 15);
            this.lbl_listados.TabIndex = 3;
            this.lbl_listados.Text = "Listado seleccionado:";
            // 
            // btn_borrados
            // 
            this.btn_borrados.Location = new System.Drawing.Point(194, 18);
            this.btn_borrados.Name = "btn_borrados";
            this.btn_borrados.Size = new System.Drawing.Size(75, 23);
            this.btn_borrados.TabIndex = 2;
            this.btn_borrados.Text = "Borrados";
            this.btn_borrados.UseVisualStyleBackColor = true;
            this.btn_borrados.Click += new System.EventHandler(this.btn_borrados_Click);
            // 
            // btn_activos
            // 
            this.btn_activos.Location = new System.Drawing.Point(113, 18);
            this.btn_activos.Name = "btn_activos";
            this.btn_activos.Size = new System.Drawing.Size(75, 23);
            this.btn_activos.TabIndex = 1;
            this.btn_activos.Text = "Activos";
            this.btn_activos.UseVisualStyleBackColor = true;
            this.btn_activos.Click += new System.EventHandler(this.btn_activos_Click);
            // 
            // btn_total
            // 
            this.btn_total.Location = new System.Drawing.Point(19, 18);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(75, 23);
            this.btn_total.TabIndex = 0;
            this.btn_total.Text = "Total";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 530);
            this.Controls.Add(this.gb_listas);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.gb_abm);
            this.Controls.Add(this.dgv_clientes);
            this.MaximumSize = new System.Drawing.Size(605, 569);
            this.MinimumSize = new System.Drawing.Size(605, 319);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClientes_FormClosing);
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.gb_abm.ResumeLayout(false);
            this.gb_abm.PerformLayout();
            this.gb_listas.ResumeLayout(false);
            this.gb_listas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private TextBox txt_dni;
        private TextBox txt_telefono_fijo;
        private TextBox txt_telefono_movil;
        private TextBox txt_domicilio;
        private TextBox txt_email;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private Label lbl_dni;
        private Label lbl_telefonoFijo;
        private Label lbl_telefonoMovil;
        private Label lbl_domicilio;
        private Label lbl_email;
        private DataGridView dgv_clientes;
        private GroupBox gb_abm;
        private Button btn_cancelar;
        private Button btn_borrar;
        private Button btn_modificar;
        private Button btn_agregar;
        private Button btn_nuevo;
        private Button btn_salir;
        private GroupBox gb_listas;
        private Button btn_total;
        private Label lbl_listados;
        private Button btn_borrados;
        private Button btn_activos;
    }
}