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
    public partial class frmBitacoraEventos : Form
    {

        private static frmBitacoraEventos instancia = null;

        public static frmBitacoraEventos Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmBitacoraEventos();
            }
            return instancia;
        }

        public frmBitacoraEventos()
        {
            InitializeComponent();
            RellenoGrilla();
            RellenarComboBox();           
            CheckedComboBox();
        }

        BLLBitacora gestorBitacora = new BLLBitacora();
        BLLUsuario gestorUsuario = new BLLUsuario();

        private void frmBitacoraEventos_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }


        

        private bool ValidarDateTimePickers(DateTime fi, DateTime ff)
        {
            bool ok = true;           
            if (fi > ff)
            {
                MessageBox.Show("No se puede realizar la busqueda con la 'Fecha de Fin' menor a la 'Fecha de inicio'", "Fechas Incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Stop);              
                ok = false;
            }           
            return ok;
        }
        
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckedComboBox()
        {
            if (checkB_Modulo.Checked == true)
            {
                cb_mod.Enabled = true;
            }
            else
            {
                cb_mod.Enabled = false;
            }

            if (checkB_usuario.Checked == true)
            {
                cb_usuario.Enabled = true;
            }
            else
            {
                cb_usuario.Enabled = false;
            }

            if (checkB_criticidad.Checked == true)
            {
                cb_criticidad.Enabled = true;
            }
            else
            {
                cb_criticidad.Enabled = false;
            }
        }


        private void RellenarComboBox()
        {
            cb_mod.DataSource = null;
            cb_mod.DataSource = Enum.GetValues(typeof(EnumModulo));
            cb_usuario.DataSource = null;
            cb_usuario.DataSource = gestorUsuario.ListarTotal();

            for (int i = 1; i <= 3; i++)
            {
                cb_criticidad.Items.Add(i);
            }
        }

        private void RellenoGrilla()
        {                         
            dgv_registroEventos.DataSource = null;
            dgv_registroEventos.DataSource = gestorBitacora.Listar();            
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            
            if (ValidarDateTimePickers(dateTimePicker_inicio.Value, dateTimePicker_fin.Value))
            {
                if (checkB_Modulo.Checked == false && checkB_usuario.Checked == false && checkB_criticidad.Checked == false)
                {
                    dgv_registroEventos.DataSource = null;
                    dgv_registroEventos.DataSource = gestorBitacora.Filtrar(dateTimePicker_inicio.Value, dateTimePicker_fin.Value);
                }
                else if (checkB_Modulo.Checked == false && checkB_usuario.Checked == true && checkB_criticidad.Checked == false)
                {
                    dgv_registroEventos.DataSource = null;
                    dgv_registroEventos.DataSource = gestorBitacora.Filtrar(dateTimePicker_inicio.Value, dateTimePicker_fin.Value, (Usuario)cb_usuario.SelectedItem);
                }
                else if (checkB_Modulo.Checked == true && checkB_usuario.Checked == false && checkB_criticidad.Checked == false)
                {
                    dgv_registroEventos.DataSource = null;
                    dgv_registroEventos.DataSource = gestorBitacora.Filtrar(dateTimePicker_inicio.Value, dateTimePicker_fin.Value, (EnumModulo)cb_mod.SelectedItem);
                }
                else if (checkB_Modulo.Checked == true && checkB_usuario.Checked == true && checkB_criticidad.Checked == false)
                {
                    dgv_registroEventos.DataSource = null;
                    dgv_registroEventos.DataSource = gestorBitacora.Filtrar(dateTimePicker_inicio.Value, dateTimePicker_fin.Value, (EnumModulo)cb_mod.SelectedItem, (Usuario)cb_usuario.SelectedItem);
                }
                else if (checkB_Modulo.Checked == false && checkB_usuario.Checked == false && checkB_criticidad.Checked == true)
                {
                    dgv_registroEventos.DataSource = null;
                    dgv_registroEventos.DataSource = gestorBitacora.Filtrar(dateTimePicker_inicio.Value, dateTimePicker_fin.Value, (int)cb_criticidad.SelectedItem);
                }
                else if (checkB_Modulo.Checked == false && checkB_usuario.Checked == true && checkB_criticidad.Checked == true)
                {
                    dgv_registroEventos.DataSource = null;
                    dgv_registroEventos.DataSource = gestorBitacora.Filtrar(dateTimePicker_inicio.Value, dateTimePicker_fin.Value, (Usuario)cb_usuario.SelectedItem, (int)cb_criticidad.SelectedItem);
                }
                else if (checkB_Modulo.Checked == true && checkB_usuario.Checked == false && checkB_criticidad.Checked == true)
                {
                    dgv_registroEventos.DataSource = null;
                    dgv_registroEventos.DataSource = gestorBitacora.Filtrar(dateTimePicker_inicio.Value, dateTimePicker_fin.Value, (EnumModulo)cb_mod.SelectedItem, (int)cb_criticidad.SelectedItem);
                }
                else if (checkB_Modulo.Checked == true && checkB_usuario.Checked == true && checkB_criticidad.Checked == true)
                {
                    dgv_registroEventos.DataSource = null;
                    dgv_registroEventos.DataSource = gestorBitacora.Filtrar(dateTimePicker_inicio.Value, dateTimePicker_fin.Value, (EnumModulo)cb_mod.SelectedItem, (Usuario)cb_usuario.SelectedItem, (int)cb_criticidad.SelectedItem);
                }
                 

            }
        }

        private void btn_ListarTotal_Click(object sender, EventArgs e)
        {
            RellenoGrilla();
        }

        private void checkB_usuario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB_usuario.Checked == true)
            {
                cb_usuario.Enabled = true;
            }
            else
            {
                cb_usuario.Enabled = false;
            }
        }

        private void checkB_Modulo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB_Modulo.Checked == true)
            {
                cb_mod.Enabled = true;
            }
            else
            {
                cb_mod.Enabled = false;
            }
        }

        private void checkB_criticidad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB_criticidad.Checked== true)
            {
                cb_criticidad.Enabled = true;
            }
            else
            {
                cb_criticidad.Enabled =false;
            }
        }
    }
}
