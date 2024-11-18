using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace TPRestaurante
{
    public partial class frmReparacion : Form
    {
        private List<RegistroInvalido> registrosInvalidos;
        private List<ColumnaInvalida> camposInvalidos;
        public frmReparacion()
        {
            InitializeComponent();
        }

        public frmReparacion(List<RegistroInvalido> registrosInvalidos, List<ColumnaInvalida> camposInvalidos)
        {
            InitializeComponent();
            this.registrosInvalidos = registrosInvalidos;
            this.camposInvalidos = camposInvalidos;
        }

        //TODO modificar para que se muestren los campos invalidos
        private void frmReparacion_Load(object sender, EventArgs e)
        {
            txtDetallesError.Text = string.Empty;
            // Verificar registros inválidos y cruzar con campos inválidos
            foreach (var registroInvalido in registrosInvalidos)
            {
                // Encontrar las columnas inválidas correspondientes a la tabla del registro
                var columnasInvalidas = camposInvalidos
                    .Where(c => c.Dvv.Tabla == registroInvalido.Dvh.Tabla)
                    .ToList();

                if (columnasInvalidas.Count > 0)
                {
                    txtDetallesError.Text += $"El registro {registroInvalido.Dvh.Registro} en la tabla {registroInvalido.Dvh.Tabla} tiene problemas en los siguientes campos:\n";

                    foreach (var columnaInvalida in columnasInvalidas)
                    {
                        txtDetallesError.Text += $"- Columna '{columnaInvalida.Dvv.Columna}' está {columnaInvalida.Estado}\n";
                    }
                }
                else
                {
                    txtDetallesError.Text += $"El registro {registroInvalido.Dvh.Registro} en la tabla {registroInvalido.Dvh.Tabla} fue {registroInvalido.Estado}, pero no hay problemas en las columnas\n";
                }

                txtDetallesError.Text += "\n";
            }
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            //BLL.DVH bllDvh = new BLL.DVH();
            BLL.Cliente bllCliente = new BLL.Cliente();
            BLL.Comanda bllComanda = new BLL.Comanda();
            BLL.Ingrediente bllIngrediente = new BLL.Ingrediente();
            BLL.ItemProducto bllItemProducto = new BLL.ItemProducto();
            BLL.MetodoDePago bllMetodoDePago = new BLL.MetodoDePago();
            BLL.Pago bllPago = new BLL.Pago();
            BLL.PagoEfectivo bllPagoEfectivo = new BLL.PagoEfectivo();
            BLL.PagoTarjeta bllPagoTarjeta = new BLL.PagoTarjeta();
            BLL.Pedido bllPedido = new BLL.Pedido();
            BLL.Producto bllProducto = new BLL.Producto();


            BLL.Factura bllFactura = new BLL.Factura();
            BLL.ItemIngrediente bllItemIngrediente = new BLL.ItemIngrediente();
            BLL.NotaDeEntrega bllNotaDeEntrega = new BLL.NotaDeEntrega();
            BLL.OrdenDeCompra bllOrdenDeCompra = new BLL.OrdenDeCompra();
            BLL.PagoInsumo bllPagoInsumo = new BLL.PagoInsumo();
            BLL.Proveedor bllProveedor = new BLL.Proveedor();
            BLL.SolicitudDeCotizacion bllSolicitudDeCotizacion = new BLL.SolicitudDeCotizacion();


            List<Services.DVH> dvhs = BLL.DVH.Listar();
            List<BE.Cliente> clientes = bllCliente.Listar();
            List<BE.Comanda> comandas = bllComanda.Listar();
            List<BE.Ingrediente> ingredientes = bllIngrediente.Listar();
            List<BE.ItemProducto> itemProductos = bllItemProducto.Listar();
            List<BE.MetodoDePago> metodosDePago = bllMetodoDePago.Listar();
            List<BE.Pago> pagos = bllPago.Listar();
            List<BE.PagoEfectivo> pagosEfectivo = bllPagoEfectivo.Listar();
            List<BE.PagoTarjeta> pagosTarjeta = bllPagoTarjeta.Listar();
            List<BE.Pedido> pedidos = bllPedido.Listar();
            List<BE.Producto> productos = bllProducto.Listar();

            List<BE.Factura> facturas = bllFactura.Listar();
            List<BE.ItemIngrediente> itemIngredientes = bllItemIngrediente.Listar();
            List<BE.NotaDeEntrega> notasDeEntrega = bllNotaDeEntrega.Listar();
            List<BE.OrdenDeCompra> ordenesDeCompra = bllOrdenDeCompra.Listar();
            List<BE.PagoInsumo> pagosInsumo = bllPagoInsumo.Listar();
            List<BE.Proveedor> proveedores = bllProveedor.Listar();
            List<BE.SolicitudDeCotizacion> solicitudesDeCotizacion = bllSolicitudDeCotizacion.Listar();



            BLL.DVH.Recalcular(dvhs, clientes, bllCliente.Concatenar, c => c.ID, "CLIENTE");
            BLL.DVH.Recalcular(dvhs, comandas, bllComanda.Concatenar, c => c.ID, "COMANDA");
            BLL.DVH.Recalcular(dvhs, ingredientes, bllIngrediente.Concatenar, c => c.CodIngrediente, "INGREDIENTE");
            BLL.DVH.Recalcular(dvhs, itemProductos, bllItemProducto.Concatenar, c => c.Id, "ITEM_PRODUCTO");
            BLL.DVH.Recalcular(dvhs, metodosDePago, bllMetodoDePago.Concatenar, c => c.id, "METODO_DE_PAGO");
            BLL.DVH.Recalcular(dvhs, pagos, bllPago.Concatenar, c => c.Id, "PAGO");
            BLL.DVH.Recalcular(dvhs, pagosEfectivo, bllPagoEfectivo.Concatenar, c => c.id, "PAGO_EFECTIVO");
            BLL.DVH.Recalcular(dvhs, pagosTarjeta, bllPagoTarjeta.Concatenar, c => c.id, "PAGO_TARJETA");
            BLL.DVH.Recalcular(dvhs, pedidos, bllPedido.Concatenar, c => c.NroPedido, "PEDIDO");
            BLL.DVH.Recalcular(dvhs, productos, bllProducto.Concatenar, c => c.CodProducto, "PRODUCTO");

            BLL.DVH.Recalcular(dvhs, facturas, bllFactura.Concatenar, c => c.NroFactura, "FACTURA");
            BLL.DVH.Recalcular(dvhs, itemIngredientes, bllItemIngrediente.Concatenar, c => c.ID, "ITEM_INGREDIENTE");
            BLL.DVH.Recalcular(dvhs, notasDeEntrega, bllNotaDeEntrega.Concatenar, c => c.NroNota, "NOTA_DE_ENTREGA");
            BLL.DVH.Recalcular(dvhs, ordenesDeCompra, bllOrdenDeCompra.Concatenar, c => c.NroOrden, "ORDEN_DE_COMPRA");
            BLL.DVH.Recalcular(dvhs, pagosInsumo, bllPagoInsumo.Concatenar, c => c.NroPago, "PAGO_INSUMO");
            BLL.DVH.Recalcular(dvhs, proveedores, bllProveedor.Concatenar, c => c.Cuit, "PROVEEDOR");
            BLL.DVH.Recalcular(dvhs, solicitudesDeCotizacion, bllSolicitudDeCotizacion.Concatenar, c => c.NroSolicitud, "SOLICITUD_DE_COMPRA");


            BLL.DVV.Recalcular();

            MessageBox.Show("Se recalcularon los DV exitosamente", "Recalculacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivo BAK|*.bak";
            ofd.Title = "Base de datos restore";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                BLL.Backup bllBackup = new BLL.Backup();
                bllBackup.RestoreBackup(ofd.FileName);
                MessageBox.Show("Restauración realizada con éxito", "Restauración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        BLL.User bllUser = new BLL.User();
        private void btnSalir_Click(object sender, EventArgs e)
        {
            bllUser.Logout();
            this.Close();
        }
    }
}
