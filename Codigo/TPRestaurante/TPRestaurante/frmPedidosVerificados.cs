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

namespace TPRestaurante
{
    public partial class frmPedidosVerificados : Form
    {
        public frmPedidosVerificados()
        {
            InitializeComponent();
            bllPedido = new BLL.Pedido();
        }

        private BLL.Pedido bllPedido;


        private void frmPedidosVerificados_Load(object sender, EventArgs e)
        {
            grdPedidosAceptados.RowHeadersVisible = false;
            grdPedidosAceptados.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPedidosAceptados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            grdPedidosAceptados.DataSource = null;
            grdPedidosAceptados.DataSource = bllPedido.ListarPorEstado(OrderType.Aceptado);

            grdPedidosRechazados.RowHeadersVisible = false;
            grdPedidosRechazados.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPedidosRechazados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdPedidosRechazados.DataSource = null;
            grdPedidosRechazados.DataSource = bllPedido.ListarPorEstado(OrderType.Rechazado);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
