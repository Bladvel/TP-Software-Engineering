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

namespace TPRestaurante
{
    public partial class frmPedidosEnCurso : Form, IIdiomaObserver
    {
        public frmPedidosEnCurso()
        {
            InitializeComponent();
            bllPedido = new BLL.Pedido();
        }

        private BLL.Pedido bllPedido;
        private void ucButtonSecondary1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPedidosEnCurso_Load(object sender, EventArgs e)
        {
            grdPedidos.RowHeadersVisible = false;
            grdPedidos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            grdPedidos.DataSource = null;
            grdPedidos.DataSource = bllPedido.ListarPorEstado(OrderType.EnPreparacion);

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
        private void frmPedidosEnCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
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
            if (ucButtonSecondary1.Tag != null && traducciones.ContainsKey(ucButtonSecondary1.Tag.ToString()))
                ucButtonSecondary1.Text = traducciones[ucButtonSecondary1.Tag.ToString()].Texto;
        }
    }
}
