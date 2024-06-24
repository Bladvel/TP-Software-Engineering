namespace TPRestaurante
{
    partial class frmPedidosEnCurso
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
            this.ucButtonSecondary1 = new TPRestaurante.UcButtonSecondary(this.components);
            this.grdPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 6;
            this.label1.Tag = "onGoingOrders";
            this.label1.Text = "Pedidos en curso";
            // 
            // ucButtonSecondary1
            // 
            this.ucButtonSecondary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.ucButtonSecondary1.FlatAppearance.BorderSize = 0;
            this.ucButtonSecondary1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButtonSecondary1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ucButtonSecondary1.ForeColor = System.Drawing.Color.White;
            this.ucButtonSecondary1.Location = new System.Drawing.Point(404, 316);
            this.ucButtonSecondary1.Name = "ucButtonSecondary1";
            this.ucButtonSecondary1.Size = new System.Drawing.Size(132, 39);
            this.ucButtonSecondary1.TabIndex = 11;
            this.ucButtonSecondary1.Tag = "close";
            this.ucButtonSecondary1.Text = "Cerrar";
            this.ucButtonSecondary1.UseVisualStyleBackColor = false;
            this.ucButtonSecondary1.Click += new System.EventHandler(this.ucButtonSecondary1_Click);
            // 
            // grdPedidos
            // 
            this.grdPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedidos.Location = new System.Drawing.Point(117, 46);
            this.grdPedidos.Name = "grdPedidos";
            this.grdPedidos.Size = new System.Drawing.Size(419, 264);
            this.grdPedidos.TabIndex = 12;
            // 
            // frmPedidosEnCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 386);
            this.Controls.Add(this.grdPedidos);
            this.Controls.Add(this.ucButtonSecondary1);
            this.Controls.Add(this.label1);
            this.Name = "frmPedidosEnCurso";
            this.Text = "frmPedidosEnCurso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPedidosEnCurso_FormClosing);
            this.Load += new System.EventHandler(this.frmPedidosEnCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private UcButtonSecondary ucButtonSecondary1;
        private System.Windows.Forms.DataGridView grdPedidos;
    }
}