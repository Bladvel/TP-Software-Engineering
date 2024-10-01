namespace TPRestaurante
{
    partial class frmBitacoraDeCambios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ucButtonPrimary1 = new TPRestaurante.UcButtonPrimary(this.components);
            this.ucButtonPrimary2 = new TPRestaurante.UcButtonPrimary(this.components);
            this.ucButtonSecondary1 = new TPRestaurante.UcButtonSecondary(this.components);
            this.ucButtonSecondary2 = new TPRestaurante.UcButtonSecondary(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BITACORA DE CAMBIOS EN PRODUCTO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 194);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cod_Prod";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucButtonSecondary2);
            this.groupBox1.Controls.Add(this.ucButtonSecondary1);
            this.groupBox1.Controls.Add(this.ucButtonPrimary2);
            this.groupBox1.Controls.Add(this.ucButtonPrimary1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(36, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Ini.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(68, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 3;
            // 
            // ucButtonPrimary1
            // 
            this.ucButtonPrimary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.ucButtonPrimary1.FlatAppearance.BorderSize = 0;
            this.ucButtonPrimary1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButtonPrimary1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ucButtonPrimary1.ForeColor = System.Drawing.Color.White;
            this.ucButtonPrimary1.Location = new System.Drawing.Point(269, 40);
            this.ucButtonPrimary1.Name = "ucButtonPrimary1";
            this.ucButtonPrimary1.Size = new System.Drawing.Size(107, 33);
            this.ucButtonPrimary1.TabIndex = 5;
            this.ucButtonPrimary1.Text = "Aplicar";
            this.ucButtonPrimary1.UseVisualStyleBackColor = false;
            // 
            // ucButtonPrimary2
            // 
            this.ucButtonPrimary2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.ucButtonPrimary2.FlatAppearance.BorderSize = 0;
            this.ucButtonPrimary2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButtonPrimary2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ucButtonPrimary2.ForeColor = System.Drawing.Color.White;
            this.ucButtonPrimary2.Location = new System.Drawing.Point(269, 94);
            this.ucButtonPrimary2.Name = "ucButtonPrimary2";
            this.ucButtonPrimary2.Size = new System.Drawing.Size(107, 33);
            this.ucButtonPrimary2.TabIndex = 5;
            this.ucButtonPrimary2.Text = "Activar";
            this.ucButtonPrimary2.UseVisualStyleBackColor = false;
            // 
            // ucButtonSecondary1
            // 
            this.ucButtonSecondary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.ucButtonSecondary1.FlatAppearance.BorderSize = 0;
            this.ucButtonSecondary1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButtonSecondary1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ucButtonSecondary1.ForeColor = System.Drawing.Color.White;
            this.ucButtonSecondary1.Location = new System.Drawing.Point(416, 94);
            this.ucButtonSecondary1.Name = "ucButtonSecondary1";
            this.ucButtonSecondary1.Size = new System.Drawing.Size(107, 33);
            this.ucButtonSecondary1.TabIndex = 6;
            this.ucButtonSecondary1.Text = "Salir";
            this.ucButtonSecondary1.UseVisualStyleBackColor = false;
            // 
            // ucButtonSecondary2
            // 
            this.ucButtonSecondary2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.ucButtonSecondary2.FlatAppearance.BorderSize = 0;
            this.ucButtonSecondary2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButtonSecondary2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ucButtonSecondary2.ForeColor = System.Drawing.Color.White;
            this.ucButtonSecondary2.Location = new System.Drawing.Point(416, 40);
            this.ucButtonSecondary2.Name = "ucButtonSecondary2";
            this.ucButtonSecondary2.Size = new System.Drawing.Size(107, 33);
            this.ucButtonSecondary2.TabIndex = 6;
            this.ucButtonSecondary2.Text = "Limpiar";
            this.ucButtonSecondary2.UseVisualStyleBackColor = false;
            // 
            // frmBitacoraDeCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmBitacoraDeCambios";
            this.Text = "Bitacora de cambios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private UcButtonSecondary ucButtonSecondary1;
        private UcButtonPrimary ucButtonPrimary2;
        private UcButtonPrimary ucButtonPrimary1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private UcButtonSecondary ucButtonSecondary2;
    }
}