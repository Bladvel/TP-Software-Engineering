namespace TPRestaurante
{
    partial class UcButtonSecondary
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ucButtonPrimary1 = new TPRestaurante.UcButtonPrimary(this.components);
            this.SuspendLayout();
            // 
            // ucButtonPrimary1
            // 
            this.ucButtonPrimary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.ucButtonPrimary1.FlatAppearance.BorderSize = 0;
            this.ucButtonPrimary1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButtonPrimary1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ucButtonPrimary1.ForeColor = System.Drawing.Color.White;
            this.ucButtonPrimary1.Location = new System.Drawing.Point(0, 0);
            this.ucButtonPrimary1.Name = "ucButtonPrimary1";
            this.ucButtonPrimary1.Size = new System.Drawing.Size(75, 23);
            this.ucButtonPrimary1.TabIndex = 0;
            this.ucButtonPrimary1.Text = "ucButtonPrimary1";
            this.ucButtonPrimary1.UseVisualStyleBackColor = false;
           
            this.ResumeLayout(false);

        }

        #endregion

        private UcButtonPrimary ucButtonPrimary1;
    }
}
