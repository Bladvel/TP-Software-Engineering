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
using BE.Permisos;
using Interfaces;
using Services;
using Component = BE.Permisos.Component;
using IComponent = Interfaces.IComponent;

namespace TPRestaurante
{
    public partial class frmGestionarPermisos : Form, IIdiomaObserver
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
            SessionManager.SuscribirObservador(this);
            Traducir(SessionManager.Instance.User.Idioma);
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


        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);

        }

        private void Traducir(IIdioma idioma = null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);

            //Menu sesion
            if (groupBox1.Tag != null && traducciones.ContainsKey(groupBox1.Tag.ToString()))
                groupBox1.Text = traducciones[groupBox1.Tag.ToString()].Texto;
            if (groupBox2.Tag != null && traducciones.ContainsKey(groupBox2.Tag.ToString()))
                groupBox2.Text = traducciones[groupBox2.Tag.ToString()].Texto;
            if (groupBox3.Tag != null && traducciones.ContainsKey(groupBox3.Tag.ToString()))
                groupBox3.Text = traducciones[groupBox3.Tag.ToString()].Texto;
            if (lblGrupos.Tag != null && traducciones.ContainsKey(lblGrupos.Tag.ToString()))
                lblGrupos.Text = traducciones[lblGrupos.Tag.ToString()].Texto;
            if (btnConfigurar.Tag != null && traducciones.ContainsKey(btnConfigurar.Tag.ToString()))
                btnConfigurar.Text = traducciones[btnConfigurar.Tag.ToString()].Texto;
            if (btnAgregarGrupo.Tag != null && traducciones.ContainsKey(btnAgregarGrupo.Tag.ToString()))
                btnAgregarGrupo.Text = traducciones[btnAgregarGrupo.Tag.ToString()].Texto;
            if (btnGuardarGrupo.Tag != null && traducciones.ContainsKey(btnGuardarGrupo.Tag.ToString()))
                btnGuardarGrupo.Text = traducciones[btnGuardarGrupo.Tag.ToString()].Texto;
            if (label2.Tag != null && traducciones.ContainsKey(label2.Tag.ToString()))
                label2.Text = traducciones[label2.Tag.ToString()].Texto;
            if (btnAgregarPermiso.Tag != null && traducciones.ContainsKey(btnAgregarPermiso.Tag.ToString()))
                btnAgregarPermiso.Text = traducciones[btnAgregarPermiso.Tag.ToString()].Texto;
            if (btnGuardarConfig.Tag != null && traducciones.ContainsKey(btnGuardarConfig.Tag.ToString()))
                btnGuardarConfig.Text = traducciones[btnGuardarConfig.Tag.ToString()].Texto;
            if (btnCancelar.Tag != null && traducciones.ContainsKey(btnCancelar.Tag.ToString()))
                btnCancelar.Text = traducciones[btnCancelar.Tag.ToString()].Texto;

        }

        private void frmGestionarPermisos_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }
    }
}
