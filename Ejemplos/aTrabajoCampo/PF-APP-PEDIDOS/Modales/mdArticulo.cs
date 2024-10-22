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
    public partial class mdArticulo : Form
    {
        public Articulo _articulo { get; set; }
        public mdArticulo()
        {
            InitializeComponent();
        }

        private void mdArticulo_Load(object sender, EventArgs e)
        {
            List<Articulo> lista = CN_Articulo.GetInstance().GetAll();

            foreach (Articulo item in lista)
            {
   
                dtgLista.Rows.Add(new object[]
                {

                    item.IdArticulo,
                    item.codigo,
                    item.Nombre,
                    item.Precio,
                    item.Stock
                });
            }

            foreach (DataGridViewColumn column in dtgLista.Columns)
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

        private void dtgListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int IRow = e.RowIndex;
            int IColimn = e.ColumnIndex;

            if(IRow >=0 && IColimn >=0)
            {
                _articulo = new Articulo()
                {
                    IdArticulo = Convert.ToInt32(dtgLista.Rows[IRow].Cells["Id"].Value.ToString()),
                    codigo = dtgLista.Rows[IRow].Cells["Codigo"].Value.ToString(),
                    Nombre = dtgLista.Rows[IRow].Cells["Nombre"].Value.ToString(),
                    Precio = Convert.ToDecimal(dtgLista.Rows[IRow].Cells["Precio"].Value.ToString()),
                    Stock = Convert.ToInt32(dtgLista.Rows[IRow].Cells["Stock"].Value.ToString())
                };

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cmbBusqueda.SelectedItem).Valor.ToString();

            if (dtgLista.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgLista.Rows)
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

            foreach (DataGridViewRow row in dtgLista.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
