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
    public partial class frmVerInsumos : Form
    {
        public frmVerInsumos()
        {
            InitializeComponent();
            bllIngrediente = new BLL.Ingrediente();
        }
        BLL.Ingrediente bllIngrediente;
        private void frmVerInsumos_Load(object sender, EventArgs e)
        {
            grdInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdInsumos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdInsumos.RowHeadersVisible = false;

            grdInsumos.DataSource = null;
            grdInsumos.DataSource = bllIngrediente.Listar();
        }

        private void ucButtonPrimary1_Click(object sender, EventArgs e)
        {
            //Chequea todos los productos, ve los que estan por debajo o igual del stock minimo y los muestra en la lista
            //Al seleccionar un insumo, habilita el textbox para ingresar la cantidad a reponer
            //Llena el textbox con la cantidad sugeridad (diferencia entre stock minimo y stock actual)
            //Al hacer click en el boton reponer, se van agregando al listbox el cual sera la solicitud de compra
        }

        private void ucButtonPrimary2_Click(object sender, EventArgs e)
        {
            frmMDI parentForm = this.MdiParent as frmMDI;
            if (parentForm != null)
            {
                frmGenerarSolicitudDeCompra generarSolicitudDeCompra = new frmGenerarSolicitudDeCompra();
                parentForm.AbrirChildForm(generarSolicitudDeCompra);
            }
        }
    }
}
