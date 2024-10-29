using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Interfaces;

namespace TPRestaurante
{
    public partial class frmRegistrarPago : Form
    {
        public frmRegistrarPago()
        {
            InitializeComponent();
            bllFactura = new BLL.Factura();
            bllOrdenDeCompra = new BLL.OrdenDeCompra();
            bllPagoInsumo = new BLL.PagoInsumo();
        }

        private BLL.Factura bllFactura;
        private BLL.OrdenDeCompra bllOrdenDeCompra;
        private BLL.PagoInsumo bllPagoInsumo;
        Factura facturaSeleccionada;
        private void frmRegistrarPago_Load(object sender, EventArgs e)
        {
            grdFacturas.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdFacturas.MultiSelect = false;
            grdFacturas.RowHeadersVisible = false;

            cmbTipo.DataSource = Enum.GetValues(typeof(TipoPago));

            LlenarGridFacturas();
        }


        void LlenarGridFacturas()
        {
            grdFacturas.DataSource = null;
            grdFacturas.DataSource = bllFactura.ListarPendientesDePago();
        }

        private void grdFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdFacturas.SelectedRows.Count > 0)
            {
                facturaSeleccionada = (Factura)grdFacturas.SelectedRows[0].DataBoundItem;
                txtMontoAdeudado.Text = bllFactura.ObtenerTotalAdeudado(facturaSeleccionada).ToString(CultureInfo.InvariantCulture);
                txtNroDeCuota.Text = bllFactura.ObtenerCuotaActualAPagar(facturaSeleccionada).ToString();
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada si no es un número
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMonto.Text) || string.IsNullOrWhiteSpace(txtNroDeCuota.Text))
            {
                MessageBox.Show("Por favor rellena los campos");
                return;
            }

            if(facturaSeleccionada == null)
            {
                MessageBox.Show("Por favor selecciona una factura");
                return;
            }

            double monto = double.Parse(txtMonto.Text, CultureInfo.InvariantCulture);
            int nroCuotas = int.Parse(txtNroDeCuota.Text);

            PagoInsumo pago = new PagoInsumo(facturaSeleccionada, monto, (TipoPago)cmbTipo.SelectedItem, nroCuotas);

            MessageBox.Show(bllFactura.ProcesarPago(pago, facturaSeleccionada));
            LlenarGridFacturas();
            LimpiarTextboxs();

        }

        private void LimpiarTextboxs()
        {
            txtMonto.Text = "";
            txtMontoAdeudado.Text = "";
            txtNroDeCuota.Text = "";
            txtMonto.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
