using System;
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
    public partial class frmCambiarPassword : Form
    {
        public frmCambiarPassword()
        {
            InitializeComponent();
        }



        private void frmCambiarPassword_Load(object sender, EventArgs e)
        {
            HabilitarControles(false);
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
    }
}
