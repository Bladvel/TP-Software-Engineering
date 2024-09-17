using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace TPRestaurante
{
    public partial class frmPedidosCerrados : Form, IIdiomaObserver
    {
        public frmPedidosCerrados()
        {
            InitializeComponent();
            bllPedido = new BLL.Pedido();
        }
        BLL.Pedido bllPedido;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPedidosCerrados_Load(object sender, EventArgs e)
        {
            grdPedidos.RowHeadersVisible = false;
            grdPedidos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            grdPedidos.DataSource = null;
            grdPedidos.DataSource = bllPedido.ListarPorEstado(OrderType.Entregado);
            RegistroBitacoraVerPedidos();
            SessionManager.SuscribirObservador(this);
            Traducir(SessionManager.Instance.User.Idioma);
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
        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma=null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);


            if (label1.Tag != null && traducciones.ContainsKey(label1.Tag.ToString()))
                label1.Text = traducciones[label1.Tag.ToString()].Texto;
            if (btnCerrar.Tag != null && traducciones.ContainsKey(btnCerrar.Tag.ToString()))
                btnCerrar.Text = traducciones[btnCerrar.Tag.ToString()].Texto;
        }

        private void frmPedidosCerrados_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }
    }
}
