using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IComponent = Interfaces.IComponent;
using BE;
using Component = BE.Component;

namespace TPRestaurante
{
    public partial class frmPerfiles : Form
    {

        private User selectedUser;
        private User tempUser;
        private BLL.User bllUser;
        private BLL.Permission bllPermission;

        public frmPerfiles()
        {
            InitializeComponent();
        }

       
        private void frmPerfiles_Load(object sender, EventArgs e)
        {
            bllUser = new BLL.User();
            bllPermission = new BLL.Permission();
            cmbUsuarios.DataSource = bllUser.ListUsers();
            cmbPermisos.DataSource = bllPermission.ListComponents();
        }

        void LlenarTreeView(TreeNode padre, IComponent component)
        {
            TreeNode hijo = new TreeNode(component.Name)
            {
                Tag = component
            };

            padre.Nodes.Add(hijo);
            foreach (var componentChild in component.Children)
            {
                LlenarTreeView(hijo,componentChild);
            }
        }

        
        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUser = (User)cmbUsuarios.SelectedItem;

            //Hago una copia temporal del usuario para manipular este sin modificar el original
            tempUser = new User();
            tempUser.ID = selectedUser.ID;
            tempUser.Nombre = selectedUser.Nombre;
            tempUser.Apellido = selectedUser.Apellido;
            tempUser.Password = selectedUser.Password;
            tempUser.DNI = selectedUser.DNI;
            tempUser.Email = selectedUser.Email;
            tempUser.Activo = selectedUser.Activo;
            tempUser.Attempts = selectedUser.Attempts;
            tempUser.Bloqueo = selectedUser.Bloqueo;
            tempUser.Username = selectedUser.Username;

            bllUser.AsignPermissions(tempUser);

            MostrarPermisos(tempUser);


        }

        private void MostrarPermisos(User user)
        {
            treeView1.Nodes.Clear();
            TreeNode root = new TreeNode(user.Nombre);
            foreach (var userPermission in user.Permissions)
            {
                LlenarTreeView(root,userPermission);
            }

            treeView1.Nodes.Add(root);
            treeView1.ExpandAll();
            
        }

        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            var permission = (Component)cmbPermisos.SelectedItem;
            if (permission != null)
            {
                bool exist = false;

                foreach (var tempUserPermission in tempUser.Permissions)
                {
                    if (bllPermission.Exist(tempUserPermission,permission.ID))
                    {
                        exist = true;
                        break;
                    }
                }

                if (exist)
                {
                    MessageBox.Show("El usuario ya posee este permiso/grupo");
                }
                else
                {
                    tempUser.Permissions.Add(permission);
                    MostrarPermisos(tempUser);
                }

            }
            else
            {
                MessageBox.Show("Seleccione un permiso/grupo");
            }



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bllUser.UpdatePermissions(tempUser);
                MessageBox.Show("Usuario modificado correctamente");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error al modificar usuario");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
