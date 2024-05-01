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
            bllUsuario = new BLL.Usuario();
        }

        BLL.Usuario bllUsuario;

        private void frmMDI_Load(object sender, EventArgs e)
        {
            ValidarForm();
        }

        public void ValidarForm()
        {
            itemCerrarSesión.Enabled = SessionManager.Instance.IsLoggedIn();
            //menuAdmin.Enabled = SessionManager.Instance.IsLoggedIn();
            
            
            itemIniciarSesión.Enabled= !SessionManager.Instance.IsLoggedIn();


            if(SessionManager.Instance.IsLoggedIn())
            {
                toolStripStatusLabel1.Text = SessionManager.Instance.User.Username;
            }else
            {
                toolStripStatusLabel1.Text = "Sesion no iniciada";
            }
        }

        private void itemCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro?", "Confirme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllUsuario.Logout();
                ValidarForm();
            }
        }


        private void itemIniciarSesion_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.MdiParent = this;
            formLogin.Show();
        }

        private void itemGestorUsuarios_Click(object sender, EventArgs e)
        {
            frmManageUsers formUsers = new frmManageUsers();
            formUsers.MdiParent = this;
            formUsers.Show();
        }
    }
}
