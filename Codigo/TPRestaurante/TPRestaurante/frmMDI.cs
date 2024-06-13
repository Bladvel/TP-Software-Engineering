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
using Interfaces;

namespace TPRestaurante
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
            bllUser = new BLL.User();
        }

        BLL.User bllUser;

        private void frmMDI_Load(object sender, EventArgs e)
        {
            ValidarForm();
        }

        private void CerrarChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void AbrirChildForm(Form childForm)
        {
            CerrarChildForms();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.WindowState = FormWindowState.Maximized;
            
            childForm.Show();
        }


        public void ValidarForm()
        {
            if (SessionManager.Instance.IsLoggedIn())
            {
                itemCerrarSesión.Visible = true;
                itemCambiarContraseña.Visible = true;
                itemCambiarIdioma.Visible = true;
                itemIniciarSesión.Enabled = false;
                toolStripStatusLabel1.Text = SessionManager.Instance.User.Username;

                menuAdmin.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarAdmin);
                itemGestorUsuarios.Visible = SessionManager.Instance.IsInRole(PermissionType.GestorUsuario);
                itemGestorPerfiles.Visible = SessionManager.Instance.IsInRole(PermissionType.GestorPerfil);
                itemGestorIdiomas.Visible = SessionManager.Instance.IsInRole(PermissionType.GestorIdioma);

                menuPedidos.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarPedido);
                itemCrearPedido.Visible = SessionManager.Instance.IsInRole(PermissionType.CrearPedido);
                itemVerPedidos.Visible = SessionManager.Instance.IsInRole(PermissionType.VerPedidos);
                itemCobrarPedido.Visible = SessionManager.Instance.IsInRole(PermissionType.CobrarPedido);
                itemComandas.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarComanda);
                itemGenerarComandas.Visible = SessionManager.Instance.IsInRole(PermissionType.GenerarComanda);
                itemVerComandas.Visible = SessionManager.Instance.IsInRole(PermissionType.VerComanda);

                menuCatalogos.Visible = SessionManager.Instance.IsInRole(PermissionType.GestionarCatalogos);
                itemProductos.Visible = SessionManager.Instance.IsInRole(PermissionType.VerProductos);
                itemIngredientes.Visible = SessionManager.Instance.IsInRole(PermissionType.VerIngredientes);

            }
            else
            {
                itemCerrarSesión.Visible = false;
                itemCambiarContraseña.Visible = false;
                itemCambiarIdioma.Visible = false;
                itemIniciarSesión.Enabled = true;
                toolStripStatusLabel1.Text = "Sesion no iniciada";

                menuAdmin.Visible = false;
                menuPedidos.Visible = false;
                menuCatalogos.Visible = false;
            }


        }

        private void itemCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro?", "Confirme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllUser.Logout();
                ValidarForm();
                CerrarChildForms();
            }
        }


        private void itemIniciarSesion_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            AbrirChildForm(formLogin);

        }

        private void itemGestorUsuarios_Click(object sender, EventArgs e)
        {
            frmManageUsers formUsers = new frmManageUsers();
            AbrirChildForm(formUsers);

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateOrder formCreateOrder = new frmCreateOrder();
            AbrirChildForm(formCreateOrder);
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cobrarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCobrarPedido formCobrarPedido = new frmCobrarPedido();
            AbrirChildForm(formCobrarPedido);
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerarComanda generarComanda = new frmGenerarComanda();
            AbrirChildForm(generarComanda);
        }

        private void abiertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidosEnCurso pedidosEnCurso = new frmPedidosEnCurso();
            AbrirChildForm(pedidosEnCurso);
        }

        private void itemProductos_Click(object sender, EventArgs e)
        {

        }

        private void registradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerificarPedido verificarPedido = new frmVerificarPedido();
            AbrirChildForm(verificarPedido);
        }

        private void itemCambiarContraseña_Click(object sender, EventArgs e)
        {
            frmCambiarPassword cambiarPassword = new frmCambiarPassword();
            AbrirChildForm(cambiarPassword);
        }


        private void asignacionDePerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfiles perfiles = new frmPerfiles();
            AbrirChildForm(perfiles);
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionarPermisos permisos = new frmGestionarPermisos();
            AbrirChildForm(permisos);
        }
    }
}
