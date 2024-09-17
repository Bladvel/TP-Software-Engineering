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
    public partial class frmPedidosVerificados : Form, IIdiomaObserver
    {
        public frmPedidosVerificados()
        {
            InitializeComponent();
            bllPedido = new BLL.Pedido();
        }

        private BLL.Pedido bllPedido;


        private void frmPedidosVerificados_Load(object sender, EventArgs e)
        {
            grdPedidosAceptados.RowHeadersVisible = false;
            grdPedidosAceptados.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPedidosAceptados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            grdPedidosAceptados.DataSource = null;
            grdPedidosAceptados.DataSource = bllPedido.ListarPorEstado(OrderType.Aceptado);

            grdPedidosRechazados.RowHeadersVisible = false;
            grdPedidosRechazados.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPedidosRechazados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdPedidosRechazados.DataSource = null;
            grdPedidosRechazados.DataSource = bllPedido.ListarPorEstado(OrderType.Rechazado);
            RegistroBitacoraVerPedidos();
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
        private void Traducir(IIdioma idioma)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);

            if (groupBox1.Tag != null && traducciones.ContainsKey(groupBox1.Tag.ToString()))
                groupBox1.Text = traducciones[groupBox1.Tag.ToString()].Texto;

            if (label1.Tag != null && traducciones.ContainsKey(label1.Tag.ToString()))
                label1.Text = traducciones[label1.Tag.ToString()].Texto;
            if (label2.Tag != null && traducciones.ContainsKey(label2.Tag.ToString()))
                label2.Text = traducciones[label2.Tag.ToString()].Texto;
            if (btnCerrar.Tag != null && traducciones.ContainsKey(btnCerrar.Tag.ToString()))
                btnCerrar.Text = traducciones[btnCerrar.Tag.ToString()].Texto;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void frmPedidosVerificados_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }
    }
}
