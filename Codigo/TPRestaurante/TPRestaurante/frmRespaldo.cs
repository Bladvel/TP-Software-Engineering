using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPRestaurante
{
    public partial class frmRespaldo : Form
    {
        public frmRespaldo()
        {
            InitializeComponent();
            bllBackup = new BLL.Backup();
        }

        //private string rutaDirectorio;
        private BLL.Backup bllBackup;

        private void btnExaminarBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtRutaBackup.Text = fbd.SelectedPath;
            }
            
        }

        private void frmRespaldo_Load(object sender, EventArgs e)
        {
            txtRutaBackup.Enabled = false;
            txtRutaRestore.Enabled = false;
        }

        private void btnGenerarBackup_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtRutaBackup.Text))
            {
                MessageBox.Show("Debe seleccionar una ruta para guardar el respaldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ruta = txtRutaBackup.Text + "\\TPRestaurante_" + DateTime.Now.ToString("ddMMyyyy_HHmm") + ".bak";
                
                if (bllBackup.CreateBackup(ruta) == 1)
                {
                    MessageBox.Show("Respaldo realizado con éxito", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRutaBackup.Text = "";
                }
                else
                {
                    MessageBox.Show("Error al realizar el respaldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnComenzarRestore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRutaRestore.Text))
            {
                MessageBox.Show("Debe seleccionar un archivo de respaldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                bllBackup.RestoreBackup(txtRutaRestore.Text);

                MessageBox.Show("Restauración realizada con éxito", "Restauración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRutaRestore.Text = "";
            }
        }

        private void btnExaminarRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivo BAK|*.bak";
            ofd.Title = "Base de datos restore";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRutaRestore.Text = ofd.FileName;
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
