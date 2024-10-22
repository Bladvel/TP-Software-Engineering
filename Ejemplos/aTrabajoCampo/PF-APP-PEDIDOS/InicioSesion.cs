using CAPA_ENTIDADES;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_APP_PEDIDOS
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //obtener la instancia del usuario capa de negocio
            CN_Usuario usuario = CN_Usuario.GetInstance();

            //obtener todos los usuarios
            List<Usuario> listaUsuarios = usuario.GetAll();

            Usuario ousuario = listaUsuarios.Where(u => u.NombreUsuario == txtNombreUsu.Text && u.Clave == txtPassword.Text).FirstOrDefault();

            if (ousuario != null)
            {
                Inicio inicio = new Inicio(ousuario);
                inicio.Show();
                this.Hide();

                inicio.FormClosing += frmClosing;
            }
            else
            {
                MessageBox.Show("No se encontro el usuario","Mnesaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

       
        }

         private void frmClosing(object sender, FormClosingEventArgs e)
        {
            txtNombreUsu.Text ="";
            txtPassword.Text = "";
            this.Show();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
