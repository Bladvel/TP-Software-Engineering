using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Interfaces;
using Services;
using Services.Multiidioma;
using Comanda = BE.Comanda;
using Pedido = BE.Pedido;
using User = BE.User;

namespace TPRestaurante
{
    public partial class frmGenerarComanda : Form, IIdiomaObserver
    {
        public frmGenerarComanda()
        {
            InitializeComponent();
            bllPedido = new BLL.Pedido();
            bllUser = new BLL.User();
            bllJefeDeCocina = new ControllerJefeDeCocina();
        }

        private BLL.Pedido bllPedido;
        private BLL.User bllUser;
        private BE.Pedido pedidoSeleccionado;
        private BLL.ControllerJefeDeCocina bllJefeDeCocina;


        private void frmGenerarComanda_Load(object sender, EventArgs e)
        {
            grdCocinerosDisponibles.RowHeadersVisible = false;
            grdCocinerosDisponibles.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdCocinerosDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdProductosPorPedido.RowHeadersVisible = false;
            grdProductosPorPedido.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdProductosPorPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdPedidosAceptados.RowHeadersVisible = false;
            grdPedidosAceptados.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPedidosAceptados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            LlenarGridPedidos();


            grdCocinerosDisponibles.Enabled = false;
            btnGenerarComanda.Enabled = false;
            txtInstrucciones.Enabled = false;
            
            SessionManager.SuscribirObservador(this);
            Traducir(SessionManager.Instance.User.Idioma);

        }

        private void grdPedidosAceptados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                pedidoSeleccionado = grdPedidosAceptados.Rows[e.RowIndex].DataBoundItem as Pedido;



                if (pedidoSeleccionado != null)
                {
                    LlenarGridProductos(pedidoSeleccionado);
                    grdCocinerosDisponibles.Enabled = true;
                    
                    LlenarGridCocineros();

                    btnGenerarComanda.Enabled = true;
                    txtInstrucciones.Enabled = true;

                }
                else
                {
                    grdCocinerosDisponibles.Enabled = false;
                    btnGenerarComanda.Enabled = false;
                    txtInstrucciones.Enabled = false;
                }

            }
            else
            {
                grdCocinerosDisponibles.Enabled = false;
                btnGenerarComanda.Enabled = false;
                txtInstrucciones.Enabled = false;
                
            }
        }

        private void LlenarGridProductos(Pedido pedido)
        {
            grdProductosPorPedido.DataSource = null;
            grdProductosPorPedido.DataSource = pedidoSeleccionado.Productos;
        }

        private void LlenarGridPedidos()
        {
            grdPedidosAceptados.DataSource = null;
            grdPedidosAceptados.DataSource = bllPedido.ListarPorEstado(OrderType.Aceptado);
        }

        private void LlenarGridCocineros()
        {
            grdCocinerosDisponibles.Columns.Clear();
            grdCocinerosDisponibles.AutoGenerateColumns = false;
            grdCocinerosDisponibles.DataSource = null;

            grdCocinerosDisponibles.DataSource = bllUser.ListAvailableChefs();

            DataGridViewTextBoxColumn nombreCompletoColumn = new DataGridViewTextBoxColumn();
            nombreCompletoColumn.HeaderText = "Nombre completo";
            nombreCompletoColumn.DataPropertyName = "NombreCompleto";
            nombreCompletoColumn.ReadOnly = true;
            grdCocinerosDisponibles.Columns.Add(nombreCompletoColumn);

            DataGridViewTextBoxColumn disponibilidadColumn = new DataGridViewTextBoxColumn();
            disponibilidadColumn.HeaderText = "Disponibilidad";
            disponibilidadColumn.DataPropertyName = "Availability";
            disponibilidadColumn.ReadOnly = true;
            grdCocinerosDisponibles.Columns.Add(disponibilidadColumn);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarComanda_Click(object sender, EventArgs e)
        {

            if (grdPedidosAceptados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un pedido.");
                return;
            }


            if (grdCocinerosDisponibles.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un cocinero.");
                return;
            }


            Pedido pedidoSeleccionado = grdPedidosAceptados.CurrentRow.DataBoundItem as Pedido;

            User cocineroSeleccionado = grdCocinerosDisponibles.CurrentRow.DataBoundItem as User;

            string instrucciones = txtInstrucciones.Text;

            bool result = bllJefeDeCocina.GenerarComanda(pedidoSeleccionado, cocineroSeleccionado, instrucciones);
            

            if (result)
            {
                MessageBox.Show("Comanda generada exitosamente");
                LlenarGridCocineros();
                LlenarGridPedidos();
                txtInstrucciones.Clear();
                
            }
            else
            {
                MessageBox.Show("Error al generar la comanda.");
            }
        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma=null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);


            if (label1.Tag != null && traducciones.ContainsKey(label1.Tag.ToString()))
                label1.Text = traducciones[label1.Tag.ToString()].Texto;
            if (label2.Tag != null && traducciones.ContainsKey(label2.Tag.ToString()))
                label2.Text = traducciones[label2.Tag.ToString()].Texto;
            if (label3.Tag != null && traducciones.ContainsKey(label3.Tag.ToString()))
                label3.Text = traducciones[label3.Tag.ToString()].Texto;
            if (label4.Tag != null && traducciones.ContainsKey(label4.Tag.ToString()))
                label4.Text = traducciones[label4.Tag.ToString()].Texto;

            if (btnGenerarComanda.Tag != null && traducciones.ContainsKey(btnGenerarComanda.Tag.ToString()))
                btnGenerarComanda.Text = traducciones[btnGenerarComanda.Tag.ToString()].Texto;
            if (btnCancelar.Tag != null && traducciones.ContainsKey(btnCancelar.Tag.ToString()))
                btnCancelar.Text = traducciones[btnCancelar.Tag.ToString()].Texto;
        }

        private void frmGenerarComanda_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }
    }
}
