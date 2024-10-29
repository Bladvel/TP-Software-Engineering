namespace TPRestaurante
{
    partial class frmSolicitarCotizacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.grdSolicitudes = new System.Windows.Forms.DataGridView();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.grdProveedores = new System.Windows.Forms.DataGridView();
            this.chkMarcarTodos = new System.Windows.Forms.CheckBox();
            this.chkDesmarcarTodos = new System.Windows.Forms.CheckBox();
            this.btnSalir = new TPRestaurante.UcButtonSecondary(this.components);
            this.btnSolicitar = new TPRestaurante.UcButtonPrimary(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOLICITUDES DE COTIZACION";
            // 
            // grdSolicitudes
            // 
            this.grdSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSolicitudes.Location = new System.Drawing.Point(81, 207);
            this.grdSolicitudes.Name = "grdSolicitudes";
            this.grdSolicitudes.Size = new System.Drawing.Size(304, 174);
            this.grdSolicitudes.TabIndex = 1;
            this.grdSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSolicitudes_CellClick);
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Location = new System.Drawing.Point(486, 180);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(89, 13);
            this.lblProveedores.TabIndex = 4;
            this.lblProveedores.Text = "PROVEEDORES";
            // 
            // grdProveedores
            // 
            this.grdProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProveedores.Location = new System.Drawing.Point(489, 203);
            this.grdProveedores.Name = "grdProveedores";
            this.grdProveedores.Size = new System.Drawing.Size(304, 174);
            this.grdProveedores.TabIndex = 5;
            this.grdProveedores.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdProveedores_CellBeginEdit);
            // 
            // chkMarcarTodos
            // 
            this.chkMarcarTodos.AutoSize = true;
            this.chkMarcarTodos.Location = new System.Drawing.Point(593, 179);
            this.chkMarcarTodos.Name = "chkMarcarTodos";
            this.chkMarcarTodos.Size = new System.Drawing.Size(88, 17);
            this.chkMarcarTodos.TabIndex = 8;
            this.chkMarcarTodos.Text = "Marcar todos";
            this.chkMarcarTodos.UseVisualStyleBackColor = true;
            this.chkMarcarTodos.CheckedChanged += new System.EventHandler(this.chkMarcarTodos_CheckedChanged);
            // 
            // chkDesmarcarTodos
            // 
            this.chkDesmarcarTodos.AutoSize = true;
            this.chkDesmarcarTodos.Location = new System.Drawing.Point(687, 179);
            this.chkDesmarcarTodos.Name = "chkDesmarcarTodos";
            this.chkDesmarcarTodos.Size = new System.Drawing.Size(106, 17);
            this.chkDesmarcarTodos.TabIndex = 8;
            this.chkDesmarcarTodos.Text = "Desmarcar todos";
            this.chkDesmarcarTodos.UseVisualStyleBackColor = true;
            this.chkDesmarcarTodos.CheckedChanged += new System.EventHandler(this.chkDesmarcarTodos_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(661, 383);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 39);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnSolicitar.FlatAppearance.BorderSize = 0;
            this.btnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSolicitar.ForeColor = System.Drawing.Color.White;
            this.btnSolicitar.Location = new System.Drawing.Point(523, 383);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(132, 39);
            this.btnSolicitar.TabIndex = 6;
            this.btnSolicitar.Text = "Enviar solicitud";
            this.btnSolicitar.UseVisualStyleBackColor = false;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // frmSolicitarCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 587);
            this.Controls.Add(this.chkDesmarcarTodos);
            this.Controls.Add(this.chkMarcarTodos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.grdProveedores);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.grdSolicitudes);
            this.Controls.Add(this.label1);
            this.Name = "frmSolicitarCotizacion";
            this.Text = "Solicitar cotizacion";
            this.Load += new System.EventHandler(this.frmSolicitarCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdSolicitudes;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.DataGridView grdProveedores;
        private UcButtonPrimary btnSolicitar;
        private UcButtonSecondary btnSalir;
        private System.Windows.Forms.CheckBox chkMarcarTodos;
        private System.Windows.Forms.CheckBox chkDesmarcarTodos;
    }
}