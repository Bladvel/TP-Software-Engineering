using BE;
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
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
            modo = new BLL.ModoDelGestor();
            bllUsuario = new BLL.Usuario();
        }

        //ModoAgregar = 1,
        //ModoModificar = 2,
        //ModoEliminar = 3,
        //ModoDesbloquear = 4,
        BLL.Usuario bllUsuario;
        BLL.ModoDelGestor modo;

        void CambiarModo(BLL.ModoDelGestor pModo)
        {
            switch (pModo)
            {
                case BLL.ModoDelGestor.ModoConsulta:
                    lblModo.Text = "Modo consulta";
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnAplicar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnDesbloquear.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnSalir.Enabled = false;
                    break;
                case BLL.ModoDelGestor.ModoAgregar:
                    lblModo.Text = "Modo agregar";
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnDesbloquear.Enabled = false;
                    btnAplicar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSalir.Enabled = true;
                    break;
                case BLL.ModoDelGestor.ModoModificar:
                    lblModo.Text = "Modo modificar";
                    btnAgregar.Enabled=false; 
                    btnModificar.Enabled=false;
                    btnEliminar.Enabled = false;
                    btnDesbloquear.Enabled = false;
                    btnAplicar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSalir.Enabled = true;
                    break;
                case BLL.ModoDelGestor.ModoEliminar:
                    lblModo.Text = "Modo eliminar";
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnDesbloquear.Enabled = false;
                    btnAplicar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSalir.Enabled = true;
                    break ;
                case BLL.ModoDelGestor.ModoDesbloquear:
                    lblModo.Text = "Modo desbloquear";
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnDesbloquear.Enabled = false;
                    btnAplicar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSalir.Enabled = true;
                    break ;
            }
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            
            modo = BLL.ModoDelGestor.ModoConsulta;
            CambiarModo(modo);
            grdUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            ActualizarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = BLL.ModoDelGestor.ModoAgregar;
            CambiarModo(modo);
            txtUsername.Focus();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case BLL.ModoDelGestor.ModoConsulta:
                    break;
                case BLL.ModoDelGestor.ModoAgregar:
                    Usuario usuario = new Usuario();
                    usuario.Username = txtUsername.Text;
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellido = txtApellido.Text;
                    usuario.DNI = CryptoManager.Encrypt(txtDNI.Text);
                    usuario.Email = txtEmail.Text;
                    usuario.Password = CryptoManager.Hash(txtDNI.Text+txtApellido.Text);//Cuando creo aca genero automaticamente una clave
                    bllUsuario.AgregarUsuario(usuario);
                    ActualizarGrilla();
                    break;
                case BLL.ModoDelGestor.ModoModificar:
                    break;
                case BLL.ModoDelGestor.ModoDesbloquear:
                    var user = grdUsuarios.CurrentRow.DataBoundItem as Usuario;
                    if (user != null)
                    {
                        user.Bloqueo = false;
                        user.Attempts = 0;
                        bllUsuario.DesbloquearUsuario(user);
                        ActualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("No hay usuario seleccionado");
                    }

                    break;
            }
        }

        public void ActualizarGrilla()
        {
            grdUsuarios.DataSource = null;
            grdUsuarios.DataSource = bllUsuario.ListarUsuarios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            modo = BLL.ModoDelGestor.ModoConsulta;
            CambiarModo(modo);
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            modo = BLL.ModoDelGestor.ModoDesbloquear;
            CambiarModo(modo);
            txtApellido.Enabled = false;
            txtEmail.Enabled = false;
            txtNombre.Enabled = false;
            txtUsername.Enabled = false;
            txtDNI.Enabled = false;
            
        }
    }
}
