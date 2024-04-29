namespace Presentacion
{
    partial class frmHabitaciones
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
            this.dgv_habitaciones = new System.Windows.Forms.DataGridView();
            this.btn_listar_total = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.btn_simples = new System.Windows.Forms.Button();
            this.btn_dobles = new System.Windows.Forms.Button();
            this.btn_triples = new System.Windows.Forms.Button();
            this.btn_cuadruples = new System.Windows.Forms.Button();
            this.gb_editarPrecio = new System.Windows.Forms.GroupBox();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.txt_precioTipoHab = new System.Windows.Forms.TextBox();
            this.lbl_precioAct = new System.Windows.Forms.Label();
            this.lbl_tipoHab = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_grilla = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitaciones)).BeginInit();
            this.gb_editarPrecio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_habitaciones
            // 
            this.dgv_habitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_habitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_habitaciones.Location = new System.Drawing.Point(12, 37);
            this.dgv_habitaciones.Name = "dgv_habitaciones";
            this.dgv_habitaciones.RowTemplate.Height = 25;
            this.dgv_habitaciones.Size = new System.Drawing.Size(379, 160);
            this.dgv_habitaciones.TabIndex = 0;
            this.dgv_habitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_habitaciones_CellClick);
            // 
            // btn_listar_total
            // 
            this.btn_listar_total.Location = new System.Drawing.Point(397, 37);
            this.btn_listar_total.Name = "btn_listar_total";
            this.btn_listar_total.Size = new System.Drawing.Size(103, 23);
            this.btn_listar_total.TabIndex = 1;
            this.btn_listar_total.Text = "Todas";
            this.btn_listar_total.UseVisualStyleBackColor = true;
            this.btn_listar_total.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(12, 200);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(110, 15);
            this.lbl_total.TabIndex = 2;
            this.lbl_total.Text = "Total Habitaciones: ";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(12, 215);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(0, 15);
            this.lbl_precio.TabIndex = 3;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(12, 230);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(0, 15);
            this.lbl_cantidad.TabIndex = 4;
            // 
            // btn_simples
            // 
            this.btn_simples.Location = new System.Drawing.Point(397, 66);
            this.btn_simples.Name = "btn_simples";
            this.btn_simples.Size = new System.Drawing.Size(103, 23);
            this.btn_simples.TabIndex = 5;
            this.btn_simples.Text = "Simples";
            this.btn_simples.UseVisualStyleBackColor = true;
            this.btn_simples.Click += new System.EventHandler(this.btn_simples_Click);
            // 
            // btn_dobles
            // 
            this.btn_dobles.Location = new System.Drawing.Point(397, 95);
            this.btn_dobles.Name = "btn_dobles";
            this.btn_dobles.Size = new System.Drawing.Size(103, 23);
            this.btn_dobles.TabIndex = 6;
            this.btn_dobles.Text = "Dobles";
            this.btn_dobles.UseVisualStyleBackColor = true;
            this.btn_dobles.Click += new System.EventHandler(this.btn_dobles_Click);
            // 
            // btn_triples
            // 
            this.btn_triples.Location = new System.Drawing.Point(397, 124);
            this.btn_triples.Name = "btn_triples";
            this.btn_triples.Size = new System.Drawing.Size(103, 23);
            this.btn_triples.TabIndex = 7;
            this.btn_triples.Text = "Triples";
            this.btn_triples.UseVisualStyleBackColor = true;
            this.btn_triples.Click += new System.EventHandler(this.btn_triples_Click);
            // 
            // btn_cuadruples
            // 
            this.btn_cuadruples.Location = new System.Drawing.Point(397, 153);
            this.btn_cuadruples.Name = "btn_cuadruples";
            this.btn_cuadruples.Size = new System.Drawing.Size(103, 23);
            this.btn_cuadruples.TabIndex = 8;
            this.btn_cuadruples.Text = "Cuadruples";
            this.btn_cuadruples.UseVisualStyleBackColor = true;
            this.btn_cuadruples.Click += new System.EventHandler(this.btn_cuadruples_Click);
            // 
            // gb_editarPrecio
            // 
            this.gb_editarPrecio.Controls.Add(this.lbl_mensaje);
            this.gb_editarPrecio.Controls.Add(this.btn_modificar);
            this.gb_editarPrecio.Controls.Add(this.btn_iniciar);
            this.gb_editarPrecio.Controls.Add(this.txt_precioTipoHab);
            this.gb_editarPrecio.Controls.Add(this.lbl_precioAct);
            this.gb_editarPrecio.Controls.Add(this.lbl_tipoHab);
            this.gb_editarPrecio.Controls.Add(this.cmb_tipo);
            this.gb_editarPrecio.Location = new System.Drawing.Point(12, 251);
            this.gb_editarPrecio.Name = "gb_editarPrecio";
            this.gb_editarPrecio.Size = new System.Drawing.Size(449, 141);
            this.gb_editarPrecio.TabIndex = 9;
            this.gb_editarPrecio.TabStop = false;
            this.gb_editarPrecio.Text = "Editar Precio de Habitación";
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Location = new System.Drawing.Point(96, 103);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(0, 15);
            this.lbl_mensaje.TabIndex = 6;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(362, 79);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 32);
            this.btn_modificar.TabIndex = 5;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.btn_iniciar.Location = new System.Drawing.Point(6, 22);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(78, 28);
            this.btn_iniciar.TabIndex = 4;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // txt_precioTipoHab
            // 
            this.txt_precioTipoHab.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.txt_precioTipoHab.Enabled = false;
            this.txt_precioTipoHab.Location = new System.Drawing.Point(354, 50);
            this.txt_precioTipoHab.MaxLength = 7;
            this.txt_precioTipoHab.Name = "txt_precioTipoHab";
            this.txt_precioTipoHab.Size = new System.Drawing.Size(83, 23);
            this.txt_precioTipoHab.TabIndex = 3;
            // 
            // lbl_precioAct
            // 
            this.lbl_precioAct.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.lbl_precioAct.AutoSize = true;
            this.lbl_precioAct.Location = new System.Drawing.Point(273, 53);
            this.lbl_precioAct.Name = "lbl_precioAct";
            this.lbl_precioAct.Size = new System.Drawing.Size(75, 15);
            this.lbl_precioAct.TabIndex = 2;
            this.lbl_precioAct.Text = "Precio actual";
            // 
            // lbl_tipoHab
            // 
            this.lbl_tipoHab.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.lbl_tipoHab.AutoSize = true;
            this.lbl_tipoHab.Location = new System.Drawing.Point(8, 58);
            this.lbl_tipoHab.Name = "lbl_tipoHab";
            this.lbl_tipoHab.Size = new System.Drawing.Size(91, 15);
            this.lbl_tipoHab.TabIndex = 1;
            this.lbl_tipoHab.Text = "Tipo Habitación";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(105, 50);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(138, 23);
            this.cmb_tipo.TabIndex = 0;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_SelectedIndexChanged);
            // 
            // lbl_grilla
            // 
            this.lbl_grilla.AutoSize = true;
            this.lbl_grilla.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_grilla.Location = new System.Drawing.Point(12, 9);
            this.lbl_grilla.Name = "lbl_grilla";
            this.lbl_grilla.Size = new System.Drawing.Size(133, 23);
            this.lbl_grilla.TabIndex = 10;
            this.lbl_grilla.Text = "Habitaciones";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(409, 410);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(92, 23);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frmHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 445);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_grilla);
            this.Controls.Add(this.gb_editarPrecio);
            this.Controls.Add(this.btn_cuadruples);
            this.Controls.Add(this.btn_triples);
            this.Controls.Add(this.btn_dobles);
            this.Controls.Add(this.btn_simples);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_listar_total);
            this.Controls.Add(this.dgv_habitaciones);
            this.MaximumSize = new System.Drawing.Size(529, 484);
            this.MinimumSize = new System.Drawing.Size(529, 484);
            this.Name = "frmHabitaciones";
            this.Text = "frmHabitaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHabitaciones_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitaciones)).EndInit();
            this.gb_editarPrecio.ResumeLayout(false);
            this.gb_editarPrecio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_habitaciones;
        private Button btn_listar_total;
        private Label lbl_total;
        private Label lbl_precio;
        private Label lbl_cantidad;
        private Button btn_simples;
        private Button btn_dobles;
        private Button btn_triples;
        private Button btn_cuadruples;
        private GroupBox gb_editarPrecio;
        private Label lbl_grilla;
        private TextBox txt_precioTipoHab;
        private Label lbl_precioAct;
        private Label lbl_tipoHab;
        private ComboBox cmb_tipo;
        private Button btn_iniciar;
        private Button btn_modificar;
        private Label lbl_mensaje;
        private Button btn_salir;
    }
}