using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Interfaces;
using Component = BE.Component;
using IComponent = Interfaces.IComponent;

namespace TPRestaurante
{
    public partial class frmGestionarPermisos : Form
    {
        public frmGestionarPermisos()
        {
            InitializeComponent();
            bllPermission = new BLL.Permission();
        }

        private BLL.Permission bllPermission;
        private Group selected;

        private void frmGestionarPermisos_Load(object sender, EventArgs e)
        {
            FillPermissions();
        }

        void FillPermissions()
        {
            cmbPermisos.DataSource = bllPermission.GetPermissions();
            cmbGrupo.DataSource = bllPermission.GetGroups();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            var tempGroup = (Group)cmbGrupo.SelectedItem;
            
            


            //Preguntar si necesito clonar esto

            if (tempGroup != null)
            {
                selected = (Group)tempGroup.Clone();
                MostrarPermisos(selected);
            }
            else
            {
                MessageBox.Show("Por favor seleccione un grupo");
            }
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
                LlenarTreeView(hijo, componentChild);
            }
        }

        private void MostrarPermisos(Component component)
        {
            treeView1.Nodes.Clear();
            TreeNode root = new TreeNode(component.Name);
            foreach (var componentChild in component.Children)
            {
                LlenarTreeView(root, componentChild);
            }

            treeView1.Nodes.Add(root);
            treeView1.ExpandAll();

        }

        private void btnGuardarGrupo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtGrupo.Text))
            {
                Group g = new Group();
                g.Name = txtGrupo.Text;
                g.Type = ComponentType.G;
                if (bllPermission.InsertComponent(g) != -1)
                {
                    MessageBox.Show("Grupo guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al guardar el elemento");
                }


                FillPermissions();
                
                txtGrupo.Clear();
            }
            else
            {
                MessageBox.Show("Por favor escriba un nombre para el grupo");
            }
            

        }



        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                MessageBox.Show("Por favor selecciona un grupo al cual agregar primero");
            }
            else
            {
                var group = (Group)cmbGrupo.SelectedItem;
                if (group == null)
                {
                    MessageBox.Show("Por favor selecciona un permiso");
                }
                else
                {
                    if (!bllPermission.CanAddComponent(selected, group))
                    {
                        MessageBox.Show("Ya existe este grupo en el grupo u ocurre referencia circular");
                    }
                    else
                    {
                        selected.AddChild(group);
                        MostrarPermisos(selected);
                    }
                }
            }
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                MessageBox.Show("Por favor selecciona un grupo al cual agregar primero");
            }
            else
            {
                var permission = (Permission)cmbPermisos.SelectedItem;
                if (permission == null)
                {
                    MessageBox.Show("Por favor selecciona un permiso");
                }
                else
                {
                    if (bllPermission.Exist(selected, permission.ID))
                    {
                        MessageBox.Show("Ya existe este permiso en el grupo");
                    }
                    else
                    {
                        selected.AddChild(permission);
                        MostrarPermisos(selected);
                    }
                }
            }
        }

        private void btnGuardarConfig_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                MessageBox.Show("Selecciona un grupo a configurar primero");
            }
            else
            {
                bllPermission.SaveGroup(selected);
                FillPermissions();
                MessageBox.Show("Se guardaron los cambios correctamente");
            }
        }


    }
}
