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
using Interfaces;
using Services;
using Services.Multiidioma;

namespace TPRestaurante
{
    public partial class frmLogin : Form, IIdiomaObserver
    {
        BLL.User bllUser;
        public frmLogin()
        {
            InitializeComponent();
            bllUser = new BLL.User();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    user.Username = txtUsername.Text;
                    user.Password = txtPassword.Text;
                    var result = bllUser.Login(user);
                    frmMDI parent = (frmMDI)this.MdiParent;
                    parent.ValidarForm();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor complete los campos");
                    VaciarTextBoxs();
                }

            }
            catch (LoginException ex)
            {
                switch (ex.Result)
                {
                    case LoginResult.InvalidUsername:
                        MessageBox.Show("User incorrecto");
                        break;
                    case LoginResult.InvalidPassword:
                        User userAttempts = bllUser.GetUser(user.Username);
                        MessageBox.Show($"Password Incorrecto\nTe quedan {3 - userAttempts.Attempts} intento/s");
                        break;
                    case LoginResult.BlockedUser:
                        MessageBox.Show("Limite de intentos superados. Ha sido Bloqueado\nContacte a un administrador");
                        break;
                    case LoginResult.AlreadyBlockedUser:
                        MessageBox.Show("User bloqueado");
                        break;
                    default:
                        break;
                }

                VaciarTextBoxs();
            }

           
        }

        public void VaciarTextBoxs()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            User user = new User();
            //user.Username = txtUsername.Text;
            user.Username = CryptoManager.Encrypt(txtUsername.Text);
            user.Password = CryptoManager.Hash(txtPassword.Text);

            bool ok = bllUser.AddUser(user);

            MessageBox.Show(ok.ToString());
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            SessionManager.SuscribirObservador(this);

            if (SessionManager.Instance.IsLoggedIn())
            {
                Traducir(SessionManager.Instance.User.Idioma);
            }
            else
            {
                Traducir();
            }


        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma = null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);

            //Menu sesion
            if (lblIniciarSesion.Tag != null && traducciones.ContainsKey(lblIniciarSesion.Tag.ToString()))
                lblIniciarSesion.Text = traducciones[lblIniciarSesion.Tag.ToString()].Texto;
            if (lblUsername.Tag != null && traducciones.ContainsKey(lblUsername.Tag.ToString()))
                lblUsername.Text = traducciones[lblUsername.Tag.ToString()].Texto;
            if (lblPassword.Tag != null && traducciones.ContainsKey(lblPassword.Tag.ToString()))
                lblPassword.Text = traducciones[lblPassword.Tag.ToString()].Texto;
            if (btnEntrar.Tag != null && traducciones.ContainsKey(btnEntrar.Tag.ToString()))
                btnEntrar.Text = traducciones[btnEntrar.Tag.ToString()].Texto;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }
    }
}
