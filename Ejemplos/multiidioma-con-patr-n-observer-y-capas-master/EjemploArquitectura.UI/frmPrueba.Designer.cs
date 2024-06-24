namespace EjemploArquitectura.UI
{
    partial class frmPrueba
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
            this.lblPrueba = new System.Windows.Forms.Label();
            this.btnGracias = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Location = new System.Drawing.Point(512, 172);
            this.lblPrueba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(0, 17);
            this.lblPrueba.TabIndex = 0;
            this.lblPrueba.Tag = "testText";
            // 
            // btnGracias
            // 
            this.btnGracias.Location = new System.Drawing.Point(489, 401);
            this.btnGracias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGracias.Name = "btnGracias";
            this.btnGracias.Size = new System.Drawing.Size(100, 28);
            this.btnGracias.TabIndex = 1;
            this.btnGracias.Tag = "please";
            this.btnGracias.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(464, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Tag = "username";
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnGracias);
            this.Controls.Add(this.lblPrueba);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrueba";
            this.Tag = "test";
            this.Text = "Prueba";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrueba_FormClosing);
            this.Load += new System.EventHandler(this.frmPrueba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.Button btnGracias;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}