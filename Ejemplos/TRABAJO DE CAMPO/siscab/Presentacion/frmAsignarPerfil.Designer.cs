namespace Presentacion
{
    partial class frmAsignarPerfil
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
            this.gb_usuarios = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_agregarf = new System.Windows.Forms.Button();
            this.cboFamilias = new System.Windows.Forms.ComboBox();
            this.lbl_agregarf = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cboPatentes = new System.Windows.Forms.ComboBox();
            this.lbl_agregarp = new System.Windows.Forms.Label();
            this.btn_configuar = new System.Windows.Forms.Button();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.lbl_todos = new System.Windows.Forms.Label();
            this.gb_usuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_usuarios
            // 
            this.gb_usuarios.Controls.Add(this.btn_guardar);
            this.gb_usuarios.Controls.Add(this.treeView1);
            this.gb_usuarios.Controls.Add(this.btn_agregarf);
            this.gb_usuarios.Controls.Add(this.cboFamilias);
            this.gb_usuarios.Controls.Add(this.lbl_agregarf);
            this.gb_usuarios.Controls.Add(this.btn_agregar);
            this.gb_usuarios.Controls.Add(this.cboPatentes);
            this.gb_usuarios.Controls.Add(this.lbl_agregarp);
            this.gb_usuarios.Controls.Add(this.btn_configuar);
            this.gb_usuarios.Controls.Add(this.cboUsuarios);
            this.gb_usuarios.Controls.Add(this.lbl_todos);
            this.gb_usuarios.Location = new System.Drawing.Point(12, 12);
            this.gb_usuarios.Name = "gb_usuarios";
            this.gb_usuarios.Size = new System.Drawing.Size(554, 366);
            this.gb_usuarios.TabIndex = 0;
            this.gb_usuarios.TabStop = false;
            this.gb_usuarios.Text = "Usuarios";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(298, 311);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(115, 33);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar cambios";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(298, 50);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(237, 255);
            this.treeView1.TabIndex = 9;
            // 
            // btn_agregarf
            // 
            this.btn_agregarf.Location = new System.Drawing.Point(29, 262);
            this.btn_agregarf.Name = "btn_agregarf";
            this.btn_agregarf.Size = new System.Drawing.Size(80, 23);
            this.btn_agregarf.TabIndex = 8;
            this.btn_agregarf.Text = "Agregar >>";
            this.btn_agregarf.UseVisualStyleBackColor = true;
            this.btn_agregarf.Click += new System.EventHandler(this.btn_agregarf_Click);
            // 
            // cboFamilias
            // 
            this.cboFamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFamilias.FormattingEnabled = true;
            this.cboFamilias.Location = new System.Drawing.Point(29, 233);
            this.cboFamilias.Name = "cboFamilias";
            this.cboFamilias.Size = new System.Drawing.Size(214, 23);
            this.cboFamilias.TabIndex = 7;
            // 
            // lbl_agregarf
            // 
            this.lbl_agregarf.AutoSize = true;
            this.lbl_agregarf.Location = new System.Drawing.Point(27, 215);
            this.lbl_agregarf.Name = "lbl_agregarf";
            this.lbl_agregarf.Size = new System.Drawing.Size(93, 15);
            this.lbl_agregarf.TabIndex = 6;
            this.lbl_agregarf.Text = "Agregar familias";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(27, 174);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(80, 23);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar >>";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // cboPatentes
            // 
            this.cboPatentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPatentes.FormattingEnabled = true;
            this.cboPatentes.Location = new System.Drawing.Point(27, 145);
            this.cboPatentes.Name = "cboPatentes";
            this.cboPatentes.Size = new System.Drawing.Size(214, 23);
            this.cboPatentes.TabIndex = 4;
            // 
            // lbl_agregarp
            // 
            this.lbl_agregarp.AutoSize = true;
            this.lbl_agregarp.Location = new System.Drawing.Point(29, 127);
            this.lbl_agregarp.Name = "lbl_agregarp";
            this.lbl_agregarp.Size = new System.Drawing.Size(97, 15);
            this.lbl_agregarp.TabIndex = 3;
            this.lbl_agregarp.Text = "Agregar patentes";
            // 
            // btn_configuar
            // 
            this.btn_configuar.Location = new System.Drawing.Point(27, 79);
            this.btn_configuar.Name = "btn_configuar";
            this.btn_configuar.Size = new System.Drawing.Size(75, 23);
            this.btn_configuar.TabIndex = 2;
            this.btn_configuar.Text = "Configurar";
            this.btn_configuar.UseVisualStyleBackColor = true;
            this.btn_configuar.Click += new System.EventHandler(this.btn_configuar_Click);
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(27, 50);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(214, 23);
            this.cboUsuarios.TabIndex = 1;
            // 
            // lbl_todos
            // 
            this.lbl_todos.AutoSize = true;
            this.lbl_todos.Location = new System.Drawing.Point(22, 26);
            this.lbl_todos.Name = "lbl_todos";
            this.lbl_todos.Size = new System.Drawing.Size(106, 15);
            this.lbl_todos.TabIndex = 0;
            this.lbl_todos.Text = "Todos los usuarios:";
            // 
            // frmAsignarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 390);
            this.Controls.Add(this.gb_usuarios);
            this.MaximumSize = new System.Drawing.Size(605, 429);
            this.MinimumSize = new System.Drawing.Size(605, 429);
            this.Name = "frmAsignarPerfil";
            this.Text = "frmAsignarPerfil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAsignarPerfil_FormClosing);
            this.gb_usuarios.ResumeLayout(false);
            this.gb_usuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_usuarios;
        private Button btn_configuar;
        private ComboBox cboUsuarios;
        private Label lbl_todos;
        private Button btn_guardar;
        private TreeView treeView1;
        private Button btn_agregarf;
        private ComboBox cboFamilias;
        private Label lbl_agregarf;
        private Button btn_agregar;
        private ComboBox cboPatentes;
        private Label lbl_agregarp;
    }
}