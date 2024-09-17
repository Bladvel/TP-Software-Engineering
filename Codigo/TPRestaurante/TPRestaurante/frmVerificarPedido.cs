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
    public partial class frmVerificarPedido : Form, IIdiomaObserver
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
            RegistroBitacoraVerPedidos();

            grdProductosPedido.RowHeadersVisible = false;
            grdProductosPedido.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdProductosPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            grdIngredientesDisponibles.RowHeadersVisible = false;
            grdIngredientesDisponibles.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdIngredientesDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdIngredientesFaltantes.RowHeadersVisible = false;
            grdIngredientesFaltantes.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdIngredientesFaltantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            SessionManager.SuscribirObservador(this);
            Traducir(SessionManager.Instance.User.Idioma);

        }

        private void RegistroBitacoraVerPedidos()
        {
            var bitacora = new Bitacora
            {
                Fecha = DateTime.Now,
                Usuario = SessionManager.Instance.User,
                Modulo = TipoModulo.VistaPedidos,
                Operacion = TipoOperacion.VerPedidos,
                Criticidad = 5
            };

            var bllBitacora = new BLL.Bitacora();
            bllBitacora.Insertar(bitacora);
        }


        private void RegistroBitacoraAceptarPedido()
        {
            var bitacora = new Bitacora
            {
                Fecha = DateTime.Now,
                Usuario = SessionManager.Instance.User,
                Modulo = TipoModulo.VerificarPedido,
                Operacion = TipoOperacion.AceptarPedido,
                Criticidad = 4
            };

            var bllBitacora = new BLL.Bitacora();
            bllBitacora.Insertar(bitacora);
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
                RegistroBitacoraAceptarPedido();
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


        private void RegistroBitacoraRechazarPedido()
        {
            var bitacora = new Bitacora
            {
                Fecha = DateTime.Now,
                Usuario = SessionManager.Instance.User,
                Modulo = TipoModulo.VerificarPedido,
                Operacion = TipoOperacion.RechazarPedido,
                Criticidad = 4
            };

            var bllBitacora = new BLL.Bitacora();
            bllBitacora.Insertar(bitacora);
        }

        private void btnRechazarPedido_Click(object sender, EventArgs e)
        {
            if (pedidoSeleccionado != null)
            {
                controllerJefeDeCocina.RechazarPedido(pedidoSeleccionado);
                RegistroBitacoraRechazarPedido();
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

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma = null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);

            if (groupBox1.Tag != null && traducciones.ContainsKey(groupBox1.Tag.ToString()))
                groupBox1.Text = traducciones[groupBox1.Tag.ToString()].Texto;
            if (groupBox2.Tag != null && traducciones.ContainsKey(groupBox2.Tag.ToString()))
                groupBox2.Text = traducciones[groupBox2.Tag.ToString()].Texto;
            if (label2.Tag != null && traducciones.ContainsKey(label2.Tag.ToString()))
                label2.Text = traducciones[label2.Tag.ToString()].Texto;
            if (label3.Tag != null && traducciones.ContainsKey(label3.Tag.ToString()))
                label3.Text = traducciones[label3.Tag.ToString()].Texto;
            if (label4.Tag != null && traducciones.ContainsKey(label4.Tag.ToString()))
                label4.Text = traducciones[label4.Tag.ToString()].Texto;
            if (label5.Tag != null && traducciones.ContainsKey(label5.Tag.ToString()))
                label5.Text = traducciones[label5.Tag.ToString()].Texto;

            if (btnCancelar.Tag != null && traducciones.ContainsKey(btnCancelar.Tag.ToString()))
                btnCancelar.Text = traducciones[btnCancelar.Tag.ToString()].Texto;
            if (btnVerificarPedido.Tag != null && traducciones.ContainsKey(btnVerificarPedido.Tag.ToString()))
                btnVerificarPedido.Text = traducciones[btnVerificarPedido.Tag.ToString()].Texto;
            if (btnAceptarPedido.Tag != null && traducciones.ContainsKey(btnAceptarPedido.Tag.ToString()))
                btnAceptarPedido.Text = traducciones[btnAceptarPedido.Tag.ToString()].Texto;
            if (btnRechazarPedido.Tag != null && traducciones.ContainsKey(btnRechazarPedido.Tag.ToString()))
                btnRechazarPedido.Text = traducciones[btnRechazarPedido.Tag.ToString()].Texto;
        }

        private void frmVerificarPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }
    }
}
