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
        public frmReparacion()
        {
            InitializeComponent();
        }

        public frmReparacion(List<RegistroInvalido> registrosInvalidos)
        {
            InitializeComponent();
            this.registrosInvalidos = registrosInvalidos;
        }

        private void frmReparacion_Load(object sender, EventArgs e)
        {
            txtDetallesError.Text = string.Empty;
            foreach (var registroInvalido in registrosInvalidos)
            {
                txtDetallesError.Text+= $"El registro {registroInvalido.Dvh.Registro} de la tabla " +
                                        $"{registroInvalido.Dvh.Tabla} fue {registroInvalido.Estado}\n";
            }
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            BLL.DVH bllDvh = new BLL.DVH();
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


            List<Services.DVH> dvhs = bllDvh.Listar();
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

            bllDvh.Recalcular(dvhs, clientes, bllCliente.Concatenar, c => c.ID, "CLIENTE");
            bllDvh.Recalcular(dvhs, comandas, bllComanda.Concatenar, c => c.ID, "COMANDA");
            bllDvh.Recalcular(dvhs, ingredientes, bllIngrediente.Concatenar, c => c.CodIngrediente, "INGREDIENTE");
            bllDvh.Recalcular(dvhs, itemProductos, bllItemProducto.Concatenar, c => c.Id, "ITEM_PRODUCTO");
            bllDvh.Recalcular(dvhs, metodosDePago, bllMetodoDePago.Concatenar, c => c.id, "METODO_DE_PAGO");
            bllDvh.Recalcular(dvhs, pagos, bllPago.Concatenar, c => c.Id, "PAGO");
            bllDvh.Recalcular(dvhs, pagosEfectivo, bllPagoEfectivo.Concatenar, c => c.id, "PAGO_EFECTIVO");
            bllDvh.Recalcular(dvhs, pagosTarjeta, bllPagoTarjeta.Concatenar, c => c.id, "PAGO_TARJETA");
            bllDvh.Recalcular(dvhs, pedidos, bllPedido.Concatenar, c => c.NroPedido, "PEDIDO");
            bllDvh.Recalcular(dvhs, productos, bllProducto.Concatenar, c => c.CodProducto, "PRODUCTO");

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
