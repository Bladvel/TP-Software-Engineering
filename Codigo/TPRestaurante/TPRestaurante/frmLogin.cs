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
            try
            {
                
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                var result = bllUsuario.Login(user);
                frmMDI parent = (frmMDI)this.MdiParent;
                parent.ValidarForm();
                this.Close();
            }
            catch (LoginException ex)
            {
                switch (ex.Result)
                {
                    case LoginResult.InvalidUsername:
                        MessageBox.Show("Usuario incorrecto");
                        break;
                    case LoginResult.InvalidPassword:
                        Usuario userAttempts = bllUsuario.ObtenerUsuario(user.Username);
                        MessageBox.Show($"Password Incorrecto\nTe quedan {3 - userAttempts.Attempts} intento/s");
                        break;
                    case LoginResult.BlockedUser:
                        MessageBox.Show("Limite de intentos superados. Ha sido Bloqueado\nContacte a un administrador");
                        break;
                    case LoginResult.AlreadyBlockedUser:
                        MessageBox.Show("Usuario bloqueado");
                        break;
                    default:
                        break;
                }
            }

           
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            //user.Username = txtUsername.Text;
            user.Username = CryptoManager.Encrypt(txtUsername.Text);
            user.Password = CryptoManager.Hash(txtPassword.Text);

            bool ok = bllUsuario.AgregarUsuario(user);

            MessageBox.Show(ok.ToString());
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
