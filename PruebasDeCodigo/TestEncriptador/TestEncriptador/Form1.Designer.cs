namespace TestEncriptador
{
    partial class Form1
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
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncriptar = new System.Windows.Forms.TextBox();
            this.txtEncriptado = new System.Windows.Forms.TextBox();
            this.txtDesencriptado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(297, 86);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptar.TabIndex = 0;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto a encriptar";
            // 
            // txtEncriptar
            // 
            this.txtEncriptar.Location = new System.Drawing.Point(97, 88);
            this.txtEncriptar.Name = "txtEncriptar";
            this.txtEncriptar.Size = new System.Drawing.Size(194, 20);
            this.txtEncriptar.TabIndex = 2;
            // 
            // txtEncriptado
            // 
            this.txtEncriptado.Location = new System.Drawing.Point(97, 171);
            this.txtEncriptado.Name = "txtEncriptado";
            this.txtEncriptado.Size = new System.Drawing.Size(194, 20);
            this.txtEncriptado.TabIndex = 3;
            // 
            // txtDesencriptado
            // 
            this.txtDesencriptado.Location = new System.Drawing.Point(97, 224);
            this.txtDesencriptado.Name = "txtDesencriptado";
            this.txtDesencriptado.Size = new System.Drawing.Size(194, 20);
            this.txtDesencriptado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 378);
            this.Controls.Add(this.txtDesencriptado);
            this.Controls.Add(this.txtEncriptado);
            this.Controls.Add(this.txtEncriptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncriptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncriptar;
        private System.Windows.Forms.TextBox txtEncriptado;
        private System.Windows.Forms.TextBox txtDesencriptado;
    }
}

