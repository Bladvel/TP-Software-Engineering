namespace TPRestaurante
{
    partial class frmGestionarPermisos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuardarGrupo = new System.Windows.Forms.Button();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.btnAgregarGrupo = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.lblGrupos = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarPermiso = new System.Windows.Forms.Button();
            this.cmbPermisos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new TPRestaurante.UcButtonSecondary(this.components);
            this.btnGuardarConfig = new TPRestaurante.UcButtonPrimary(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnAgregarGrupo);
            this.groupBox1.Controls.Add(this.btnConfigurar);
            this.groupBox1.Controls.Add(this.lblGrupos);
            this.groupBox1.Controls.Add(this.cmbGrupo);
            this.groupBox1.Location = new System.Drawing.Point(94, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "groups";
            this.groupBox1.Text = "Grupos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGuardarGrupo);
            this.groupBox3.Controls.Add(this.txtGrupo);
            this.groupBox3.Location = new System.Drawing.Point(18, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 75);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "createNewGroup";
            this.groupBox3.Text = "Crear nuevo grupo";
            // 
            // btnGuardarGrupo
            // 
            this.btnGuardarGrupo.Location = new System.Drawing.Point(3, 46);
            this.btnGuardarGrupo.Name = "btnGuardarGrupo";
            this.btnGuardarGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarGrupo.TabIndex = 1;
            this.btnGuardarGrupo.Tag = "save";
            this.btnGuardarGrupo.Text = "Guardar";
            this.btnGuardarGrupo.UseVisualStyleBackColor = true;
            this.btnGuardarGrupo.Click += new System.EventHandler(this.btnGuardarGrupo_Click);
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(3, 19);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(164, 20);
            this.txtGrupo.TabIndex = 0;
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.Location = new System.Drawing.Point(99, 71);
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarGrupo.TabIndex = 2;
            this.btnAgregarGrupo.Tag = "add";
            this.btnAgregarGrupo.Text = "Agregar";
            this.btnAgregarGrupo.UseVisualStyleBackColor = true;
            this.btnAgregarGrupo.Click += new System.EventHandler(this.btnAgregarGrupo_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(18, 71);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 23);
            this.btnConfigurar.TabIndex = 2;
            this.btnConfigurar.Tag = "configure";
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // lblGrupos
            // 
            this.lblGrupos.AutoSize = true;
            this.lblGrupos.Location = new System.Drawing.Point(18, 24);
            this.lblGrupos.Name = "lblGrupos";
            this.lblGrupos.Size = new System.Drawing.Size(41, 13);
            this.lblGrupos.TabIndex = 1;
            this.lblGrupos.Tag = "groups";
            this.lblGrupos.Text = "Grupos";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(18, 43);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(167, 21);
            this.cmbGrupo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarPermiso);
            this.groupBox2.Controls.Add(this.cmbPermisos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(94, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "permissions";
            this.groupBox2.Text = "Permisos";
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.Location = new System.Drawing.Point(18, 70);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPermiso.TabIndex = 2;
            this.btnAgregarPermiso.Tag = "add";
            this.btnAgregarPermiso.Text = "Agregar";
            this.btnAgregarPermiso.UseVisualStyleBackColor = true;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // cmbPermisos
            // 
            this.cmbPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermisos.FormattingEnabled = true;
            this.cmbPermisos.Location = new System.Drawing.Point(18, 43);
            this.cmbPermisos.Name = "cmbPermisos";
            this.cmbPermisos.Size = new System.Drawing.Size(167, 21);
            this.cmbPermisos.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "allThePermissions";
            this.label2.Text = "Todos los permisos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(588, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 39);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Tag = "cancel";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarConfig
            // 
            this.btnGuardarConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnGuardarConfig.FlatAppearance.BorderSize = 0;
            this.btnGuardarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarConfig.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardarConfig.ForeColor = System.Drawing.Color.White;
            this.btnGuardarConfig.Location = new System.Drawing.Point(450, 380);
            this.btnGuardarConfig.Name = "btnGuardarConfig";
            this.btnGuardarConfig.Size = new System.Drawing.Size(132, 39);
            this.btnGuardarConfig.TabIndex = 5;
            this.btnGuardarConfig.Tag = "save";
            this.btnGuardarConfig.Text = "Guardar";
            this.btnGuardarConfig.UseVisualStyleBackColor = false;
            this.btnGuardarConfig.Click += new System.EventHandler(this.btnGuardarConfig_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(384, 22);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(336, 352);
            this.treeView1.TabIndex = 4;
            // 
            // frmGestionarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 505);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarConfig);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGestionarPermisos";
            this.Text = "frmGestionarPermisos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGestionarPermisos_FormClosing);
            this.Load += new System.EventHandler(this.frmGestionarPermisos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGuardarGrupo;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Button btnAgregarGrupo;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Label lblGrupos;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Button btnAgregarPermiso;
        private System.Windows.Forms.ComboBox cmbPermisos;
        private System.Windows.Forms.Label label2;
        private UcButtonSecondary btnCancelar;
        private UcButtonPrimary btnGuardarConfig;
        private System.Windows.Forms.TreeView treeView1;
    }
}