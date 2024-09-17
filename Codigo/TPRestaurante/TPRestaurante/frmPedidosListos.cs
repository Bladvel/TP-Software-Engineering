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
using Services;

namespace TPRestaurante
{
    public partial class frmPedidosListos : Form, IIdiomaObserver
    {
        public frmPedidosListos()
        {
            InitializeComponent();
            bllPedido = new BLL.Pedido();
            bllCajero = new BLL.ControllerCajero();
        }

        private BLL.Pedido bllPedido;
        private BLL.ControllerCajero bllCajero;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdPedidosListos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPedidosListos_Load(object sender, EventArgs e)
        {
            grdPedidosListos.RowHeadersVisible = false;
            grdPedidosListos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPedidosListos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            LlenarGrillaPedidos();
            SessionManager.SuscribirObservador(this);
            Traducir(SessionManager.Instance.User.Idioma);
        }

        private void LlenarGrillaPedidos()
        {
            grdPedidosListos.DataSource = null;
            grdPedidosListos.DataSource = bllPedido.ListarPorEstado(OrderType.Listo);
            RegistroBitacoraVerPedidos();
        }

        private void RegistroBitacoraVerPedidos()
        {
            var bitacora = new Services.Bitacora
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


        private void btnCerrarPedido_Click(object sender, EventArgs e)
        {
            if (grdPedidosListos.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un pedido a cerrar");
            }
            else
            {
                Pedido pedidoSeleccionado = grdPedidosListos.CurrentRow.DataBoundItem as Pedido;
                if (bllCajero.CerrarPedido(pedidoSeleccionado))
                {
                    MessageBox.Show("Pedido cerrado exitosamente. Por favor entregar al cliente");
                    RegistroBitacoraCerrarPedidos();
                    LlenarGrillaPedidos();
                }
                else
                {
                    MessageBox.Show("Error al cerrar el pedido. No ha sido pagado");
                }
                

            }
        }

        private void RegistroBitacoraCerrarPedidos()
        {
            var bitacora = new Services.Bitacora
            {
                Fecha = DateTime.Now,
                Usuario = SessionManager.Instance.User,
                Modulo = TipoModulo.VistaPedidosListos,
                Operacion = TipoOperacion.CerrarPedidos,
                Criticidad = 3
            };

            var bllBitacora = new BLL.Bitacora();
            bllBitacora.Insertar(bitacora);
        }



        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma = null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);


            if (label1.Tag != null && traducciones.ContainsKey(label1.Tag.ToString()))
                label1.Text = traducciones[label1.Tag.ToString()].Texto;
            if (btnCerrarPedido.Tag != null && traducciones.ContainsKey(btnCerrarPedido.Tag.ToString()))
                btnCerrarPedido.Text = traducciones[btnCerrarPedido.Tag.ToString()].Texto;
            if (btnCancelar.Tag != null && traducciones.ContainsKey(btnCancelar.Tag.ToString()))
                btnCancelar.Text = traducciones[btnCancelar.Tag.ToString()].Texto;
        }

        private void frmPedidosListos_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }
    }
}
