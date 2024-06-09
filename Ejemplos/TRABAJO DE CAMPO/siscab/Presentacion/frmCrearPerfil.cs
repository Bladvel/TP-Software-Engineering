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
    public partial class frmCrearPerfil : Form
    {
        private static frmCrearPerfil instancia;

        public static frmCrearPerfil Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmCrearPerfil();
            }
            return instancia;
        }

        BLLPermisos repo;
        Familia seleccion;

        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();


        public frmCrearPerfil()
        {
            InitializeComponent();
            repo = new BLLPermisos();
            //cargo los permisos "Atómicos"
            this.cboPermisos.DataSource = repo.GetAllPermission();

        }


        private void ReportarBitacoraCrearPerfil()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Perfiles;
            registroBitacora.Operacion = EnumOperacion.Alta;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }


        private void frmCrearModificarPerfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void LlenarPatentesFamilias()
        {

            this.cboPatentes.DataSource = repo.GetAllPatentes();
            this.cboFamilias.DataSource = repo.GetAllFamilias();
        }

        private void frmCrearModificarPerfil_Load(object sender, EventArgs e)
        {
            LlenarPatentesFamilias();
        }

        private void btn_guardarP_Click(object sender, EventArgs e)
        {
            Patente p = new Patente()
            {
                Nombre = this.txt_NombrePatente.Text,
                Permiso = (TipoPermiso)this.cboPermisos.SelectedItem

            };

            repo.GuardarComponente(p, false);
            LlenarPatentesFamilias();

            MessageBox.Show("Patente guardada correctamente");
        }

        private void btn_guardarF_Click(object sender, EventArgs e)
        {
            Familia p = new Familia()
            {
                Nombre = this.txt_NombreFamilia.Text

            };


            repo.GuardarComponente(p, true);
            LlenarPatentesFamilias();
            MessageBox.Show("Familia guardada correctamente");
        }


        void MostrarFamilia(bool init)
        {
            if (seleccion == null) return;


            IList<Componente> flia = null;
            if (init)
            {
                //traigo los hijos de la base
                flia = repo.GetAll("=" + seleccion.Id);


                foreach (var i in flia)
                    seleccion.AgregarHijo(i);
            }
            else
            {
                flia = seleccion.Hijos;
            }

            this.treeConfigurarFamilia.Nodes.Clear();

            TreeNode root = new TreeNode(seleccion.Nombre);
            root.Tag = seleccion;
            this.treeConfigurarFamilia.Nodes.Add(root);

            foreach (var item in flia)
            {
                MostrarEnTreeView(root, item);
            }

            treeConfigurarFamilia.ExpandAll();
        }



        void MostrarEnTreeView(TreeNode tn, Componente c)
        {
            TreeNode n = new TreeNode(c.Nombre);
            tn.Tag = c;
            tn.Nodes.Add(n);
            if (c.Hijos != null)
                foreach (var item in c.Hijos)
                {
                    MostrarEnTreeView(n, item);
                }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (seleccion != null)
            {
                var patente = (Patente)cboPatentes.SelectedItem;
                if (patente != null)
                {
                    var esta = repo.Existe(seleccion, patente.Id);
                    if (esta)
                        MessageBox.Show("ya exsite la patente indicada");
                    else
                    {

                        {
                            seleccion.AgregarHijo(patente);
                            MostrarFamilia(false);
                        }
                    }
                }
            }
        }

        private void btn_configurar_Click(object sender, EventArgs e)
        {
            var tmp = (Familia)this.cboFamilias.SelectedItem;
            seleccion = new Familia();
            seleccion.Id = tmp.Id;
            seleccion.Nombre = tmp.Nombre;
            MostrarFamilia(true);
        }

        private void btn_AgregarFamilia_Click(object sender, EventArgs e)
        {
            if (seleccion != null)
            {
                var familia = (Familia)cboFamilias.SelectedItem;
                if (familia != null)
                {

                    var esta = repo.Existe(seleccion, familia.Id);
                    if (esta)
                        MessageBox.Show("ya existe la familia indicada");
                    else
                    {

                        repo.FillFamilyComponents(familia);
                        seleccion.AgregarHijo(familia);
                        MostrarFamilia(false);
                    }


                }
            }
        }

        private void btn_guardarFamiliaGral_Click(object sender, EventArgs e)
        {

            try
            {
                repo.GuardarFamilia(seleccion);
                MessageBox.Show("Familia guardada correctamente");
                ReportarBitacoraCrearPerfil();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al guardar la familia");
            }
        }

        private void cboPatentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
