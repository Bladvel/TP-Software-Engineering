namespace Presentacion
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txt_usenarme = new TextBox();
            txt_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            pictureBox1 = new PictureBox();
            lbl_titulo = new Label();
            lbl_titulo2 = new Label();
            llabel_ayuda = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_usenarme
            // 
            txt_usenarme.Location = new Point(434, 98);
            txt_usenarme.MaxLength = 8;
            txt_usenarme.Name = "txt_usenarme";
            txt_usenarme.Size = new Size(130, 23);
            txt_usenarme.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(433, 127);
            txt_password.MaxLength = 8;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(129, 23);
            txt_password.TabIndex = 1;
            txt_password.KeyPress += txt_password_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 106);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(361, 135);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(408, 171);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 4;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(489, 171);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titulo.Location = new Point(417, 18);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(128, 38);
            lbl_titulo.TabIndex = 7;
            lbl_titulo.Text = "SISCAB";
            // 
            // lbl_titulo2
            // 
            lbl_titulo2.AutoSize = true;
            lbl_titulo2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_titulo2.Location = new Point(360, 57);
            lbl_titulo2.Name = "lbl_titulo2";
            lbl_titulo2.Size = new Size(230, 17);
            lbl_titulo2.TabIndex = 8;
            lbl_titulo2.Text = "Sistema de Gestión para Cabañas";
            // 
            // llabel_ayuda
            // 
            llabel_ayuda.AutoSize = true;
            llabel_ayuda.LinkColor = Color.Black;
            llabel_ayuda.LinkVisited = true;
            llabel_ayuda.Location = new Point(421, 209);
            llabel_ayuda.Name = "llabel_ayuda";
            llabel_ayuda.Size = new Size(124, 15);
            llabel_ayuda.TabIndex = 9;
            llabel_ayuda.TabStop = true;
            llabel_ayuda.Text = "Ayuda Primeros Pasos";
            llabel_ayuda.LinkClicked += llabel_ayuda_LinkClicked;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(593, 233);
            Controls.Add(llabel_ayuda);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_titulo2);
            Controls.Add(lbl_titulo);
            Controls.Add(label2);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(label1);
            Controls.Add(txt_password);
            Controls.Add(txt_usenarme);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_usenarme;
        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private PictureBox pictureBox1;
        private Label lbl_titulo;
        private Label lbl_titulo2;
        private LinkLabel llabel_ayuda;
    }
}