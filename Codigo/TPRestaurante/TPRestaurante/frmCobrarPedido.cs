using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Interfaces;


namespace TPRestaurante
{
    public partial class frmCobrarPedido : Form
    {
        public frmCobrarPedido()
        {
            InitializeComponent();
            bllPedido = new BLL.Pedido();
        }

        private void ucButtonSecondary1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private BLL.Pedido bllPedido;
        private void frmCobrarPedido_Load(object sender, EventArgs e)
        {
            grdPedidosPorCobrar.RowHeadersVisible = false;
            grdPedidosPorCobrar.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPedidosPorCobrar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            grdPedidosPorCobrar.DataSource = null;
            grdPedidosPorCobrar.DataSource = bllPedido.ListarPorPago(PaymentState.NoPagado);

            groupEfectivo.Visible = false;
            groupTarjeta.Visible = false;


            cmbMetodo.Items.Add(PaymentMethodType.Tarjeta);
            cmbMetodo.Items.Add(PaymentMethodType.Efectivo);

        }

        private Pedido pedidoSeleccionado;


        private void grdPedidosPorCobrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                pedidoSeleccionado = grdPedidosPorCobrar.Rows[e.RowIndex].DataBoundItem as Pedido;



                if (pedidoSeleccionado != null)
                {
                    float total = bllPedido.CalcularSubtotal(pedidoSeleccionado);
                    lblTotal.Text = $"${total}";

                }
                

            }

        }

        private void cmbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodo.SelectedItem != null)
            {
                string metodoSeleccionado = cmbMetodo.SelectedItem.ToString();
                if (metodoSeleccionado == "Tarjeta")
                {
                    // Mostrar opciones de tarjeta y ocultar opciones de efectivo
                    groupTarjeta.Visible = true;
                    groupEfectivo.Visible = false;
                }
                else if (metodoSeleccionado == "Efectivo")
                {
                    groupTarjeta.Visible = false;
                    groupEfectivo.Visible = true;
                }
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {

        }
    }
}
