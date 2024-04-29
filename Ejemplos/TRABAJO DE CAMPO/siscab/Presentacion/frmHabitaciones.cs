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
    public partial class frmHabitaciones : Form
    {

        private static frmHabitaciones instancia = null;

        public static frmHabitaciones Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmHabitaciones();
            }
            return instancia;
        }

        
        public frmHabitaciones()
        {
            InitializeComponent();
        }

        private void frmHabitaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }


        BE.Habitacion habitacion = new BE.Habitacion();
        BLL.BLLHabitacion gestor = new BLL.BLLHabitacion();      
        BLL.BLLTipo_Habitacion gestorTH = new BLL.BLLTipo_Habitacion();
        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();


        void EnlazarTotal()
        {
            dgv_habitaciones.DataSource = null;
            List<BE.Habitacion> habitaciones = gestor.ListarTotal();
            dgv_habitaciones.DataSource = habitaciones;
            lbl_total.Text = "Total Habitaciones: " + habitaciones.Count;
            
        }

        void EnlazarSimple()
        {
            dgv_habitaciones.DataSource = null;
            List<BE.Habitacion> habitaciones = gestor.ListarSimples();
            dgv_habitaciones.DataSource = habitaciones;
            lbl_total.Text = "Total Habitaciones: " + habitaciones.Count;

        }
        void EnlazarDobles()
        {
            dgv_habitaciones.DataSource = null;
            List<BE.Habitacion> habitaciones = gestor.ListarDobles();
            dgv_habitaciones.DataSource = habitaciones;
            lbl_total.Text = "Total Habitaciones: " + habitaciones.Count;

        }

        void EnlazarTriple()
        {
            dgv_habitaciones.DataSource = null;
            List<BE.Habitacion> habitaciones = gestor.ListarTriples();
            dgv_habitaciones.DataSource = habitaciones;
            lbl_total.Text = "Total Habitaciones: " + habitaciones.Count;

        }

        void EnlazarCuadruple()
        {
            dgv_habitaciones.DataSource = null;
            List<BE.Habitacion> habitaciones = gestor.ListarCuadruples();
            dgv_habitaciones.DataSource = habitaciones;
            lbl_total.Text = "Total Habitaciones: " + habitaciones.Count;
        }

        void RellenarComboBox()
        {          
            List<BE.Tipo_Habitacion> tiposHabitaciones = gestorTH.Listar();
            cmb_tipo.DataSource = tiposHabitaciones;
        }


        private void ReportarBitacoraModificarPrecio()
        { 
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Habitaciones;
            registroBitacora.Operacion = EnumOperacion.Modificacion;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

        private void dgv_habitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            habitacion = (BE.Habitacion)dgv_habitaciones.Rows[e.RowIndex].DataBoundItem;
            lbl_precio.Text = "Precio $: " + habitacion.Tipo.Precio;
            lbl_cantidad.Text = "Huéspedes máximos que puede albergar: " + habitacion.Tipo.Huespedes_Maximo;
        }


        private void btn_listar_Click(object sender, EventArgs e)
        {
            LimpiarLabels();
            EnlazarTotal();
        }
        private void btn_simples_Click(object sender, EventArgs e)
        {
            LimpiarLabels();
            EnlazarSimple();
        }

        private void btn_dobles_Click(object sender, EventArgs e)
        {
            LimpiarLabels();
            EnlazarDobles();
        }

        private void btn_triples_Click(object sender, EventArgs e)
        {
            LimpiarLabels();
            EnlazarTriple();
        }

        private void btn_cuadruples_Click(object sender, EventArgs e)
        {
            LimpiarLabels();
            EnlazarCuadruple();
        }


        void LimpiarLabels()
        {
            lbl_precio.Text = "";
            lbl_cantidad.Text = "";
            lbl_total.Text = "";
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            
            
            dgv_habitaciones.DataSource = null;
            txt_precioTipoHab.Enabled = true;                     
            RellenarComboBox();
            btn_iniciar.Enabled = false;
            btn_modificar.Enabled = true;
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tipo_Habitacion th = new Tipo_Habitacion();
            th = (BE.Tipo_Habitacion)cmb_tipo.SelectedItem;
            txt_precioTipoHab.Text = Convert.ToString(th.Precio);
            lbl_mensaje.Text = "";
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Tipo_Habitacion th = new Tipo_Habitacion();
            th = (BE.Tipo_Habitacion)cmb_tipo.SelectedItem;
            th.Precio = float.Parse(txt_precioTipoHab.Text);
            gestorTH.Grabar(th);
            btn_iniciar.Enabled = true;
            btn_modificar.Enabled = false;
            lbl_mensaje.Text = "Usted edito el precio del tipo de habitación: " + th.Nombre + " a $" + th.Precio;
            ReportarBitacoraModificarPrecio();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
