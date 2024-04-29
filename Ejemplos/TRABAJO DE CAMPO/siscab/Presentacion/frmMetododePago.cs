using BE;
using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmMetododePago : Form
    {

       
               
        public frmMetododePago(Factura_Hospedaje fh)
        {
          
            InitializeComponent();
            facHosp = fh;
            txt_numeroFactura.Text = fh.Numero;
        }

        Factura_Hospedaje facHosp = new Factura_Hospedaje();

        BE.Pago_Estadia pagoEstadia;
        BLL.BLLPago_Estadia gestorPagoEstadia = new BLL.BLLPago_Estadia();

        BE.Procesador_Pago procesador;
        BLL.BLLProcesador_Pago gestorProcesador = new BLL.BLLProcesador_Pago();
        
        BE.Tipo_Tarjeta tipo_tarjeta;
        BLL.BLLTipo_Tarjeta gestorTipoTarjeta = new BLL.BLLTipo_Tarjeta();
            
        BE.Banco banco;
        BLL.BLLBanco gestorBanco = new BLL.BLLBanco();

        
        BLL.BLLFactura_Hospedaje gestorFacturaHospedaje = new BLL.BLLFactura_Hospedaje();

        BE.Estadia estadia;
        BLL.BLLEstadia gestorEstadia = new BLL.BLLEstadia();

        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();


        void CargarComboBoxs()
        {
            cb_tarjeta.DataSource = null;
            cb_tarjeta.DataSource = gestorProcesador.Listar();
            cb_tipo.DataSource = null;
            cb_tipo.DataSource = gestorTipoTarjeta.Listar();
            cb_banco.DataSource = null;
            cb_banco.DataSource = gestorBanco.Listar();
        }

        private void frmMetododePago_Load(object sender, EventArgs e)
        {
            CargarComboBoxs();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportarBitacoraAltaFacturacionEstadia()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.FacturarEstadia;
            registroBitacora.Operacion = EnumOperacion.Alta;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }


        private bool ValidarDatosTarjeta()
        {
            return (!string.IsNullOrWhiteSpace(txt_numerotarjeta.Text) || !string.IsNullOrWhiteSpace(txt_codigo.Text));
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosTarjeta())
            {
                pagoEstadia = new BE.Pago_Estadia();
                tipo_tarjeta = new BE.Tipo_Tarjeta();
                procesador = new BE.Procesador_Pago();

                procesador = (BE.Procesador_Pago)cb_tarjeta.SelectedItem;
                tipo_tarjeta = (BE.Tipo_Tarjeta)cb_tipo.SelectedItem;
                banco = (BE.Banco)cb_banco.SelectedItem;

                pagoEstadia.Tipo = tipo_tarjeta;
                pagoEstadia.Procesador = procesador;
                pagoEstadia.Banco = banco;
                pagoEstadia.Numero = long.Parse(txt_numerotarjeta.Text);
                pagoEstadia.Codigo = int.Parse(txt_codigo.Text);
                pagoEstadia.Vencimiento = dateTimePickerVencimiento.Value;
                pagoEstadia.Cuotas = int.Parse(txt_cuotas.Text);

                pagoEstadia.FacturaHospedaje = facHosp;
                gestorPagoEstadia.Insertar(pagoEstadia);

                MessageBox.Show("Se realizó el pago correctamente.","Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReportarBitacoraAltaFacturacionEstadia();
                facHosp.Estado = EnumEstadoPago.Pago;
                gestorFacturaHospedaje.CambiarEstado(pagoEstadia, facHosp);


                estadia = new Estadia();

                estadia = facHosp.Estadia;
                estadia.Estado = EnumEstadoEstadia.Desactiva;

                gestorEstadia.CambiarEstado(facHosp, estadia);


                this.Close();
            }
            else
            {
                MessageBox.Show("Complete lo campos vacios.","Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void txt_numerotarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txt_cuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
