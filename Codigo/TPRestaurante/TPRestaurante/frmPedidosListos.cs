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
using BE;

namespace TPRestaurante
{
    public partial class frmPedidosListos : Form
    {
        public frmPedidosListos()
        {
            InitializeComponent();
            bllPedido = new BLL.Pedido();
            bllCajero = new BLL.ControllerCajero();
        }

        private BLL.Pedido bllPedido;
        private BLL.ControllerCajero bllCajero;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdPedidosListos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPedidosListos_Load(object sender, EventArgs e)
        {
            grdPedidosListos.RowHeadersVisible = false;
            grdPedidosListos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPedidosListos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            LlenarGrillaPedidos();
        }

        private void LlenarGrillaPedidos()
        {
            grdPedidosListos.DataSource = null;
            grdPedidosListos.DataSource = bllPedido.ListarPorEstado(OrderType.Listo);
        }

        private void btnCerrarPedido_Click(object sender, EventArgs e)
        {
            if (grdPedidosListos.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un pedido a cerrar");
            }
            else
            {
                Pedido pedidoSeleccionado = grdPedidosListos.CurrentRow.DataBoundItem as Pedido;
                if (bllCajero.CerrarPedido(pedidoSeleccionado))
                {
                    MessageBox.Show("Pedido cerrado exitosamente. Por favor entregar al cliente");
                    LlenarGrillaPedidos();
                }
                else
                {
                    MessageBox.Show("Error al cerrar el pedido. No ha sido pagado");
                }
                

            }
        }
    }
}
