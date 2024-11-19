namespace TPRestaurante
{
    partial class frmManualUsuarios
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
            this.panelPdf = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelPdf
            // 
            this.panelPdf.Location = new System.Drawing.Point(24, 21);
            this.panelPdf.Name = "panelPdf";
            this.panelPdf.Size = new System.Drawing.Size(823, 544);
            this.panelPdf.TabIndex = 0;
            // 
            // frmManualUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 587);
            this.Controls.Add(this.panelPdf);
            this.Name = "frmManualUsuarios";
            this.Text = "frmManualUsuarios";
            this.Load += new System.EventHandler(this.frmManualUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPdf;
    }
}