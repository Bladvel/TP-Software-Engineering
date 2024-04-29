namespace Presentacion
{
    partial class frmRespaldos
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
            this.btn_GenerarBackUp = new System.Windows.Forms.Button();
            this.lbl_rutaBackup = new System.Windows.Forms.Label();
            this.txt_rutaBackUp = new System.Windows.Forms.TextBox();
            this.btn_ComenzarRestore = new System.Windows.Forms.Button();
            this.txt_rutaRestore = new System.Windows.Forms.TextBox();
            this.lbl_ComenzarRestore = new System.Windows.Forms.Label();
            this.btn_examinar1 = new System.Windows.Forms.Button();
            this.btn_Examinar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GenerarBackUp
            // 
            this.btn_GenerarBackUp.Location = new System.Drawing.Point(558, 35);
            this.btn_GenerarBackUp.Name = "btn_GenerarBackUp";
            this.btn_GenerarBackUp.Size = new System.Drawing.Size(118, 33);
            this.btn_GenerarBackUp.TabIndex = 0;
            this.btn_GenerarBackUp.Text = "Generar Backup";
            this.btn_GenerarBackUp.UseVisualStyleBackColor = true;
            this.btn_GenerarBackUp.Click += new System.EventHandler(this.btn_GenerarBackUp_Click);
            // 
            // lbl_rutaBackup
            // 
            this.lbl_rutaBackup.AutoSize = true;
            this.lbl_rutaBackup.Location = new System.Drawing.Point(12, 23);
            this.lbl_rutaBackup.Name = "lbl_rutaBackup";
            this.lbl_rutaBackup.Size = new System.Drawing.Size(76, 15);
            this.lbl_rutaBackup.TabIndex = 1;
            this.lbl_rutaBackup.Text = "Ruta Backup:";
            // 
            // txt_rutaBackUp
            // 
            this.txt_rutaBackUp.Location = new System.Drawing.Point(12, 41);
            this.txt_rutaBackUp.Name = "txt_rutaBackUp";
            this.txt_rutaBackUp.ReadOnly = true;
            this.txt_rutaBackUp.Size = new System.Drawing.Size(398, 23);
            this.txt_rutaBackUp.TabIndex = 2;
            // 
            // btn_ComenzarRestore
            // 
            this.btn_ComenzarRestore.Location = new System.Drawing.Point(558, 91);
            this.btn_ComenzarRestore.Name = "btn_ComenzarRestore";
            this.btn_ComenzarRestore.Size = new System.Drawing.Size(118, 31);
            this.btn_ComenzarRestore.TabIndex = 3;
            this.btn_ComenzarRestore.Text = "Comenzar Restore";
            this.btn_ComenzarRestore.UseVisualStyleBackColor = true;
            this.btn_ComenzarRestore.Click += new System.EventHandler(this.btn_ComenzarRestore_Click);
            // 
            // txt_rutaRestore
            // 
            this.txt_rutaRestore.Location = new System.Drawing.Point(12, 96);
            this.txt_rutaRestore.Name = "txt_rutaRestore";
            this.txt_rutaRestore.ReadOnly = true;
            this.txt_rutaRestore.Size = new System.Drawing.Size(398, 23);
            this.txt_rutaRestore.TabIndex = 5;
            // 
            // lbl_ComenzarRestore
            // 
            this.lbl_ComenzarRestore.AutoSize = true;
            this.lbl_ComenzarRestore.Location = new System.Drawing.Point(12, 78);
            this.lbl_ComenzarRestore.Name = "lbl_ComenzarRestore";
            this.lbl_ComenzarRestore.Size = new System.Drawing.Size(76, 15);
            this.lbl_ComenzarRestore.TabIndex = 4;
            this.lbl_ComenzarRestore.Text = "Ruta Restore:";
            // 
            // btn_examinar1
            // 
            this.btn_examinar1.Location = new System.Drawing.Point(431, 36);
            this.btn_examinar1.Name = "btn_examinar1";
            this.btn_examinar1.Size = new System.Drawing.Size(109, 32);
            this.btn_examinar1.TabIndex = 6;
            this.btn_examinar1.Text = "Examinar...";
            this.btn_examinar1.UseVisualStyleBackColor = true;
            this.btn_examinar1.Click += new System.EventHandler(this.btn_examinar1_Click);
            // 
            // btn_Examinar2
            // 
            this.btn_Examinar2.Location = new System.Drawing.Point(431, 91);
            this.btn_Examinar2.Name = "btn_Examinar2";
            this.btn_Examinar2.Size = new System.Drawing.Size(109, 32);
            this.btn_Examinar2.TabIndex = 7;
            this.btn_Examinar2.Text = "Examinar...";
            this.btn_Examinar2.UseVisualStyleBackColor = true;
            this.btn_Examinar2.Click += new System.EventHandler(this.btn_Examinar2_Click);
            // 
            // frmRespaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 144);
            this.Controls.Add(this.btn_Examinar2);
            this.Controls.Add(this.btn_examinar1);
            this.Controls.Add(this.txt_rutaRestore);
            this.Controls.Add(this.lbl_ComenzarRestore);
            this.Controls.Add(this.btn_ComenzarRestore);
            this.Controls.Add(this.txt_rutaBackUp);
            this.Controls.Add(this.lbl_rutaBackup);
            this.Controls.Add(this.btn_GenerarBackUp);
            this.MaximumSize = new System.Drawing.Size(704, 183);
            this.MinimumSize = new System.Drawing.Size(704, 183);
            this.Name = "frmRespaldos";
            this.Text = "frmRespaldos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRespaldos_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_GenerarBackUp;
        private Label lbl_rutaBackup;
        private TextBox txt_rutaBackUp;
        private Button btn_ComenzarRestore;
        private TextBox txt_rutaRestore;
        private Label lbl_ComenzarRestore;
        private Button btn_examinar1;
        private Button btn_Examinar2;
    }
}