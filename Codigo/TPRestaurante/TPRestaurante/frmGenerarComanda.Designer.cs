namespace TPRestaurante
{
    partial class frmGenerarComanda
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
            this.txtInstrucciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grdPedidosAceptados = new System.Windows.Forms.DataGridView();
            this.grdProductosPorPedido = new System.Windows.Forms.DataGridView();
            this.grdCocinerosDisponibles = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new TPRestaurante.UcButtonSecondary(this.components);
            this.btnGenerarComanda = new TPRestaurante.UcButtonPrimary(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidosAceptados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosPorPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCocinerosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Tag = "selectOrder";
            this.label1.Text = "Seleccionar pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Tag = "products";
            this.label2.Text = "Productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Tag = "addInstructions";
            this.label3.Text = "Agregar instrucciones";
            // 
            // txtInstrucciones
            // 
            this.txtInstrucciones.Location = new System.Drawing.Point(411, 269);
            this.txtInstrucciones.Multiline = true;
            this.txtInstrucciones.Name = "txtInstrucciones";
            this.txtInstrucciones.Size = new System.Drawing.Size(301, 95);
            this.txtInstrucciones.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Tag = "assignChef";
            this.label4.Text = "Asignar cocinero";
            // 
            // grdPedidosAceptados
            // 
            this.grdPedidosAceptados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedidosAceptados.Location = new System.Drawing.Point(47, 59);
            this.grdPedidosAceptados.Name = "grdPedidosAceptados";
            this.grdPedidosAceptados.Size = new System.Drawing.Size(301, 150);
            this.grdPedidosAceptados.TabIndex = 14;
            this.grdPedidosAceptados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPedidosAceptados_CellClick);
            // 
            // grdProductosPorPedido
            // 
            this.grdProductosPorPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductosPorPedido.Location = new System.Drawing.Point(411, 59);
            this.grdProductosPorPedido.Name = "grdProductosPorPedido";
            this.grdProductosPorPedido.Size = new System.Drawing.Size(301, 150);
            this.grdProductosPorPedido.TabIndex = 14;
            // 
            // grdCocinerosDisponibles
            // 
            this.grdCocinerosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCocinerosDisponibles.Location = new System.Drawing.Point(47, 269);
            this.grdCocinerosDisponibles.Name = "grdCocinerosDisponibles";
            this.grdCocinerosDisponibles.Size = new System.Drawing.Size(301, 150);
            this.grdCocinerosDisponibles.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(580, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 39);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Tag = "cancel";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerarComanda
            // 
            this.btnGenerarComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnGenerarComanda.FlatAppearance.BorderSize = 0;
            this.btnGenerarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarComanda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerarComanda.ForeColor = System.Drawing.Color.White;
            this.btnGenerarComanda.Location = new System.Drawing.Point(442, 380);
            this.btnGenerarComanda.Name = "btnGenerarComanda";
            this.btnGenerarComanda.Size = new System.Drawing.Size(132, 39);
            this.btnGenerarComanda.TabIndex = 12;
            this.btnGenerarComanda.Tag = "generate";
            this.btnGenerarComanda.Text = "Generar";
            this.btnGenerarComanda.UseVisualStyleBackColor = false;
            this.btnGenerarComanda.Click += new System.EventHandler(this.btnGenerarComanda_Click);
            // 
            // frmGenerarComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 477);
            this.Controls.Add(this.grdProductosPorPedido);
            this.Controls.Add(this.grdCocinerosDisponibles);
            this.Controls.Add(this.grdPedidosAceptados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerarComanda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInstrucciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGenerarComanda";
            this.Text = "frmGenerarComanda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGenerarComanda_FormClosing);
            this.Load += new System.EventHandler(this.frmGenerarComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidosAceptados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosPorPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCocinerosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInstrucciones;
        private System.Windows.Forms.Label label4;
        private UcButtonPrimary btnGenerarComanda;
        private UcButtonSecondary btnCancelar;
        private System.Windows.Forms.DataGridView grdPedidosAceptados;
        private System.Windows.Forms.DataGridView grdProductosPorPedido;
        private System.Windows.Forms.DataGridView grdCocinerosDisponibles;
    }
}