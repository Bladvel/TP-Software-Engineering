using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCTD2020.ArquitecturaCapasV2.BE;
using TCTD2020.ArquitecturaCapasV2.BLL;
using TCTD2020.ArquitecturaCapasV2.Servicios;


namespace TCTD2020.ArquitecturaCapasV2.UI
{
    public partial class frmMdiPrincipal : Form
    {
       


        UsuarioBLL _bllUsuarios;
        public frmMdiPrincipal()
        {
            InitializeComponent();
            ValidarForm();
            _bllUsuarios= new UsuarioBLL();
        
            

        }

  

        public void ValidarForm()
        {

            this.itemLogin.Enabled = !SingletonSesion.Instancia.IsLogged();
            this.itemLogout.Enabled = SingletonSesion.Instancia.IsLogged();
            this.mnuGestores.Enabled = SingletonSesion.Instancia.IsLogged();

            if (SingletonSesion.Instancia.IsLogged())
                this.toolStripSesion.Text = SingletonSesion.Instancia.Usuario.Email;
            else
                this.toolStripSesion.Text = "[Sesión no iniciada]";


            //valido permisos
            this.mnuGestorPermisos.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorPermiso);
            this.mnuGestorUsuarios.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorUsuario);
        }

        private void ItemLogin_Click(object sender, EventArgs e)
        {
            
            frmLogin frm = new frmLogin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ItemLogout_Click(object sender, EventArgs e)
        {


           if ( MessageBox.Show("¿Está seguro?", "Confirme", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                _bllUsuarios.Logout();
                ValidarForm();
            }
        }

        private void MnuGestorPermisos_Click(object sender, EventArgs e)
        {

            frmGestorPermisos frm = new frmGestorPermisos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMdiPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
