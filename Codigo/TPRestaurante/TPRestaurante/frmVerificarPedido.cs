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
        }

        private void ucButtonSecondary1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private BLL.Pedido bllPedido;


        private void frmVerificarPedido_Load(object sender, EventArgs e)
        {
            btnVerificarPedido.Visible = SessionManager.Instance.IsInRole(PermissionType.VerificarPedido);

            grdPedidos.RowHeadersVisible = false;
            grdPedidos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdPedidos.DataSource = null;
            grdPedidos.DataSource = bllPedido.ListarPorEstado(OrderType.Creado);


            grdProductosPedido.RowHeadersVisible = false;
            grdProductosPedido.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdProductosPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void grdPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                var pedidoSeleccionado = grdPedidos.Rows[e.RowIndex].DataBoundItem as Pedido;



                if (pedidoSeleccionado != null)
                {
                    LlenarGridProductos(pedidoSeleccionado);
                }
            }
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


        //TODO Manejar el evento de seleccionar la celda de pedido y mostrar los productos
    }
}
