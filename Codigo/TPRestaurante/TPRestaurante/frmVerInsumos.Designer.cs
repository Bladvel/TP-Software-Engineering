namespace TPRestaurante
{
    partial class frmVerInsumos
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
            this.components = new System.ComponentModel.Container();
            this.grdInsumos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSolicitud = new System.Windows.Forms.ListBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGenerar = new TPRestaurante.UcButtonPrimary(this.components);
            this.btnVerPendientes = new TPRestaurante.UcButtonPrimary(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdInsumos
            // 
            this.grdInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInsumos.Location = new System.Drawing.Point(12, 44);
            this.grdInsumos.Name = "grdInsumos";
            this.grdInsumos.Size = new System.Drawing.Size(472, 212);
            this.grdInsumos.TabIndex = 0;
            this.grdInsumos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdInsumos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA DE INSUMOS";
            // 
            // lstSolicitud
            // 
            this.lstSolicitud.FormattingEnabled = true;
            this.lstSolicitud.Location = new System.Drawing.Point(494, 44);
            this.lstSolicitud.Name = "lstSolicitud";
            this.lstSolicitud.Size = new System.Drawing.Size(298, 212);
            this.lstSolicitud.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(112, 273);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(35, 20);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(9, 276);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad a agregar";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(153, 271);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(557, 262);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(235, 39);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar solicitud de cotizacion";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.ucButtonPrimary2_Click);
            // 
            // btnVerPendientes
            // 
            this.btnVerPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnVerPendientes.FlatAppearance.BorderSize = 0;
            this.btnVerPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPendientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerPendientes.ForeColor = System.Drawing.Color.White;
            this.btnVerPendientes.Location = new System.Drawing.Point(266, 262);
            this.btnVerPendientes.Name = "btnVerPendientes";
            this.btnVerPendientes.Size = new System.Drawing.Size(218, 39);
            this.btnVerPendientes.TabIndex = 2;
            this.btnVerPendientes.Text = "Ver pendientes por compra";
            this.btnVerPendientes.UseVisualStyleBackColor = false;
            this.btnVerPendientes.Click += new System.EventHandler(this.ucButtonPrimary1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(494, 271);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(57, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmVerInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 379);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lstSolicitud);
            this.Controls.Add(this.btnVerPendientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdInsumos);
            this.Name = "frmVerInsumos";
            this.Text = "Ver insumos";
            this.Load += new System.EventHandler(this.frmVerInsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdInsumos;
        private System.Windows.Forms.Label label1;
        private UcButtonPrimary btnVerPendientes;
        private System.Windows.Forms.ListBox lstSolicitud;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnCargar;
        private UcButtonPrimary btnGenerar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}