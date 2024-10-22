using CAPA_ENTIDADES;
using CAPA_NEGOCIO;
using PF_APP_PEDIDOS.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_APP_PEDIDOS.Modales
{
    public partial class mdCliente : Form
    {
        public Cliente _cliente { get; set; }
        public mdCliente()
        {
            InitializeComponent();
        }

        private void mdCliente_Load(object sender, EventArgs e)
        {
            List<Cliente> lista = CN_Cliente.GetInstance().GetAll();

            foreach (Cliente item in lista)
            {
                string Des_dni = Seguridad.Password.Decrypt(item.Dni);

                dtgListaCliente.Rows.Add(new object[]
                {
                    
                    item.IdCliente,
                    item.Nombre,
                    item.Apellido,
                    Des_dni
                });
            }

            foreach (DataGridViewColumn column in dtgListaCliente.Columns)
            {
                if (column.Visible == true)
                {
                    cmbBusqueda.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }
            cmbBusqueda.DisplayMember = "Texto";
            cmbBusqueda.ValueMember = "Valor";
            cmbBusqueda.SelectedIndex = 0;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cmbBusqueda.SelectedItem).Valor.ToString();

            if (dtgListaCliente.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgListaCliente.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";

            foreach (DataGridViewRow row in dtgListaCliente.Rows)
            {
                row.Visible = true;
            }
        }

        private void dtgListaCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if(iRow >= 0 && iColumn >= 0)
            {
                _cliente = new Cliente()
                {
                    IdCliente = Convert.ToInt32(dtgListaCliente.Rows[iRow].Cells["Id"].Value.ToString()),
                    Nombre = dtgListaCliente.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Apellido = dtgListaCliente.Rows[iRow].Cells["Apellido"].Value.ToString(),
                    Dni = dtgListaCliente.Rows[iRow].Cells["Dni"].Value.ToString()
                };

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
