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
using Services;

namespace TPRestaurante
{
    public partial class frmPedidosEnCurso : Form
    {
        public frmPedidosEnCurso()
        {
            InitializeComponent();
            bllPedido = new BLL.Pedido();
        }

        private BLL.Pedido bllPedido;
        private void ucButtonSecondary1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPedidosEnCurso_Load(object sender, EventArgs e)
        {
            grdPedidos.RowHeadersVisible = false;
            grdPedidos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            grdPedidos.DataSource = null;
            grdPedidos.DataSource = bllPedido.ListarPorEstado(OrderType.EnPreparacion);
        }
    }
}
