namespace TPRestaurante
{
    partial class frmReporteProductos
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
            this.grdProductosVendidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPromociones = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new TPRestaurante.UcButtonSecondary(this.components);
            this.btnExportar = new TPRestaurante.UcButtonPrimary(this.components);
            this.btnPromociones = new TPRestaurante.UcButtonPrimary(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProductosVendidos
            // 
            this.grdProductosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductosVendidos.Location = new System.Drawing.Point(24, 195);
            this.grdProductosVendidos.Name = "grdProductosVendidos";
            this.grdProductosVendidos.Size = new System.Drawing.Size(358, 183);
            this.grdProductosVendidos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos vendidos";
            // 
            // txtPromociones
            // 
            this.txtPromociones.Location = new System.Drawing.Point(489, 195);
            this.txtPromociones.Name = "txtPromociones";
            this.txtPromociones.ReadOnly = true;
            this.txtPromociones.Size = new System.Drawing.Size(358, 183);
            this.txtPromociones.TabIndex = 3;
            this.txtPromociones.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Promociones";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(715, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 39);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(577, 384);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(132, 39);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar pdf";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnPromociones
            // 
            this.btnPromociones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnPromociones.FlatAppearance.BorderSize = 0;
            this.btnPromociones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromociones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPromociones.ForeColor = System.Drawing.Color.White;
            this.btnPromociones.Location = new System.Drawing.Point(185, 384);
            this.btnPromociones.Name = "btnPromociones";
            this.btnPromociones.Size = new System.Drawing.Size(197, 39);
            this.btnPromociones.TabIndex = 2;
            this.btnPromociones.Text = "Recomendar promociones";
            this.btnPromociones.UseVisualStyleBackColor = false;
            this.btnPromociones.Click += new System.EventHandler(this.btnPromociones_Click);
            // 
            // frmReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 587);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.txtPromociones);
            this.Controls.Add(this.btnPromociones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdProductosVendidos);
            this.Name = "frmReporteProductos";
            this.Text = "Reportes sobre productos";
            this.Load += new System.EventHandler(this.frmReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProductosVendidos;
        private System.Windows.Forms.Label label1;
        private UcButtonPrimary btnPromociones;
        private System.Windows.Forms.RichTextBox txtPromociones;
        private System.Windows.Forms.Label label2;
        private UcButtonPrimary btnExportar;
        private UcButtonSecondary btnSalir;
    }
}