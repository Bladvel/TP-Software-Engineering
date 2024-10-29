using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Interfaces;

namespace TPRestaurante
{
    public partial class frmRecepcionDeInsumos : Form
    {
        public frmRecepcionDeInsumos()
        {
            InitializeComponent();
            bllOrdenDeCompra = new BLL.OrdenDeCompra();
            bllNotaDeEntrega = new BLL.NotaDeEntrega();
        }

        private BLL.OrdenDeCompra bllOrdenDeCompra;
        private BLL.NotaDeEntrega bllNotaDeEntrega;
        private OrdenDeCompra ordenSeleccionada;

        private void frmRecepcionDeInsumos_Load(object sender, EventArgs e)
        {
            grdOrdenes.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdOrdenes.MultiSelect = false;
            grdOrdenes.RowHeadersVisible = false;

            grdInsumos.RowHeadersVisible = false;
            grdInsumos.AllowUserToAddRows = false;


            LLenarGridOrdenes();

        }


        void LLenarGridOrdenes()
        {
            grdOrdenes.DataSource = null;
            grdOrdenes.DataSource = bllOrdenDeCompra.ListarPorEstadoDeOrden(EstadoOrdenDeCompra.Generada);
        }


        void LlenarGridInsumos(OrdenDeCompra orden)
        {

            grdInsumos.Columns.Clear();
            grdInsumos.DataSource = null;

            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Insumo";
            col.Name = "Insumo";

            grdInsumos.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Cantidad";
            col.Name = "Cantidad";
            grdInsumos.Columns.Add(col);

            col = new DataGridViewCheckBoxColumn();
            col.HeaderText = "Recibido";
            col.Name = "Recibido";
            grdInsumos.Columns.Add(col);

            foreach (var insumos in orden.Solicitud.Ingredientes)
            {
                grdInsumos.Rows.Add(insumos.Ingrediente.Nombre, insumos.CantidadRequerida, false);
            }

            grdInsumos.Columns["Insumo"].ReadOnly = true;
            grdInsumos.Columns["Cantidad"].ReadOnly = true;
            grdInsumos.Columns["Recibido"].ReadOnly = false;


        }

        private void grdOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdOrdenes.SelectedRows.Count > 0)
            {
                ordenSeleccionada = (OrdenDeCompra)grdOrdenes.SelectedRows[0].DataBoundItem;
                LlenarGridInsumos(ordenSeleccionada);
            }
        }

        

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (ordenSeleccionada == null)
            {
                MessageBox.Show("Seleccione una orden de compra.");
                return;
            }

            bool todosRecibidos = true;

            
            foreach (DataGridViewRow row in grdInsumos.Rows)
            {
                bool recibido = Convert.ToBoolean(row.Cells["Recibido"].Value);
                if (!recibido)
                {
                    todosRecibidos = false;
                    break;
                }
            }

            
            EstadoNotaDeEntrega estadoNota = todosRecibidos ? EstadoNotaDeEntrega.Aprobada : EstadoNotaDeEntrega.Rechazada;
            NotaDeEntrega nota = new NotaDeEntrega(
               dtpFechaRecepcion.Value,
               ordenSeleccionada,
               estadoNota,
               txtObservaciones.Text
            );

            if (bllNotaDeEntrega.Insertar(nota) != -1)
            {
                MessageBox.Show($"Nota de entrega guardada como: {estadoNota}");


                DialogResult = MessageBox.Show("Por favor proceda a cargar la factura", "Cargar Factura",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (DialogResult == DialogResult.OK)
                {
                    frmMDI parentForm = this.MdiParent as frmMDI;
                    if (parentForm != null)
                    {
                        frmCargarFactura frmCargarFactura = new frmCargarFactura(ordenSeleccionada);
                        parentForm.AbrirChildForm(frmCargarFactura);
                    }
                    

                }
            }
            else
            {
                MessageBox.Show("Error al guardar la nota de entrega");
            }

            
            LLenarGridOrdenes();
            txtObservaciones.Text = "";

            dtpFechaRecepcion.Value = DateTime.Now;
            grdInsumos.Columns.Clear();

        }
    }
}

