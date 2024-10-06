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
        private void frmBitacoraDeCambios_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        void ActualizarGrilla()
        {
            grdBitacora.DataSource = null;
            grdBitacora.DataSource = bllProductoBitacora.Listar();

            grdBitacora.Columns["Id"].Visible = false;


        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            grdBitacora.DataSource = null;
            grdBitacora.DataSource = bllProductoBitacora.Filtrar(dtpInit.Value, dtpFin.Value, int.Parse(txtCodigo.Text), txtNombre.Text);
        }
    }
}
