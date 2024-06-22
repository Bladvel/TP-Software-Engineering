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

        BLL.ControllerCajero bllCajero = new BLL.ControllerCajero();


        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (grdPedidosPorCobrar.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un pedido.");
                return;
            }

            Pedido pedidoSeleccionado = grdPedidosPorCobrar.CurrentRow.DataBoundItem as Pedido;
            if (pedidoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un pedido válido.");
                return;
            }

            if (cmbMetodo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un método de pago.");
                return;
            }

            string metodoPagoSeleccionado = cmbMetodo.SelectedItem.ToString();
            MetodoDePago metodoDePago = null;

            if (metodoPagoSeleccionado == "Tarjeta")
            {

                if (string.IsNullOrWhiteSpace(txtNumero.Text) ||
                    dateTimePicker1.Value == null ||
                    string.IsNullOrWhiteSpace(txtCvv.Text) ||
                    string.IsNullOrWhiteSpace(txtTitular.Text))
                {
                    MessageBox.Show("Complete todos los campos de la tarjeta.");
                    return;
                }

                metodoDePago = new PagoTarjeta
                {
                    tipo = PaymentMethodType.Tarjeta,
                    NumeroTarjeta = long.Parse(txtNumero.Text),
                    FechaVencimiento = dateTimePicker1.Value,
                    Cvv = int.Parse(txtCvv.Text),
                    Titular = txtTitular.Text
                };
            }
            else if (metodoPagoSeleccionado == "Efectivo")
            {
                // Validar campo de efectivo
                if (string.IsNullOrWhiteSpace(txtMonto.Text))
                {
                    MessageBox.Show("Ingrese el monto en efectivo.");
                    return;
                }

                metodoDePago = new PagoEfectivo
                {
                    tipo = PaymentMethodType.Efectivo,
                    Monto = float.Parse(txtMonto.Text)
                };
            }

            if (bllCajero.RealizarCobro(metodoDePago, pedidoSeleccionado) > 0)
            {
                MessageBox.Show("Pago registrado exitosamente.");
                grdPedidosPorCobrar.DataSource = null;
                grdPedidosPorCobrar.DataSource = bllPedido.ListarPorPago(PaymentState.NoPagado);
            }
            else
            {
                MessageBox.Show("Error al registrar el pago.");
            }

        }
    }
}
