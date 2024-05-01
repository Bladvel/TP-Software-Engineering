namespace TPRestaurante
{
    partial class frmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.itemIniciarSesión = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCerrarSesión = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGestorUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abiertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSesion,
            this.menuAdmin,
            this.pedidoToolStripMenuItem,
            this.catalogosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSesion
            // 
            this.menuSesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemIniciarSesión,
            this.itemCerrarSesión});
            this.menuSesion.Name = "menuSesion";
            this.menuSesion.Size = new System.Drawing.Size(53, 20);
            this.menuSesion.Text = "Sesión";
            // 
            // itemIniciarSesión
            // 
            this.itemIniciarSesión.Name = "itemIniciarSesión";
            this.itemIniciarSesión.Size = new System.Drawing.Size(143, 22);
            this.itemIniciarSesión.Text = "Iniciar Sesión";
            this.itemIniciarSesión.Click += new System.EventHandler(this.itemIniciarSesion_Click);
            // 
            // itemCerrarSesión
            // 
            this.itemCerrarSesión.Name = "itemCerrarSesión";
            this.itemCerrarSesión.Size = new System.Drawing.Size(143, 22);
            this.itemCerrarSesión.Text = "Cerrar Sesión";
            this.itemCerrarSesión.Click += new System.EventHandler(this.itemCerrarSesion_Click);
            // 
            // menuAdmin
            // 
            this.menuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemGestorUsuarios});
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(55, 20);
            this.menuAdmin.Text = "Admin";
            // 
            // itemGestorUsuarios
            // 
            this.itemGestorUsuarios.Name = "itemGestorUsuarios";
            this.itemGestorUsuarios.Size = new System.Drawing.Size(180, 22);
            this.itemGestorUsuarios.Text = "Gestion de usuarios";
            this.itemGestorUsuarios.Click += new System.EventHandler(this.itemGestorUsuarios_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel1.Text = "Sesion no iniciada";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.verPedidosToolStripMenuItem});
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.ingredientesToolStripMenuItem});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // ingredientesToolStripMenuItem
            // 
            this.ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            this.ingredientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingredientesToolStripMenuItem.Text = "Ingredientes";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // verPedidosToolStripMenuItem
            // 
            this.verPedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abiertosToolStripMenuItem,
            this.cerradosToolStripMenuItem});
            this.verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            this.verPedidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verPedidosToolStripMenuItem.Text = "Ver pedidos";
            // 
            // abiertosToolStripMenuItem
            // 
            this.abiertosToolStripMenuItem.Name = "abiertosToolStripMenuItem";
            this.abiertosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abiertosToolStripMenuItem.Text = "Abiertos";
            // 
            // cerradosToolStripMenuItem
            // 
            this.cerradosToolStripMenuItem.Name = "cerradosToolStripMenuItem";
            this.cerradosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerradosToolStripMenuItem.Text = "Cerrados";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "FoodSmart";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem menuSesion;
        private System.Windows.Forms.ToolStripMenuItem itemIniciarSesión;
        private System.Windows.Forms.ToolStripMenuItem itemCerrarSesión;
        private System.Windows.Forms.ToolStripMenuItem menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem itemGestorUsuarios;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abiertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerradosToolStripMenuItem;
    }
}

