namespace TPRestaurante
{
    partial class frmVerComandas
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
            this.grdComandas = new System.Windows.Forms.DataGridView();
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.btnNotificarPedidoListo = new TPRestaurante.UcButtonPrimary(this.components);
            this.btnCancelar = new TPRestaurante.UcButtonSecondary(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdComandas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdComandas
            // 
            this.grdComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdComandas.Location = new System.Drawing.Point(28, 62);
            this.grdComandas.Name = "grdComandas";
            this.grdComandas.Size = new System.Drawing.Size(388, 58);
            this.grdComandas.TabIndex = 0;
            this.grdComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdComandas_CellClick);
            // 
            // grdProductos
            // 
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Location = new System.Drawing.Point(441, 62);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.Size = new System.Drawing.Size(347, 229);
            this.grdProductos.TabIndex = 1;
            // 
            // btnNotificarPedidoListo
            // 
            this.btnNotificarPedidoListo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnNotificarPedidoListo.FlatAppearance.BorderSize = 0;
            this.btnNotificarPedidoListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificarPedidoListo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNotificarPedidoListo.ForeColor = System.Drawing.Color.White;
            this.btnNotificarPedidoListo.Location = new System.Drawing.Point(518, 313);
            this.btnNotificarPedidoListo.Name = "btnNotificarPedidoListo";
            this.btnNotificarPedidoListo.Size = new System.Drawing.Size(132, 39);
            this.btnNotificarPedidoListo.TabIndex = 2;
            this.btnNotificarPedidoListo.Tag = "changeToReady";
            this.btnNotificarPedidoListo.Text = "Pasar a listo";
            this.btnNotificarPedidoListo.UseVisualStyleBackColor = false;
            this.btnNotificarPedidoListo.Click += new System.EventHandler(this.btnNotificarPedidoListo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(656, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 39);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Tag = "cancel";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 4;
            this.label1.Tag = "assignedOrderTicket";
            this.label1.Text = "Comanda asignada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Tag = "products";
            this.label2.Text = "Productos";
            // 
            // frmVerComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNotificarPedidoListo);
            this.Controls.Add(this.grdProductos);
            this.Controls.Add(this.grdComandas);
            this.Name = "frmVerComandas";
            this.Text = "frmVerComandas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVerComandas_FormClosing);
            this.Load += new System.EventHandler(this.frmVerComandas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdComandas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdComandas;
        private System.Windows.Forms.DataGridView grdProductos;
        private UcButtonPrimary btnNotificarPedidoListo;
        private UcButtonSecondary btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}