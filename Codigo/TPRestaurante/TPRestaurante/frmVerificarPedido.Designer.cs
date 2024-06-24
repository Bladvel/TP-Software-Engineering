namespace TPRestaurante
{
    partial class frmVerificarPedido
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grdPedidos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.grdProductosPedido = new System.Windows.Forms.DataGridView();
            this.btnRechazarPedido = new TPRestaurante.UcButtonPrimary(this.components);
            this.btnCancelar = new TPRestaurante.UcButtonSecondary(this.components);
            this.btnVerificarPedido = new TPRestaurante.UcButtonPrimary(this.components);
            this.grdIngredientesDisponibles = new System.Windows.Forms.DataGridView();
            this.grdIngredientesFaltantes = new System.Windows.Forms.DataGridView();
            this.btnAceptarPedido = new TPRestaurante.UcButtonPrimary(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIngredientesDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIngredientesFaltantes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Tag = "orders";
            this.label2.Text = "Pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 16);
            this.label3.TabIndex = 2;
            this.label3.Tag = "availableIngredients";
            this.label3.Text = "Ingredientes disponibles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 16);
            this.label4.TabIndex = 2;
            this.label4.Tag = "missingIngredients";
            this.label4.Text = "Ingredientes faltantes";
            // 
            // grdPedidos
            // 
            this.grdPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedidos.Location = new System.Drawing.Point(9, 36);
            this.grdPedidos.Name = "grdPedidos";
            this.grdPedidos.Size = new System.Drawing.Size(331, 95);
            this.grdPedidos.TabIndex = 6;
            this.grdPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPedidos_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 2;
            this.label5.Tag = "products";
            this.label5.Text = "ItemProductos";
            // 
            // grdProductosPedido
            // 
            this.grdProductosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductosPedido.Location = new System.Drawing.Point(9, 176);
            this.grdProductosPedido.Name = "grdProductosPedido";
            this.grdProductosPedido.Size = new System.Drawing.Size(331, 95);
            this.grdProductosPedido.TabIndex = 6;
            // 
            // btnRechazarPedido
            // 
            this.btnRechazarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRechazarPedido.FlatAppearance.BorderSize = 0;
            this.btnRechazarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazarPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRechazarPedido.ForeColor = System.Drawing.Color.White;
            this.btnRechazarPedido.Location = new System.Drawing.Point(241, 276);
            this.btnRechazarPedido.Name = "btnRechazarPedido";
            this.btnRechazarPedido.Size = new System.Drawing.Size(132, 39);
            this.btnRechazarPedido.TabIndex = 7;
            this.btnRechazarPedido.Tag = "decline";
            this.btnRechazarPedido.Text = "Rechazar";
            this.btnRechazarPedido.UseVisualStyleBackColor = false;
            this.btnRechazarPedido.Click += new System.EventHandler(this.btnRechazarPedido_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(642, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Tag = "cancel";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.ucButtonSecondary1_Click);
            // 
            // btnVerificarPedido
            // 
            this.btnVerificarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnVerificarPedido.FlatAppearance.BorderSize = 0;
            this.btnVerificarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificarPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerificarPedido.ForeColor = System.Drawing.Color.White;
            this.btnVerificarPedido.Location = new System.Drawing.Point(208, 277);
            this.btnVerificarPedido.Name = "btnVerificarPedido";
            this.btnVerificarPedido.Size = new System.Drawing.Size(132, 39);
            this.btnVerificarPedido.TabIndex = 4;
            this.btnVerificarPedido.Tag = "verify";
            this.btnVerificarPedido.Text = "Verificar";
            this.btnVerificarPedido.UseVisualStyleBackColor = false;
            this.btnVerificarPedido.Click += new System.EventHandler(this.btnVerificarPedido_Click);
            // 
            // grdIngredientesDisponibles
            // 
            this.grdIngredientesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIngredientesDisponibles.Location = new System.Drawing.Point(20, 36);
            this.grdIngredientesDisponibles.Name = "grdIngredientesDisponibles";
            this.grdIngredientesDisponibles.Size = new System.Drawing.Size(353, 95);
            this.grdIngredientesDisponibles.TabIndex = 8;
            // 
            // grdIngredientesFaltantes
            // 
            this.grdIngredientesFaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIngredientesFaltantes.Location = new System.Drawing.Point(20, 176);
            this.grdIngredientesFaltantes.Name = "grdIngredientesFaltantes";
            this.grdIngredientesFaltantes.Size = new System.Drawing.Size(353, 94);
            this.grdIngredientesFaltantes.TabIndex = 9;
            // 
            // btnAceptarPedido
            // 
            this.btnAceptarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnAceptarPedido.FlatAppearance.BorderSize = 0;
            this.btnAceptarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAceptarPedido.ForeColor = System.Drawing.Color.White;
            this.btnAceptarPedido.Location = new System.Drawing.Point(103, 276);
            this.btnAceptarPedido.Name = "btnAceptarPedido";
            this.btnAceptarPedido.Size = new System.Drawing.Size(132, 39);
            this.btnAceptarPedido.TabIndex = 10;
            this.btnAceptarPedido.Tag = "acept";
            this.btnAceptarPedido.Text = "Aceptar";
            this.btnAceptarPedido.UseVisualStyleBackColor = false;
            this.btnAceptarPedido.Click += new System.EventHandler(this.btnAceptarPedido_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnVerificarPedido);
            this.groupBox1.Controls.Add(this.grdPedidos);
            this.groupBox1.Controls.Add(this.grdProductosPedido);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 353);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "step1";
            this.groupBox1.Text = "Paso 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdIngredientesDisponibles);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAceptarPedido);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.grdIngredientesFaltantes);
            this.groupBox2.Controls.Add(this.btnRechazarPedido);
            this.groupBox2.Location = new System.Drawing.Point(377, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 353);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "step2";
            this.groupBox2.Text = "Paso 2";
            // 
            // frmVerificarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmVerificarPedido";
            this.Text = "frmVerificarPedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVerificarPedido_FormClosing);
            this.Load += new System.EventHandler(this.frmVerificarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIngredientesDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIngredientesFaltantes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private UcButtonPrimary btnVerificarPedido;
        private UcButtonSecondary btnCancelar;
        private System.Windows.Forms.DataGridView grdPedidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdProductosPedido;
        private UcButtonPrimary btnRechazarPedido;
        private System.Windows.Forms.DataGridView grdIngredientesDisponibles;
        private System.Windows.Forms.DataGridView grdIngredientesFaltantes;
        private UcButtonPrimary btnAceptarPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}