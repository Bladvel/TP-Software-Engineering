using System;
using BE;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace TPRestaurante
{
    public partial class frmLogin : Form
    {
        BLL.Usuario bllUsuario;
        public frmLogin()
        {
            InitializeComponent();
            bllUsuario = new BLL.Usuario();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            string result = bllUsuario.Login(user);
            MessageBox.Show(result);
            frmMDI parent = (frmMDI)this.MdiParent;
            parent.ValidarForm();
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Username = txtUsername.Text;
            user.Password = CryptoManager.Hash(txtPassword.Text);

            bool ok = bllUsuario.AgregarUsuario(user);

            MessageBox.Show(ok.ToString());
        }
    }
}
