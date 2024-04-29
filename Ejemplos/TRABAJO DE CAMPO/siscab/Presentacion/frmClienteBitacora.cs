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
    public partial class frmClienteBitacora : Form
    {
        private static frmClienteBitacora instancia = null;

        public static frmClienteBitacora Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmClienteBitacora();
            }
            return instancia;
        }



        public frmClienteBitacora()
        {
            InitializeComponent();
            RellenarGrillaCompleta();  
        }

        ClienteBitacora clienteBIT =null;
        BLLClienteBitacora gestorClienteBIT = new BLLClienteBitacora();



        private bool ValidarDateTimePickers(DateTime fi, DateTime ff)
        {
            bool ok = true;
            if (fi > ff)
            {
                MessageBox.Show("No se puede realizar la busqueda con la 'Fecha hasta' menor a la 'Fecha desde'", "Fechas Incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ok = false;
            }
            return ok;
        }


        private void RellenarGrillaCompleta()
        {
            dgv_clientesBIT.DataSource = null;
            dgv_clientesBIT.DataSource = gestorClienteBIT.Listar();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClienteBitacora_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            if (ValidarDateTimePickers(dateTimePicker_Desde.Value, dateTimePicker_Hasta.Value))
            {
                dgv_clientesBIT.DataSource = null;
                dgv_clientesBIT.DataSource = gestorClienteBIT.FiltrarPorFechas(dateTimePicker_Desde.Value, dateTimePicker_Hasta.Value);

            }                
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_dni.Text))
            {
                MessageBox.Show("Para poder realizar una consulta debe ingresar un número de DNI.", "Consulta fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int dni;
                dni = int.Parse(txt_dni.Text);
                dgv_clientesBIT.DataSource = null;
                dgv_clientesBIT.DataSource = gestorClienteBIT.ConsultarDNI(dni);
            }           
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btn_marcar_Click(object sender, EventArgs e)
        {
            if (clienteBIT != null)
            {
                if (gestorClienteBIT.VerificarRegistroActivo(clienteBIT))
                {
                    MessageBox.Show("No se puede reactivar un registro que ya se encuentra activo (Activo = 1)", "Activación fallida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {                   
                   gestorClienteBIT.Desactivar(clienteBIT.Dni);
                   gestorClienteBIT.Reactivar(clienteBIT);

                   gestorClienteBIT.RestaurarCambiosTablaCliente(clienteBIT);
                   MessageBox.Show("Restauración exitosa", "Restauración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   dgv_clientesBIT.DataSource = null;
                   dgv_clientesBIT.DataSource = gestorClienteBIT.Listar();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro de la grilla para realizar la operación", "Activación fallida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgv_clientesBIT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clienteBIT = (ClienteBitacora)dgv_clientesBIT.Rows[e.RowIndex].DataBoundItem;
        }
    }
}
