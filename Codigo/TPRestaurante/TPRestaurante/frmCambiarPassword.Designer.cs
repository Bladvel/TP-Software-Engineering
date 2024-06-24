namespace TPRestaurante
{
    partial class frmCambiarPassword
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
            this.components = new System.ComponentModel.Container();
            this.txtContraseñaVieja = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña1 = new System.Windows.Forms.TextBox();
            this.lblNueva1 = new System.Windows.Forms.Label();
            this.lblVieja = new System.Windows.Forms.Label();
            this.txtNuevaContraseña2 = new System.Windows.Forms.TextBox();
            this.lblNueva2 = new System.Windows.Forms.Label();
            this.btnIngresarPassword = new TPRestaurante.UcButtonPrimary(this.components);
            this.btnCancelar = new TPRestaurante.UcButtonSecondary(this.components);
            this.btnCambiar = new TPRestaurante.UcButtonPrimary(this.components);
            this.SuspendLayout();
            // 
            // txtContraseñaVieja
            // 
            this.txtContraseñaVieja.Location = new System.Drawing.Point(248, 84);
            this.txtContraseñaVieja.Name = "txtContraseñaVieja";
            this.txtContraseñaVieja.PasswordChar = '*';
            this.txtContraseñaVieja.Size = new System.Drawing.Size(148, 20);
            this.txtContraseñaVieja.TabIndex = 0;
            // 
            // txtNuevaContraseña1
            // 
            this.txtNuevaContraseña1.Location = new System.Drawing.Point(248, 137);
            this.txtNuevaContraseña1.Name = "txtNuevaContraseña1";
            this.txtNuevaContraseña1.PasswordChar = '*';
            this.txtNuevaContraseña1.Size = new System.Drawing.Size(148, 20);
            this.txtNuevaContraseña1.TabIndex = 1;
            // 
            // lblNueva1
            // 
            this.lblNueva1.AutoSize = true;
            this.lblNueva1.Location = new System.Drawing.Point(96, 140);
            this.lblNueva1.Name = "lblNueva1";
            this.lblNueva1.Size = new System.Drawing.Size(131, 13);
            this.lblNueva1.TabIndex = 2;
            this.lblNueva1.Tag = "enterNewPassword";
            this.lblNueva1.Text = "Ingrese nueva contraseña";
            // 
            // lblVieja
            // 
            this.lblVieja.AutoSize = true;
            this.lblVieja.Location = new System.Drawing.Point(97, 87);
            this.lblVieja.Name = "lblVieja";
            this.lblVieja.Size = new System.Drawing.Size(130, 13);
            this.lblVieja.TabIndex = 2;
            this.lblVieja.Tag = "enterCurrentPassword";
            this.lblVieja.Text = "Ingrese contraseña actual";
            // 
            // txtNuevaContraseña2
            // 
            this.txtNuevaContraseña2.Location = new System.Drawing.Point(248, 163);
            this.txtNuevaContraseña2.Name = "txtNuevaContraseña2";
            this.txtNuevaContraseña2.PasswordChar = '*';
            this.txtNuevaContraseña2.Size = new System.Drawing.Size(148, 20);
            this.txtNuevaContraseña2.TabIndex = 1;
            // 
            // lblNueva2
            // 
            this.lblNueva2.AutoSize = true;
            this.lblNueva2.Location = new System.Drawing.Point(72, 166);
            this.lblNueva2.Name = "lblNueva2";
            this.lblNueva2.Size = new System.Drawing.Size(155, 13);
            this.lblNueva2.TabIndex = 2;
            this.lblNueva2.Tag = "reEnterNewPassword";
            this.lblNueva2.Text = "Reingrese la nueva contraseña";
            // 
            // btnIngresarPassword
            // 
            this.btnIngresarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnIngresarPassword.FlatAppearance.BorderSize = 0;
            this.btnIngresarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIngresarPassword.ForeColor = System.Drawing.Color.White;
            this.btnIngresarPassword.Location = new System.Drawing.Point(176, 296);
            this.btnIngresarPassword.Name = "btnIngresarPassword";
            this.btnIngresarPassword.Size = new System.Drawing.Size(132, 39);
            this.btnIngresarPassword.TabIndex = 5;
            this.btnIngresarPassword.Tag = "enter";
            this.btnIngresarPassword.Text = "Ingresar";
            this.btnIngresarPassword.UseVisualStyleBackColor = false;
            this.btnIngresarPassword.Click += new System.EventHandler(this.btnIngresarPassword_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(314, 296);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 39);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Tag = "cancel";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCambiar.ForeColor = System.Drawing.Color.White;
            this.btnCambiar.Location = new System.Drawing.Point(151, 296);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(157, 39);
            this.btnCambiar.TabIndex = 3;
            this.btnCambiar.Tag = "changePassword";
            this.btnCambiar.Text = "Cambiar contraseña";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // frmCambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 347);
            this.Controls.Add(this.btnIngresarPassword);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblVieja);
            this.Controls.Add(this.lblNueva2);
            this.Controls.Add(this.lblNueva1);
            this.Controls.Add(this.txtNuevaContraseña2);
            this.Controls.Add(this.txtNuevaContraseña1);
            this.Controls.Add(this.txtContraseñaVieja);
            this.Name = "frmCambiarPassword";
            this.Text = "frmCambiarPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCambiarPassword_FormClosing);
            this.Load += new System.EventHandler(this.frmCambiarPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseñaVieja;
        private System.Windows.Forms.TextBox txtNuevaContraseña1;
        private System.Windows.Forms.Label lblNueva1;
        private System.Windows.Forms.Label lblVieja;
        private System.Windows.Forms.TextBox txtNuevaContraseña2;
        private System.Windows.Forms.Label lblNueva2;
        private UcButtonPrimary btnCambiar;
        private UcButtonSecondary btnCancelar;
        private UcButtonPrimary btnIngresarPassword;
    }
}