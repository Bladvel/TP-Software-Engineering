namespace TPRestaurante
{
    partial class frmCobrarPedido
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.groupEfectivo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.groupTarjeta = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.grdPedidosPorCobrar = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.ucButtonSecondary1 = new TPRestaurante.UcButtonSecondary(this.components);
            this.btnCobrar = new TPRestaurante.UcButtonPrimary(this.components);
            this.groupEfectivo.SuspendLayout();
            this.groupTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidosPorCobrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 0;
            this.label1.Tag = "selectOrder";
            this.label1.Text = "Seleccionar pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(732, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Tag = "total";
            this.label2.Text = "Total: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 16);
            this.label3.TabIndex = 3;
            this.label3.Tag = "selectPaymentMethod";
            this.label3.Text = "Seleccione metodo de pago";
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Location = new System.Drawing.Point(368, 36);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(137, 21);
            this.cmbMetodo.TabIndex = 4;
            this.cmbMetodo.SelectedIndexChanged += new System.EventHandler(this.cmbMetodo_SelectedIndexChanged);
            // 
            // groupEfectivo
            // 
            this.groupEfectivo.Controls.Add(this.label4);
            this.groupEfectivo.Controls.Add(this.txtMonto);
            this.groupEfectivo.Location = new System.Drawing.Point(623, 100);
            this.groupEfectivo.Name = "groupEfectivo";
            this.groupEfectivo.Size = new System.Drawing.Size(200, 196);
            this.groupEfectivo.TabIndex = 5;
            this.groupEfectivo.TabStop = false;
            this.groupEfectivo.Tag = "cash";
            this.groupEfectivo.Text = "Efectivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Tag = "amount";
            this.label4.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(81, 50);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 0;
            // 
            // groupTarjeta
            // 
            this.groupTarjeta.Controls.Add(this.label8);
            this.groupTarjeta.Controls.Add(this.label7);
            this.groupTarjeta.Controls.Add(this.label6);
            this.groupTarjeta.Controls.Add(this.label5);
            this.groupTarjeta.Controls.Add(this.txtTitular);
            this.groupTarjeta.Controls.Add(this.txtCvv);
            this.groupTarjeta.Controls.Add(this.dateTimePicker1);
            this.groupTarjeta.Controls.Add(this.txtNumero);
            this.groupTarjeta.Location = new System.Drawing.Point(368, 100);
            this.groupTarjeta.Name = "groupTarjeta";
            this.groupTarjeta.Size = new System.Drawing.Size(249, 196);
            this.groupTarjeta.TabIndex = 5;
            this.groupTarjeta.TabStop = false;
            this.groupTarjeta.Tag = "card";
            this.groupTarjeta.Text = "Tarjeta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 4;
            this.label8.Tag = "cardHolder";
            this.label8.Text = "Titular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 4;
            this.label7.Tag = "cvv";
            this.label7.Text = "CVV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 4;
            this.label6.Tag = "dueDate";
            this.label6.Text = "Fecha Vto.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Tag = "number";
            this.label5.Text = "Numero";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(10, 111);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(220, 20);
            this.txtTitular.TabIndex = 3;
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(41, 146);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(56, 20);
            this.txtCvv.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(9, 32);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(221, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // grdPedidosPorCobrar
            // 
            this.grdPedidosPorCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedidosPorCobrar.Location = new System.Drawing.Point(15, 36);
            this.grdPedidosPorCobrar.Name = "grdPedidosPorCobrar";
            this.grdPedidosPorCobrar.Size = new System.Drawing.Size(338, 260);
            this.grdPedidosPorCobrar.TabIndex = 8;
            this.grdPedidosPorCobrar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPedidosPorCobrar_CellClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(791, 36);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 16);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "$0";
            // 
            // ucButtonSecondary1
            // 
            this.ucButtonSecondary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.ucButtonSecondary1.FlatAppearance.BorderSize = 0;
            this.ucButtonSecondary1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButtonSecondary1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ucButtonSecondary1.ForeColor = System.Drawing.Color.White;
            this.ucButtonSecondary1.Location = new System.Drawing.Point(691, 328);
            this.ucButtonSecondary1.Name = "ucButtonSecondary1";
            this.ucButtonSecondary1.Size = new System.Drawing.Size(132, 39);
            this.ucButtonSecondary1.TabIndex = 7;
            this.ucButtonSecondary1.Tag = "cancel";
            this.ucButtonSecondary1.Text = "Cancelar";
            this.ucButtonSecondary1.UseVisualStyleBackColor = false;
            this.ucButtonSecondary1.Click += new System.EventHandler(this.ucButtonSecondary1_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(549, 328);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(132, 39);
            this.btnCobrar.TabIndex = 6;
            this.btnCobrar.Tag = "charge";
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // frmCobrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(855, 410);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grdPedidosPorCobrar);
            this.Controls.Add(this.ucButtonSecondary1);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.groupTarjeta);
            this.Controls.Add(this.groupEfectivo);
            this.Controls.Add(this.cmbMetodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCobrarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCobrarPedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCobrarPedido_FormClosing);
            this.Load += new System.EventHandler(this.frmCobrarPedido_Load);
            this.groupEfectivo.ResumeLayout(false);
            this.groupEfectivo.PerformLayout();
            this.groupTarjeta.ResumeLayout(false);
            this.groupTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidosPorCobrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.GroupBox groupEfectivo;
        private System.Windows.Forms.GroupBox groupTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label8;
        private UcButtonPrimary btnCobrar;
        private UcButtonSecondary ucButtonSecondary1;
        private System.Windows.Forms.DataGridView grdPedidosPorCobrar;
        private System.Windows.Forms.Label lblTotal;
    }
}