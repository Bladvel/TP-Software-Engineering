namespace TPRestaurante
{
    partial class frmMaestroClientes
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
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblModo = new System.Windows.Forms.Label();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnDesserializar = new System.Windows.Forms.Button();
            this.txtRutaSerializar = new System.Windows.Forms.TextBox();
            this.btnExaminarSerializar = new System.Windows.Forms.Button();
            this.txtRutaDesserializar = new System.Windows.Forms.TextBox();
            this.btnExaminarDesserializar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rtbXml = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdClientes
            // 
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(43, 59);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.Size = new System.Drawing.Size(489, 159);
            this.grdClientes.TabIndex = 0;
            this.grdClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(611, 140);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 33);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(611, 296);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 33);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(611, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 33);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(611, 218);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(109, 33);
            this.btnAplicar.TabIndex = 16;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(611, 100);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 33);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(611, 59);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 35);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "MAESTRO DE CLIENTES - ABM";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(114, 309);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(167, 20);
            this.txtTelefono.TabIndex = 28;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(114, 258);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(167, 20);
            this.txtApellido.TabIndex = 27;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 233);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(114, 283);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(167, 20);
            this.txtDNI.TabIndex = 25;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "DNI";
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.Location = new System.Drawing.Point(406, 233);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(126, 20);
            this.lblModo.TabIndex = 34;
            this.lblModo.Text = "Modo consulta";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(477, 24);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 35;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Location = new System.Drawing.Point(411, 24);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(60, 17);
            this.rbActivos.TabIndex = 35;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.rbActivos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSerializar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnDesserializar);
            this.groupBox1.Controls.Add(this.txtRutaSerializar);
            this.groupBox1.Controls.Add(this.btnExaminarSerializar);
            this.groupBox1.Controls.Add(this.txtRutaDesserializar);
            this.groupBox1.Controls.Add(this.btnExaminarDesserializar);
            this.groupBox1.Location = new System.Drawing.Point(37, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 240);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serializacion";
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(51, 28);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(109, 33);
            this.btnSerializar.TabIndex = 39;
            this.btnSerializar.Text = "Serializar";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // btnDesserializar
            // 
            this.btnDesserializar.Location = new System.Drawing.Point(51, 114);
            this.btnDesserializar.Name = "btnDesserializar";
            this.btnDesserializar.Size = new System.Drawing.Size(109, 33);
            this.btnDesserializar.TabIndex = 39;
            this.btnDesserializar.Text = "Des-serializar";
            this.btnDesserializar.UseVisualStyleBackColor = true;
            this.btnDesserializar.Click += new System.EventHandler(this.btnDesserializar_Click);
            // 
            // txtRutaSerializar
            // 
            this.txtRutaSerializar.Location = new System.Drawing.Point(21, 67);
            this.txtRutaSerializar.Name = "txtRutaSerializar";
            this.txtRutaSerializar.ReadOnly = true;
            this.txtRutaSerializar.Size = new System.Drawing.Size(167, 20);
            this.txtRutaSerializar.TabIndex = 38;
            // 
            // btnExaminarSerializar
            // 
            this.btnExaminarSerializar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExaminarSerializar.BackgroundImage = global::TPRestaurante.Properties.Resources.carpeta;
            this.btnExaminarSerializar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExaminarSerializar.Location = new System.Drawing.Point(194, 60);
            this.btnExaminarSerializar.Name = "btnExaminarSerializar";
            this.btnExaminarSerializar.Size = new System.Drawing.Size(34, 33);
            this.btnExaminarSerializar.TabIndex = 37;
            this.btnExaminarSerializar.UseVisualStyleBackColor = false;
            this.btnExaminarSerializar.Click += new System.EventHandler(this.btnExaminarSerializar_Click);
            // 
            // txtRutaDesserializar
            // 
            this.txtRutaDesserializar.Location = new System.Drawing.Point(18, 153);
            this.txtRutaDesserializar.Name = "txtRutaDesserializar";
            this.txtRutaDesserializar.ReadOnly = true;
            this.txtRutaDesserializar.Size = new System.Drawing.Size(167, 20);
            this.txtRutaDesserializar.TabIndex = 38;
            // 
            // btnExaminarDesserializar
            // 
            this.btnExaminarDesserializar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExaminarDesserializar.BackgroundImage = global::TPRestaurante.Properties.Resources.carpeta;
            this.btnExaminarDesserializar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExaminarDesserializar.Location = new System.Drawing.Point(191, 146);
            this.btnExaminarDesserializar.Name = "btnExaminarDesserializar";
            this.btnExaminarDesserializar.Size = new System.Drawing.Size(34, 33);
            this.btnExaminarDesserializar.TabIndex = 37;
            this.btnExaminarDesserializar.UseVisualStyleBackColor = false;
            this.btnExaminarDesserializar.Click += new System.EventHandler(this.btnExaminarDesserializar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(77, 179);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(48, 22);
            this.btnLimpiar.TabIndex = 37;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // rtbXml
            // 
            this.rtbXml.Location = new System.Drawing.Point(311, 352);
            this.rtbXml.Name = "rtbXml";
            this.rtbXml.ReadOnly = true;
            this.rtbXml.Size = new System.Drawing.Size(409, 240);
            this.rtbXml.TabIndex = 38;
            this.rtbXml.Text = "";
            // 
            // frmMaestroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 626);
            this.Controls.Add(this.rtbXml);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbActivos);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grdClientes);
            this.Name = "frmMaestroClientes";
            this.Text = "frmMaestroClientes";
            this.Load += new System.EventHandler(this.frmMaestroClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExaminarDesserializar;
        private System.Windows.Forms.TextBox txtRutaDesserializar;
        private System.Windows.Forms.Button btnDesserializar;
        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.TextBox txtRutaSerializar;
        private System.Windows.Forms.Button btnExaminarSerializar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RichTextBox rtbXml;
    }
}