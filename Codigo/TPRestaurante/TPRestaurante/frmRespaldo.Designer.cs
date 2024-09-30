namespace TPRestaurante
{
    partial class frmRespaldo
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
            this.txtRutaBackup = new System.Windows.Forms.TextBox();
            this.txtRutaRestore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComenzarRestore = new TPRestaurante.UcButtonPrimary(this.components);
            this.btnExaminarRestore = new TPRestaurante.UcButtonSecondary(this.components);
            this.btnGenerarBackup = new TPRestaurante.UcButtonPrimary(this.components);
            this.btnExaminarBackup = new TPRestaurante.UcButtonSecondary(this.components);
            this.btnSalir = new TPRestaurante.UcButtonSecondary(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRutaBackup
            // 
            this.txtRutaBackup.BackColor = System.Drawing.Color.White;
            this.txtRutaBackup.Location = new System.Drawing.Point(36, 38);
            this.txtRutaBackup.Name = "txtRutaBackup";
            this.txtRutaBackup.ReadOnly = true;
            this.txtRutaBackup.Size = new System.Drawing.Size(270, 20);
            this.txtRutaBackup.TabIndex = 0;
            // 
            // txtRutaRestore
            // 
            this.txtRutaRestore.BackColor = System.Drawing.Color.White;
            this.txtRutaRestore.Location = new System.Drawing.Point(36, 43);
            this.txtRutaRestore.Name = "txtRutaRestore";
            this.txtRutaRestore.ReadOnly = true;
            this.txtRutaRestore.Size = new System.Drawing.Size(270, 20);
            this.txtRutaRestore.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta Backup:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruta Restore:";
            // 
            // btnComenzarRestore
            // 
            this.btnComenzarRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnComenzarRestore.FlatAppearance.BorderSize = 0;
            this.btnComenzarRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzarRestore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnComenzarRestore.ForeColor = System.Drawing.Color.White;
            this.btnComenzarRestore.Location = new System.Drawing.Point(487, 24);
            this.btnComenzarRestore.Name = "btnComenzarRestore";
            this.btnComenzarRestore.Size = new System.Drawing.Size(132, 39);
            this.btnComenzarRestore.TabIndex = 2;
            this.btnComenzarRestore.Text = "Restore";
            this.btnComenzarRestore.UseVisualStyleBackColor = false;
            this.btnComenzarRestore.Click += new System.EventHandler(this.btnComenzarRestore_Click);
            // 
            // btnExaminarRestore
            // 
            this.btnExaminarRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnExaminarRestore.FlatAppearance.BorderSize = 0;
            this.btnExaminarRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminarRestore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExaminarRestore.ForeColor = System.Drawing.Color.White;
            this.btnExaminarRestore.Location = new System.Drawing.Point(334, 24);
            this.btnExaminarRestore.Name = "btnExaminarRestore";
            this.btnExaminarRestore.Size = new System.Drawing.Size(132, 39);
            this.btnExaminarRestore.TabIndex = 1;
            this.btnExaminarRestore.Text = "Examinar...";
            this.btnExaminarRestore.UseVisualStyleBackColor = false;
            this.btnExaminarRestore.Click += new System.EventHandler(this.btnExaminarRestore_Click);
            // 
            // btnGenerarBackup
            // 
            this.btnGenerarBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnGenerarBackup.FlatAppearance.BorderSize = 0;
            this.btnGenerarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarBackup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerarBackup.ForeColor = System.Drawing.Color.White;
            this.btnGenerarBackup.Location = new System.Drawing.Point(487, 19);
            this.btnGenerarBackup.Name = "btnGenerarBackup";
            this.btnGenerarBackup.Size = new System.Drawing.Size(132, 39);
            this.btnGenerarBackup.TabIndex = 2;
            this.btnGenerarBackup.Text = "Generar Backup";
            this.btnGenerarBackup.UseVisualStyleBackColor = false;
            this.btnGenerarBackup.Click += new System.EventHandler(this.btnGenerarBackup_Click);
            // 
            // btnExaminarBackup
            // 
            this.btnExaminarBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnExaminarBackup.FlatAppearance.BorderSize = 0;
            this.btnExaminarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminarBackup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExaminarBackup.ForeColor = System.Drawing.Color.White;
            this.btnExaminarBackup.Location = new System.Drawing.Point(334, 19);
            this.btnExaminarBackup.Name = "btnExaminarBackup";
            this.btnExaminarBackup.Size = new System.Drawing.Size(132, 39);
            this.btnExaminarBackup.TabIndex = 1;
            this.btnExaminarBackup.Text = "Examinar...";
            this.btnExaminarBackup.UseVisualStyleBackColor = false;
            this.btnExaminarBackup.Click += new System.EventHandler(this.btnExaminarBackup_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(529, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 39);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRutaRestore);
            this.groupBox1.Controls.Add(this.btnExaminarRestore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnComenzarRestore);
            this.groupBox1.Location = new System.Drawing.Point(42, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 80);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restaurar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExaminarBackup);
            this.groupBox2.Controls.Add(this.txtRutaBackup);
            this.groupBox2.Controls.Add(this.btnGenerarBackup);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(42, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 80);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar";
            // 
            // frmRespaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmRespaldo";
            this.Text = "Gestión de respaldos";
            this.Load += new System.EventHandler(this.frmRespaldo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRutaBackup;
        private UcButtonSecondary btnExaminarBackup;
        private UcButtonPrimary btnGenerarBackup;
        private System.Windows.Forms.TextBox txtRutaRestore;
        private UcButtonSecondary btnExaminarRestore;
        private UcButtonPrimary btnComenzarRestore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UcButtonSecondary btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}