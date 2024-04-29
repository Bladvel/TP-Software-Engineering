namespace Presentacion
{
    partial class frmGestionUsuario
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.dgw_usuarios = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_desbloquear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_listados = new System.Windows.Forms.Label();
            this.btn_listar_todos = new System.Windows.Forms.Button();
            this.btn_listar_activos = new System.Windows.Forms.Button();
            this.btn_listar_borrados = new System.Windows.Forms.Button();
            this.btn_listar_bloqueados = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.cb_rol = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_usuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Location = new System.Drawing.Point(83, 118);
            this.txt_username.MaxLength = 8;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 23);
            this.txt_username.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Enabled = false;
            this.txt_password.Location = new System.Drawing.Point(273, 118);
            this.txt_password.MaxLength = 8;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(100, 23);
            this.txt_password.TabIndex = 4;
            // 
            // dgw_usuarios
            // 
            this.dgw_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_usuarios.Location = new System.Drawing.Point(23, 92);
            this.dgw_usuarios.Name = "dgw_usuarios";
            this.dgw_usuarios.RowTemplate.Height = 25;
            this.dgw_usuarios.Size = new System.Drawing.Size(594, 244);
            this.dgw_usuarios.TabIndex = 14;
            this.dgw_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_usuarios_CellClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(102, 22);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(72, 23);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(298, 22);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(72, 23);
            this.btn_modificar.TabIndex = 7;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Enabled = false;
            this.btn_borrar.Location = new System.Drawing.Point(376, 22);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(72, 23);
            this.btn_borrar.TabIndex = 8;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Enabled = false;
            this.txt_apellido.Location = new System.Drawing.Point(273, 60);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 23);
            this.txt_apellido.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(83, 60);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_dni
            // 
            this.txt_dni.Enabled = false;
            this.txt_dni.Location = new System.Drawing.Point(83, 89);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(100, 23);
            this.txt_dni.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "DNI";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(21, 22);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(72, 23);
            this.btn_nuevo.TabIndex = 5;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(524, 546);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(93, 23);
            this.btn_salir.TabIndex = 15;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(377, 191);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(71, 23);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_desbloquear
            // 
            this.btn_desbloquear.Enabled = false;
            this.btn_desbloquear.Location = new System.Drawing.Point(287, 191);
            this.btn_desbloquear.Name = "btn_desbloquear";
            this.btn_desbloquear.Size = new System.Drawing.Size(83, 23);
            this.btn_desbloquear.TabIndex = 17;
            this.btn_desbloquear.Text = "Desbloquear";
            this.btn_desbloquear.UseVisualStyleBackColor = true;
            this.btn_desbloquear.Click += new System.EventHandler(this.btn_desbloquear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_listados);
            this.groupBox1.Controls.Add(this.btn_listar_todos);
            this.groupBox1.Controls.Add(this.btn_listar_activos);
            this.groupBox1.Controls.Add(this.btn_listar_borrados);
            this.groupBox1.Controls.Add(this.btn_listar_bloqueados);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 74);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar usuarios";
            // 
            // lbl_listados
            // 
            this.lbl_listados.AutoSize = true;
            this.lbl_listados.Location = new System.Drawing.Point(10, 54);
            this.lbl_listados.Name = "lbl_listados";
            this.lbl_listados.Size = new System.Drawing.Size(120, 15);
            this.lbl_listados.TabIndex = 22;
            this.lbl_listados.Text = "Listado seleccionado:";
            // 
            // btn_listar_todos
            // 
            this.btn_listar_todos.Location = new System.Drawing.Point(6, 22);
            this.btn_listar_todos.Name = "btn_listar_todos";
            this.btn_listar_todos.Size = new System.Drawing.Size(96, 23);
            this.btn_listar_todos.TabIndex = 21;
            this.btn_listar_todos.Text = "Total";
            this.btn_listar_todos.UseVisualStyleBackColor = true;
            this.btn_listar_todos.Click += new System.EventHandler(this.btn_listar_todos_Click);
            // 
            // btn_listar_activos
            // 
            this.btn_listar_activos.Location = new System.Drawing.Point(118, 22);
            this.btn_listar_activos.Name = "btn_listar_activos";
            this.btn_listar_activos.Size = new System.Drawing.Size(96, 23);
            this.btn_listar_activos.TabIndex = 20;
            this.btn_listar_activos.Text = "Activos";
            this.btn_listar_activos.UseVisualStyleBackColor = true;
            this.btn_listar_activos.Click += new System.EventHandler(this.btn_listar_activos_Click);
            // 
            // btn_listar_borrados
            // 
            this.btn_listar_borrados.Location = new System.Drawing.Point(353, 22);
            this.btn_listar_borrados.Name = "btn_listar_borrados";
            this.btn_listar_borrados.Size = new System.Drawing.Size(96, 23);
            this.btn_listar_borrados.TabIndex = 19;
            this.btn_listar_borrados.Text = "Borrados";
            this.btn_listar_borrados.UseVisualStyleBackColor = true;
            this.btn_listar_borrados.Click += new System.EventHandler(this.btn_listar_borrados_Click);
            // 
            // btn_listar_bloqueados
            // 
            this.btn_listar_bloqueados.Location = new System.Drawing.Point(234, 22);
            this.btn_listar_bloqueados.Name = "btn_listar_bloqueados";
            this.btn_listar_bloqueados.Size = new System.Drawing.Size(96, 23);
            this.btn_listar_bloqueados.TabIndex = 18;
            this.btn_listar_bloqueados.Text = "Bloqueados";
            this.btn_listar_bloqueados.UseVisualStyleBackColor = true;
            this.btn_listar_bloqueados.Click += new System.EventHandler(this.btn_listar_bloqueados_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_rol);
            this.groupBox2.Controls.Add(this.cb_rol);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Controls.Add(this.btn_cancelar);
            this.groupBox2.Controls.Add(this.btn_desbloquear);
            this.groupBox2.Controls.Add(this.txt_apellido);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_dni);
            this.groupBox2.Controls.Add(this.btn_borrar);
            this.groupBox2.Controls.Add(this.txt_username);
            this.groupBox2.Controls.Add(this.btn_modificar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_password);
            this.groupBox2.Location = new System.Drawing.Point(29, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 231);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ABM y Desbloqueo de Usuario";
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Location = new System.Drawing.Point(21, 160);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(24, 15);
            this.lbl_rol.TabIndex = 19;
            this.lbl_rol.Text = "Rol";
            // 
            // cb_rol
            // 
            this.cb_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rol.Enabled = false;
            this.cb_rol.FormattingEnabled = true;
            this.cb_rol.Location = new System.Drawing.Point(85, 154);
            this.cb_rol.Name = "cb_rol";
            this.cb_rol.Size = new System.Drawing.Size(98, 23);
            this.cb_rol.TabIndex = 18;
            // 
            // frmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dgw_usuarios);
            this.MaximumSize = new System.Drawing.Size(645, 637);
            this.MinimumSize = new System.Drawing.Size(645, 637);
            this.Name = "frmGestionUsuario";
            this.Text = "frmGestionUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGestionUsuario_FormClosing);
            this.Load += new System.EventHandler(this.frmCrearModificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_usuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txt_username;
        private Label label1;
        private Label label2;
        private TextBox txt_password;
        private DataGridView dgw_usuarios;
        private Button btn_agregar;
        private Button btn_modificar;
        private Button btn_borrar;
        private Label label3;
        private Label label4;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private TextBox txt_dni;
        private Label label5;
        private Button btn_nuevo;
        private Button btn_salir;
        private Button btn_cancelar;
        private Button btn_desbloquear;
        private GroupBox groupBox1;
        private Button btn_listar_bloqueados;
        private Button btn_listar_todos;
        private Button btn_listar_activos;
        private Button btn_listar_borrados;
        private Label lbl_listados;
        private GroupBox groupBox2;
        private Label lbl_rol;
        private ComboBox cb_rol;
    }
}