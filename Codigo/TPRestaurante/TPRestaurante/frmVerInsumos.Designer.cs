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
            this.ucButtonPrimary1 = new TPRestaurante.UcButtonPrimary(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ucButtonPrimary2 = new TPRestaurante.UcButtonPrimary(this.components);
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
            // ucButtonPrimary1
            // 
            this.ucButtonPrimary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.ucButtonPrimary1.FlatAppearance.BorderSize = 0;
            this.ucButtonPrimary1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButtonPrimary1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ucButtonPrimary1.ForeColor = System.Drawing.Color.White;
            this.ucButtonPrimary1.Location = new System.Drawing.Point(266, 262);
            this.ucButtonPrimary1.Name = "ucButtonPrimary1";
            this.ucButtonPrimary1.Size = new System.Drawing.Size(218, 39);
            this.ucButtonPrimary1.TabIndex = 2;
            this.ucButtonPrimary1.Text = "Ver pendientes por compra";
            this.ucButtonPrimary1.UseVisualStyleBackColor = false;
            this.ucButtonPrimary1.Click += new System.EventHandler(this.ucButtonPrimary1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(531, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 212);
            this.listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad a agregar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ucButtonPrimary2
            // 
            this.ucButtonPrimary2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.ucButtonPrimary2.FlatAppearance.BorderSize = 0;
            this.ucButtonPrimary2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButtonPrimary2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ucButtonPrimary2.ForeColor = System.Drawing.Color.White;
            this.ucButtonPrimary2.Location = new System.Drawing.Point(543, 262);
            this.ucButtonPrimary2.Name = "ucButtonPrimary2";
            this.ucButtonPrimary2.Size = new System.Drawing.Size(218, 39);
            this.ucButtonPrimary2.TabIndex = 7;
            this.ucButtonPrimary2.Text = "Generar solicitud de compra";
            this.ucButtonPrimary2.UseVisualStyleBackColor = false;
            this.ucButtonPrimary2.Click += new System.EventHandler(this.ucButtonPrimary2_Click);
            // 
            // frmVerInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 326);
            this.Controls.Add(this.ucButtonPrimary2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ucButtonPrimary1);
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
        private UcButtonPrimary ucButtonPrimary1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private UcButtonPrimary ucButtonPrimary2;
    }
}