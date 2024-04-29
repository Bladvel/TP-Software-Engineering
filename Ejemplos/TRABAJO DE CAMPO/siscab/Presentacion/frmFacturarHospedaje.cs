using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    
    public partial class frmFacturarHospedaje : Form
    {

        private static frmFacturarHospedaje instancia = null;

        public static frmFacturarHospedaje Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmFacturarHospedaje();
            }
            return instancia;
        }

       
        

        public frmFacturarHospedaje()
        {
            InitializeComponent();
        }

        BE.Estadia estadia = new BE.Estadia();
        BLL.BLLEstadia gestorEstadia = new BLL.BLLEstadia();
        BE.Factura_Hospedaje facturaHospedaje;
        BLL.BLLFactura_Hospedaje gestorFacturaHospedaje = new BLL.BLLFactura_Hospedaje();



        private void ActualizarGrilla()
        {
            dgv_estadias.DataSource = null;
            dgv_estadias.DataSource = gestorEstadia.ListarPendientesPago();

        }


        private void frmFacturarHospedaje_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void frmFacturarHospedaje_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgv_estadias.DataSource = null;
            dgv_estadias.DataSource = gestorEstadia.BuscarEstadia(int.Parse(txt_dniConsulta.Text));

            if (dgv_estadias.Rows.Count == 0)
            {
                ResetearTextBox();
                MessageBox.Show("No se encontró un cliente con ese número de DNI. Vuelva a intentar", "Buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
            }
        }

        private void ResetearTextBox()
        {
            txt_fecha.Text = "";
            txt_lugar.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_dni.Text = "";
            txt_direccion.Text = "";
            txt_telefonofijo.Text = "";
            txt_telefonomovil.Text = "";
            txt_descripcion.Text = "";
            txt_total_estadia.Text = "";
            txt_deposito.Text = "";
            txt_total_pagar.Text = "";
        }


        private void txt_dniConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_estadias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            estadia = (BE.Estadia)dgv_estadias.Rows[e.RowIndex].DataBoundItem;
            facturaHospedaje = new BE.Factura_Hospedaje();

            facturaHospedaje.Cliente = estadia.Cliente;
            facturaHospedaje.Fecha = DateTime.Now;
            facturaHospedaje.Fecha = DateTime.Now;
            facturaHospedaje.Numero = "entramite";
            facturaHospedaje.Lugar = "Ciudad de San Rafael, MENDOZA";
            facturaHospedaje.Estadia = estadia;
            facturaHospedaje.FacturaReserva = estadia.FacturaReserva;
            facturaHospedaje.TotalPagar = gestorFacturaHospedaje.ObtenerTotalPagar(estadia.FacturaReserva);
            facturaHospedaje.Deposito = gestorFacturaHospedaje.ObtenerDeposito(estadia.FacturaReserva);
            facturaHospedaje.TotalEstadia = gestorFacturaHospedaje.ObtenerTotalEstadia(estadia.FacturaReserva);            
            facturaHospedaje.Estado = EnumEstadoPago.NoPago;


            txt_fecha.Text = facturaHospedaje.Fecha.ToString();
            txt_lugar.Text = facturaHospedaje.Lugar;
            txt_nombre.Text = facturaHospedaje.Cliente.Nombre;
            txt_apellido.Text = facturaHospedaje.Cliente.Apellido;
            txt_dni.Text = facturaHospedaje.Cliente.Dni.ToString();
            txt_direccion.Text = facturaHospedaje.Cliente.Domicilio;
            txt_telefonofijo.Text = facturaHospedaje.Cliente.Telefono_Fijo;
            txt_telefonomovil.Text = facturaHospedaje.Cliente.Telefono_Movil;

            txt_descripcion.Text = "Checkin= " + facturaHospedaje.Estadia.Checkin + " - Checkout= " + facturaHospedaje.Estadia.Checkout + " - Habitación = " +
                facturaHospedaje.Estadia.Habitacion + " - Cantidad de Huéspedes = " + facturaHospedaje.Estadia.CantidadHuespedes;

            txt_total_estadia.Text = "$ " + facturaHospedaje.TotalEstadia.ToString();

            txt_deposito.Text = "$ " + facturaHospedaje.Deposito.ToString();
            
            txt_total_pagar.Text = "$ " + facturaHospedaje.TotalPagar.ToString();

        }

        private void btn_metodo_pago_Click(object sender, EventArgs e)
        {
            frmMetododePago frm = new frmMetododePago(facturaHospedaje);
            AddOwnedForm(frm);
            frm.ShowDialog();           
            frm.BringToFront();
            ActualizarGrilla();
        }

        private void btn_generarFactura_Click(object sender, EventArgs e)
        {
            if (txt_total_estadia.Text != "" && txt_total_pagar.Text != "" & txt_deposito.Text != "")
            {

                gestorFacturaHospedaje.Insertar(facturaHospedaje);
                facturaHospedaje.Numero = gestorFacturaHospedaje.GenerarNumero(facturaHospedaje.Fecha, facturaHospedaje.Id);
                gestorFacturaHospedaje.Modificar(facturaHospedaje);
                
                ResetearTextBox();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para generar la factura.", "Generar Factura", MessageBoxButtons.OK, MessageBoxIcon.Stop); ;
            }
        }
    }
}
