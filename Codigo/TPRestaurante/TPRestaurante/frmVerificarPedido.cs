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
using Services;
using BE;

namespace TPRestaurante
{
    public partial class frmVerificarPedido : Form
    {
        public frmVerificarPedido()
        {
            InitializeComponent();
            bllPedido = new BLL.Pedido();
            controllerJefeDeCocina = new BLL.ControllerJefeDeCocina();
        }

        private void ucButtonSecondary1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private BLL.Pedido bllPedido;


        private void frmVerificarPedido_Load(object sender, EventArgs e)
        {
            btnVerificarPedido.Visible = SessionManager.Instance.IsInRole(PermissionType.VerificarPedido);
            btnAceptarPedido.Visible = SessionManager.Instance.IsInRole(PermissionType.VerificarPedido);
            btnRechazarPedido.Visible = SessionManager.Instance.IsInRole(PermissionType.VerificarPedido);

            grdIngredientesDisponibles.Visible = SessionManager.Instance.IsInRole(PermissionType.VerificarPedido);
            grdIngredientesFaltantes.Visible = SessionManager.Instance.IsInRole(PermissionType.VerificarPedido);



            btnVerificarPedido.Enabled = false;
            btnAceptarPedido.Enabled = false;
            btnRechazarPedido.Enabled = false;

            grdPedidos.RowHeadersVisible = false;
            grdPedidos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdPedidos.DataSource = null;
            grdPedidos.DataSource = bllPedido.ListarPorEstado(OrderType.Creado);


            grdProductosPedido.RowHeadersVisible = false;
            grdProductosPedido.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdProductosPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            grdIngredientesDisponibles.RowHeadersVisible = false;
            grdIngredientesDisponibles.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdIngredientesDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdIngredientesFaltantes.RowHeadersVisible = false;
            grdIngredientesFaltantes.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdIngredientesFaltantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private BE.Pedido pedidoSeleccionado;

        private void grdPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                pedidoSeleccionado = grdPedidos.Rows[e.RowIndex].DataBoundItem as Pedido;



                if (pedidoSeleccionado != null)
                {
                    LlenarGridProductos(pedidoSeleccionado);
                    btnVerificarPedido.Enabled = true;
                    
                }
                else
                {
                    btnVerificarPedido.Enabled = false;
                }

            }
            else
            {
                btnVerificarPedido.Enabled = false;
            }

            btnAceptarPedido.Enabled = false;
            btnRechazarPedido.Enabled = false;
        }

        //private void LlenarGridProductos(Pedido pedidoSeleccionado)
        //{
        //    grdProductosPedido.Columns.Clear();
        //    grdProductosPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    grdProductosPedido.EditMode = DataGridViewEditMode.EditProgrammatically;
        //    grdProductosPedido.RowHeadersVisible = false;

        //    grdProductosPedido.AutoGenerateColumns = false;
        //    grdProductosPedido.DataSource = null;
        //    grdProductosPedido.DataSource = pedidoSeleccionado.Productos;


        //    DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
        //    nameColumn.HeaderText = "PRODUCTO";
        //    nameColumn.DataPropertyName = "Producto";
        //    nameColumn.ReadOnly = true;
        //    grdProductosPedido.Columns.Add(nameColumn);

        //    DataGridViewTextBoxColumn cantidadColumn = new DataGridViewTextBoxColumn();
        //    nameColumn.HeaderText = "CANTIDAD";
        //    nameColumn.DataPropertyName = "Cantidad";
        //    nameColumn.ReadOnly = true;
        //    grdProductosPedido.Columns.Add(cantidadColumn);



        //}

        private void LlenarGridProductos(Pedido pedidoSeleccionado)
        {

            grdProductosPedido.DataSource = null;
            grdProductosPedido.DataSource = pedidoSeleccionado.Productos;

        }

        private BLL.ControllerJefeDeCocina controllerJefeDeCocina;


        private void btnVerificarPedido_Click(object sender, EventArgs e)
        {
            if (pedidoSeleccionado != null)
            {
                var (ingredientesDisponibles, ingredientesFaltantes) = controllerJefeDeCocina.VerificarDisponibilidad(pedidoSeleccionado);

                grdIngredientesDisponibles.DataSource = null;
                grdIngredientesDisponibles.DataSource = ingredientesDisponibles;

                grdIngredientesFaltantes.DataSource = null;
                grdIngredientesFaltantes.DataSource = ingredientesFaltantes;

                if (ingredientesFaltantes.Count > 0)
                {
                    MessageBox.Show("Algunos ingredientes no están disponibles.");
                    btnAceptarPedido.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Todos los ingredientes están disponibles.");
                    btnAceptarPedido.Enabled = true;
                }

                btnRechazarPedido.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor seleccione un pedido");
                btnAceptarPedido.Enabled = false;
                btnRechazarPedido.Enabled = false;
            }
        }

        private void btnAceptarPedido_Click(object sender, EventArgs e)
        {
            if (pedidoSeleccionado != null)
            {
                controllerJefeDeCocina.AceptarPedido(pedidoSeleccionado);
                btnAceptarPedido.Enabled = false;
                btnRechazarPedido.Enabled = false;
                btnVerificarPedido.Enabled = false;
                MessageBox.Show("Pedido aceptado con éxito");

                grdPedidos.DataSource = null;
                grdPedidos.DataSource = bllPedido.ListarPorEstado(OrderType.Creado);
            }
            else
            {
                MessageBox.Show("Selecciona un pedido primero");
            }
        }

        private void btnRechazarPedido_Click(object sender, EventArgs e)
        {
            if (pedidoSeleccionado != null)
            {
                controllerJefeDeCocina.RechazarPedido(pedidoSeleccionado);
                btnAceptarPedido.Enabled = false;
                btnRechazarPedido.Enabled = false;
                btnVerificarPedido.Enabled = false;
                MessageBox.Show("Pedido Rechazado con éxito");

                grdPedidos.DataSource = null;
                grdPedidos.DataSource = bllPedido.ListarPorEstado(OrderType.Creado);
            }
            else
            {
                MessageBox.Show("Selecciona un pedido primero");
            }
        }
    }
}
