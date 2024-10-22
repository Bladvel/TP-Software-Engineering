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
using User = BE.User;
using Interfaces;
using IComponent = Interfaces.IComponent;
using Component = BE.Permisos.Component;
using BLL;

namespace TPRestaurante
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
            modo = new BLL.ModoDelGestor();
            bllUser = new BLL.User();
            bllPermisos = new BLL.Permission();
            bllBitacora = new BLL.Bitacora();
            bitacora = new Services.Bitacora();
            bllDvh = new BLL.DVH();
        }

        //ModoAgregar = 1,
        //ModoModificar = 2,
        //ModoEliminar = 3,
        //ModoDesbloquear = 4,
        BLL.User bllUser;
        BLL.ModoDelGestor modo;
        BLL.Permission bllPermisos;
        private Services.Bitacora bitacora;
        private BLL.Bitacora bllBitacora;
        private BLL.DVH bllDvh;

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
                    cmbRol.Enabled = true;
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

                    cmbRol.Enabled = true;
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
                    cmbRol.Enabled = false;
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
                    cmbRol.Enabled = false;
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

                    cmbRol.Enabled = false;
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
            cmbRol.DataSource = null;
            cmbRol.DataSource = bllPermisos.GetGroups();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = BLL.ModoDelGestor.ModoAgregar;
            CambiarModo(modo);
            txtUsername.Focus();
        }

        
        private void RegistroBitacoraAltaUsuario(User user)
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = user;
            bitacora.Modulo = TipoModulo.GestorDeUsuarios;
            bitacora.Operacion = TipoOperacion.Alta;
            bitacora.Criticidad = 2;
            bllBitacora.Insertar(bitacora);
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case BLL.ModoDelGestor.ModoConsulta:
                    break;
                case BLL.ModoDelGestor.ModoAgregar:
                    var permission = (Component)cmbRol.SelectedItem;
                    if (permission != null)
                    {
                        User user = new User();
                        user.Username = txtUsername.Text;
                        user.Nombre = txtNombre.Text;
                        user.Apellido = txtApellido.Text;
                        user.DNI = CryptoManager.Encrypt(txtDNI.Text);
                        user.Email = txtEmail.Text;
                        user.Password = CryptoManager.Hash(txtDNI.Text + txtApellido.Text);//Cuando creo aca genero automaticamente una clave
                        user.ID= bllUser.AddUser(user);
                        user.Permissions.Add(permission);
                        bllUser.UpdatePermissions(user);
                       


                        RegistroBitacoraAltaUsuario(user);
                    }
                    
                    
                    
                    ActualizarGrilla();
                    ResetTextFields();
                    break;
                case BLL.ModoDelGestor.ModoModificar:

                    var selectedUser = grdUsuarios.CurrentRow.DataBoundItem as User;
                    if (selectedUser != null)
                    {
                        selectedUser.Username = txtUsername.Text;
                        selectedUser.Nombre = txtNombre.Text;
                        selectedUser.Apellido = txtApellido.Text;
                        selectedUser.DNI = CryptoManager.Encrypt(txtDNI.Text);
                        selectedUser.Email = txtEmail.Text;
                        bllUser.UpdateUser(selectedUser);
                        ActualizarGrilla();
                        ResetTextFields();
                        RegistroBitacoraModificarUsuario();
                    }
                    else
                    {
                        MessageBox.Show("No hay usuario seleccionado");
                    }
                    break;
                case BLL.ModoDelGestor.ModoDesbloquear:
                    var pUser = grdUsuarios.CurrentRow.DataBoundItem as User;
                    if (pUser != null)
                    {
                        pUser.Bloqueo = false;
                        pUser.Attempts = 0;
                        bllUser.UnblockUser(pUser);
                        RegistroBitacoraDesbloquearUsuairo();
                        ActualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("No hay usuario seleccionado");
                    }

                    break;
            }
        }

        private void RegistroBitacoraDesbloquearUsuairo()
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = SessionManager.Instance.User;
            bitacora.Modulo = TipoModulo.GestorDeUsuarios;
            bitacora.Operacion = TipoOperacion.DesbloquearUsuario;
            bitacora.Criticidad = 1; //TEST
            bllBitacora.Insertar(bitacora);
        }

        private void RegistroBitacoraModificarUsuario()
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = SessionManager.Instance.User;
            bitacora.Modulo = TipoModulo.GestorDeUsuarios;
            bitacora.Operacion = TipoOperacion.Modificacion;
            bitacora.Criticidad = 3;
            bllBitacora.Insertar(bitacora);
        }



        public void ActualizarGrilla()
        {
            grdUsuarios.Columns.Clear();
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
            if (modo == ModoDelGestor.ModoModificar)
            {
                txtDNI.Enabled = !habilitar;
            }
            else
            {
                txtDNI.Enabled = habilitar;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modo = BLL.ModoDelGestor.ModoModificar;
            CambiarModo(modo);
            txtUsername.Focus();
        }

        private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modo == ModoDelGestor.ModoModificar)
            {
                
                var selectedUser = grdUsuarios.CurrentRow.DataBoundItem as User;
                if (selectedUser != null)
                {
                    txtUsername.Text = selectedUser.Username;
                    txtNombre.Text = selectedUser.Nombre;
                    txtApellido.Text = selectedUser.Apellido;
                    txtDNI.Text = selectedUser.DNI;
                    txtEmail.Text = selectedUser.Email;
                    chkActivo.Checked = selectedUser.Activo;
                    chkBloqueado.Checked = selectedUser.Bloqueo;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
