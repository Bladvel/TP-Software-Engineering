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
using Services;


namespace TPRestaurante
{
    public partial class frmCobrarPedido : Form, IIdiomaObserver
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


            SessionManager.SuscribirObservador(this);
            Traducir(SessionManager.Instance.User.Idioma);

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
                RegistroBitacoraCobro();
                grdPedidosPorCobrar.DataSource = null;
                grdPedidosPorCobrar.DataSource = bllPedido.ListarPorPago(PaymentState.NoPagado);
            }
            else
            {
                MessageBox.Show("Pago rechazado. Error al registrar el pago.");
            }

        }

        
        private void RegistroBitacoraCobro()
        {
            var bitacora = new Services.Bitacora
            {
                Fecha = DateTime.Now,
                Usuario = SessionManager.Instance.User,
                Modulo = TipoModulo.Cobro,
                Operacion = TipoOperacion.CobrarPedido,
                Criticidad = 3
            };

            var bllBitacora = new BLL.Bitacora();
            bllBitacora.Insertar(bitacora);
        }



        private void frmCobrarPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma = null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);

            if (groupTarjeta.Tag != null && traducciones.ContainsKey(groupTarjeta.Tag.ToString()))
                groupTarjeta.Text = traducciones[groupTarjeta.Tag.ToString()].Texto;
            if (groupEfectivo.Tag != null && traducciones.ContainsKey(groupEfectivo.Tag.ToString()))
                groupEfectivo.Text = traducciones[groupEfectivo.Tag.ToString()].Texto;
            if (label1.Tag != null && traducciones.ContainsKey(label1.Tag.ToString()))
                label1.Text = traducciones[label1.Tag.ToString()].Texto;
            if (label2.Tag != null && traducciones.ContainsKey(label2.Tag.ToString()))
                label2.Text = traducciones[label2.Tag.ToString()].Texto;
            if (label3.Tag != null && traducciones.ContainsKey(label3.Tag.ToString()))
                label3.Text = traducciones[label3.Tag.ToString()].Texto;
            if (label4.Tag != null && traducciones.ContainsKey(label4.Tag.ToString()))
                label4.Text = traducciones[label4.Tag.ToString()].Texto;
            if (label5.Tag != null && traducciones.ContainsKey(label5.Tag.ToString()))
                label5.Text = traducciones[label5.Tag.ToString()].Texto;
            if (label6.Tag != null && traducciones.ContainsKey(label6.Tag.ToString()))
                label6.Text = traducciones[label6.Tag.ToString()].Texto;
            if (label7.Tag != null && traducciones.ContainsKey(label7.Tag.ToString()))
                label7.Text = traducciones[label7.Tag.ToString()].Texto;
            if (label8.Tag != null && traducciones.ContainsKey(label8.Tag.ToString()))
                label8.Text = traducciones[label8.Tag.ToString()].Texto;
            if (btnCobrar.Tag != null && traducciones.ContainsKey(btnCobrar.Tag.ToString()))
                btnCobrar.Text = traducciones[btnCobrar.Tag.ToString()].Texto;
            if (ucButtonSecondary1.Tag != null && traducciones.ContainsKey(ucButtonSecondary1.Tag.ToString()))
                ucButtonSecondary1.Text = traducciones[ucButtonSecondary1.Tag.ToString()].Texto;

        }
    }
}
