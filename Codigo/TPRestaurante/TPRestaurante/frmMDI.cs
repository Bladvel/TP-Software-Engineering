using Services;
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
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.MdiParent = this;
            formLogin.Show();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            ValidarForm();
        }

        public void ValidarForm()
        {
            if(SessionManager.Instance.IsLoggedIn())
            {
                toolStripStatusLabel1.Text = SessionManager.Instance.User.Username;
            }else
            {
                toolStripStatusLabel1.Text = "Sesion no iniciada";
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
