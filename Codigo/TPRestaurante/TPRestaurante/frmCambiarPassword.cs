using System;
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

namespace TPRestaurante
{
    public partial class frmCambiarPassword : Form, IIdiomaObserver
    {
        public frmCambiarPassword()
        {
            InitializeComponent();
        }



        private void frmCambiarPassword_Load(object sender, EventArgs e)
        {
            HabilitarControles(false);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        BLL.User bllUser = new BLL.User();

        private void btnIngresarPassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtContraseñaVieja.Text))
            {
                var user = SessionManager.Instance.User as BE.User;
                if (bllUser.VerifyUser(user, txtContraseñaVieja.Text))
                {
                    HabilitarControles(true);


                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                    txtContraseñaVieja.Text = String.Empty;
                }

            }
            else
            {
                MessageBox.Show("Por favor ingrese su contraseña actual");
            }
        }


        private void RegistrarBitacoraCambiarContraseña()
        {
            var user = SessionManager.Instance.User;
            var logEntry = new Services.Bitacora
            {
                Usuario = user,
                Fecha = DateTime.Now,
                Modulo = TipoModulo.Sesion,
                Operacion = TipoOperacion.CambiarContraseña,
                Criticidad = 3
            };

            BLL.Bitacora bllBitacora = new BLL.Bitacora();
            bllBitacora.Insertar(logEntry);
        }


        private void btnCambiar_Click(object sender, EventArgs e)
        {
            var password1 = txtNuevaContraseña1.Text;
            var password2 = txtNuevaContraseña2.Text;
            int resultado = -1;
            if (!string.IsNullOrWhiteSpace(password1) && !string.IsNullOrWhiteSpace(password2))
            {

                if (password1.Equals(password2))
                {
                    var user = SessionManager.Instance.User as BE.User;
                    resultado = bllUser.ChangePassword(user, password1);
                    RegistrarBitacoraCambiarContraseña();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    txtNuevaContraseña1.Text = String.Empty;
                    txtNuevaContraseña2.Text = String.Empty;
                }


            }
            else
            {
                MessageBox.Show("Por favor introduzca la contraseña nueva en ambos campos");
            }

            if (resultado > 0)
            {
                MessageBox.Show("La contraseña se cambio exitosamente");
                Close();
            }
            else
            {
                MessageBox.Show("No se pudo cambiar la contraseña");
            }


        }




        public void HabilitarControles(bool habilitar)
        {
            
            //Controles de abajo
            lblNueva1.Visible = habilitar;
            lblNueva2.Visible = habilitar;
            txtNuevaContraseña1.Visible = habilitar;
            txtNuevaContraseña2.Visible = habilitar;
            btnCambiar.Visible = habilitar;

            //Controles de arriba
            lblVieja.Visible = !habilitar;
            txtContraseñaVieja.Visible = !habilitar;
            btnIngresarPassword.Visible = !habilitar;
        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma = null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);

            //Menu sesion
            if (lblVieja.Tag != null && traducciones.ContainsKey(lblVieja.Tag.ToString()))
                lblVieja.Text = traducciones[lblVieja.Tag.ToString()].Texto;
            if (lblNueva1.Tag != null && traducciones.ContainsKey(lblNueva1.Tag.ToString()))
                lblNueva1.Text = traducciones[lblNueva1.Tag.ToString()].Texto;
            if (lblNueva2.Tag != null && traducciones.ContainsKey(lblNueva2.Tag.ToString()))
                lblNueva2.Text = traducciones[lblNueva2.Tag.ToString()].Texto;
            if (btnCambiar.Tag != null && traducciones.ContainsKey(btnCambiar.Tag.ToString()))
                btnCambiar.Text = traducciones[btnCambiar.Tag.ToString()].Texto;
            if (btnIngresarPassword.Tag != null && traducciones.ContainsKey(btnIngresarPassword.Tag.ToString()))
                btnIngresarPassword.Text = traducciones[btnIngresarPassword.Tag.ToString()].Texto;
            if (btnCancelar.Tag != null && traducciones.ContainsKey(btnCancelar.Tag.ToString()))
                btnCancelar.Text = traducciones[btnCancelar.Tag.ToString()].Texto;
        }

        private void frmCambiarPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }
    }
}
