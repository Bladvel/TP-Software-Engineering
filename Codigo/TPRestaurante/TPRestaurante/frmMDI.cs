using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using BLL;

namespace TPRestaurante
{
    public partial class frmMDI : Form, IIdiomaObserver
    {
        public frmMDI()
        {
            InitializeComponent();
            bllUser = new BLL.User();
            _idiomaActual = Traductor.ObtenerIdiomaDefault();
            bitacora = new Services.Bitacora();
            bllBitacora = new BLL.Bitacora();
        }
        private IIdioma _idiomaActual;
        BLL.User bllUser;
        Services.Bitacora bitacora;
        BLL.Bitacora bllBitacora;

        private void frmMDI_Load(object sender, EventArgs e)
        {
            ValidarForm();
            CargarIdiomas();
            SessionManager.SuscribirObservador(this);

            /************************ CALCULO INICIAL DE DVH ************************/

            //BLL.DVH bllDvh = new BLL.DVH();
            //Cliente bllCliente = new Cliente();
            //Comanda bllComanda = new Comanda();
            //Ingrediente bllIngrediente = new Ingrediente();
            //ItemProducto bllItemProducto = new ItemProducto();
            //MetodoDePago bllMetodoDePago = new MetodoDePago();
            //Pago bllPago = new Pago();
            //PagoEfectivo bllPagoEfectivo = new PagoEfectivo();
            //PagoTarjeta bllPagoTarjeta = new PagoTarjeta();
            //Pedido bllPedido = new Pedido();
            //Producto bllProducto = new Producto();

            //Factura bllFactura = new Factura();
            //ItemIngrediente bllItemIngrediente = new ItemIngrediente();
            //NotaDeEntrega bllNotaDeEntrega = new NotaDeEntrega();
            //OrdenDeCompra bllOrdenDeCompra = new OrdenDeCompra();
            //PagoInsumo bllPagoInsumo = new PagoInsumo();
            //Proveedor bllProveedor = new Proveedor();
            //SolicitudDeCotizacion bllSolicitudDeCotizacion = new SolicitudDeCotizacion();

            //List<Services.DVH> dvhs = bllDvh.Listar();
            //List<BE.Cliente> clientes = bllCliente.Listar();
            //List<BE.Comanda> comandas = bllComanda.Listar();
            //List<BE.Ingrediente> ingredientes = bllIngrediente.Listar();
            //List<BE.ItemProducto> itemProductos = bllItemProducto.Listar();
            //List<BE.MetodoDePago> metodosDePago = bllMetodoDePago.Listar();
            //List<BE.Pago> pagos = bllPago.Listar();
            //List<BE.PagoEfectivo> pagosEfectivo = bllPagoEfectivo.Listar();
            //List<BE.PagoTarjeta> pagosTarjeta = bllPagoTarjeta.Listar();
            //List<BE.Pedido> pedidos = bllPedido.Listar();
            //List<BE.Producto> productos = bllProducto.Listar();

            //List<BE.Factura> facturas = bllFactura.Listar();
            //List<BE.ItemIngrediente> itemIngredientes = bllItemIngrediente.Listar();
            //List<BE.NotaDeEntrega> notasDeEntrega = bllNotaDeEntrega.Listar();
            //List<BE.OrdenDeCompra> ordenesDeCompra = bllOrdenDeCompra.Listar();
            //List<BE.PagoInsumo> pagosInsumo = bllPagoInsumo.Listar();
            //List<BE.Proveedor> proveedores = bllProveedor.Listar();
            //List<BE.SolicitudDeCotizacion> solicitudesDeCotizacion = bllSolicitudDeCotizacion.Listar();

            //bllDvh.Recalcular(dvhs, clientes, bllCliente.Concatenar, c => c.ID, "CLIENTE");
            //bllDvh.Recalcular(dvhs, comandas, bllComanda.Concatenar, c => c.ID, "COMANDA");
            //bllDvh.Recalcular(dvhs, ingredientes, bllIngrediente.Concatenar, c => c.CodIngrediente, "INGREDIENTE");
            //bllDvh.Recalcular(dvhs, itemProductos, bllItemProducto.Concatenar, c => c.Id, "ITEM_PRODUCTO");
            //bllDvh.Recalcular(dvhs, metodosDePago, bllMetodoDePago.Concatenar, c => c.id, "METODO_DE_PAGO");
            //bllDvh.Recalcular(dvhs, pagos, bllPago.Concatenar, c => c.Id, "PAGO");
            //bllDvh.Recalcular(dvhs, pagosEfectivo, bllPagoEfectivo.Concatenar, c => c.id, "PAGO_EFECTIVO");
            //bllDvh.Recalcular(dvhs, pagosTarjeta, bllPagoTarjeta.Concatenar, c => c.id, "PAGO_TARJETA");
            //bllDvh.Recalcular(dvhs, pedidos, bllPedido.Concatenar, c => c.NroPedido, "PEDIDO");
            //bllDvh.Recalcular(dvhs, productos, bllProducto.Concatenar, c => c.CodProducto, "PRODUCTO");

            //bllDvh.Recalcular(dvhs, facturas, bllFactura.Concatenar, c => c.NroFactura, "FACTURA");
            //bllDvh.Recalcular(dvhs, itemIngredientes, bllItemIngrediente.Concatenar, c => c.ID, "ITEM_INGREDIENTE");
            //bllDvh.Recalcular(dvhs, notasDeEntrega, bllNotaDeEntrega.Concatenar, c => c.NroNota, "NOTA_DE_ENTREGA");
            //bllDvh.Recalcular(dvhs, ordenesDeCompra, bllOrdenDeCompra.Concatenar, c => c.NroOrden, "ORDEN_DE_COMPRA");
            //bllDvh.Recalcular(dvhs, pagosInsumo, bllPagoInsumo.Concatenar, c => c.NroPago, "PAGO_INSUMO");
            //bllDvh.Recalcular(dvhs, proveedores, bllProveedor.Concatenar, c => c.Cuit, "PROVEEDOR");
            //bllDvh.Recalcular(dvhs, solicitudesDeCotizacion, bllSolicitudDeCotizacion.Concatenar, c => c.NroSolicitud, "SOLICITUD_DE_COMPRA");

            //BLL.DVV bllDvv = new BLL.DVV();
            //bllDvv.Recalcular();



        }

        private void CerrarChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        public void AbrirChildForm(Form childForm)
        {
            CerrarChildForms();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.WindowState = FormWindowState.Maximized;
            
            childForm.Show();
        }


        public void ValidarForm()
        {
            if (SessionManager.Instance.IsLoggedIn())
            {
                itemCerrarSesión.Visible = true;
                itemCambiarContraseña.Visible = true;
                itemCambiarIdioma.Visible = true;
                itemIniciarSesión.Enabled = false;
                toolStripStatusLabel1.Text = SessionManager.Instance.User.Username;

                menuAdmin.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarAdmin);
                itemGestorUsuarios.Visible = SessionManager.Instance.IsInRole(PermissionType.GestorUsuario);
                itemGestorPerfiles.Visible = SessionManager.Instance.IsInRole(PermissionType.GestorPerfil);
                itemGestorIdiomas.Visible = SessionManager.Instance.IsInRole(PermissionType.GestorIdioma);

                menuPedidos.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarPedido);
                itemCrearPedido.Visible = SessionManager.Instance.IsInRole(PermissionType.CrearPedido);
                
                itemVerPedidos.Visible = SessionManager.Instance.IsInRole(PermissionType.VerPedidos);
                itemVerPedidosRegistrados.Visible =
                    SessionManager.Instance.IsInRole(PermissionType.VerPedidosRegistrados);
                itemVerPedidosEnCurso.Visible = SessionManager.Instance.IsInRole(PermissionType.VerPedidosEnCurso);
                itemVerPedidosCerrados.Visible = SessionManager.Instance.IsInRole(PermissionType.VerPedidosCerrados);
                itemVerPedidosVerificados.Visible =
                    SessionManager.Instance.IsInRole(PermissionType.VerPedidosVerificados);
                itemVerPedidosListos.Visible = SessionManager.Instance.IsInRole(PermissionType.VerPedidosListos);
                
                itemCobrarPedido.Visible = SessionManager.Instance.IsInRole(PermissionType.CobrarPedido);
                itemComandas.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarComanda);
                itemGenerarComandas.Visible = SessionManager.Instance.IsInRole(PermissionType.GenerarComanda);
                itemVerComandas.Visible = SessionManager.Instance.IsInRole(PermissionType.VerComanda);

                menuInventario.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarCatalogos);
                
                itemIngredientes.Visible = SessionManager.Instance.IsInRole(PermissionType.VerIngredientes);

                maestrisToolStripMenuItem.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarMaestros);
                clientesToolStripMenuItem.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarClientes);
                productosToolStripMenuItem.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarProductos);

                comprasToolStripMenuItem.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarCompras);
                cotizacionesToolStripMenuItem.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarCotizaciones);
                gestionarToolStripMenuItem1.Visible = SessionManager.Instance.IsInRole(PermissionType.VerGestionarCotizaciones);
                solicitarToolStripMenuItem.Visible = SessionManager.Instance.IsInRole(PermissionType.VerEnviarCotizaciones);
                ordenesDeCompraToolStripMenuItem.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarOrdenesDeCompra);
                generarToolStripMenuItem.Visible = SessionManager.Instance.IsInRole(PermissionType.VerGenerarOrdenesDeCompra);
                gestionarToolStripMenuItem.Visible = SessionManager.Instance.IsInRole(PermissionType.VerGestionarOrdenesDeCompra);
                gestionDePagoToolStripMenuItem.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarGestionDePagos);
                facturasToolStripMenuItem.Visible = SessionManager.Instance.IsInRole(PermissionType.VerCargarFacturas);
                registrarPagoToolStripMenuItem1.Visible = SessionManager.Instance.IsInRole(PermissionType.VerRegistrarPagos);


                Traducir(SessionManager.Instance.User.Idioma);
            }
            else
            {
                itemCerrarSesión.Visible = false;
                itemCambiarContraseña.Visible = false;
                itemCambiarIdioma.Visible = true;
                itemIniciarSesión.Enabled = true;
                toolStripStatusLabel1.Text = "Sesion no iniciada";

                menuAdmin.Visible = false;
                menuPedidos.Visible = false;
                menuInventario.Visible = false;
                comprasToolStripMenuItem.Visible = false;
                maestrisToolStripMenuItem.Visible = false;
                Traducir();
            }


        }

        private void itemCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro?", "Confirme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                bllUser.Logout();
                ValidarForm();
                CerrarChildForms();
            }
        }
        
        

        private void itemIniciarSesion_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            AbrirChildForm(formLogin);

        }

        private void itemGestorUsuarios_Click(object sender, EventArgs e)
        {
            frmManageUsers formUsers = new frmManageUsers();
            AbrirChildForm(formUsers);

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateOrder formCreateOrder = new frmCreateOrder();
            AbrirChildForm(formCreateOrder);
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cobrarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCobrarPedido formCobrarPedido = new frmCobrarPedido();
            AbrirChildForm(formCobrarPedido);
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerarComanda generarComanda = new frmGenerarComanda();
            AbrirChildForm(generarComanda);
        }

        private void abiertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidosEnCurso pedidosEnCurso = new frmPedidosEnCurso();
            AbrirChildForm(pedidosEnCurso);
        }
        

        private void registradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerificarPedido verificarPedido = new frmVerificarPedido();
            AbrirChildForm(verificarPedido);
        }

        private void itemCambiarContraseña_Click(object sender, EventArgs e)
        {
            frmCambiarPassword cambiarPassword = new frmCambiarPassword();
            AbrirChildForm(cambiarPassword);
        }


        private void asignacionDePerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfiles perfiles = new frmPerfiles();
            AbrirChildForm(perfiles);
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionarPermisos permisos = new frmGestionarPermisos();
            AbrirChildForm(permisos);
        }

        private void itemVerComandas_Click(object sender, EventArgs e)
        {
            frmVerComandas comandas = new frmVerComandas();
            AbrirChildForm(comandas);
        }

        private void itemVerPedidosListos_Click(object sender, EventArgs e)
        {
            frmPedidosListos pedidosListos = new frmPedidosListos();
            AbrirChildForm(pedidosListos);
        }

        private void itemVerPedidosVerificados_Click(object sender, EventArgs e)
        {
            frmPedidosVerificados pedidosVerificados = new frmPedidosVerificados();
            AbrirChildForm(pedidosVerificados);
        }

        private void itemVerPedidosCerrados_Click(object sender, EventArgs e)
        {
            frmPedidosCerrados pedidosListos = new frmPedidosCerrados();
            AbrirChildForm(pedidosListos);
        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma = null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);
            
            //Menu sesion
            if (menuSesion.Tag != null && traducciones.ContainsKey(menuSesion.Tag.ToString()))
                menuSesion.Text = traducciones[menuSesion.Tag.ToString()].Texto;
            if (itemIniciarSesión.Tag != null && traducciones.ContainsKey(itemIniciarSesión.Tag.ToString()))
                itemIniciarSesión.Text = traducciones[itemIniciarSesión.Tag.ToString()].Texto;
            if (itemCerrarSesión.Tag != null && traducciones.ContainsKey(itemCerrarSesión.Tag.ToString()))
                itemCerrarSesión.Text = traducciones[itemCerrarSesión.Tag.ToString()].Texto;
            if (itemCambiarIdioma.Tag != null && traducciones.ContainsKey(itemCambiarIdioma.Tag.ToString()))
                itemCambiarIdioma.Text = traducciones[itemCambiarIdioma.Tag.ToString()].Texto;
            if (itemCambiarContraseña.Tag != null && traducciones.ContainsKey(itemCambiarContraseña.Tag.ToString()))
                itemCambiarContraseña.Text = traducciones[itemCambiarContraseña.Tag.ToString()].Texto;


            //Menu admin
            if (menuAdmin.Tag != null && traducciones.ContainsKey(menuAdmin.Tag.ToString()))
                menuAdmin.Text = traducciones[menuAdmin.Tag.ToString()].Texto;
            if (itemGestorUsuarios.Tag != null && traducciones.ContainsKey(itemGestorUsuarios.Tag.ToString()))
                itemGestorUsuarios.Text = traducciones[itemGestorUsuarios.Tag.ToString()].Texto;
            if (itemGestorPerfiles.Tag != null && traducciones.ContainsKey(itemGestorPerfiles.Tag.ToString()))
                itemGestorPerfiles.Text = traducciones[itemGestorPerfiles.Tag.ToString()].Texto;
            if (permisosToolStripMenuItem.Tag != null && traducciones.ContainsKey(permisosToolStripMenuItem.Tag.ToString()))
                permisosToolStripMenuItem.Text = traducciones[permisosToolStripMenuItem.Tag.ToString()].Texto;
            if (asignacionDePerfilToolStripMenuItem.Tag != null && traducciones.ContainsKey(asignacionDePerfilToolStripMenuItem.Tag.ToString()))
                asignacionDePerfilToolStripMenuItem.Text = traducciones[asignacionDePerfilToolStripMenuItem.Tag.ToString()].Texto;
            if (itemGestorIdiomas.Tag != null && traducciones.ContainsKey(itemGestorIdiomas.Tag.ToString()))
                itemGestorIdiomas.Text = traducciones[itemGestorIdiomas.Tag.ToString()].Texto;


            //Menu pedidos
            if (menuPedidos.Tag != null && traducciones.ContainsKey(menuPedidos.Tag.ToString()))
                menuPedidos.Text = traducciones[menuPedidos.Tag.ToString()].Texto;
            if (itemCrearPedido.Tag != null && traducciones.ContainsKey(itemCrearPedido.Tag.ToString()))
                itemCrearPedido.Text = traducciones[itemCrearPedido.Tag.ToString()].Texto;

            if (itemVerPedidos.Tag != null && traducciones.ContainsKey(itemVerPedidos.Tag.ToString()))
                itemVerPedidos.Text = traducciones[itemVerPedidos.Tag.ToString()].Texto;
            if (itemVerPedidosRegistrados.Tag != null && traducciones.ContainsKey(itemVerPedidosRegistrados.Tag.ToString()))
                itemVerPedidosRegistrados.Text = traducciones[itemVerPedidosRegistrados.Tag.ToString()].Texto;
            if (itemVerPedidosVerificados.Tag != null && traducciones.ContainsKey(itemVerPedidosVerificados.Tag.ToString()))
                itemVerPedidosVerificados.Text = traducciones[itemVerPedidosVerificados.Tag.ToString()].Texto;
            if (itemVerPedidosEnCurso.Tag != null && traducciones.ContainsKey(itemVerPedidosEnCurso.Tag.ToString()))
                itemVerPedidosEnCurso.Text = traducciones[itemVerPedidosEnCurso.Tag.ToString()].Texto;
            if (itemVerPedidosListos.Tag != null && traducciones.ContainsKey(itemVerPedidosListos.Tag.ToString()))
                itemVerPedidosListos.Text = traducciones[itemVerPedidosListos.Tag.ToString()].Texto;
            if (itemVerPedidosCerrados.Tag != null && traducciones.ContainsKey(itemVerPedidosCerrados.Tag.ToString()))
                itemVerPedidosCerrados.Text = traducciones[itemVerPedidosCerrados.Tag.ToString()].Texto;

            if (itemCobrarPedido.Tag != null && traducciones.ContainsKey(itemCobrarPedido.Tag.ToString()))
                itemCobrarPedido.Text = traducciones[itemCobrarPedido.Tag.ToString()].Texto;

            if (itemComandas.Tag != null && traducciones.ContainsKey(itemComandas.Tag.ToString()))
                itemComandas.Text = traducciones[itemComandas.Tag.ToString()].Texto;
            if (itemGenerarComandas.Tag != null && traducciones.ContainsKey(itemGenerarComandas.Tag.ToString()))
                itemGenerarComandas.Text = traducciones[itemGenerarComandas.Tag.ToString()].Texto;
            if (itemVerComandas.Tag != null && traducciones.ContainsKey(itemVerComandas.Tag.ToString()))
                itemVerComandas.Text = traducciones[itemVerComandas.Tag.ToString()].Texto;


            //Menu catalogos
            if (menuInventario.Tag != null && traducciones.ContainsKey(menuInventario.Tag.ToString()))
                menuInventario.Text = traducciones[menuInventario.Tag.ToString()].Texto;
            
            if (itemIngredientes.Tag != null && traducciones.ContainsKey(itemIngredientes.Tag.ToString()))
                itemIngredientes.Text = traducciones[itemIngredientes.Tag.ToString()].Texto;

            //Menu ayuda
            if (menuAyuda.Tag != null && traducciones.ContainsKey(menuAyuda.Tag.ToString()))
                menuAyuda.Text = traducciones[menuAyuda.Tag.ToString()].Texto;


        }

        public void CargarIdiomas()
        {
            itemCambiarIdioma.DropDownItems.Clear();
            var idiomas = Traductor.ObtenerIdiomas();
            foreach (var idioma in idiomas)
            {
                var menuItem = new ToolStripMenuItem
                {
                    Text = idioma.Nombre,
                    Tag = idioma // Guarda el objeto idioma en la propiedad Tag para referencia
                };
                menuItem.Click += MenuItem_Click;
                itemCambiarIdioma.DropDownItems.Add(menuItem);
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                var idiomaSeleccionado = menuItem.Tag as IIdioma;
                if (idiomaSeleccionado != null)
                {
                    SessionManager.Instance.CambiarIdioma(idiomaSeleccionado);
                }
            }
        }


        private void frmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }

        private void itemGestorIdiomas_Click(object sender, EventArgs e)
        {
            frmManageLanguages gestionarIdiomas = new frmManageLanguages();
            AbrirChildForm(gestionarIdiomas);
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacoraEventos bitacoraEventos = new frmBitacoraEventos();
            AbrirChildForm(bitacoraEventos);
        }

        private void gestionDeRespaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRespaldo respaldo = new frmRespaldo();
            AbrirChildForm(respaldo);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaestroClientes clientes = new frmMaestroClientes();
            AbrirChildForm(clientes);
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerInsumos ingredientes = new frmVerInsumos();
            AbrirChildForm(ingredientes);
        }

        private void generarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmGenerarOrdenDeCompra ordenDeCompra = new frmGenerarOrdenDeCompra();
            AbrirChildForm(ordenDeCompra);
        }

        private void solicitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSolicitarCotizacion solicitarCotizacion = new frmSolicitarCotizacion();
            AbrirChildForm(solicitarCotizacion);
        }




        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecepcionDeInsumos recepcionDeInsumos = new frmRecepcionDeInsumos();
            AbrirChildForm(recepcionDeInsumos);
        }


        private void generarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrarPago registrarPago = new frmRegistrarPago();
            AbrirChildForm(registrarPago);
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarFacturaDirectamente cargarFactura = new frmCargarFacturaDirectamente();
            AbrirChildForm(cargarFactura);
        }

        private void cambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacoraDeCambios bitacoraDeCambios = new frmBitacoraDeCambios();
            AbrirChildForm(bitacoraDeCambios);
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaestroProductos maestroProductos = new frmMaestroProductos();
            AbrirChildForm(maestroProductos);
        }

        private void gestionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEvaluarSolicitudDeCotizacion evaluarSolicitudDeCotizacion = new frmEvaluarSolicitudDeCotizacion();
            AbrirChildForm(evaluarSolicitudDeCotizacion);
        }

        
    }
}
