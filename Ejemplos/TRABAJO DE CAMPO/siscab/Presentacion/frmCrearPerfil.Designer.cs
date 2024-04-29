namespace Presentacion
{
    partial class frmCrearPerfil
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
            this.gb_patente = new System.Windows.Forms.GroupBox();
            this.btn_guardarP = new System.Windows.Forms.Button();
            this.gb_nueva = new System.Windows.Forms.GroupBox();
            this.txt_NombrePatente = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.cboPermisos = new System.Windows.Forms.ComboBox();
            this.lbl_permiso = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cboPatentes = new System.Windows.Forms.ComboBox();
            this.lbl_todasP = new System.Windows.Forms.Label();
            this.gb_familia = new System.Windows.Forms.GroupBox();
            this.gb_nuevaF = new System.Windows.Forms.GroupBox();
            this.btn_guardarF = new System.Windows.Forms.Button();
            this.txt_NombreFamilia = new System.Windows.Forms.TextBox();
            this.lbl_nombreF = new System.Windows.Forms.Label();
            this.btn_AgregarFamilia = new System.Windows.Forms.Button();
            this.btn_configurar = new System.Windows.Forms.Button();
            this.cboFamilias = new System.Windows.Forms.ComboBox();
            this.lbl_todasF = new System.Windows.Forms.Label();
            this.gb_configurar = new System.Windows.Forms.GroupBox();
            this.btn_guardarFamiliaGral = new System.Windows.Forms.Button();
            this.treeConfigurarFamilia = new System.Windows.Forms.TreeView();
            this.gb_patente.SuspendLayout();
            this.gb_nueva.SuspendLayout();
            this.gb_familia.SuspendLayout();
            this.gb_nuevaF.SuspendLayout();
            this.gb_configurar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_patente
            // 
            this.gb_patente.Controls.Add(this.btn_guardarP);
            this.gb_patente.Controls.Add(this.gb_nueva);
            this.gb_patente.Controls.Add(this.btn_agregar);
            this.gb_patente.Controls.Add(this.cboPatentes);
            this.gb_patente.Controls.Add(this.lbl_todasP);
            this.gb_patente.Location = new System.Drawing.Point(12, 12);
            this.gb_patente.Name = "gb_patente";
            this.gb_patente.Size = new System.Drawing.Size(237, 298);
            this.gb_patente.TabIndex = 0;
            this.gb_patente.TabStop = false;
            this.gb_patente.Text = "Patente";
            // 
            // btn_guardarP
            // 
            this.btn_guardarP.Location = new System.Drawing.Point(42, 258);
            this.btn_guardarP.Name = "btn_guardarP";
            this.btn_guardarP.Size = new System.Drawing.Size(75, 23);
            this.btn_guardarP.TabIndex = 4;
            this.btn_guardarP.Text = "Guardar";
            this.btn_guardarP.UseVisualStyleBackColor = true;
            this.btn_guardarP.Click += new System.EventHandler(this.btn_guardarP_Click);
            // 
            // gb_nueva
            // 
            this.gb_nueva.Controls.Add(this.txt_NombrePatente);
            this.gb_nueva.Controls.Add(this.lbl_nombre);
            this.gb_nueva.Controls.Add(this.cboPermisos);
            this.gb_nueva.Controls.Add(this.lbl_permiso);
            this.gb_nueva.Location = new System.Drawing.Point(22, 122);
            this.gb_nueva.Name = "gb_nueva";
            this.gb_nueva.Size = new System.Drawing.Size(203, 170);
            this.gb_nueva.TabIndex = 3;
            this.gb_nueva.TabStop = false;
            this.gb_nueva.Text = "Nueva patente";
            // 
            // txt_NombrePatente
            // 
            this.txt_NombrePatente.Location = new System.Drawing.Point(21, 102);
            this.txt_NombrePatente.Name = "txt_NombrePatente";
            this.txt_NombrePatente.Size = new System.Drawing.Size(142, 23);
            this.txt_NombrePatente.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(17, 80);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // cboPermisos
            // 
            this.cboPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPermisos.FormattingEnabled = true;
            this.cboPermisos.Location = new System.Drawing.Point(16, 47);
            this.cboPermisos.Name = "cboPermisos";
            this.cboPermisos.Size = new System.Drawing.Size(147, 23);
            this.cboPermisos.TabIndex = 1;
            // 
            // lbl_permiso
            // 
            this.lbl_permiso.AutoSize = true;
            this.lbl_permiso.Location = new System.Drawing.Point(9, 24);
            this.lbl_permiso.Name = "lbl_permiso";
            this.lbl_permiso.Size = new System.Drawing.Size(50, 15);
            this.lbl_permiso.TabIndex = 0;
            this.lbl_permiso.Text = "Permiso";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(15, 75);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 23);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar >>";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // cboPatentes
            // 
            this.cboPatentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPatentes.FormattingEnabled = true;
            this.cboPatentes.Location = new System.Drawing.Point(14, 43);
            this.cboPatentes.Name = "cboPatentes";
            this.cboPatentes.Size = new System.Drawing.Size(171, 23);
            this.cboPatentes.TabIndex = 1;
            // 
            // lbl_todasP
            // 
            this.lbl_todasP.AutoSize = true;
            this.lbl_todasP.Location = new System.Drawing.Point(13, 22);
            this.lbl_todasP.Name = "lbl_todasP";
            this.lbl_todasP.Size = new System.Drawing.Size(102, 15);
            this.lbl_todasP.TabIndex = 0;
            this.lbl_todasP.Text = "Todas las patentes";
            // 
            // gb_familia
            // 
            this.gb_familia.Controls.Add(this.gb_nuevaF);
            this.gb_familia.Controls.Add(this.btn_AgregarFamilia);
            this.gb_familia.Controls.Add(this.btn_configurar);
            this.gb_familia.Controls.Add(this.cboFamilias);
            this.gb_familia.Controls.Add(this.lbl_todasF);
            this.gb_familia.Location = new System.Drawing.Point(264, 12);
            this.gb_familia.Name = "gb_familia";
            this.gb_familia.Size = new System.Drawing.Size(249, 298);
            this.gb_familia.TabIndex = 1;
            this.gb_familia.TabStop = false;
            this.gb_familia.Text = "Familia";
            // 
            // gb_nuevaF
            // 
            this.gb_nuevaF.Controls.Add(this.btn_guardarF);
            this.gb_nuevaF.Controls.Add(this.txt_NombreFamilia);
            this.gb_nuevaF.Controls.Add(this.lbl_nombreF);
            this.gb_nuevaF.Location = new System.Drawing.Point(21, 122);
            this.gb_nuevaF.Name = "gb_nuevaF";
            this.gb_nuevaF.Size = new System.Drawing.Size(222, 110);
            this.gb_nuevaF.TabIndex = 6;
            this.gb_nuevaF.TabStop = false;
            this.gb_nuevaF.Text = "Nueva";
            // 
            // btn_guardarF
            // 
            this.btn_guardarF.Location = new System.Drawing.Point(15, 83);
            this.btn_guardarF.Name = "btn_guardarF";
            this.btn_guardarF.Size = new System.Drawing.Size(71, 23);
            this.btn_guardarF.TabIndex = 2;
            this.btn_guardarF.Text = "Guardar";
            this.btn_guardarF.UseVisualStyleBackColor = true;
            this.btn_guardarF.Click += new System.EventHandler(this.btn_guardarF_Click);
            // 
            // txt_NombreFamilia
            // 
            this.txt_NombreFamilia.Location = new System.Drawing.Point(14, 49);
            this.txt_NombreFamilia.Name = "txt_NombreFamilia";
            this.txt_NombreFamilia.Size = new System.Drawing.Size(190, 23);
            this.txt_NombreFamilia.TabIndex = 1;
            // 
            // lbl_nombreF
            // 
            this.lbl_nombreF.AutoSize = true;
            this.lbl_nombreF.Location = new System.Drawing.Point(10, 25);
            this.lbl_nombreF.Name = "lbl_nombreF";
            this.lbl_nombreF.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombreF.TabIndex = 0;
            this.lbl_nombreF.Text = "Nombre";
            // 
            // btn_AgregarFamilia
            // 
            this.btn_AgregarFamilia.Location = new System.Drawing.Point(100, 72);
            this.btn_AgregarFamilia.Name = "btn_AgregarFamilia";
            this.btn_AgregarFamilia.Size = new System.Drawing.Size(77, 23);
            this.btn_AgregarFamilia.TabIndex = 5;
            this.btn_AgregarFamilia.Text = "Agregar >>";
            this.btn_AgregarFamilia.UseVisualStyleBackColor = true;
            this.btn_AgregarFamilia.Click += new System.EventHandler(this.btn_AgregarFamilia_Click);
            // 
            // btn_configurar
            // 
            this.btn_configurar.Location = new System.Drawing.Point(9, 72);
            this.btn_configurar.Name = "btn_configurar";
            this.btn_configurar.Size = new System.Drawing.Size(81, 23);
            this.btn_configurar.TabIndex = 3;
            this.btn_configurar.Text = "Configurar";
            this.btn_configurar.UseVisualStyleBackColor = true;
            this.btn_configurar.Click += new System.EventHandler(this.btn_configurar_Click);
            // 
            // cboFamilias
            // 
            this.cboFamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFamilias.FormattingEnabled = true;
            this.cboFamilias.Location = new System.Drawing.Point(6, 43);
            this.cboFamilias.Name = "cboFamilias";
            this.cboFamilias.Size = new System.Drawing.Size(171, 23);
            this.cboFamilias.TabIndex = 2;
            // 
            // lbl_todasF
            // 
            this.lbl_todasF.AutoSize = true;
            this.lbl_todasF.Location = new System.Drawing.Point(9, 20);
            this.lbl_todasF.Name = "lbl_todasF";
            this.lbl_todasF.Size = new System.Drawing.Size(98, 15);
            this.lbl_todasF.TabIndex = 0;
            this.lbl_todasF.Text = "Todas las familias";
            // 
            // gb_configurar
            // 
            this.gb_configurar.Controls.Add(this.btn_guardarFamiliaGral);
            this.gb_configurar.Controls.Add(this.treeConfigurarFamilia);
            this.gb_configurar.Location = new System.Drawing.Point(528, 12);
            this.gb_configurar.Name = "gb_configurar";
            this.gb_configurar.Size = new System.Drawing.Size(260, 298);
            this.gb_configurar.TabIndex = 2;
            this.gb_configurar.TabStop = false;
            this.gb_configurar.Text = "Configurar Familia";
            // 
            // btn_guardarFamiliaGral
            // 
            this.btn_guardarFamiliaGral.Location = new System.Drawing.Point(143, 266);
            this.btn_guardarFamiliaGral.Name = "btn_guardarFamiliaGral";
            this.btn_guardarFamiliaGral.Size = new System.Drawing.Size(111, 23);
            this.btn_guardarFamiliaGral.TabIndex = 1;
            this.btn_guardarFamiliaGral.Text = "Guardar";
            this.btn_guardarFamiliaGral.UseVisualStyleBackColor = true;
            this.btn_guardarFamiliaGral.Click += new System.EventHandler(this.btn_guardarFamiliaGral_Click);
            // 
            // treeConfigurarFamilia
            // 
            this.treeConfigurarFamilia.Location = new System.Drawing.Point(13, 27);
            this.treeConfigurarFamilia.Name = "treeConfigurarFamilia";
            this.treeConfigurarFamilia.Size = new System.Drawing.Size(241, 225);
            this.treeConfigurarFamilia.TabIndex = 0;
            // 
            // frmCrearPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.gb_configurar);
            this.Controls.Add(this.gb_familia);
            this.Controls.Add(this.gb_patente);
            this.MaximumSize = new System.Drawing.Size(816, 361);
            this.MinimumSize = new System.Drawing.Size(816, 361);
            this.Name = "frmCrearPerfil";
            this.Text = "frmCrearPerfil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCrearModificarPerfil_FormClosing);
            this.Load += new System.EventHandler(this.frmCrearModificarPerfil_Load);
            this.gb_patente.ResumeLayout(false);
            this.gb_patente.PerformLayout();
            this.gb_nueva.ResumeLayout(false);
            this.gb_nueva.PerformLayout();
            this.gb_familia.ResumeLayout(false);
            this.gb_familia.PerformLayout();
            this.gb_nuevaF.ResumeLayout(false);
            this.gb_nuevaF.PerformLayout();
            this.gb_configurar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_patente;
        private Button btn_guardarP;
        private GroupBox gb_nueva;
        private TextBox txt_NombrePatente;
        private Label lbl_nombre;
        private ComboBox cboPermisos;
        private Label lbl_permiso;
        private Button btn_agregar;
        private ComboBox cboPatentes;
        private Label lbl_todasP;
        private GroupBox gb_familia;
        private GroupBox gb_nuevaF;
        private Button btn_guardarF;
        private TextBox txt_NombreFamilia;
        private Label lbl_nombreF;
        private Button btn_AgregarFamilia;
        private Button btn_configurar;
        private ComboBox cboFamilias;
        private Label lbl_todasF;
        private GroupBox gb_configurar;
        private Button btn_guardarFamiliaGral;
        private TreeView treeConfigurarFamilia;
    }
}