namespace TCTD2020.ArquitecturaCapasV2.UI
{
    partial class frmMdiPrincipal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestorUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestorPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSesion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mnuGestores});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemLogin,
            this.itemLogout});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.inicioToolStripMenuItem.Text = "Sesión";
            // 
            // itemLogin
            // 
            this.itemLogin.Name = "itemLogin";
            this.itemLogin.Size = new System.Drawing.Size(143, 22);
            this.itemLogin.Text = "Iniciar Sesión";
            this.itemLogin.Click += new System.EventHandler(this.ItemLogin_Click);
            // 
            // itemLogout
            // 
            this.itemLogout.Name = "itemLogout";
            this.itemLogout.Size = new System.Drawing.Size(143, 22);
            this.itemLogout.Text = "Cerrar Sesión";
            this.itemLogout.Click += new System.EventHandler(this.ItemLogout_Click);
            // 
            // mnuGestores
            // 
            this.mnuGestores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGestorUsuarios,
            this.mnuGestorPermisos});
            this.mnuGestores.Name = "mnuGestores";
            this.mnuGestores.Size = new System.Drawing.Size(64, 20);
            this.mnuGestores.Text = "Gestores";
            // 
            // mnuGestorUsuarios
            // 
            this.mnuGestorUsuarios.Name = "mnuGestorUsuarios";
            this.mnuGestorUsuarios.Size = new System.Drawing.Size(175, 22);
            this.mnuGestorUsuarios.Text = "Gestor de usuarios";
            // 
            // mnuGestorPermisos
            // 
            this.mnuGestorPermisos.Name = "mnuGestorPermisos";
            this.mnuGestorPermisos.Size = new System.Drawing.Size(175, 22);
            this.mnuGestorPermisos.Text = "Gestor de permisos";
            this.mnuGestorPermisos.Click += new System.EventHandler(this.MnuGestorPermisos_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripSesion});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel.Text = "Usuario";
            // 
            // toolStripSesion
            // 
            this.toolStripSesion.Name = "toolStripSesion";
            this.toolStripSesion.Size = new System.Drawing.Size(116, 17);
            this.toolStripSesion.Text = "[ Sesión no iniciada ]";
            // 
            // frmMdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMdiPrincipal";
            this.Text = "Arquitectura V2";
            this.Load += new System.EventHandler(this.frmMdiPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemLogin;
        private System.Windows.Forms.ToolStripMenuItem itemLogout;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSesion;
        private System.Windows.Forms.ToolStripMenuItem mnuGestores;
        private System.Windows.Forms.ToolStripMenuItem mnuGestorUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuGestorPermisos;
    }
}



