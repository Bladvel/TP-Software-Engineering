using BLL;
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
    public partial class frmRespaldos : Form
    {

        private static frmRespaldos instancia = null;

        public static frmRespaldos Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmRespaldos();
            }
            return instancia;
        }

        public void AjustarFormulario()
        {
            btn_examinar1.Enabled = false;
            btn_GenerarBackUp.Enabled = false;
        }

        private BLLBackupService bcu = new BLLBackupService();
        private BLLBackupService rest = new BLLBackupService();
        string rutaDirectorio = string.Empty;
        string rutaBak = string.Empty;

        public frmRespaldos()
        {
            InitializeComponent();
        }

        private void frmRespaldos_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }


        private bool ValidarValorRutaDirectorio()
        {
            return (!string.IsNullOrWhiteSpace(txt_rutaBackUp.Text));
        }

        private bool ValidarValorRutaArchivo()
        {
            return (!string.IsNullOrWhiteSpace(txt_rutaRestore.Text));
        }

        private void btn_GenerarBackUp_Click(object sender, EventArgs e)
        {
            if (ValidarValorRutaDirectorio())
            {
                string nombreCopia = (DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString() + "-" +
                 DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-Siscab.bak");

                bcu.CreateBackup(rutaDirectorio + "\\" + nombreCopia);
                MessageBox.Show("El backup se generó satisfactoriamente", "Generación de Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_rutaBackUp.Text = "";
                rutaDirectorio = string.Empty;              
            }
            else
            {
                MessageBox.Show("Debe seleccionar un directorio para generar un backup");
            }
            
        }

        private void btn_examinar1_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = fbd.SelectedPath;
            }
            txt_rutaBackUp.Text = rutaDirectorio;
        }

        private void btn_Examinar2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivo BAK|*.bak";
            ofd.Title = "Base de datos restore";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaBak = ofd.FileName;               
            }
            txt_rutaRestore.Text = rutaBak;
       }

        private void btn_ComenzarRestore_Click(object sender, EventArgs e)
        {
            if (ValidarValorRutaArchivo())
            {
                
                
                bcu.RestoresBackup(rutaBak);
                MessageBox.Show("Se ha reestablecido la base de datos", "Restore de Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_rutaRestore.Text = "";
                
                rutaBak = string.Empty;

            }
            else
            {
                MessageBox.Show("Debe seleccionar un archivo para realizar el restore de una base de datos");
            }
        }


    }
}
