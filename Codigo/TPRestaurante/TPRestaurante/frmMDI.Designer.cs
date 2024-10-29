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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.itemIniciarSesión = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCerrarSesión = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCambiarContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCambiarIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGestorUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGestorPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDePerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGestorIdiomas = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeBitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeRespaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCrearPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVerPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVerPedidosRegistrados = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVerPedidosVerificados = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVerPedidosEnCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVerPedidosListos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVerPedidosCerrados = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCobrarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.itemComandas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGenerarComandas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVerComandas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.itemIngredientes = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPagoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.maestrisToolStripMenuItem,
            this.catalogoToolStripMenuItem,
            this.menuPedidos,
            this.menuInventario,
            this.comprasToolStripMenuItem,
            this.menuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSesion
            // 
            this.menuSesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemIniciarSesión,
            this.itemCerrarSesión,
            this.itemCambiarContraseña,
            this.itemCambiarIdioma});
            this.menuSesion.Name = "menuSesion";
            this.menuSesion.Size = new System.Drawing.Size(53, 20);
            this.menuSesion.Tag = "session";
            this.menuSesion.Text = "Sesión";
            // 
            // itemIniciarSesión
            // 
            this.itemIniciarSesión.Name = "itemIniciarSesión";
            this.itemIniciarSesión.Size = new System.Drawing.Size(180, 22);
            this.itemIniciarSesión.Tag = "login";
            this.itemIniciarSesión.Text = "Iniciar Sesión";
            this.itemIniciarSesión.Click += new System.EventHandler(this.itemIniciarSesion_Click);
            // 
            // itemCerrarSesión
            // 
            this.itemCerrarSesión.Name = "itemCerrarSesión";
            this.itemCerrarSesión.Size = new System.Drawing.Size(180, 22);
            this.itemCerrarSesión.Tag = "logout";
            this.itemCerrarSesión.Text = "Cerrar Sesión";
            this.itemCerrarSesión.Click += new System.EventHandler(this.itemCerrarSesion_Click);
            // 
            // itemCambiarContraseña
            // 
            this.itemCambiarContraseña.Name = "itemCambiarContraseña";
            this.itemCambiarContraseña.Size = new System.Drawing.Size(180, 22);
            this.itemCambiarContraseña.Tag = "changePassword";
            this.itemCambiarContraseña.Text = "Cambiar contraseña";
            this.itemCambiarContraseña.Click += new System.EventHandler(this.itemCambiarContraseña_Click);
            // 
            // itemCambiarIdioma
            // 
            this.itemCambiarIdioma.Name = "itemCambiarIdioma";
            this.itemCambiarIdioma.Size = new System.Drawing.Size(180, 22);
            this.itemCambiarIdioma.Tag = "changeLanguage";
            this.itemCambiarIdioma.Text = "Cambiar idioma";
            // 
            // menuAdmin
            // 
            this.menuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemGestorUsuarios,
            this.itemGestorPerfiles,
            this.itemGestorIdiomas,
            this.gestionDeBitacoraToolStripMenuItem,
            this.gestionDeRespaldoToolStripMenuItem});
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(55, 20);
            this.menuAdmin.Tag = "admin";
            this.menuAdmin.Text = "Admin";
            // 
            // itemGestorUsuarios
            // 
            this.itemGestorUsuarios.Name = "itemGestorUsuarios";
            this.itemGestorUsuarios.Size = new System.Drawing.Size(178, 22);
            this.itemGestorUsuarios.Tag = "userManagement";
            this.itemGestorUsuarios.Text = "Gestion de usuarios";
            this.itemGestorUsuarios.Click += new System.EventHandler(this.itemGestorUsuarios_Click);
            // 
            // itemGestorPerfiles
            // 
            this.itemGestorPerfiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permisosToolStripMenuItem,
            this.asignacionDePerfilToolStripMenuItem});
            this.itemGestorPerfiles.Name = "itemGestorPerfiles";
            this.itemGestorPerfiles.Size = new System.Drawing.Size(178, 22);
            this.itemGestorPerfiles.Tag = "rolesManagement";
            this.itemGestorPerfiles.Text = "Gestion de perfiles";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.permisosToolStripMenuItem.Tag = "managePermissions";
            this.permisosToolStripMenuItem.Text = "Gestionar permisos";
            this.permisosToolStripMenuItem.Click += new System.EventHandler(this.permisosToolStripMenuItem_Click);
            // 
            // asignacionDePerfilToolStripMenuItem
            // 
            this.asignacionDePerfilToolStripMenuItem.Name = "asignacionDePerfilToolStripMenuItem";
            this.asignacionDePerfilToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.asignacionDePerfilToolStripMenuItem.Tag = "assignRoles";
            this.asignacionDePerfilToolStripMenuItem.Text = "Asignacion de perfiles";
            this.asignacionDePerfilToolStripMenuItem.Click += new System.EventHandler(this.asignacionDePerfilToolStripMenuItem_Click);
            // 
            // itemGestorIdiomas
            // 
            this.itemGestorIdiomas.Name = "itemGestorIdiomas";
            this.itemGestorIdiomas.Size = new System.Drawing.Size(178, 22);
            this.itemGestorIdiomas.Tag = "languageManagement";
            this.itemGestorIdiomas.Text = "Gestion de idiomas";
            this.itemGestorIdiomas.Click += new System.EventHandler(this.itemGestorIdiomas_Click);
            // 
            // gestionDeBitacoraToolStripMenuItem
            // 
            this.gestionDeBitacoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventosToolStripMenuItem,
            this.cambiosToolStripMenuItem});
            this.gestionDeBitacoraToolStripMenuItem.Name = "gestionDeBitacoraToolStripMenuItem";
            this.gestionDeBitacoraToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.gestionDeBitacoraToolStripMenuItem.Text = "Gestion de bitacora";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.eventosToolStripMenuItem.Text = "Eventos";
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click);
            // 
            // cambiosToolStripMenuItem
            // 
            this.cambiosToolStripMenuItem.Name = "cambiosToolStripMenuItem";
            this.cambiosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cambiosToolStripMenuItem.Text = "Cambios";
            this.cambiosToolStripMenuItem.Click += new System.EventHandler(this.cambiosToolStripMenuItem_Click);
            // 
            // gestionDeRespaldoToolStripMenuItem
            // 
            this.gestionDeRespaldoToolStripMenuItem.Name = "gestionDeRespaldoToolStripMenuItem";
            this.gestionDeRespaldoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.gestionDeRespaldoToolStripMenuItem.Text = "Gestion de respaldo";
            this.gestionDeRespaldoToolStripMenuItem.Click += new System.EventHandler(this.gestionDeRespaldoToolStripMenuItem_Click);
            // 
            // maestrisToolStripMenuItem
            // 
            this.maestrisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.maestrisToolStripMenuItem.Name = "maestrisToolStripMenuItem";
            this.maestrisToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.maestrisToolStripMenuItem.Text = "Maestros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProductosToolStripMenuItem});
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // menuProductosToolStripMenuItem
            // 
            this.menuProductosToolStripMenuItem.Name = "menuProductosToolStripMenuItem";
            this.menuProductosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.menuProductosToolStripMenuItem.Text = "Menu productos";
            // 
            // menuPedidos
            // 
            this.menuPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCrearPedido,
            this.itemVerPedidos,
            this.itemCobrarPedido,
            this.itemComandas});
            this.menuPedidos.Name = "menuPedidos";
            this.menuPedidos.Size = new System.Drawing.Size(61, 20);
            this.menuPedidos.Tag = "orders";
            this.menuPedidos.Text = "Pedidos";
            // 
            // itemCrearPedido
            // 
            this.itemCrearPedido.Name = "itemCrearPedido";
            this.itemCrearPedido.Size = new System.Drawing.Size(180, 22);
            this.itemCrearPedido.Tag = "create";
            this.itemCrearPedido.Text = "Crear";
            this.itemCrearPedido.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // itemVerPedidos
            // 
            this.itemVerPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemVerPedidosRegistrados,
            this.itemVerPedidosVerificados,
            this.itemVerPedidosEnCurso,
            this.itemVerPedidosListos,
            this.itemVerPedidosCerrados});
            this.itemVerPedidos.Name = "itemVerPedidos";
            this.itemVerPedidos.Size = new System.Drawing.Size(180, 22);
            this.itemVerPedidos.Tag = "seeOrders";
            this.itemVerPedidos.Text = "Ver pedidos";
            // 
            // itemVerPedidosRegistrados
            // 
            this.itemVerPedidosRegistrados.Name = "itemVerPedidosRegistrados";
            this.itemVerPedidosRegistrados.Size = new System.Drawing.Size(135, 22);
            this.itemVerPedidosRegistrados.Tag = "registered";
            this.itemVerPedidosRegistrados.Text = "Registrados";
            this.itemVerPedidosRegistrados.Click += new System.EventHandler(this.registradosToolStripMenuItem_Click);
            // 
            // itemVerPedidosVerificados
            // 
            this.itemVerPedidosVerificados.Name = "itemVerPedidosVerificados";
            this.itemVerPedidosVerificados.Size = new System.Drawing.Size(135, 22);
            this.itemVerPedidosVerificados.Tag = "verified";
            this.itemVerPedidosVerificados.Text = "Verificados";
            this.itemVerPedidosVerificados.Click += new System.EventHandler(this.itemVerPedidosVerificados_Click);
            // 
            // itemVerPedidosEnCurso
            // 
            this.itemVerPedidosEnCurso.Name = "itemVerPedidosEnCurso";
            this.itemVerPedidosEnCurso.Size = new System.Drawing.Size(135, 22);
            this.itemVerPedidosEnCurso.Tag = "onGoing";
            this.itemVerPedidosEnCurso.Text = "En curso";
            this.itemVerPedidosEnCurso.Click += new System.EventHandler(this.abiertosToolStripMenuItem_Click);
            // 
            // itemVerPedidosListos
            // 
            this.itemVerPedidosListos.Name = "itemVerPedidosListos";
            this.itemVerPedidosListos.Size = new System.Drawing.Size(135, 22);
            this.itemVerPedidosListos.Tag = "ready";
            this.itemVerPedidosListos.Text = "Listos";
            this.itemVerPedidosListos.Click += new System.EventHandler(this.itemVerPedidosListos_Click);
            // 
            // itemVerPedidosCerrados
            // 
            this.itemVerPedidosCerrados.Name = "itemVerPedidosCerrados";
            this.itemVerPedidosCerrados.Size = new System.Drawing.Size(135, 22);
            this.itemVerPedidosCerrados.Tag = "closed";
            this.itemVerPedidosCerrados.Text = "Cerrados";
            this.itemVerPedidosCerrados.Click += new System.EventHandler(this.itemVerPedidosCerrados_Click);
            // 
            // itemCobrarPedido
            // 
            this.itemCobrarPedido.Name = "itemCobrarPedido";
            this.itemCobrarPedido.Size = new System.Drawing.Size(180, 22);
            this.itemCobrarPedido.Tag = "chargeOrder";
            this.itemCobrarPedido.Text = "Cobrar pedido";
            this.itemCobrarPedido.Click += new System.EventHandler(this.cobrarPedidoToolStripMenuItem_Click);
            // 
            // itemComandas
            // 
            this.itemComandas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemGenerarComandas,
            this.itemVerComandas});
            this.itemComandas.Name = "itemComandas";
            this.itemComandas.Size = new System.Drawing.Size(180, 22);
            this.itemComandas.Tag = "orderTicket";
            this.itemComandas.Text = "Comandas";
            // 
            // itemGenerarComandas
            // 
            this.itemGenerarComandas.Name = "itemGenerarComandas";
            this.itemGenerarComandas.Size = new System.Drawing.Size(115, 22);
            this.itemGenerarComandas.Tag = "generate";
            this.itemGenerarComandas.Text = "Generar";
            this.itemGenerarComandas.Click += new System.EventHandler(this.generarToolStripMenuItem_Click);
            // 
            // itemVerComandas
            // 
            this.itemVerComandas.Name = "itemVerComandas";
            this.itemVerComandas.Size = new System.Drawing.Size(115, 22);
            this.itemVerComandas.Tag = "see";
            this.itemVerComandas.Text = "Ver";
            this.itemVerComandas.Click += new System.EventHandler(this.itemVerComandas_Click);
            // 
            // menuInventario
            // 
            this.menuInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemIngredientes});
            this.menuInventario.Name = "menuInventario";
            this.menuInventario.Size = new System.Drawing.Size(72, 20);
            this.menuInventario.Tag = "";
            this.menuInventario.Text = "Inventario";
            // 
            // itemIngredientes
            // 
            this.itemIngredientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem});
            this.itemIngredientes.Name = "itemIngredientes";
            this.itemIngredientes.Size = new System.Drawing.Size(180, 22);
            this.itemIngredientes.Tag = "ingredients";
            this.itemIngredientes.Text = "Insumos";
            this.itemIngredientes.Click += new System.EventHandler(this.ingredientesToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionesToolStripMenuItem,
            this.ordenesDeCompraToolStripMenuItem,
            this.gestionDePagoToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem1,
            this.solicitarToolStripMenuItem});
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            this.cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cotizacionesToolStripMenuItem.Text = "Cotizaciones";
            // 
            // gestionarToolStripMenuItem1
            // 
            this.gestionarToolStripMenuItem1.Name = "gestionarToolStripMenuItem1";
            this.gestionarToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.gestionarToolStripMenuItem1.Text = "Gestionar";
            this.gestionarToolStripMenuItem1.Click += new System.EventHandler(this.gestionarToolStripMenuItem1_Click);
            // 
            // solicitarToolStripMenuItem
            // 
            this.solicitarToolStripMenuItem.Name = "solicitarToolStripMenuItem";
            this.solicitarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.solicitarToolStripMenuItem.Text = "Enviar";
            this.solicitarToolStripMenuItem.Click += new System.EventHandler(this.solicitarToolStripMenuItem_Click);
            // 
            // ordenesDeCompraToolStripMenuItem
            // 
            this.ordenesDeCompraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarToolStripMenuItem,
            this.gestionarToolStripMenuItem});
            this.ordenesDeCompraToolStripMenuItem.Name = "ordenesDeCompraToolStripMenuItem";
            this.ordenesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenesDeCompraToolStripMenuItem.Text = "Ordenes de compra";
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.generarToolStripMenuItem.Text = "Generar";
            this.generarToolStripMenuItem.Click += new System.EventHandler(this.generarToolStripMenuItem_Click_1);
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            this.gestionarToolStripMenuItem.Click += new System.EventHandler(this.gestionarToolStripMenuItem_Click);
            // 
            // gestionDePagoToolStripMenuItem
            // 
            this.gestionDePagoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem,
            this.registrarPagoToolStripMenuItem1});
            this.gestionDePagoToolStripMenuItem.Name = "gestionDePagoToolStripMenuItem";
            this.gestionDePagoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDePagoToolStripMenuItem.Text = "Gestion de pagos";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.facturasToolStripMenuItem.Text = "Cargar facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // registrarPagoToolStripMenuItem1
            // 
            this.registrarPagoToolStripMenuItem1.Name = "registrarPagoToolStripMenuItem1";
            this.registrarPagoToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.registrarPagoToolStripMenuItem1.Text = "Registrar";
            this.registrarPagoToolStripMenuItem1.Click += new System.EventHandler(this.generarToolStripMenuItem1_Click);
            // 
            // menuAyuda
            // 
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuAyuda.Tag = "help";
            this.menuAyuda.Text = "Ayuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(871, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel1.Text = "Sesion no iniciada";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(871, 587);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "SISFOOD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMDI_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem menuPedidos;
        private System.Windows.Forms.ToolStripMenuItem menuInventario;
        private System.Windows.Forms.ToolStripMenuItem itemIngredientes;
        private System.Windows.Forms.ToolStripMenuItem itemCrearPedido;
        private System.Windows.Forms.ToolStripMenuItem itemVerPedidos;
        private System.Windows.Forms.ToolStripMenuItem itemVerPedidosEnCurso;
        private System.Windows.Forms.ToolStripMenuItem itemVerPedidosCerrados;
        private System.Windows.Forms.ToolStripMenuItem itemCobrarPedido;
        private System.Windows.Forms.ToolStripMenuItem itemComandas;
        private System.Windows.Forms.ToolStripMenuItem itemGenerarComandas;
        private System.Windows.Forms.ToolStripMenuItem itemVerComandas;
        private System.Windows.Forms.ToolStripMenuItem itemCambiarContraseña;
        private System.Windows.Forms.ToolStripMenuItem itemCambiarIdioma;
        private System.Windows.Forms.ToolStripMenuItem itemGestorPerfiles;
        private System.Windows.Forms.ToolStripMenuItem itemGestorIdiomas;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem itemVerPedidosRegistrados;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDePerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemVerPedidosVerificados;
        private System.Windows.Forms.ToolStripMenuItem itemVerPedidosListos;
        private System.Windows.Forms.ToolStripMenuItem gestionDeBitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeRespaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPagoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem1;
    }
}

