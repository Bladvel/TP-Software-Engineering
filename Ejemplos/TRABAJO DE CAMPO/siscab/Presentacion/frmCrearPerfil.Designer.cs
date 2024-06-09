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
            gb_patente = new GroupBox();
            btn_guardarP = new Button();
            gb_nueva = new GroupBox();
            txt_NombrePatente = new TextBox();
            lbl_nombre = new Label();
            cboPermisos = new ComboBox();
            lbl_permiso = new Label();
            btn_agregar = new Button();
            cboPatentes = new ComboBox();
            lbl_todasP = new Label();
            gb_familia = new GroupBox();
            gb_nuevaF = new GroupBox();
            btn_guardarF = new Button();
            txt_NombreFamilia = new TextBox();
            lbl_nombreF = new Label();
            btn_AgregarFamilia = new Button();
            btn_configurar = new Button();
            cboFamilias = new ComboBox();
            lbl_todasF = new Label();
            gb_configurar = new GroupBox();
            btn_guardarFamiliaGral = new Button();
            treeConfigurarFamilia = new TreeView();
            gb_patente.SuspendLayout();
            gb_nueva.SuspendLayout();
            gb_familia.SuspendLayout();
            gb_nuevaF.SuspendLayout();
            gb_configurar.SuspendLayout();
            SuspendLayout();
            // 
            // gb_patente
            // 
            gb_patente.Controls.Add(btn_guardarP);
            gb_patente.Controls.Add(gb_nueva);
            gb_patente.Controls.Add(btn_agregar);
            gb_patente.Controls.Add(cboPatentes);
            gb_patente.Controls.Add(lbl_todasP);
            gb_patente.Location = new Point(12, 12);
            gb_patente.Name = "gb_patente";
            gb_patente.Size = new Size(237, 298);
            gb_patente.TabIndex = 0;
            gb_patente.TabStop = false;
            gb_patente.Text = "Patente";
            // 
            // btn_guardarP
            // 
            btn_guardarP.Location = new Point(42, 258);
            btn_guardarP.Name = "btn_guardarP";
            btn_guardarP.Size = new Size(75, 23);
            btn_guardarP.TabIndex = 4;
            btn_guardarP.Text = "Guardar";
            btn_guardarP.UseVisualStyleBackColor = true;
            btn_guardarP.Click += btn_guardarP_Click;
            // 
            // gb_nueva
            // 
            gb_nueva.Controls.Add(txt_NombrePatente);
            gb_nueva.Controls.Add(lbl_nombre);
            gb_nueva.Controls.Add(cboPermisos);
            gb_nueva.Controls.Add(lbl_permiso);
            gb_nueva.Location = new Point(22, 122);
            gb_nueva.Name = "gb_nueva";
            gb_nueva.Size = new Size(203, 170);
            gb_nueva.TabIndex = 3;
            gb_nueva.TabStop = false;
            gb_nueva.Text = "Nueva patente";
            // 
            // txt_NombrePatente
            // 
            txt_NombrePatente.Location = new Point(21, 102);
            txt_NombrePatente.Name = "txt_NombrePatente";
            txt_NombrePatente.Size = new Size(142, 23);
            txt_NombrePatente.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(17, 80);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 2;
            lbl_nombre.Text = "Nombre";
            // 
            // cboPermisos
            // 
            cboPermisos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPermisos.FormattingEnabled = true;
            cboPermisos.Location = new Point(16, 47);
            cboPermisos.Name = "cboPermisos";
            cboPermisos.Size = new Size(147, 23);
            cboPermisos.TabIndex = 1;
            // 
            // lbl_permiso
            // 
            lbl_permiso.AutoSize = true;
            lbl_permiso.Location = new Point(9, 24);
            lbl_permiso.Name = "lbl_permiso";
            lbl_permiso.Size = new Size(50, 15);
            lbl_permiso.TabIndex = 0;
            lbl_permiso.Text = "Permiso";
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(15, 75);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(100, 23);
            btn_agregar.TabIndex = 2;
            btn_agregar.Text = "Agregar >>";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // cboPatentes
            // 
            cboPatentes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPatentes.FormattingEnabled = true;
            cboPatentes.Location = new Point(14, 43);
            cboPatentes.Name = "cboPatentes";
            cboPatentes.Size = new Size(171, 23);
            cboPatentes.TabIndex = 1;
            cboPatentes.SelectedIndexChanged += cboPatentes_SelectedIndexChanged;
            // 
            // lbl_todasP
            // 
            lbl_todasP.AutoSize = true;
            lbl_todasP.Location = new Point(13, 22);
            lbl_todasP.Name = "lbl_todasP";
            lbl_todasP.Size = new Size(102, 15);
            lbl_todasP.TabIndex = 0;
            lbl_todasP.Text = "Todas las patentes";
            // 
            // gb_familia
            // 
            gb_familia.Controls.Add(gb_nuevaF);
            gb_familia.Controls.Add(btn_AgregarFamilia);
            gb_familia.Controls.Add(btn_configurar);
            gb_familia.Controls.Add(cboFamilias);
            gb_familia.Controls.Add(lbl_todasF);
            gb_familia.Location = new Point(264, 12);
            gb_familia.Name = "gb_familia";
            gb_familia.Size = new Size(249, 298);
            gb_familia.TabIndex = 1;
            gb_familia.TabStop = false;
            gb_familia.Text = "Familia";
            // 
            // gb_nuevaF
            // 
            gb_nuevaF.Controls.Add(btn_guardarF);
            gb_nuevaF.Controls.Add(txt_NombreFamilia);
            gb_nuevaF.Controls.Add(lbl_nombreF);
            gb_nuevaF.Location = new Point(21, 122);
            gb_nuevaF.Name = "gb_nuevaF";
            gb_nuevaF.Size = new Size(222, 110);
            gb_nuevaF.TabIndex = 6;
            gb_nuevaF.TabStop = false;
            gb_nuevaF.Text = "Nueva";
            // 
            // btn_guardarF
            // 
            btn_guardarF.Location = new Point(15, 83);
            btn_guardarF.Name = "btn_guardarF";
            btn_guardarF.Size = new Size(71, 23);
            btn_guardarF.TabIndex = 2;
            btn_guardarF.Text = "Guardar";
            btn_guardarF.UseVisualStyleBackColor = true;
            btn_guardarF.Click += btn_guardarF_Click;
            // 
            // txt_NombreFamilia
            // 
            txt_NombreFamilia.Location = new Point(14, 49);
            txt_NombreFamilia.Name = "txt_NombreFamilia";
            txt_NombreFamilia.Size = new Size(190, 23);
            txt_NombreFamilia.TabIndex = 1;
            // 
            // lbl_nombreF
            // 
            lbl_nombreF.AutoSize = true;
            lbl_nombreF.Location = new Point(10, 25);
            lbl_nombreF.Name = "lbl_nombreF";
            lbl_nombreF.Size = new Size(51, 15);
            lbl_nombreF.TabIndex = 0;
            lbl_nombreF.Text = "Nombre";
            // 
            // btn_AgregarFamilia
            // 
            btn_AgregarFamilia.Location = new Point(100, 72);
            btn_AgregarFamilia.Name = "btn_AgregarFamilia";
            btn_AgregarFamilia.Size = new Size(77, 23);
            btn_AgregarFamilia.TabIndex = 5;
            btn_AgregarFamilia.Text = "Agregar >>";
            btn_AgregarFamilia.UseVisualStyleBackColor = true;
            btn_AgregarFamilia.Click += btn_AgregarFamilia_Click;
            // 
            // btn_configurar
            // 
            btn_configurar.Location = new Point(9, 72);
            btn_configurar.Name = "btn_configurar";
            btn_configurar.Size = new Size(81, 23);
            btn_configurar.TabIndex = 3;
            btn_configurar.Text = "Configurar";
            btn_configurar.UseVisualStyleBackColor = true;
            btn_configurar.Click += btn_configurar_Click;
            // 
            // cboFamilias
            // 
            cboFamilias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFamilias.FormattingEnabled = true;
            cboFamilias.Location = new Point(6, 43);
            cboFamilias.Name = "cboFamilias";
            cboFamilias.Size = new Size(171, 23);
            cboFamilias.TabIndex = 2;
            // 
            // lbl_todasF
            // 
            lbl_todasF.AutoSize = true;
            lbl_todasF.Location = new Point(9, 20);
            lbl_todasF.Name = "lbl_todasF";
            lbl_todasF.Size = new Size(98, 15);
            lbl_todasF.TabIndex = 0;
            lbl_todasF.Text = "Todas las familias";
            // 
            // gb_configurar
            // 
            gb_configurar.Controls.Add(btn_guardarFamiliaGral);
            gb_configurar.Controls.Add(treeConfigurarFamilia);
            gb_configurar.Location = new Point(528, 12);
            gb_configurar.Name = "gb_configurar";
            gb_configurar.Size = new Size(260, 298);
            gb_configurar.TabIndex = 2;
            gb_configurar.TabStop = false;
            gb_configurar.Text = "Configurar Familia";
            // 
            // btn_guardarFamiliaGral
            // 
            btn_guardarFamiliaGral.Location = new Point(143, 266);
            btn_guardarFamiliaGral.Name = "btn_guardarFamiliaGral";
            btn_guardarFamiliaGral.Size = new Size(111, 23);
            btn_guardarFamiliaGral.TabIndex = 1;
            btn_guardarFamiliaGral.Text = "Guardar";
            btn_guardarFamiliaGral.UseVisualStyleBackColor = true;
            btn_guardarFamiliaGral.Click += btn_guardarFamiliaGral_Click;
            // 
            // treeConfigurarFamilia
            // 
            treeConfigurarFamilia.Location = new Point(13, 27);
            treeConfigurarFamilia.Name = "treeConfigurarFamilia";
            treeConfigurarFamilia.Size = new Size(241, 225);
            treeConfigurarFamilia.TabIndex = 0;
            // 
            // frmCrearPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 322);
            Controls.Add(gb_configurar);
            Controls.Add(gb_familia);
            Controls.Add(gb_patente);
            MaximumSize = new Size(816, 361);
            MinimumSize = new Size(816, 361);
            Name = "frmCrearPerfil";
            Text = "frmCrearPerfil";
            FormClosing += frmCrearModificarPerfil_FormClosing;
            Load += frmCrearModificarPerfil_Load;
            gb_patente.ResumeLayout(false);
            gb_patente.PerformLayout();
            gb_nueva.ResumeLayout(false);
            gb_nueva.PerformLayout();
            gb_familia.ResumeLayout(false);
            gb_familia.PerformLayout();
            gb_nuevaF.ResumeLayout(false);
            gb_nuevaF.PerformLayout();
            gb_configurar.ResumeLayout(false);
            ResumeLayout(false);
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