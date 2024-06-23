using Interfaces;
using Services;
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


namespace TPRestaurante
{
    public partial class frmVerComandas : Form
    {
        public frmVerComandas()
        {
            InitializeComponent();
            bllComanda = new BLL.Comanda();
            bllCocinero = new BLL.ControllerCocinero();
        }

        private void frmVerComandas_Load(object sender, EventArgs e)
        {
            btnNotificarPedidoListo.Visible = SessionManager.Instance.IsInRole(PermissionType.NotificarPedidoListo);

            grdComandas.RowHeadersVisible = false;
            grdComandas.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdComandas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            LlenarGridComandas();


            grdProductos.RowHeadersVisible = false;
            grdProductos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            btnNotificarPedidoListo.Enabled = false;

        }

        private BLL.Comanda bllComanda;
        private void LlenarGridComandas()
        {
            grdComandas.DataSource = null;
            grdComandas.DataSource = bllComanda.ListarEnCursoPorCocinero(SessionManager.Instance.User as User);

        }

        private void grdComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                Comanda comandaSeleccionada = grdComandas.Rows[e.RowIndex].DataBoundItem as Comanda;



                if (comandaSeleccionada != null)
                {
                    LlenarGrillaProductos(comandaSeleccionada);
                    btnNotificarPedidoListo.Enabled = true;
                }
                else
                {
                    btnNotificarPedidoListo.Enabled = false;
                }

            }
            else
            {
                btnNotificarPedidoListo.Enabled = false;

            }
        }

        private void LlenarGrillaProductos(Comanda comandaSeleccionada)
        {
            grdProductos.Columns.Clear();
            grdProductos.AutoGenerateColumns = false;
            grdProductos.DataSource = null;

            grdProductos.DataSource = comandaSeleccionada.PedidoAsignado.Productos;

            DataGridViewTextBoxColumn productoColumn = new DataGridViewTextBoxColumn();
            productoColumn.HeaderText = "Producto";
            productoColumn.DataPropertyName = "Producto";
            productoColumn.ReadOnly = true;
            grdProductos.Columns.Add(productoColumn);

            DataGridViewTextBoxColumn cantidadColumn = new DataGridViewTextBoxColumn();
            cantidadColumn.HeaderText = "Cantidad";
            cantidadColumn.DataPropertyName = "Cantidad";
            cantidadColumn.ReadOnly = true;
            grdProductos.Columns.Add(cantidadColumn);


        }

        private BLL.ControllerCocinero bllCocinero;
        private void btnNotificarPedidoListo_Click(object sender, EventArgs e)
        {
            if (grdComandas.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una comanda.");
                return;
            }

            // Obtener la comanda seleccionada
            Comanda comandaSeleccionada = grdComandas.CurrentRow.DataBoundItem as Comanda;

            if (comandaSeleccionada != null)
            {

                bllCocinero.RealizarComanda(comandaSeleccionada);
                
                MessageBox.Show("El pedido ha sido actualizado a 'Listo' y el cocinero está ahora 'Disponible'.");
                

                LlenarGridComandas();
                
            }
            else
            {
                MessageBox.Show("Error al obtener la comanda seleccionada.");
            }
        }
    }
}
