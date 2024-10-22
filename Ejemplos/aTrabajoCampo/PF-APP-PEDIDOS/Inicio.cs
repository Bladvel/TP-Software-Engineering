using CAPA_ENTIDADES;
using FontAwesome.Sharp;
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
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objUsuario = null)
        {
            if (objUsuario == null) usuarioActual = new Usuario() { NombreUsuario = "Luis", IdUsuario = 77 };
            else
                usuarioActual = objUsuario;
            
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuarioActual.NombreUsuario;
        }

        private void AbrirFormulario( IconMenuItem menu, Form formulario)
        {
            if(MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;

            if(FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);

            formulario.Show();
        }
        private void menuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem) sender, new FrmUsuarios());
        }

        private void menuPedido_Click(object sender, EventArgs e)
        {

        }

        private void SubmenuRegistrarPedido_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuPedido, new FrmRegistrarPedido(usuarioActual));
        }

        private void SubmenuVerDetalles_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuPedido, new FrmVerDetallePedido());
        }

        private void menuBitacora_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmBitacora());
        }

        private void menuBackup_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmBackup());
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmAyuda());
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmCliente());
        }

        private void menuFamilia_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmFamilia());
        }

        private void menuArticulo_Click(object sender, EventArgs e)
        {

        }

        private void submenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuArticulo, new FrmCategoria());
        }

        private void submenuArticulos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuArticulo, new FrmArticulos());
        }

        private void submenuNegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuArticulo, new FrmNegocio());
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
