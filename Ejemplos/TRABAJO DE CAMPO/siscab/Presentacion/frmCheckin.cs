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
    public partial class frmCheckin : Form
    {

        private static frmCheckin instancia = null;

        public static frmCheckin Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmCheckin();
            }
            return instancia;
        }

        public frmCheckin()
        {
            InitializeComponent();
        }

        BE.Factura factura;
        BLL.BLLFactura gestorFactura = new BLL.BLLFactura();
        BE.Reserva reserva;
        BE.Estadia estadia;
        BLL.BLLEstadia gestorEstadia = new BLL.BLLEstadia();
        string fecha = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;

        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();



        private void IniciarFecha()
        {
            txt_fechaHoy.Text = fecha;
        }

        private void frmCheckin_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCheckin_Load(object sender, EventArgs e)
        {
            IniciarFecha();
        }


       private void ResetearTextBox()
        {
            txt_numeroFactura.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_dni.Text = "";
            txt_fechaingreso.Text = "";
            txt_fechasalida.Text = "";
            txt_noches.Text = "";
            txt_tipohabitacion.Text = "";
            txt_numero.Text = "";
            txt_cantidad.Text = "";
            txt_deposito.Text = "";
            txt_estadia.Text = "";
        }

        private void ReportarBitacoraAltaCheckin()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Checkin;
            registroBitacora.Operacion = EnumOperacion.Alta;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }


        private void btn_consultar_Click(object sender, EventArgs e)
        {           
            reserva = new BE.Reserva();
            string numeroFactura = txt_numeroFactura.Text;

            if (gestorFactura.ValidarFactura(numeroFactura))
            {

                if (gestorEstadia.ValidarEstadia(numeroFactura))
                {
                    MessageBox.Show("El cliente ya registró el checkin", "Checkin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    reserva = gestorFactura.BuscarReserva(numeroFactura);
                    string fecha2 = reserva.Fecha_Inicio.Day + "/" + reserva.Fecha_Inicio.Month + "/" + reserva.Fecha_Inicio.Year;
                    if (fecha == fecha2)
                    {

                        factura = new BE.Factura();
                        MessageBox.Show("El cliente puede realizar el checkin", "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txt_nombre.Text = reserva.Cliente.Nombre;
                        txt_apellido.Text = reserva.Cliente.Apellido;
                        txt_dni.Text = reserva.Cliente.Dni.ToString();
                        txt_fechaingreso.Text = reserva.Fecha_Inicio.Day + "/" + reserva.Fecha_Inicio.Month + "/" + reserva.Fecha_Inicio.Year;
                        txt_fechasalida.Text = reserva.Fecha_Fin.Day + "/" + reserva.Fecha_Fin.Month + "/" + reserva.Fecha_Fin.Year;
                        txt_noches.Text = reserva.Cantidad_Dias.ToString();
                        txt_tipohabitacion.Text = reserva.Habitacion.Tipo.Nombre;
                        txt_numero.Text = reserva.Habitacion.Numero.ToString();
                        txt_cantidad.Text = reserva.Cantidad_Huespedes.ToString();


                        factura = gestorFactura.BuscarFactura(numeroFactura);


                        txt_deposito.Text = factura.Deposito.ToString();
                        txt_estadia.Text = factura.Total.ToString();

                        btn_checkin.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("No se encontró una reserva para el día de la fecha", "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }                               
            }
            else
            {
                MessageBox.Show("El número de factura que ingreso es inválido o no existe","Check-In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btn_checkin_Click(object sender, EventArgs e)
        {
            estadia = new BE.Estadia();

            estadia.FacturaReserva = factura;
            estadia.Checkin = reserva.Fecha_Inicio;
            estadia.Checkout = reserva.Fecha_Fin;
            estadia.Habitacion = reserva.Habitacion;
            estadia.Cliente = reserva.Cliente;
            estadia.CantidadHuespedes = reserva.Cantidad_Huespedes;
            estadia.Estado = BE.EnumEstadoEstadia.Activa;
            gestorEstadia.RealizarCheckin(estadia);
            MessageBox.Show("Se registró el checkin del cliente " + estadia.Cliente + "." , "Checkin", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); ;
            ReportarBitacoraAltaCheckin();
            ResetearTextBox();
            btn_checkin.Enabled = false;
        }
    }
}
