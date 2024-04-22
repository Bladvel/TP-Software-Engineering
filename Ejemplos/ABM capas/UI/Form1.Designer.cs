namespace UI
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
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.lstEstado = new System.Windows.Forms.ListBox();
            this.btnCargarUsuario = new System.Windows.Forms.Button();
            this.btnCargarEstado = new System.Windows.Forms.Button();
            this.btnMostrarUsuario = new System.Windows.Forms.Button();
            this.btnMostrarEstado = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificarEstado = new System.Windows.Forms.Button();
            this.btnEliminarEstado = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(60, 166);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(318, 225);
            this.lstUsuarios.TabIndex = 0;
            // 
            // lstEstado
            // 
            this.lstEstado.FormattingEnabled = true;
            this.lstEstado.Location = new System.Drawing.Point(565, 166);
            this.lstEstado.Name = "lstEstado";
            this.lstEstado.Size = new System.Drawing.Size(186, 225);
            this.lstEstado.TabIndex = 1;
            // 
            // btnCargarUsuario
            // 
            this.btnCargarUsuario.Location = new System.Drawing.Point(404, 166);
            this.btnCargarUsuario.Name = "btnCargarUsuario";
            this.btnCargarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCargarUsuario.TabIndex = 2;
            this.btnCargarUsuario.Text = "Cargar";
            this.btnCargarUsuario.UseVisualStyleBackColor = true;
            this.btnCargarUsuario.Click += new System.EventHandler(this.btnCargarUsuario_Click);
            // 
            // btnCargarEstado
            // 
            this.btnCargarEstado.Location = new System.Drawing.Point(785, 166);
            this.btnCargarEstado.Name = "btnCargarEstado";
            this.btnCargarEstado.Size = new System.Drawing.Size(75, 23);
            this.btnCargarEstado.TabIndex = 2;
            this.btnCargarEstado.Text = "Cargar";
            this.btnCargarEstado.UseVisualStyleBackColor = true;
            this.btnCargarEstado.Click += new System.EventHandler(this.btnCargarEstado_Click);
            // 
            // btnMostrarUsuario
            // 
            this.btnMostrarUsuario.Location = new System.Drawing.Point(404, 214);
            this.btnMostrarUsuario.Name = "btnMostrarUsuario";
            this.btnMostrarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarUsuario.TabIndex = 2;
            this.btnMostrarUsuario.Text = "Mostrar";
            this.btnMostrarUsuario.UseVisualStyleBackColor = true;
            this.btnMostrarUsuario.Click += new System.EventHandler(this.btnMostrarUsuario_Click);
            // 
            // btnMostrarEstado
            // 
            this.btnMostrarEstado.Location = new System.Drawing.Point(785, 300);
            this.btnMostrarEstado.Name = "btnMostrarEstado";
            this.btnMostrarEstado.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarEstado.TabIndex = 2;
            this.btnMostrarEstado.Text = "Mostrar";
            this.btnMostrarEstado.UseVisualStyleBackColor = true;
            this.btnMostrarEstado.Click += new System.EventHandler(this.btnMostrarEstado_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(60, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(60, 74);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(180, 20);
            this.txtDNI.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DNI";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(613, 35);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(180, 20);
            this.txtEstado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado";
            // 
            // btnModificarEstado
            // 
            this.btnModificarEstado.Location = new System.Drawing.Point(785, 214);
            this.btnModificarEstado.Name = "btnModificarEstado";
            this.btnModificarEstado.Size = new System.Drawing.Size(75, 23);
            this.btnModificarEstado.TabIndex = 6;
            this.btnModificarEstado.Text = "Modificar";
            this.btnModificarEstado.UseVisualStyleBackColor = true;
            this.btnModificarEstado.Click += new System.EventHandler(this.btnModificarEstado_Click);
            // 
            // btnEliminarEstado
            // 
            this.btnEliminarEstado.Location = new System.Drawing.Point(785, 255);
            this.btnEliminarEstado.Name = "btnEliminarEstado";
            this.btnEliminarEstado.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEstado.TabIndex = 7;
            this.btnEliminarEstado.Text = "Eliminar";
            this.btnEliminarEstado.UseVisualStyleBackColor = true;
            this.btnEliminarEstado.Click += new System.EventHandler(this.btnEliminarEstado_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 598);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnEliminarEstado);
            this.Controls.Add(this.btnModificarEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnMostrarEstado);
            this.Controls.Add(this.btnMostrarUsuario);
            this.Controls.Add(this.btnCargarEstado);
            this.Controls.Add(this.btnCargarUsuario);
            this.Controls.Add(this.lstEstado);
            this.Controls.Add(this.lstUsuarios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.ListBox lstEstado;
        private System.Windows.Forms.Button btnCargarUsuario;
        private System.Windows.Forms.Button btnCargarEstado;
        private System.Windows.Forms.Button btnMostrarUsuario;
        private System.Windows.Forms.Button btnMostrarEstado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificarEstado;
        private System.Windows.Forms.Button btnEliminarEstado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}

