using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCTD2020.ArquitecturaCapasV2.BLL;
using TCTD2020.ArquitecturaCapasV2.BE;
using TCTD2020.ArquitecturaCapasV2.Servicios.Composite;
using TCTD2020.ArquitecturaCapasV2.Interfaces;

namespace TCTD2020.ArquitecturaCapasV2.UI
{


    public partial class frmGestorPermisos : Form
    {

        UsuarioBLL _bllusuarios;

       Usuario _usuario;
        public frmGestorPermisos()
        {
            _bllusuarios = new UsuarioBLL();
            InitializeComponent();

            var users = _bllusuarios.GetAll();
            this.cboUsuarios.DataSource =users;
        }

        private void CboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            _usuario = (Usuario)this.cboUsuarios.SelectedItem;
            MostrarPermisos();
        }

        private TreeNode CrearNodo(IPermiso item)
        {
            TreeNode tn = new TreeNode(item.Nombre);
            tn.Tag = item;

            return tn;
        }


        private void MostrarPermisosRecursivo(IPermiso p, TreeNode tn)
        {
            foreach (var item in p.ObtenerHijos())
            {
                var tnn = CrearNodo(item);
                tn.Nodes.Add(tnn);
               

                if (item.ObtenerHijos().Count > 0)
                {
                    MostrarPermisosRecursivo(item, tnn);
                }
            }
        }
        private void MostrarPermisos()
        {
            if (_usuario!=null)
            {
                this.treeView1.Nodes.Clear();
                TreeNode raiz = new TreeNode("Permisos");
                this.treeView1.Nodes.Add(raiz);

                foreach (var item in _usuario.Permisos)
                {
                    var tn = CrearNodo(item);
                    raiz.Nodes.Add(tn);

                    if (item.ObtenerHijos().Count > 0)
                    {
                        MostrarPermisosRecursivo(item, tn);
                    }
                }
            }

            

        }



    }
}
