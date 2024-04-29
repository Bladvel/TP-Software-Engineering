namespace Presentacion
{
    partial class frmBitacoraEventos
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
            this.dgv_registroEventos = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_inicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_fin = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechaInicio = new System.Windows.Forms.Label();
            this.lbl_fechaFin = new System.Windows.Forms.Label();
            this.cb_usuario = new System.Windows.Forms.ComboBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.cb_modulo = new System.Windows.Forms.Label();
            this.cb_mod = new System.Windows.Forms.ComboBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_ListarTotal = new System.Windows.Forms.Button();
            this.gb_Busqueda = new System.Windows.Forms.GroupBox();
            this.checkB_criticidad = new System.Windows.Forms.CheckBox();
            this.lbl_criticidad = new System.Windows.Forms.Label();
            this.cb_criticidad = new System.Windows.Forms.ComboBox();
            this.checkB_Modulo = new System.Windows.Forms.CheckBox();
            this.checkB_usuario = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registroEventos)).BeginInit();
            this.gb_Busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_registroEventos
            // 
            this.dgv_registroEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registroEventos.Location = new System.Drawing.Point(12, 165);
            this.dgv_registroEventos.Name = "dgv_registroEventos";
            this.dgv_registroEventos.RowTemplate.Height = 25;
            this.dgv_registroEventos.Size = new System.Drawing.Size(545, 327);
            this.dgv_registroEventos.TabIndex = 0;
            // 
            // dateTimePicker_inicio
            // 
            this.dateTimePicker_inicio.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_inicio.Location = new System.Drawing.Point(6, 40);
            this.dateTimePicker_inicio.Name = "dateTimePicker_inicio";
            this.dateTimePicker_inicio.Size = new System.Drawing.Size(143, 23);
            this.dateTimePicker_inicio.TabIndex = 1;
            this.dateTimePicker_inicio.Value = new System.DateTime(2023, 9, 18, 0, 0, 0, 0);
            // 
            // dateTimePicker_fin
            // 
            this.dateTimePicker_fin.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_fin.Location = new System.Drawing.Point(6, 89);
            this.dateTimePicker_fin.Name = "dateTimePicker_fin";
            this.dateTimePicker_fin.Size = new System.Drawing.Size(143, 23);
            this.dateTimePicker_fin.TabIndex = 2;
            this.dateTimePicker_fin.Value = new System.DateTime(2023, 9, 18, 23, 59, 59, 0);
            // 
            // lbl_fechaInicio
            // 
            this.lbl_fechaInicio.AutoSize = true;
            this.lbl_fechaInicio.Location = new System.Drawing.Point(6, 22);
            this.lbl_fechaInicio.Name = "lbl_fechaInicio";
            this.lbl_fechaInicio.Size = new System.Drawing.Size(73, 15);
            this.lbl_fechaInicio.TabIndex = 3;
            this.lbl_fechaInicio.Text = "Fecha Inicio:";
            // 
            // lbl_fechaFin
            // 
            this.lbl_fechaFin.AutoSize = true;
            this.lbl_fechaFin.Location = new System.Drawing.Point(6, 71);
            this.lbl_fechaFin.Name = "lbl_fechaFin";
            this.lbl_fechaFin.Size = new System.Drawing.Size(60, 15);
            this.lbl_fechaFin.TabIndex = 4;
            this.lbl_fechaFin.Text = "Fecha Fin:";
            // 
            // cb_usuario
            // 
            this.cb_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_usuario.FormattingEnabled = true;
            this.cb_usuario.Location = new System.Drawing.Point(217, 40);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(121, 23);
            this.cb_usuario.TabIndex = 5;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(217, 25);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(50, 15);
            this.lbl_usuario.TabIndex = 6;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // cb_modulo
            // 
            this.cb_modulo.AutoSize = true;
            this.cb_modulo.Location = new System.Drawing.Point(217, 73);
            this.cb_modulo.Name = "cb_modulo";
            this.cb_modulo.Size = new System.Drawing.Size(52, 15);
            this.cb_modulo.TabIndex = 7;
            this.cb_modulo.Text = "Módulo:";
            // 
            // cb_mod
            // 
            this.cb_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mod.FormattingEnabled = true;
            this.cb_mod.Location = new System.Drawing.Point(217, 89);
            this.cb_mod.Name = "cb_mod";
            this.cb_mod.Size = new System.Drawing.Size(121, 23);
            this.cb_mod.TabIndex = 8;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_consultar.Location = new System.Drawing.Point(390, 101);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(102, 27);
            this.btn_consultar.TabIndex = 9;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(482, 498);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_ListarTotal
            // 
            this.btn_ListarTotal.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ListarTotal.Location = new System.Drawing.Point(390, 69);
            this.btn_ListarTotal.Name = "btn_ListarTotal";
            this.btn_ListarTotal.Size = new System.Drawing.Size(102, 26);
            this.btn_ListarTotal.TabIndex = 11;
            this.btn_ListarTotal.Text = "Listar Todos";
            this.btn_ListarTotal.UseVisualStyleBackColor = false;
            this.btn_ListarTotal.Click += new System.EventHandler(this.btn_ListarTotal_Click);
            // 
            // gb_Busqueda
            // 
            this.gb_Busqueda.Controls.Add(this.checkB_criticidad);
            this.gb_Busqueda.Controls.Add(this.lbl_criticidad);
            this.gb_Busqueda.Controls.Add(this.cb_criticidad);
            this.gb_Busqueda.Controls.Add(this.checkB_Modulo);
            this.gb_Busqueda.Controls.Add(this.checkB_usuario);
            this.gb_Busqueda.Controls.Add(this.dateTimePicker_inicio);
            this.gb_Busqueda.Controls.Add(this.btn_ListarTotal);
            this.gb_Busqueda.Controls.Add(this.lbl_fechaInicio);
            this.gb_Busqueda.Controls.Add(this.dateTimePicker_fin);
            this.gb_Busqueda.Controls.Add(this.btn_consultar);
            this.gb_Busqueda.Controls.Add(this.lbl_fechaFin);
            this.gb_Busqueda.Controls.Add(this.cb_mod);
            this.gb_Busqueda.Controls.Add(this.cb_modulo);
            this.gb_Busqueda.Controls.Add(this.cb_usuario);
            this.gb_Busqueda.Controls.Add(this.lbl_usuario);
            this.gb_Busqueda.Location = new System.Drawing.Point(12, 20);
            this.gb_Busqueda.Name = "gb_Busqueda";
            this.gb_Busqueda.Size = new System.Drawing.Size(545, 139);
            this.gb_Busqueda.TabIndex = 12;
            this.gb_Busqueda.TabStop = false;
            this.gb_Busqueda.Text = "Parámetros de busqueda";
            // 
            // checkB_criticidad
            // 
            this.checkB_criticidad.AutoSize = true;
            this.checkB_criticidad.Location = new System.Drawing.Point(457, 43);
            this.checkB_criticidad.Name = "checkB_criticidad";
            this.checkB_criticidad.Size = new System.Drawing.Size(15, 14);
            this.checkB_criticidad.TabIndex = 17;
            this.checkB_criticidad.UseVisualStyleBackColor = true;
            this.checkB_criticidad.CheckedChanged += new System.EventHandler(this.checkB_criticidad_CheckedChanged);
            // 
            // lbl_criticidad
            // 
            this.lbl_criticidad.AutoSize = true;
            this.lbl_criticidad.Location = new System.Drawing.Point(390, 22);
            this.lbl_criticidad.Name = "lbl_criticidad";
            this.lbl_criticidad.Size = new System.Drawing.Size(61, 15);
            this.lbl_criticidad.TabIndex = 16;
            this.lbl_criticidad.Text = "Criticidad:";
            // 
            // cb_criticidad
            // 
            this.cb_criticidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_criticidad.FormattingEnabled = true;
            this.cb_criticidad.Location = new System.Drawing.Point(390, 40);
            this.cb_criticidad.Name = "cb_criticidad";
            this.cb_criticidad.Size = new System.Drawing.Size(61, 23);
            this.cb_criticidad.TabIndex = 15;
            // 
            // checkB_Modulo
            // 
            this.checkB_Modulo.AutoSize = true;
            this.checkB_Modulo.Location = new System.Drawing.Point(344, 93);
            this.checkB_Modulo.Name = "checkB_Modulo";
            this.checkB_Modulo.Size = new System.Drawing.Size(15, 14);
            this.checkB_Modulo.TabIndex = 14;
            this.checkB_Modulo.UseVisualStyleBackColor = true;
            this.checkB_Modulo.CheckedChanged += new System.EventHandler(this.checkB_Modulo_CheckedChanged);
            // 
            // checkB_usuario
            // 
            this.checkB_usuario.AutoSize = true;
            this.checkB_usuario.Location = new System.Drawing.Point(344, 43);
            this.checkB_usuario.Name = "checkB_usuario";
            this.checkB_usuario.Size = new System.Drawing.Size(15, 14);
            this.checkB_usuario.TabIndex = 13;
            this.checkB_usuario.UseVisualStyleBackColor = true;
            this.checkB_usuario.CheckedChanged += new System.EventHandler(this.checkB_usuario_CheckedChanged);
            // 
            // frmBitacoraEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 530);
            this.Controls.Add(this.gb_Busqueda);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dgv_registroEventos);
            this.Name = "frmBitacoraEventos";
            this.Text = "frmBitacoraEventos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBitacoraEventos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registroEventos)).EndInit();
            this.gb_Busqueda.ResumeLayout(false);
            this.gb_Busqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_registroEventos;
        private DateTimePicker dateTimePicker_inicio;
        private DateTimePicker dateTimePicker_fin;
        private Label lbl_fechaInicio;
        private Label lbl_fechaFin;
        private ComboBox cb_usuario;
        private Label lbl_usuario;
        private Label cb_modulo;
        private ComboBox cb_mod;
        private Button btn_consultar;
        private Button btn_salir;
        private Button btn_ListarTotal;
        private GroupBox gb_Busqueda;
        private CheckBox checkB_Modulo;
        private CheckBox checkB_usuario;
        private CheckBox checkB_criticidad;
        private Label lbl_criticidad;
        private ComboBox cb_criticidad;
    }
}