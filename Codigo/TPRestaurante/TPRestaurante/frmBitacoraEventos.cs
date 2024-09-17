using Interfaces;
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
    public partial class frmBitacoraEventos : Form
    {
        public frmBitacoraEventos()
        {
            InitializeComponent();
            bllBitacora = new BLL.Bitacora();
            bllUser = new BLL.User();
        }

        BLL.Bitacora bllBitacora;
        BLL.User bllUser;


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmBitacoraEventos_Load(object sender, EventArgs e)
        {
            RellenarComboBox();
            ActualizarGrilla();
        }

        void RellenarComboBox()
        {
            List<BE.User> usuarios = bllUser.ListUsers();
            usuarios.Insert(0, new BE.User { Nombre = "Todos" });
            cmbUsuarios.DataSource = null;
            cmbUsuarios.DataSource = usuarios;

            cmbOperacion.DataSource = null;
            cmbModulo.DataSource = null;





            cmbOperacion.DataSource = Enum.GetValues(typeof(TipoOperacion));
            cmbModulo.DataSource = Enum.GetValues(typeof(TipoModulo));

            cmbModulo.SelectedIndex = 0;
            cmbOperacion.SelectedIndex = 0;

            for (int i = 1; i <= 5; i++)
            {
                cmbCriticidad.Items.Add(i);
            }

            cmbCriticidad.Items.Insert(0, "Todos");
            cmbCriticidad.SelectedIndex = 0;
        }

        void ActualizarGrilla(List<Services.Bitacora> bitacoras = null)
        {

            grdBitacoraEventos.AutoGenerateColumns = false;
            grdBitacoraEventos.DataSource = null;
            grdBitacoraEventos.Columns.Clear();
            grdBitacoraEventos.Rows.Clear();
            if(bitacoras == null)
                grdBitacoraEventos.DataSource = bllBitacora.Listar();
            else
            {
                grdBitacoraEventos.DataSource = bitacoras;
            }

            DataGridViewTextBoxColumn fechaColumn = new DataGridViewTextBoxColumn();
            fechaColumn.HeaderText = "FECHA";
            fechaColumn.DataPropertyName = "Fecha";
            fechaColumn.ReadOnly =true;
            grdBitacoraEventos.Columns.Add(fechaColumn);


            DataGridViewTextBoxColumn usuarioColumn = new DataGridViewTextBoxColumn();
            usuarioColumn.HeaderText = "USUARIO";
            usuarioColumn.DataPropertyName = "Username";
            usuarioColumn.ReadOnly =true;
            grdBitacoraEventos.Columns.Add(usuarioColumn);

            DataGridViewTextBoxColumn moduloColumn = new DataGridViewTextBoxColumn();
            moduloColumn.HeaderText = "MODULO";
            moduloColumn.DataPropertyName = "Modulo";
            moduloColumn.ReadOnly =true;
            grdBitacoraEventos.Columns.Add(moduloColumn);

            DataGridViewTextBoxColumn operacionColumn = new DataGridViewTextBoxColumn();
            operacionColumn.HeaderText = "OPERACION";
            operacionColumn.DataPropertyName = "Operacion";
            operacionColumn.ReadOnly =true;
            grdBitacoraEventos.Columns.Add(operacionColumn);

            DataGridViewTextBoxColumn criticadColumn = new DataGridViewTextBoxColumn();
            criticadColumn.HeaderText = "CRITICIDAD";
            criticadColumn.DataPropertyName = "Criticidad";
            criticadColumn.ReadOnly =true;
            grdBitacoraEventos.Columns.Add(criticadColumn);

            


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpInicial.Value;
            DateTime fechaFin = dtpFinal.Value;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.");
                return;
            }

            Guid? idUSer = null;
            if (cmbUsuarios.SelectedItem != null)
            {
                BE.User usuario;
                usuario = (BE.User)cmbUsuarios.SelectedValue;
                if (usuario.Nombre != "Todos")
                    idUSer = usuario.ID;
            }

            int? criticidad = null;
            if (cmbCriticidad.SelectedItem != null && cmbCriticidad.SelectedItem.ToString() != "Todos")
                criticidad = (int)cmbCriticidad.SelectedItem;

            string operacion = null;
            if (cmbOperacion.SelectedItem != null && cmbOperacion.SelectedItem.ToString() != "Todos")
                operacion = cmbOperacion.SelectedItem.ToString();

            string modulo = null;
            if (cmbModulo.SelectedItem != null && cmbModulo.SelectedItem.ToString() != "Todos")
                modulo = cmbModulo.SelectedItem.ToString();

            
            List<Services.Bitacora> bitacoras = bllBitacora.Filtrar(fechaInicio, fechaFin, idUSer,modulo, operacion, criticidad);
            ActualizarGrilla(bitacoras);
        }
    }
}
