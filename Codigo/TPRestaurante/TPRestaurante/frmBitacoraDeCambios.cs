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
    public partial class frmBitacoraDeCambios : Form
    {
        public frmBitacoraDeCambios()
        {
            InitializeComponent();
            bllProductoBitacora = new BLL.ProductoBitacora();
        }

        private BLL.ProductoBitacora bllProductoBitacora;
        private List<BE.ProductoBitacora> bitacorasFiltradas;
        private void frmBitacoraDeCambios_Load(object sender, EventArgs e)
        {
            dtpInit.Value = DateTime.Today.AddDays(-1);
            dtpFin.Value = DateTime.Today.AddDays(1);
            ActualizarGrilla();
        }

        void ActualizarGrilla(List<BE.ProductoBitacora> bitacoras = null)
        {
            
            grdBitacora.DataSource = null;

            if (bitacoras == null)
            {
                grdBitacora.DataSource = bllProductoBitacora.Listar();
            }
            else
            {
                grdBitacora.DataSource = bitacoras;
            }

            


            grdBitacora.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdBitacora.MultiSelect = false;
            grdBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdBitacora.RowHeadersVisible = false;


            grdBitacora.Columns["Id"].Visible = false;
            grdBitacora.Columns["CodProducto"].HeaderText = "Código";
            grdBitacora.Columns["Producto"].Visible = false;



        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {

            string codigo = null;
            if(txtCodigo.Text != "")
            {
                codigo = txtCodigo.Text;
            }

            string nombre = null;
            if (txtNombre.Text != "")
                nombre = txtNombre.Text;

            int? codigoInt = null;
            if (!string.IsNullOrEmpty(codigo))
            {
                codigoInt = int.Parse(codigo);
            }

            ActualizarGrilla(bllProductoBitacora.Filtrar(dtpInit.Value, dtpFin.Value, codigoInt, nombre));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            dtpInit.Value = DateTime.Today.AddDays(-1);
            dtpFin.Value = DateTime.Today.AddDays(1);
            ActualizarGrilla();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            BE.ProductoBitacora bitacora = (BE.ProductoBitacora)grdBitacora.CurrentRow.DataBoundItem;
            bitacora.Activo = true;
            bllProductoBitacora.Activar(bitacora);
            ActualizarGrilla();
        }
    }
}
