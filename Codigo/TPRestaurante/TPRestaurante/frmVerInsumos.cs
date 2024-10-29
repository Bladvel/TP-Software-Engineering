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
            ingredientes = new List<BE.Ingrediente>();
        }
        BLL.Ingrediente bllIngrediente;
        private List<BE.Ingrediente> ingredientes;
        private List<BE.Ingrediente> faltantes;
        public List<BE.ItemIngrediente> Items;
        private void frmVerInsumos_Load(object sender, EventArgs e)
        {
            grdInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdInsumos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdInsumos.RowHeadersVisible = false;
            ingredientes = bllIngrediente.Listar();
            LlenarGrid(ingredientes);


            HabilitarControles(false);

        }

        void HabilitarControles(bool habilitar)
        {
            lblCantidad.Visible = habilitar;
            txtCantidad.Visible = habilitar;
            lstSolicitud.Visible = habilitar;
            btnCargar.Visible = habilitar;
            btnGenerar.Visible = habilitar;
            btnLimpiar.Visible = habilitar;
        }


        //Ver pendientes de compra
        private void ucButtonPrimary1_Click(object sender, EventArgs e)
        {
            faltantes = bllIngrediente.FiltrarFaltantes(ingredientes);

            if(faltantes.Count > 0)
            {
                LlenarGrid(faltantes);
                Items = new List<BE.ItemIngrediente>();
                HabilitarControles(true);
            }
            else
            {
                MessageBox.Show("No hay insumos por debajo del stock minimo");
            }

        }

        //Generar solicitud de compra
        private void ucButtonPrimary2_Click(object sender, EventArgs e)
        {
            frmMDI parentForm = this.MdiParent as frmMDI;
            if (parentForm != null)
            {
                frmGenerarSolicitudDeCotizacion generarSolicitudDeCompra = new frmGenerarSolicitudDeCotizacion(Items);
                parentForm.AbrirChildForm(generarSolicitudDeCompra);
            }
        }

        void LlenarGrid(List<BE.Ingrediente> ingredientes)
        {
            grdInsumos.DataSource = null;
            grdInsumos.DataSource = ingredientes;
        }

        private void grdInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Ingrediente ingrediente = (BE.Ingrediente)grdInsumos.CurrentRow.DataBoundItem;
            int cantidadFaltante = ingrediente.StockMin - ingrediente.Cantidad;
            txtCantidad.Text = cantidadFaltante.ToString();
        }



        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada si no es un número
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            BE.Ingrediente ingrediente = (BE.Ingrediente)grdInsumos.CurrentRow.DataBoundItem;
            int cantidad;

            if (faltantes.Count > 0 && int.TryParse(txtCantidad.Text, out cantidad) && ingrediente != null)
            {

                var sumaCantidad = cantidad + ingrediente.Cantidad;

                if (sumaCantidad > ingrediente.StockMax)
                {
                    MessageBox.Show("La cantidad ingresada supera el stock maximo");
                    txtCantidad.Text = "";
                    return;
                }

                var itemExistente = Items.FirstOrDefault(item => item.Ingrediente.CodIngrediente == ingrediente.CodIngrediente);

                if (itemExistente != null)
                {
                    itemExistente.CantidadRequerida = cantidad;

                    ActualizarListaSolicitud();
                }
                else
                {
                    BE.ItemIngrediente item = new BE.ItemIngrediente(ingrediente, cantidad);
                    Items.Add(item);
                    lstSolicitud.Items.Add(item.Ingrediente.Nombre + " - " + item.CantidadRequerida);
                }
            }
        }


        private void ActualizarListaSolicitud()
        {
            lstSolicitud.Items.Clear();
            foreach (var item in Items)
            {
                lstSolicitud.Items.Add(item.Ingrediente.Nombre + " - " + item.CantidadRequerida);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Items.Clear();
            lstSolicitud.Items.Clear();
        }
    }
}
