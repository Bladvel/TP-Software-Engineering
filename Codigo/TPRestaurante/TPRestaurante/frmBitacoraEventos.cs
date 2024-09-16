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
            cmbUsuarios.DataSource = null;
            cmbUsuarios.DataSource = bllUser.ListUsers();

            cmbOperacion.DataSource = null;
            cmbModulo.DataSource = null;
            cmbOperacion.DataSource = Enum.GetValues(typeof(TipoOperacion));
            cmbModulo.DataSource = Enum.GetValues(typeof(TipoModulo));

            for (int i = 1; i <= 5; i++)
            {
                cmbCriticidad.Items.Add(i);
            }
        }

        void ActualizarGrilla()
        {

            grdBitacoraEventos.AutoGenerateColumns = false;
            grdBitacoraEventos.DataSource = null;
            grdBitacoraEventos.Columns.Clear();
            grdBitacoraEventos.Rows.Clear();
            grdBitacoraEventos.DataSource = bllBitacora.Listar();

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


    }
}
