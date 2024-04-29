namespace Presentacion
{
    partial class frmInconsistenciaUsuario
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
            this.lbl_advertencia = new System.Windows.Forms.Label();
            this.lbl_advertencia2 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_advertencia
            // 
            this.lbl_advertencia.AutoSize = true;
            this.lbl_advertencia.Location = new System.Drawing.Point(2, 18);
            this.lbl_advertencia.Name = "lbl_advertencia";
            this.lbl_advertencia.Size = new System.Drawing.Size(395, 15);
            this.lbl_advertencia.TabIndex = 0;
            this.lbl_advertencia.Text = "¡ADVERTENCIA! La base de datos se encuentra en un estado inconsistente.";
            // 
            // lbl_advertencia2
            // 
            this.lbl_advertencia2.AutoSize = true;
            this.lbl_advertencia2.Location = new System.Drawing.Point(70, 46);
            this.lbl_advertencia2.Name = "lbl_advertencia2";
            this.lbl_advertencia2.Size = new System.Drawing.Size(261, 15);
            this.lbl_advertencia2.TabIndex = 1;
            this.lbl_advertencia2.Text = "Comuníquese con el Administrador del Sistema.";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_aceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_aceptar.Location = new System.Drawing.Point(157, 79);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(85, 26);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // frmInconsistenciaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 117);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_advertencia2);
            this.Controls.Add(this.lbl_advertencia);
            this.Name = "frmInconsistenciaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInconsistenciaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_advertencia;
        private Label lbl_advertencia2;
        private Button btn_aceptar;
    }
}