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
    public partial class frmVerComandas : Form, IIdiomaObserver
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

            SessionManager.SuscribirObservador(this);
            Traducir(SessionManager.Instance.User.Idioma);

        }

        private BLL.Comanda bllComanda;
        private void LlenarGridComandas()
        {
            grdComandas.DataSource = null;
            grdComandas.DataSource = bllComanda.ListarEnCursoPorCocinero(SessionManager.Instance.User as User);
            RegistroBitacoraVistaDeComandas();

        }

        
        private void RegistroBitacoraVistaDeComandas()
        {
            var bitacora = new Services.Bitacora
            {
                Fecha = DateTime.Now,
                Usuario = SessionManager.Instance.User,
                Modulo = TipoModulo.VistaDeComandas,
                Operacion = TipoOperacion.VerComanda,
                Criticidad = 5
            };

            var bllBitacora = new BLL.Bitacora();
            bllBitacora.Insertar(bitacora);
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
                RegistroBitacoraNotificarPedidoListo();

                LlenarGridComandas();
                
            }
            else
            {
                MessageBox.Show("Error al obtener la comanda seleccionada.");
            }
        }

        private void RegistroBitacoraNotificarPedidoListo()
        {
            var bitacora = new Services.Bitacora
            {
                Fecha = DateTime.Now,
                Usuario = SessionManager.Instance.User,
                Modulo = TipoModulo.VistaDeComandas,
                Operacion = TipoOperacion.NotificarPedidoListo,
                Criticidad = 5
            };

            var bllBitacora = new BLL.Bitacora();
            bllBitacora.Insertar(bitacora);
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


            if (btnCancelar.Tag != null && traducciones.ContainsKey(btnCancelar.Tag.ToString()))
                btnCancelar.Text = traducciones[btnCancelar.Tag.ToString()].Texto;
            if (btnNotificarPedidoListo.Tag != null && traducciones.ContainsKey(btnNotificarPedidoListo.Tag.ToString()))
                btnNotificarPedidoListo.Text = traducciones[btnNotificarPedidoListo.Tag.ToString()].Texto;
        }

        private void frmVerComandas_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }
    }
}
