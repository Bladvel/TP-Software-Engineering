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
    public partial class frmCheckout : Form
    {

        private static frmCheckout instancia = null;
        
        public static frmCheckout Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmCheckout();
            }
            return instancia;

        }

        public frmCheckout()
        {
            InitializeComponent();
        }

        private BE.Estadia estadia;
        
        private BLL.BLLEstadia gestorEstadia = new BLL.BLLEstadia();

        private Cliente cliente;

        private BLL.BLLCliente gestorCliente = new BLL.BLLCliente();

        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();





        string fecha = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;



        private void IniciarFecha()
        {
            txt_fecha.Text = fecha;
        }


        private void LimpiarTextBox()
        {
            txt_idEstadia.Text = "";
            txt_nombre.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_dni.Text = "";
            txt_checkin.Text = "";
            txt_checkout.Text = "";
            txt_cantHuespedes.Text = "";
            txt_estado.Text = "";


        }



        private void frmCheckout_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void ReportarBitacoraAltaCheckout()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Checkout;
            registroBitacora.Operacion = EnumOperacion.Alta;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

       


        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_dniConsulta.Text))
            {
                MessageBox.Show("Para poder realizar el checkout debe ingresar el DNI del cliente.","Checkout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (gestorCliente.VerificarClienteExistente(int.Parse(txt_dniConsulta.Text)))
                {
                    estadia = new BE.Estadia();
                    cliente = new Cliente();
                    cliente = gestorCliente.BuscarIdCliente(int.Parse(txt_dniConsulta.Text));

                    if (gestorEstadia.ValidarCliente(cliente))
                    {
                        estadia = gestorEstadia.BuscarEstadia(cliente);
                        txt_idEstadia.Text = estadia.Id.ToString();
                        txt_nombre.Text = estadia.Cliente.Id.ToString();
                        txt_nombre.Text = estadia.Cliente.Nombre;
                        txt_apellido.Text = estadia.Cliente.Apellido;
                        txt_dni.Text = estadia.Cliente.Dni.ToString();

                        DateTime fechaTMP1 = estadia.Checkin;
                        DateTime fechaTMP2 = estadia.Checkout;

                        txt_checkin.Text = fechaTMP1.Day + "/" + fechaTMP1.Month + "/" + fechaTMP2.Year;
                        txt_checkout.Text = fechaTMP2.Day + "/" + fechaTMP2.Month + "/" + fechaTMP2.Year;

                        txt_cantHuespedes.Text = estadia.CantidadHuespedes.ToString();
                        txt_estado.Text = estadia.Estado.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El cliente " + cliente.Nombre + " " + cliente.Apellido + " DNI: " + cliente.Dni + " no tiene una estadia activa.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No existe un cliente con ese número de DNI.","Cliente Inexistente", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            IniciarFecha();
        }

        //Para que el textbox acepte solo numeros y pueda usar la tecla borrar
        private void txt_dniConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btn_registrarCheckout_Click(object sender, EventArgs e)
        {
            if (gestorEstadia.VerificarFechaSalida(DateTime.Now, estadia.Checkout))
            {

                Estadia estadiaTMP = new Estadia();
                estadiaTMP = estadia;
                estadiaTMP.Estado = EnumEstadoEstadia.Pendiente_Pago;
                gestorEstadia.RealizarCheckout(estadiaTMP);
                MessageBox.Show("Se realizó correctamente el checkout, el cliente debe dirigirse a la caja a abonar.", "Chekout exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                ReportarBitacoraAltaCheckout();
                LimpiarTextBox();

            }
            else
            {
                var confirmacion = MessageBox.Show("El checkout del cliente no es hoy. ¿Desea continuar?","Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    Estadia estadiaTMP = new Estadia();
                    estadiaTMP = estadia;
                    estadiaTMP.Checkout = DateTime.Now;
                    estadiaTMP.Estado = EnumEstadoEstadia.Pendiente_Pago;
                    gestorEstadia.RealizarCheckoutAntes(estadiaTMP);

                    MessageBox.Show("Se realizó correctamente el checkout, el cliente debe dirigirse a la caja a abonar.","Chekout exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReportarBitacoraAltaCheckout();
                }
                else
                {
                    MessageBox.Show("No se realizó el checkout al cliente.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
