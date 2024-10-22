namespace PF_APP_PEDIDOS
{
    partial class Inicio
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
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.menuFamilia = new FontAwesome.Sharp.IconMenuItem();
            this.menuCliente = new FontAwesome.Sharp.IconMenuItem();
            this.menuArticulo = new FontAwesome.Sharp.IconMenuItem();
            this.submenuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuNegocio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedido = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuRegistrarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.SubmenuVerDetalles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBitacora = new FontAwesome.Sharp.IconMenuItem();
            this.menuBackup = new FontAwesome.Sharp.IconMenuItem();
            this.menuAyuda = new FontAwesome.Sharp.IconMenuItem();
            this.menuCerrarSesion = new FontAwesome.Sharp.IconMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Blue;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1219, 62);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "SISTEMA DE GESTIÓN DE PEDIDOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(356, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "PEDIDOS EXPRESS";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 94);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1219, 593);
            this.contenedor.TabIndex = 3;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(912, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Blue;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(997, 24);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(105, 24);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // menuUsuario
            // 
            this.menuUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuUsuario.IconColor = System.Drawing.Color.Black;
            this.menuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuario.IconSize = 45;
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(130, 28);
            this.menuUsuario.Text = "USUARIOS";
            this.menuUsuario.Click += new System.EventHandler(this.menuUsuario_Click);
            // 
            // menuFamilia
            // 
            this.menuFamilia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFamilia.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuFamilia.IconColor = System.Drawing.Color.Black;
            this.menuFamilia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuFamilia.IconSize = 45;
            this.menuFamilia.Name = "menuFamilia";
            this.menuFamilia.Size = new System.Drawing.Size(119, 28);
            this.menuFamilia.Text = "FAMILIAS";
            this.menuFamilia.Click += new System.EventHandler(this.menuFamilia_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuCliente.IconColor = System.Drawing.Color.Black;
            this.menuCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCliente.IconSize = 45;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(125, 28);
            this.menuCliente.Text = "CLIENTES";
            this.menuCliente.Click += new System.EventHandler(this.menuCliente_Click);
            // 
            // menuArticulo
            // 
            this.menuArticulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuCategoria,
            this.submenuArticulos,
            this.submenuNegocio});
            this.menuArticulo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuArticulo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuArticulo.IconColor = System.Drawing.Color.Black;
            this.menuArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuArticulo.IconSize = 45;
            this.menuArticulo.Name = "menuArticulo";
            this.menuArticulo.Size = new System.Drawing.Size(102, 28);
            this.menuArticulo.Text = "STOCK";
            this.menuArticulo.Click += new System.EventHandler(this.menuArticulo_Click);
            // 
            // submenuCategoria
            // 
            this.submenuCategoria.Name = "submenuCategoria";
            this.submenuCategoria.Size = new System.Drawing.Size(168, 28);
            this.submenuCategoria.Text = "Categoria";
            this.submenuCategoria.Click += new System.EventHandler(this.submenuCategoria_Click);
            // 
            // submenuArticulos
            // 
            this.submenuArticulos.Name = "submenuArticulos";
            this.submenuArticulos.Size = new System.Drawing.Size(168, 28);
            this.submenuArticulos.Text = "Articulos";
            this.submenuArticulos.Click += new System.EventHandler(this.submenuArticulos_Click);
            // 
            // submenuNegocio
            // 
            this.submenuNegocio.Name = "submenuNegocio";
            this.submenuNegocio.Size = new System.Drawing.Size(168, 28);
            this.submenuNegocio.Text = "Negocio";
            this.submenuNegocio.Click += new System.EventHandler(this.submenuNegocio_Click);
            // 
            // menuPedido
            // 
            this.menuPedido.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuRegistrarPedido,
            this.SubmenuVerDetalles});
            this.menuPedido.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPedido.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuPedido.IconColor = System.Drawing.Color.Black;
            this.menuPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuPedido.IconSize = 45;
            this.menuPedido.Name = "menuPedido";
            this.menuPedido.Size = new System.Drawing.Size(118, 28);
            this.menuPedido.Text = "PEDIDOS";
            this.menuPedido.Click += new System.EventHandler(this.menuPedido_Click);
            // 
            // SubmenuRegistrarPedido
            // 
            this.SubmenuRegistrarPedido.Name = "SubmenuRegistrarPedido";
            this.SubmenuRegistrarPedido.Size = new System.Drawing.Size(186, 28);
            this.SubmenuRegistrarPedido.Text = "Registrar";
            this.SubmenuRegistrarPedido.Click += new System.EventHandler(this.SubmenuRegistrarPedido_Click);
            // 
            // SubmenuVerDetalles
            // 
            this.SubmenuVerDetalles.Name = "SubmenuVerDetalles";
            this.SubmenuVerDetalles.Size = new System.Drawing.Size(186, 28);
            this.SubmenuVerDetalles.Text = "Ver Detalles";
            this.SubmenuVerDetalles.Click += new System.EventHandler(this.SubmenuVerDetalles_Click);
            // 
            // menuBitacora
            // 
            this.menuBitacora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBitacora.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuBitacora.IconColor = System.Drawing.Color.Black;
            this.menuBitacora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuBitacora.IconSize = 45;
            this.menuBitacora.Name = "menuBitacora";
            this.menuBitacora.Size = new System.Drawing.Size(129, 28);
            this.menuBitacora.Text = "BITÁCORA";
            this.menuBitacora.Click += new System.EventHandler(this.menuBitacora_Click);
            // 
            // menuBackup
            // 
            this.menuBackup.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBackup.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuBackup.IconColor = System.Drawing.Color.Black;
            this.menuBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuBackup.IconSize = 45;
            this.menuBackup.Name = "menuBackup";
            this.menuBackup.Size = new System.Drawing.Size(114, 28);
            this.menuBackup.Text = "BACKUP";
            this.menuBackup.Click += new System.EventHandler(this.menuBackup_Click);
            // 
            // menuAyuda
            // 
            this.menuAyuda.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAyuda.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuAyuda.IconColor = System.Drawing.Color.Black;
            this.menuAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAyuda.IconSize = 45;
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(100, 28);
            this.menuAyuda.Text = "AYUDA";
            this.menuAyuda.Click += new System.EventHandler(this.menuAyuda_Click);
            // 
            // menuCerrarSesion
            // 
            this.menuCerrarSesion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuCerrarSesion.IconColor = System.Drawing.Color.Black;
            this.menuCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCerrarSesion.IconSize = 45;
            this.menuCerrarSesion.Name = "menuCerrarSesion";
            this.menuCerrarSesion.Size = new System.Drawing.Size(181, 28);
            this.menuCerrarSesion.Text = "CERRAR SESIÓN";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuFamilia,
            this.menuCliente,
            this.menuArticulo,
            this.menuPedido,
            this.menuBitacora,
            this.menuBackup,
            this.menuAyuda,
            this.menuCerrarSesion});
            this.menu.Location = new System.Drawing.Point(0, 62);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1219, 32);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // Inicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1219, 687);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem menuUsuario;
        private FontAwesome.Sharp.IconMenuItem menuFamilia;
        private FontAwesome.Sharp.IconMenuItem menuCliente;
        private FontAwesome.Sharp.IconMenuItem menuArticulo;
        private System.Windows.Forms.ToolStripMenuItem submenuCategoria;
        private System.Windows.Forms.ToolStripMenuItem submenuArticulos;
        private FontAwesome.Sharp.IconMenuItem menuPedido;
        public System.Windows.Forms.ToolStripMenuItem SubmenuRegistrarPedido;
        private System.Windows.Forms.ToolStripMenuItem SubmenuVerDetalles;
        private FontAwesome.Sharp.IconMenuItem menuBitacora;
        private FontAwesome.Sharp.IconMenuItem menuBackup;
        private FontAwesome.Sharp.IconMenuItem menuAyuda;
        private FontAwesome.Sharp.IconMenuItem menuCerrarSesion;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem submenuNegocio;
    }
}

