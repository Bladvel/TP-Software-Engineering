using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using BE;

namespace TPRestaurante
{
    public partial class frmGenerarOrdenDeCompra : Form
    {
        public frmGenerarOrdenDeCompra()
        {
            InitializeComponent();
            bllSolicitudDeCotizacion = new BLL.SolicitudDeCotizacion();
            bllProveedor = new BLL.Proveedor();
            bllOrdenDeCompra = new BLL.OrdenDeCompra();
        }

        private BLL.SolicitudDeCotizacion bllSolicitudDeCotizacion;
        private BLL.Proveedor bllProveedor;
        BE.SolicitudDeCotizacion solicitudSeleccionada;
        private BLL.OrdenDeCompra bllOrdenDeCompra;

        private void frmGenerarOrdenDeCompra_Load(object sender, EventArgs e)
        {
            grdSolicitudes.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSolicitudes.MultiSelect = false;
            grdSolicitudes.RowHeadersVisible = false;

            cmbProveedores.DataSource = bllProveedor.Listar();

            ActualizarGrillaSolicitudes();

        }

        void ActualizarGrillaSolicitudes()
        {
            grdSolicitudes.DataSource = null;
            grdSolicitudes.DataSource = bllSolicitudDeCotizacion.ListarPorEstado(EstadoSolicitudCotizacion.Enviada);
        }

        private void grdSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdSolicitudes.SelectedRows.Count > 0)
            {
                solicitudSeleccionada = (BE.SolicitudDeCotizacion)grdSolicitudes.SelectedRows[0].DataBoundItem;
                LlenarGridInsumos(solicitudSeleccionada.Ingredientes);
            }
        }

        private void LlenarGridInsumos(List<ItemIngrediente> items)
        {
            
            grdInsumos.Columns.Clear();
            grdInsumos.DataSource = null;

            grdInsumos.RowHeadersVisible = false;

            grdInsumos.Columns.Add("Ingrediente", "Ingrediente");
            grdInsumos.Columns["Ingrediente"].ReadOnly = true;

            
            DataGridViewTextBoxColumn cantidadColumna = new DataGridViewTextBoxColumn();
            cantidadColumna.HeaderText = "Cantidad";
            cantidadColumna.Name = "Cantidad";
            grdInsumos.Columns.Add(cantidadColumna);

            
            DataGridViewTextBoxColumn precioCotizacionColumna = new DataGridViewTextBoxColumn();
            precioCotizacionColumna.HeaderText = "Precio de Cotización";
            precioCotizacionColumna.Name = "PrecioCotizacion";
            grdInsumos.Columns.Add(precioCotizacionColumna);


            
            foreach (var item in items)
            {
                grdInsumos.Rows.Add(item.Ingrediente.Nombre, item.CantidadRequerida, item.PrecioCotizacion);
            }

            grdInsumos.Columns["Cantidad"].ReadOnly = true;
            grdInsumos.Columns["PrecioCotizacion"].ReadOnly = false;
            grdInsumos.AllowUserToAddRows = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            

            
            foreach (DataGridViewRow row in grdInsumos.Rows)
            {
                    string nombreIngrediente = row.Cells["Ingrediente"].Value.ToString();

                    
                    var itemOriginal = solicitudSeleccionada.Ingredientes.FirstOrDefault(item => item.Ingrediente.Nombre == nombreIngrediente);


                    if (itemOriginal != null)
                    {

                        float precioCotizacion = Convert.ToSingle(row.Cells["PrecioCotizacion"].Value);


                        itemOriginal.PrecioCotizacion = precioCotizacion;

                    }
            }
                
            Proveedor proveedor = (Proveedor)cmbProveedores.SelectedItem;
            string observaciones = txtObservaciones.Text;
            string condicion = txtCondicion.Text;


            BE.OrdenDeCompra orden = new BE.OrdenDeCompra(proveedor, solicitudSeleccionada, observaciones, condicion);
            orden.NroOrden = bllOrdenDeCompra.Insertar(orden);
            if(orden.NroOrden !=-1)
            {
                string result = bllOrdenDeCompra.EnviarEmail(orden);
                MessageBox.Show(result);
                ActualizarGrillaSolicitudes();
            }
            else
            {
                MessageBox.Show("Error al generar la orden de compra");
            }


        }
    }
}
