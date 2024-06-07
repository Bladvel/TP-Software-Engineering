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
            this.lstPedidosPorCobrar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNotificarPedidoListo = new TPRestaurante.UcButtonPrimary(this.components);
            this.ucButtonSecondary1 = new TPRestaurante.UcButtonSecondary(this.components);
            this.SuspendLayout();
            // 
            // lstPedidosPorCobrar
            // 
            this.lstPedidosPorCobrar.FormattingEnabled = true;
            this.lstPedidosPorCobrar.Location = new System.Drawing.Point(26, 62);
            this.lstPedidosPorCobrar.Name = "lstPedidosPorCobrar";
            this.lstPedidosPorCobrar.Size = new System.Drawing.Size(226, 95);
            this.lstPedidosPorCobrar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pedidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Comanda del pedido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 227);
            this.textBox1.TabIndex = 9;
            // 
            // btnNotificarPedidoListo
            // 
            this.btnNotificarPedidoListo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnNotificarPedidoListo.FlatAppearance.BorderSize = 0;
            this.btnNotificarPedidoListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificarPedidoListo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNotificarPedidoListo.ForeColor = System.Drawing.Color.White;
            this.btnNotificarPedidoListo.Location = new System.Drawing.Point(327, 318);
            this.btnNotificarPedidoListo.Name = "btnNotificarPedidoListo";
            this.btnNotificarPedidoListo.Size = new System.Drawing.Size(132, 39);
            this.btnNotificarPedidoListo.TabIndex = 10;
            this.btnNotificarPedidoListo.Text = "Pasar a listo";
            this.btnNotificarPedidoListo.UseVisualStyleBackColor = false;
            // 
            // ucButtonSecondary1
            // 
            this.ucButtonSecondary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.ucButtonSecondary1.FlatAppearance.BorderSize = 0;
            this.ucButtonSecondary1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButtonSecondary1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ucButtonSecondary1.ForeColor = System.Drawing.Color.White;
            this.ucButtonSecondary1.Location = new System.Drawing.Point(465, 318);
            this.ucButtonSecondary1.Name = "ucButtonSecondary1";
            this.ucButtonSecondary1.Size = new System.Drawing.Size(132, 39);
            this.ucButtonSecondary1.TabIndex = 11;
            this.ucButtonSecondary1.Text = "Cancelar";
            this.ucButtonSecondary1.UseVisualStyleBackColor = false;
            this.ucButtonSecondary1.Click += new System.EventHandler(this.ucButtonSecondary1_Click);
            // 
            // frmPedidosEnCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 386);
            this.Controls.Add(this.ucButtonSecondary1);
            this.Controls.Add(this.btnNotificarPedidoListo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPedidosPorCobrar);
            this.Controls.Add(this.label1);
            this.Name = "frmPedidosEnCurso";
            this.Text = "frmPedidosEnCurso";
            this.Load += new System.EventHandler(this.frmPedidosEnCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPedidosPorCobrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private UcButtonPrimary btnNotificarPedidoListo;
        private UcButtonSecondary ucButtonSecondary1;
    }
}