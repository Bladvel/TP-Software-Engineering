namespace Presentacion
{
    partial class frmCambiarClave
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
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_nueva_contraseña = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_nueva_contraseña = new System.Windows.Forms.TextBox();
            this.txt_reingrese_nueva_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_conf_nueva_contraseña = new System.Windows.Forms.Label();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(21, 9);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(47, 15);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Location = new System.Drawing.Point(21, 27);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(127, 23);
            this.txt_usuario.TabIndex = 1;
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(21, 53);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(100, 15);
            this.lbl_contraseña.TabIndex = 2;
            this.lbl_contraseña.Text = "Contaseña Actual";
            // 
            // lbl_nueva_contraseña
            // 
            this.lbl_nueva_contraseña.AutoSize = true;
            this.lbl_nueva_contraseña.Location = new System.Drawing.Point(21, 100);
            this.lbl_nueva_contraseña.Name = "lbl_nueva_contraseña";
            this.lbl_nueva_contraseña.Size = new System.Drawing.Size(104, 15);
            this.lbl_nueva_contraseña.TabIndex = 3;
            this.lbl_nueva_contraseña.Text = "Nueva Contraseña";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(21, 71);
            this.txt_contraseña.MaxLength = 8;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(127, 23);
            this.txt_contraseña.TabIndex = 4;
            // 
            // txt_nueva_contraseña
            // 
            this.txt_nueva_contraseña.Location = new System.Drawing.Point(21, 118);
            this.txt_nueva_contraseña.MaxLength = 8;
            this.txt_nueva_contraseña.Name = "txt_nueva_contraseña";
            this.txt_nueva_contraseña.PasswordChar = '*';
            this.txt_nueva_contraseña.Size = new System.Drawing.Size(127, 23);
            this.txt_nueva_contraseña.TabIndex = 5;
            // 
            // txt_reingrese_nueva_contraseña
            // 
            this.txt_reingrese_nueva_contraseña.Location = new System.Drawing.Point(25, 162);
            this.txt_reingrese_nueva_contraseña.MaxLength = 8;
            this.txt_reingrese_nueva_contraseña.Name = "txt_reingrese_nueva_contraseña";
            this.txt_reingrese_nueva_contraseña.PasswordChar = '*';
            this.txt_reingrese_nueva_contraseña.Size = new System.Drawing.Size(123, 23);
            this.txt_reingrese_nueva_contraseña.TabIndex = 6;
            this.txt_reingrese_nueva_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_reingrese_nueva_contraseña_KeyPress);
            // 
            // lbl_conf_nueva_contraseña
            // 
            this.lbl_conf_nueva_contraseña.AutoSize = true;
            this.lbl_conf_nueva_contraseña.Location = new System.Drawing.Point(21, 144);
            this.lbl_conf_nueva_contraseña.Name = "lbl_conf_nueva_contraseña";
            this.lbl_conf_nueva_contraseña.Size = new System.Drawing.Size(170, 15);
            this.lbl_conf_nueva_contraseña.TabIndex = 7;
            this.lbl_conf_nueva_contraseña.Text = "Reingrese la Nueva Contraseña";
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(230, 129);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 8;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.Location = new System.Drawing.Point(230, 100);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(75, 23);
            this.btn_cambiar.TabIndex = 9;
            this.btn_cambiar.Text = "Aceptar";
            this.btn_cambiar.UseVisualStyleBackColor = true;
            this.btn_cambiar.Click += new System.EventHandler(this.btn_cambiar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(230, 161);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frmCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 202);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_cambiar);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.lbl_conf_nueva_contraseña);
            this.Controls.Add(this.txt_reingrese_nueva_contraseña);
            this.Controls.Add(this.txt_nueva_contraseña);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.lbl_nueva_contraseña);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.MaximumSize = new System.Drawing.Size(351, 241);
            this.MinimumSize = new System.Drawing.Size(351, 241);
            this.Name = "frmCambiarClave";
            this.Text = "frmCambiarClave";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCambiarClave_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_usuario;
        private TextBox txt_usuario;
        private Label lbl_contraseña;
        private Label lbl_nueva_contraseña;
        private TextBox txt_contraseña;
        private TextBox txt_nueva_contraseña;
        private TextBox txt_reingrese_nueva_contraseña;
        private Label lbl_conf_nueva_contraseña;
        private Button btn_borrar;
        private Button btn_cambiar;
        private Button btn_cancelar;
    }
}