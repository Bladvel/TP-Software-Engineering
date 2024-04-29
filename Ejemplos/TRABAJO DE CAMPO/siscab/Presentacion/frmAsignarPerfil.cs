using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAsignarPerfil : Form
    {
        private static frmAsignarPerfil instancia = null;

        public static frmAsignarPerfil Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmAsignarPerfil();
            }
            return instancia;
        }
        public frmAsignarPerfil()
        {
            InitializeComponent();
            repo = new BLL.BLLUsuario();
            permisosRepo = new BLL.BLLPermisos();
            this.cboUsuarios.DataSource = repo.ListarActivos();
            this.cboFamilias.DataSource = permisosRepo.GetAllFamilias();
            this.cboPatentes.DataSource = permisosRepo.GetAllPatentes();
        }

        private void frmAsignarPerfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        BLL.BLLUsuario repo;
        BLL.BLLPermisos permisosRepo;
        Usuario seleccion;
        Usuario tmp;

        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();

        void LlenarTreeView(TreeNode padre, Componente c)
        {
            TreeNode hijo = new TreeNode(c.Nombre);
            hijo.Tag = c;
            padre.Nodes.Add(hijo);

            foreach (var item in c.Hijos)
            {
                LlenarTreeView(hijo, item);
            }

        }


        private void ReportarBitacoraAsignarPerfil()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Perfiles;
            registroBitacora.Operacion = EnumOperacion.Asignar;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }



        void MostrarPermisos(Usuario u)
        {
            this.treeView1.Nodes.Clear();
            TreeNode root = new TreeNode(u.Nombre);

            foreach (var item in u.Permisos)
            {
                LlenarTreeView(root, item);
            }

            this.treeView1.Nodes.Add(root);
            this.treeView1.ExpandAll();
        }

        private void btn_configuar_Click(object sender, EventArgs e)
        {
            seleccion = (Usuario)this.cboUsuarios.SelectedItem;

            //hago una copia del objeto para no modificr el que esta en el combo.
            tmp = new Usuario();
            tmp.Id = seleccion.Id;
            tmp.Nombre = seleccion.Nombre;
            
            permisosRepo.FillUserComponents(tmp);

            MostrarPermisos(tmp);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                var patente = (Patente)cboPatentes.SelectedItem;
                if (patente != null)
                {
                    var esta = false;

                    foreach (var item in tmp.Permisos)
                    {
                        if (permisosRepo.Existe(item, patente.Id))
                        {
                            esta = true;
                            break;
                        }
                    }
                    if (esta)
                        MessageBox.Show("El usuario ya tiene la patente indicada");
                    else
                    {
                        {
                            tmp.Permisos.Add(patente);
                            MostrarPermisos(tmp);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Seleccione un usuario");
        }

        private void btn_agregarf_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                var flia = (Familia)cboFamilias.SelectedItem;
                if (flia != null)
                {
                    var esta = false;
                    //verifico que ya no tenga el permiso. TODO: Esto debe ser parte de otra capa.
                    foreach (var item in tmp.Permisos)
                    {
                        if (permisosRepo.Existe(item, flia.Id))
                        {
                            esta = true;
                        }
                    }

                    if (esta)
                        MessageBox.Show("El usuario ya tiene la familia indicada");
                    else
                    {
                        {
                            permisosRepo.FillFamilyComponents(flia);

                            tmp.Permisos.Add(flia);
                            MostrarPermisos(tmp);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Seleccione un usuario");
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                repo.GuardarPermisos(tmp);
                MessageBox.Show("Usuario guardado correctamente");
                ReportarBitacoraAsignarPerfil();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al guardar el usuario");
            }
        }
    }
}
