namespace Presentacion
{
    partial class frmSerializacionFactura
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
            btn_deserializacionRollBack = new Button();
            btn_salir = new Button();
            txt_ruta = new TextBox();
            lbl_ruta = new Label();
            txt_objeto = new TextBox();
            SuspendLayout();
            // 
            // btn_deserializacionRollBack
            // 
            btn_deserializacionRollBack.BackColor = SystemColors.ActiveCaptionText;
            btn_deserializacionRollBack.ForeColor = SystemColors.ButtonHighlight;
            btn_deserializacionRollBack.Location = new Point(13, 27);
            btn_deserializacionRollBack.Name = "btn_deserializacionRollBack";
            btn_deserializacionRollBack.Size = new Size(154, 35);
            btn_deserializacionRollBack.TabIndex = 1;
            btn_deserializacionRollBack.Text = "Deserialización - RollBack";
            btn_deserializacionRollBack.UseVisualStyleBackColor = false;
            btn_deserializacionRollBack.Click += btn_deserializacionRollBack_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(363, 227);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(88, 23);
            btn_salir.TabIndex = 2;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // txt_ruta
            // 
            txt_ruta.Location = new Point(13, 186);
            txt_ruta.Name = "txt_ruta";
            txt_ruta.ReadOnly = true;
            txt_ruta.Size = new Size(438, 23);
            txt_ruta.TabIndex = 3;
            // 
            // lbl_ruta
            // 
            lbl_ruta.AutoSize = true;
            lbl_ruta.Location = new Point(13, 168);
            lbl_ruta.Name = "lbl_ruta";
            lbl_ruta.Size = new Size(160, 15);
            lbl_ruta.TabIndex = 4;
            lbl_ruta.Text = "Ruta de la serialización JSON:";
            // 
            // txt_objeto
            // 
            txt_objeto.Location = new Point(179, 27);
            txt_objeto.Multiline = true;
            txt_objeto.Name = "txt_objeto";
            txt_objeto.Size = new Size(272, 134);
            txt_objeto.TabIndex = 5;
            // 
            // frmSerializacionFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 263);
            Controls.Add(txt_objeto);
            Controls.Add(lbl_ruta);
            Controls.Add(txt_ruta);
            Controls.Add(btn_salir);
            Controls.Add(btn_deserializacionRollBack);
            Name = "frmSerializacionFactura";
            Text = "frmSerializacionFactura";
            FormClosing += frmSerializacionFactura_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_deserializacionRollBack;
        private Button btn_salir;
        private TextBox txt_ruta;
        private Label lbl_ruta;
        private TextBox txt_objeto;
    }
}