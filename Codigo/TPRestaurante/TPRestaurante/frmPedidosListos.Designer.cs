namespace TPRestaurante
{
    partial class frmPedidosListos
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
            this.grdPedidosListos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarPedido = new TPRestaurante.UcButtonPrimary(this.components);
            this.btnCancelar = new TPRestaurante.UcButtonSecondary(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidosListos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPedidosListos
            // 
            this.grdPedidosListos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedidosListos.Location = new System.Drawing.Point(175, 58);
            this.grdPedidosListos.Name = "grdPedidosListos";
            this.grdPedidosListos.Size = new System.Drawing.Size(443, 248);
            this.grdPedidosListos.TabIndex = 0;
            this.grdPedidosListos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPedidosListos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Tag = "ordersReady";
            this.label1.Text = "Pedidos listos";
            // 
            // btnCerrarPedido
            // 
            this.btnCerrarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnCerrarPedido.FlatAppearance.BorderSize = 0;
            this.btnCerrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarPedido.ForeColor = System.Drawing.Color.White;
            this.btnCerrarPedido.Location = new System.Drawing.Point(348, 312);
            this.btnCerrarPedido.Name = "btnCerrarPedido";
            this.btnCerrarPedido.Size = new System.Drawing.Size(132, 39);
            this.btnCerrarPedido.TabIndex = 2;
            this.btnCerrarPedido.Tag = "closeOrder";
            this.btnCerrarPedido.Text = "Cerrar Pedido";
            this.btnCerrarPedido.UseVisualStyleBackColor = false;
            this.btnCerrarPedido.Click += new System.EventHandler(this.btnCerrarPedido_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(486, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 39);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Tag = "cancel";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPedidosListos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCerrarPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdPedidosListos);
            this.Name = "frmPedidosListos";
            this.Text = "frmPedidosListos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPedidosListos_FormClosing);
            this.Load += new System.EventHandler(this.frmPedidosListos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidosListos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPedidosListos;
        private System.Windows.Forms.Label label1;
        private UcButtonPrimary btnCerrarPedido;
        private UcButtonSecondary btnCancelar;
    }
}