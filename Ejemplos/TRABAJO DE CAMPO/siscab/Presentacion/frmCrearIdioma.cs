using Servicios;
using Servicios.Multiidioma;
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
    public partial class frmCrearIdioma : Form
    {

        private static frmCrearIdioma instancia = null;

        public static frmCrearIdioma Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmCrearIdioma();
            }
            return instancia;
        }



        public frmCrearIdioma()
        {
            InitializeComponent();
        }


        BLL.BLLIdioma gestorIdioma = new BLL.BLLIdioma();

        BLL.BLLTraduccion gestorTraduccion = new BLL.BLLTraduccion();



        private void frmCrearIdioma_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void frmCrearIdioma_Load(object sender, EventArgs e)
        {
            cb_idiomas.DataSource = null;
            cb_idiomas.DataSource = gestorIdioma.Listar();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            dgv_traducciones.DataSource = null;
            dgv_traducciones.DataSource = gestorTraduccion.ListarPorIdioma((Idioma)cb_idiomas.SelectedItem);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
