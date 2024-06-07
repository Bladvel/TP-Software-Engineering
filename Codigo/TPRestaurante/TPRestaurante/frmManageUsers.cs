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
            bllUser = new BLL.User();
        }

        //ModoAgregar = 1,
        //ModoModificar = 2,
        //ModoEliminar = 3,
        //ModoDesbloquear = 4,
        BLL.User bllUser;
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
                    HabilitarTextboxs(true);
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
                    HabilitarTextboxs(true);
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
                    HabilitarTextboxs(true);
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
                    HabilitarTextboxs(false);
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
                    HabilitarTextboxs(false);
                    break ;
            }
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            
            modo = BLL.ModoDelGestor.ModoConsulta;
            CambiarModo(modo);
            grdUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdUsuarios.RowHeadersVisible = false;
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
                    User user = new User();
                    user.Username = txtUsername.Text;
                    user.Nombre = txtNombre.Text;
                    user.Apellido = txtApellido.Text;
                    user.DNI = CryptoManager.Encrypt(txtDNI.Text);
                    user.Email = txtEmail.Text;
                    user.Password = CryptoManager.Hash(txtDNI.Text+txtApellido.Text);//Cuando creo aca genero automaticamente una clave
                    bllUser.AddUser(user);
                    ActualizarGrilla();
                    ResetTextFields();
                    break;
                case BLL.ModoDelGestor.ModoModificar:
                    break;
                case BLL.ModoDelGestor.ModoDesbloquear:
                    var pUser = grdUsuarios.CurrentRow.DataBoundItem as User;
                    if (pUser != null)
                    {
                        pUser.Bloqueo = false;
                        pUser.Attempts = 0;
                        bllUser.UnblockUser(pUser);
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
            grdUsuarios.AutoGenerateColumns = false;
            grdUsuarios.DataSource = null;
            grdUsuarios.DataSource = bllUser.ListUsers();

            

            DataGridViewTextBoxColumn dniColumn = new DataGridViewTextBoxColumn();
            dniColumn.HeaderText = "DNI";
            dniColumn.DataPropertyName = "DNI";
            dniColumn.ReadOnly = true;
            grdUsuarios.Columns.Add(dniColumn);
            
            DataGridViewTextBoxColumn nombreCompletoColumn = new DataGridViewTextBoxColumn();
            nombreCompletoColumn.HeaderText = "Nombre completo";
            nombreCompletoColumn.DataPropertyName = "NombreCompleto";
            nombreCompletoColumn.ReadOnly = true;
            grdUsuarios.Columns.Add(nombreCompletoColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.HeaderText = "Email";
            emailColumn.DataPropertyName = "Email";
            emailColumn.ReadOnly = true;
            grdUsuarios.Columns.Add(emailColumn);

            DataGridViewTextBoxColumn userColumn = new DataGridViewTextBoxColumn();
            userColumn.HeaderText = "Username";
            userColumn.DataPropertyName = "Username";
            userColumn.ReadOnly = true;
            grdUsuarios.Columns.Add(userColumn);

            DataGridViewTextBoxColumn bloqueadoColumn = new DataGridViewTextBoxColumn();
            bloqueadoColumn.HeaderText = "¿Bloqueado?";
            bloqueadoColumn.DataPropertyName = "Bloqueo";
            bloqueadoColumn.ReadOnly = true;
            grdUsuarios.Columns.Add(bloqueadoColumn);




            DataGridViewTextBoxColumn activoColumn = new DataGridViewTextBoxColumn();
            activoColumn.HeaderText = "¿Usuario Activo?";
            activoColumn.DataPropertyName = "Activo";
            activoColumn.ReadOnly = true;
            grdUsuarios.Columns.Add(activoColumn);



        }

        private void ResetTextFields()
        {
            txtUsername.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombre.Text = string.Empty;
            chkActivo.Checked = false;
            chkBloqueado.Checked = false;
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
            HabilitarTextboxs(false);
            
        }

        private void HabilitarTextboxs( bool habilitar)
        {
            txtApellido.Enabled = habilitar;
            txtEmail.Enabled = habilitar;
            txtNombre.Enabled = habilitar;
            txtUsername.Enabled = habilitar;
            txtDNI.Enabled = habilitar;
        }
    }
}
