using BE;
using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;
using System.IO;
using System.Text.Json.Serialization;




namespace Presentacion
{
    public partial class frmFacturarReserva : Form
    {

        private static frmFacturarReserva instancia = null;

        public static frmFacturarReserva VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmFacturarReserva();
            }
            return instancia;
            
        }

        public frmFacturarReserva()
        {
            InitializeComponent();
            ValidarPermisos();
        }

        BE.Reserva reserva = new BE.Reserva();
        BLL.BLLReserva gestorReserva = new BLL.BLLReserva();
        BE.Cliente cliente = new BE.Cliente();
        BLL.BLLCliente gestorCliente = new BLL.BLLCliente();
        BE.Habitacion habitacion = new BE.Habitacion();
        BLL.BLLHabitacion gestorHabitacion = new BLL.BLLHabitacion();
        BE.Factura factura;
        BLL.BLLFactura gestorFactura = new BLL.BLLFactura();
        BE.Procesador_Pago procesador;
        BLL.BLLProcesador_Pago gestorProcesador = new BLL.BLLProcesador_Pago();
        BE.Tipo_Tarjeta tipo_tarjeta;
        BLL.BLLTipo_Tarjeta gestorTipoTarjeta = new BLL.BLLTipo_Tarjeta();
        BE.Pago_Deposito pagoDeposito;
        BLL.BLLPago_Deposito gestorPagoDeposito = new BLL.BLLPago_Deposito();
        BE.Banco banco;
        BLL.BLLBanco gestorBanco = new BLL.BLLBanco();
        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();
        DVH dvh = new DVH();
        BLLDVH gestorDVH = new BLLDVH();
        DVV dvv = new DVV();
        BLLDVV gestorDVV = new BLLDVV();

        string concID, concFI, concFF, concCLI, concCD, concHAB, concFA;
        string hashID, hashFI, hashFF, hashCLI, hashCD, hashHAB, hashFA;

        string rutaDirectorio = "";
        string nombreArchivo = "";


        private void ValidarPermisos()
        {
            if (SingletonSesion.Instancia.Usuario.Rol == "Administrador")
            {
                this.btn_serializacion.Visible = true;
            }
            else
            {
                this.btn_serializacion.Visible = false;
            }
        }

        private void frmFacturarReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        void BorrarTextBox()
        {
            txt_fecha.Text = "";
            txt_lugar.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_dni.Text = "";
            txt_domicilio.Text = "";
            txt_telefono_fijo.Text = "";
            txt_telefono_movil.Text = "";
            txt_email.Text = "";
            txt_noches.Text = "";
            txt_precio.Text = "";
            txt_descripcion.Text = "";
            txt_subtotal.Text = "";
            txt_iva.Text = "";
            txt_total.Text = "";
            txt_deposito.Text = "";
        }

        void CargarComboBoxs()
        {
            cb_tarjeta.DataSource = null;
            cb_tarjeta.DataSource = gestorProcesador.Listar();
            cb_tipo.DataSource = null;
            cb_tipo.DataSource = gestorTipoTarjeta.Listar();
            cb_banco.DataSource = null;
            cb_banco.DataSource = gestorBanco.Listar();
        }

        private void frmFacturarReserva_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            DesactivarBotones();

        }

        private void ActualizarGrilla()
        {
            dgv_reservas.DataSource = null;
            dgv_reservas.DataSource = gestorReserva.ListarReservasSinFacturar();
        }

        private void ActivarBotones()
        {
            btn_facturar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void DesactivarBotones()
        {
            btn_facturar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void ReportarBitacoraFacturacionReserva()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.FacturarReserva;
            registroBitacora.Operacion = EnumOperacion.Alta;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }


        private void dgv_reservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reserva = (BE.Reserva)dgv_reservas.Rows[e.RowIndex].DataBoundItem;
            factura = new BE.Factura();
            factura.Cliente = reserva.Cliente;
            factura.Fecha = DateTime.Now;
            factura.Lugar = "Ciudad de San Rafael, MENDOZA";
            factura.Reserva = reserva;
            factura.Subtotal = gestorFactura.ObtenerSubtotal(reserva);
            factura.Iva = gestorFactura.ObtenerIVA(factura.Subtotal);
            factura.Total = gestorFactura.ObtenerTotal(factura.Subtotal, factura.Iva);
            factura.Deposito = gestorFactura.ObtenerDeposito(factura.Total);

            txt_fecha.Text = factura.Fecha.ToString();
            txt_lugar.Text = factura.Lugar;
            txt_nombre.Text = factura.Cliente.Nombre;
            txt_apellido.Text = factura.Cliente.Apellido;
            txt_dni.Text = factura.Cliente.Dni.ToString();
            txt_domicilio.Text = factura.Cliente.Domicilio;
            txt_telefono_fijo.Text = factura.Cliente.Telefono_Fijo;
            txt_telefono_movil.Text = factura.Cliente.Telefono_Movil;
            txt_email.Text = factura.Cliente.Email;
            txt_noches.Text = factura.Reserva.Cantidad_Dias.ToString();
            txt_precio.Text = factura.Reserva.Habitacion.Tipo.Precio.ToString();

            txt_descripcion.Text = "Reserva de una Habitación: " + factura.Reserva.Habitacion.Tipo +
                " - Check-In: " + factura.Reserva.Fecha_Inicio + " - Check-Out: " + factura.Reserva.Fecha_Fin +
                " - Cantidad de Huéspedes: " + factura.Reserva.Cantidad_Huespedes;

            txt_subtotal.Text = "$ " + factura.Subtotal.ToString();
            txt_iva.Text = "$ " + factura.Iva.ToString();
            txt_total.Text = "$ " + factura.Total.ToString();
            txt_deposito.Text = "$ " + factura.Deposito.ToString();

            CargarComboBoxs();
            ActivarBotones();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            factura = null;
            BorrarTextBox();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            factura = null;
            this.Close();
        }

        private bool ValidarDatosTarjeta()
        {
            return (!string.IsNullOrWhiteSpace(txt_numerotarjeta.Text) || !string.IsNullOrWhiteSpace(txt_codigo.Text));
        }





        private void btn_facturar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosTarjeta())
            {
                try
                {
                    gestorFactura.Insertar(factura);
                    factura.Numero = gestorFactura.GenerarNumero(factura.Fecha, factura.Id);
                    gestorFactura.Modificar(factura);
                    reserva.Facturada = "Si";
                    gestorReserva.Modificar(reserva);


                    //Aca hay que trabajar bien
                    ProcesoDigitoVerificadorHorizontal(reserva);

                    ProcesoDigitoVerificadorVertical();


                    pagoDeposito = new BE.Pago_Deposito();
                    tipo_tarjeta = new BE.Tipo_Tarjeta();
                    procesador = new BE.Procesador_Pago();

                    procesador = (BE.Procesador_Pago)cb_tarjeta.SelectedItem;
                    tipo_tarjeta = (BE.Tipo_Tarjeta)cb_tipo.SelectedItem;
                    banco = (BE.Banco)cb_banco.SelectedItem;

                    pagoDeposito.Tipo = tipo_tarjeta;
                    pagoDeposito.Procesador = procesador;
                    pagoDeposito.Banco = banco;
                    pagoDeposito.Numero = long.Parse(txt_numerotarjeta.Text);
                    pagoDeposito.Codigo = int.Parse(txt_codigo.Text);
                    pagoDeposito.Vencimiento = datetimerVencimiento.Value;


                    pagoDeposito.Cuotas = int.Parse(txt_cuotas.Text);

                    pagoDeposito.Factura = factura;
                    gestorPagoDeposito.Insertar(pagoDeposito);


                    //ACA TENGO QUE HACER UNA SERIALIZACION AUTOMATICA


                    Serializar(factura);

                    //ACA TERMINA



                    ReportarBitacoraFacturacionReserva();

                    BorrarTextBox();
                    DesactivarBotones();
                    ActualizarGrilla();
                    MessageBox.Show("¡Facturación exitosa!", "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Formato: " + ex.Source, "Formato incorrecto en el método de pago", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }

            }
            else
            {
                MessageBox.Show("Complete los datos de la tarjeta", "Método de Pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Serializar (BE.Factura factura)
        {
            string cadenaJson = JsonSerializer.Serialize(factura);           
            rutaDirectorio = @"serializacionRollBack\";


            nombreArchivo = (DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString() + "-" +
             DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-Factura_ReservaJSON.json");

            File.WriteAllText(rutaDirectorio + "\\" + nombreArchivo, cadenaJson);
            

        }


        public void ProcesoDigitoVerificadorVertical()
        {
            List<Reserva> reservasTMP = new List<Reserva>();
            reservasTMP = gestorReserva.Listar();

            for (int i = 0; i < reservasTMP.Count; i++)
            {
                concID += reservasTMP[i].Id;
                concFI += reservasTMP[i].Fecha_Inicio;
                concFF += reservasTMP[i].Fecha_Fin;
                concCLI += reservasTMP[i].Cliente.Id;
                concCD += reservasTMP[i].Cantidad_Dias;
                concHAB += reservasTMP[i].Habitacion.Id;
                concFA += reservasTMP[i].Facturada;
            }

            hashID = gestorDVV.ObtenerDigitoVerificador(concID);
            hashFI = gestorDVV.ObtenerDigitoVerificador(concFI);
            hashFF = gestorDVV.ObtenerDigitoVerificador(concFF);
            hashCLI = gestorDVV.ObtenerDigitoVerificador(concCLI);
            hashCD = gestorDVV.ObtenerDigitoVerificador(concCD);
            hashHAB = gestorDVV.ObtenerDigitoVerificador(concHAB);
            hashFA = gestorDVV.ObtenerDigitoVerificador(concFA);

            dvv.Modulo = "Reserva";
            dvv.Columna = 1;
            dvv.DV = hashID;
            gestorDVV.ActualizarDigitoVerificador(dvv);

            dvv.Modulo = "Reserva";
            dvv.Columna = 2;
            dvv.DV = hashFI;
            gestorDVV.ActualizarDigitoVerificador(dvv);

            dvv.Modulo = "Reserva";
            dvv.Columna = 3;
            dvv.DV = hashFF;
            gestorDVV.ActualizarDigitoVerificador(dvv);

            dvv.Modulo = "Reserva";
            dvv.Columna = 4;
            dvv.DV = hashCLI;
            gestorDVV.ActualizarDigitoVerificador(dvv);

            dvv.Modulo = "Reserva";
            dvv.Columna = 5;
            dvv.DV = hashCD;
            gestorDVV.Insertar(dvv);

            dvv.Modulo = "Reserva";
            dvv.Columna = 6;
            dvv.DV = hashHAB;
            gestorDVV.ActualizarDigitoVerificador(dvv);

            dvv.Modulo = "Reserva";
            dvv.Columna = 7;
            dvv.DV = hashFA;
            gestorDVV.ActualizarDigitoVerificador(dvv);

        }


        private string ConcatenarRegistro(Reserva reserva)
        {
            //int idclienteTMP = reserva.Cliente.Id;
            //int idhabitacionTMP = reserva.Habitacion.Id;
            //string fechaInicioTMP = reserva.Fecha_Inicio.Year + "/" + reserva.Fecha_Inicio.Month + "/" + reserva.Fecha_Inicio.Day + " 00:00:00:000";
            //string fechaFin = reserva.Fecha_Fin.Year + "/" + reserva.Fecha_Fin.Month + "/" + reserva.Fecha_Fin.Day + " 00:00:00:000";

            var concatenacion = string.Concat(Convert.ToString(reserva.Id) + Convert.ToString(reserva.Fecha_Inicio) +
                 Convert.ToString(reserva.Fecha_Fin) + Convert.ToString(reserva.Cliente.Id) + Convert.ToString(reserva.Habitacion.Id) +
                Convert.ToString(reserva.Cantidad_Huespedes) + Convert.ToString(reserva.Cantidad_Dias) + Convert.ToString(reserva.Facturada));

            return concatenacion;
        }

        private void ProcesoDigitoVerificadorHorizontal(Reserva reserva)
        {
            string cadena = ConcatenarRegistro(reserva);
            dvh.Modulo = "Reserva";
            dvh.Registro = reserva.Id;
            dvh.DV = gestorDVH.ObtenerDigitoVerificador(cadena);
            gestorDVH.ActualizarDigitoVerificador(dvh);
        }



        private void cb_tipo_SelectedValueChanged(object sender, EventArgs e)
        {
            BE.Tipo_Tarjeta tipoTMP = new BE.Tipo_Tarjeta();
            tipoTMP = (BE.Tipo_Tarjeta)cb_tipo.SelectedItem;

            if (tipoTMP.Tipo == "Débito")
            {
                txt_cuotas.Enabled = false;
                txt_cuotas.Text = "0";
            }
            else
            {
                txt_cuotas.Enabled = true;
                txt_cuotas.Text = "";
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

        private void btn_serializacion_Click(object sender, EventArgs e)
        {
            frmSerializacionFactura frm = frmSerializacionFactura.VentanaUnica();
            frm.Show();
            frm.BringToFront();
        }
    }
}
