using BE;
using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmReserva : Form
    {       
        private static frmReserva instancia = null;

        public static frmReserva VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmReserva();
            }
            return instancia;
        }

        public frmReserva()
        {
            InitializeComponent();
            ValidarPermisos();
        }

        BE.Cliente cliente= new BE.Cliente();
        BLL.BLLCliente gestorCliente = new BLL.BLLCliente();
        BE.Habitacion habitacion = new BE.Habitacion();
        BLL.BLLHabitacion gestorHabitacion = new BLL.BLLHabitacion();      
        BE.Reserva reserva = new BE.Reserva();
        BLL.BLLReserva gestorReservas = new BLL.BLLReserva();
        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();
        DVH dvh = new DVH();
        BLLDVH gestorDVH = new BLLDVH();
        DVV dvv = new DVV();
        BLLDVV gestorDVV = new BLLDVV();

        string concID, concFI, concFF, concCLI, concCD, concHAB, concFA;
        string hashID, hashFI, hashFF, hashCLI, hashCD, hashHAB, hashFA;



        private void frmReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            EstadoInicialControles();

        }

        private void ValidarPermisos()
        {

            if (SingletonSesion.Instancia.Usuario.Rol == "Administrador")
            {                
                this.btn_serializacion.Visible = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorUsuario);
            }
            else
            {
                this.btn_serializacion.Visible = false;
            }
        }


        void EstadoInicialControles()
        {
            cb_Huspedes.DataSource = null;
            RellenarComboBoxHuspedes();
            IniciarDateTimePickers();
            InicializarLabelsInforacion();
            dgv_habDisp.Enabled = true;
            dgv_habDisp.DataSource = null;
            dateTimeEntrada.Enabled = true;
            dateTimeSalida.Enabled = true;           
            lbl_numero.Enabled = true;
            lbl_tipo.Enabled = true;
            lbl_precio.Enabled = true;
            lbl_cant_noche.Enabled = true;
            lbl_total_estadia.Enabled = true;            
            txt_dni.Enabled = false;
            txt_dni.Text = "";
            btn_buscar_alojamiento.Enabled = true;
            btn_iniciarFacturacion.Enabled = false;
            btn_iniciar_reserva.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_crearCliente.Visible = false;
        }

        void IniciarDateTimePickers()
        {
            dateTimeEntrada.MinDate = DateTime.Now;
            dateTimeEntrada.Value = DateTime.Now;                    
            dateTimeSalida.Value = dateTimeEntrada.Value.AddDays(1);
        }

        bool ValidarDateTimePickers(DateTime fi, DateTime ff)
        {
            bool ok = true;
            int periodo = (ff - fi).Days;            
            if (fi > ff)
            {
                MessageBox.Show("La fecha de salida no debe ser menor que la fecha de entrada","Fechas Incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                IniciarDateTimePickers();
                ok = false;
            }
            if (periodo > 90)
            {
                MessageBox.Show("El período no debe superar a 90 días","Fechas incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Stop);               
                IniciarDateTimePickers();
                ok=false;
            }
            return ok;
        }

        void RellenarComboBoxHuspedes()
        {
            for (int i = 1; i < 5; i++)
            {
                cb_Huspedes.Items.Add(i);
            }
        }


  
        void DesactivarControles()
        {
            dateTimeEntrada.Enabled = false;
            dateTimeSalida.Enabled = false;
            dgv_habDisp.Enabled = false;
            lbl_numero.Enabled = false;
            lbl_tipo.Enabled = false;
            lbl_precio.Enabled = false;
            lbl_cant_noche.Enabled = false;
            lbl_total_estadia.Enabled = false;
            btn_buscar_alojamiento.Enabled = false;
        }

       

        void InicializarLabelsInforacion()
        {
            lbl_numero.Text = "Número de habitación: No se ha seleccionado";
            lbl_tipo.Text = "Tipo de habitación: No se ha seleccionado";
            lbl_precio.Text = "Precio por noche: No se ha seleccionado ";
            lbl_cant_noche.Text = "Cantidad de noches: No se ha seleccionado";
            lbl_total_estadia.Text = "Total de la estadía: No se ha seleccionado ";
        }

        private void ReportarBitacoraAltaReserva()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Reserva;
            registroBitacora.Operacion = EnumOperacion.Alta;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }


        private void btn_buscar_alojamiento_Click(object sender, EventArgs e)
        {           
            if (ValidarDateTimePickers(dateTimeEntrada.Value, dateTimeSalida.Value))
            {                                               
                    List<Habitacion> habitaciones = new List<Habitacion>();
                    reserva = new BE.Reserva();
                    reserva.Fecha_Inicio = dateTimeEntrada.Value.Date;
                    reserva.Fecha_Fin = dateTimeSalida.Value.Date;                    
                    if (cb_Huspedes.SelectedIndex == 0)
                    {
                        habitaciones = gestorHabitacion.ListarSimples();
                    }
                    else if (cb_Huspedes.SelectedIndex == 1)
                    {
                        habitaciones = gestorHabitacion.ListarDobles();

                    }
                    else if (cb_Huspedes.SelectedIndex == 2)
                    {
                        habitaciones = gestorHabitacion.ListarTriples();
                    }
                    else if (cb_Huspedes.SelectedIndex == 3)
                    {
                        habitaciones = gestorHabitacion.ListarCuadruples();
                    }

                    habitaciones = gestorReservas.VerificarDisponibilidad(habitaciones, reserva.Fecha_Inicio, reserva.Fecha_Fin, cb_Huspedes.SelectedIndex + 1);
                    dgv_habDisp.DataSource = null;
                    dgv_habDisp.DataSource = habitaciones;
                    InicializarLabelsInforacion();                                
            }
        }

       
        private void dgv_habDisp_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            habitacion = (BE.Habitacion)dgv_habDisp.Rows[e.RowIndex].DataBoundItem;           
            gestorReservas.CalcularCantidadDias(reserva);
            float totalTMP = reserva.Cantidad_Dias * habitacion.Tipo.Precio;
            lbl_numero.Text = "Número de habitación: " + habitacion.Numero.ToString();
            lbl_tipo.Text = "Tipo de habitación: " + habitacion.Tipo.ToString();
            lbl_precio.Text = "Precio por noche: $ " + habitacion.Tipo.Precio.ToString();            
            lbl_cant_noche.Text = "Cantidad de noches: " +  reserva.Cantidad_Dias.ToString();           
            lbl_total_estadia.Text = "Total de la estadía: $ " + totalTMP.ToString();
            btn_iniciar_reserva.Enabled = true;
            reserva.Cantidad_Huespedes = habitacion.Tipo.Huespedes_Maximo;
            reserva.Habitacion = habitacion;
           
        }   

        private void btn_iniciar_reserva_Click(object sender, EventArgs e)
        {
            DesactivarControles();            
            txt_dni.Enabled = true;
            btn_iniciarFacturacion.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            EstadoInicialControles();                       
        }

        private void btn_iniciarFacturacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_dni.Text))
            {
                MessageBox.Show("Complete los datos del cliente");
            }
            else
            {
                try
                {
                    cliente.Dni = int.Parse(txt_dni.Text);
                    if (gestorCliente.VerificarClienteExistente(cliente.Dni))
                    {
                        reserva.Cliente = gestorCliente.BuscarIdCliente(cliente.Dni);
                        reserva.Facturada = "No";
                        gestorReservas.Insertar(reserva);
                        MessageBox.Show("La reserva se generó correctamente", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EstadoInicialControles();
                        ReportarBitacoraAltaReserva();
                                                                       
                        ProcesoDigitoVerificadorHorizontal(reserva);
                        ProcesoDigitoVerificadorVertical();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("El cliente no existe, debe registrarlo en el sistema para continuar", "Cliente no existente", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        btn_crearCliente.Visible = true;
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Formato: " + ex.Source, "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                                    
            }
        }

        //HAY QUE SEGUIR ACA
        public void ProcesoDigitoVerificadorVertical()
        {
            List<Reserva> reservasTMP = new List<Reserva>();            
            reservasTMP = gestorReservas.Listar();
                     
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

            if (reservasTMP.Count > 1)
            {
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
                gestorDVV.ActualizarDigitoVerificador(dvv);

                dvv.Modulo = "Reserva";
                dvv.Columna = 6;
                dvv.DV = hashHAB;
                gestorDVV.ActualizarDigitoVerificador(dvv);

                dvv.Modulo = "Reserva";
                dvv.Columna = 7;
                dvv.DV = hashFA;
                gestorDVV.ActualizarDigitoVerificador(dvv);
            }
            else
            {
                dvv.Modulo = "Reserva";
                dvv.Columna = 1;
                dvv.DV = hashID;
                gestorDVV.Insertar(dvv);

                dvv.Modulo = "Reserva";
                dvv.Columna = 2;
                dvv.DV = hashFI;
                gestorDVV.Insertar(dvv);

                dvv.Modulo = "Reserva";
                dvv.Columna = 3;
                dvv.DV = hashFF;
                gestorDVV.Insertar(dvv);

                dvv.Modulo = "Reserva";
                dvv.Columna = 4;
                dvv.DV = hashCLI;
                gestorDVV.Insertar(dvv);

                dvv.Modulo = "Reserva";
                dvv.Columna = 5;
                dvv.DV = hashCD;
                gestorDVV.Insertar(dvv);

                dvv.Modulo = "Reserva";
                dvv.Columna = 6;
                dvv.DV = hashHAB;
                gestorDVV.Insertar(dvv);

                dvv.Modulo = "Reserva";
                dvv.Columna = 7;
                dvv.DV = hashFA;
                gestorDVV.Insertar(dvv);
            }                    
        }
             
        private void ProcesoDigitoVerificadorHorizontal(Reserva reserva)
        {
            string cadena = gestorDVH.ConcatenarRegistro(reserva);
            dvh.Modulo = "Reserva";
            dvh.Registro = reserva.Id;
            dvh.DV = gestorDVH.ObtenerDigitoVerificador(cadena);
            gestorDVH.Insertar(dvh);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_crearCliente_Click(object sender, EventArgs e)
        {
            frmClientes frm = frmClientes.Ventana_Unica();
            frm.Show();
            frm.BringToFront();
            frm.AjustarFormulario();
                                
        }

        private void btn_serializacion_Click(object sender, EventArgs e)
        {
            frmSerializacion frm = frmSerializacion.VentanaUnica();
            frm.Show();
            frm.BringToFront();            
        }


        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
           
        }
    }
}
