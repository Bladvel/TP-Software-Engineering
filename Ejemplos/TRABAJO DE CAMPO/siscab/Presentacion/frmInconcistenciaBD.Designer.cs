namespace Presentacion
{
    partial class frmInconcistenciaBD
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
            this.btn_recomponer = new System.Windows.Forms.Button();
            this.btn_restore_backup = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_advertencia = new System.Windows.Forms.Label();
            this.lbl_advertencia2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_recomponer
            // 
            this.btn_recomponer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_recomponer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_recomponer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_recomponer.Location = new System.Drawing.Point(141, 83);
            this.btn_recomponer.Name = "btn_recomponer";
            this.btn_recomponer.Size = new System.Drawing.Size(207, 25);
            this.btn_recomponer.TabIndex = 0;
            this.btn_recomponer.Text = "Recomponer el dígito verificador ";
            this.btn_recomponer.UseVisualStyleBackColor = false;
            this.btn_recomponer.Click += new System.EventHandler(this.btn_recomponer_Click);
            // 
            // btn_restore_backup
            // 
            this.btn_restore_backup.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_restore_backup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_restore_backup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_restore_backup.Location = new System.Drawing.Point(141, 114);
            this.btn_restore_backup.Name = "btn_restore_backup";
            this.btn_restore_backup.Size = new System.Drawing.Size(207, 25);
            this.btn_restore_backup.TabIndex = 1;
            this.btn_restore_backup.Text = "Restaurar desde un backup";
            this.btn_restore_backup.UseVisualStyleBackColor = false;
            this.btn_restore_backup.Click += new System.EventHandler(this.btn_restore_backup_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_salir.Location = new System.Drawing.Point(141, 145);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(207, 25);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_advertencia
            // 
            this.lbl_advertencia.AutoSize = true;
            this.lbl_advertencia.Location = new System.Drawing.Point(53, 23);
            this.lbl_advertencia.Name = "lbl_advertencia";
            this.lbl_advertencia.Size = new System.Drawing.Size(395, 15);
            this.lbl_advertencia.TabIndex = 3;
            this.lbl_advertencia.Text = "¡ADVERTENCIA! La base de datos se encuentra en un estado inconsistente.";
            // 
            // lbl_advertencia2
            // 
            this.lbl_advertencia2.AutoSize = true;
            this.lbl_advertencia2.Location = new System.Drawing.Point(176, 49);
            this.lbl_advertencia2.Name = "lbl_advertencia2";
            this.lbl_advertencia2.Size = new System.Drawing.Size(126, 15);
            this.lbl_advertencia2.TabIndex = 4;
            this.lbl_advertencia2.Text = "Seleccione una opción";
            // 
            // frmInconcistenciaBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 176);
            this.Controls.Add(this.lbl_advertencia2);
            this.Controls.Add(this.lbl_advertencia);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_restore_backup);
            this.Controls.Add(this.btn_recomponer);
            this.MaximumSize = new System.Drawing.Size(497, 215);
            this.MinimumSize = new System.Drawing.Size(497, 215);
            this.Name = "frmInconcistenciaBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInconcistenciaBD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_recomponer;
        private Button btn_restore_backup;
        private Button btn_salir;
        private Label lbl_advertencia;
        private Label lbl_advertencia2;
    }
}