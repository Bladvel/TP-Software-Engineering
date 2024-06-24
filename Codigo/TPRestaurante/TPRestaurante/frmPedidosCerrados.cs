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
using Services.Multiidioma;

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
            SessionManager.SuscribirObservador(this);
            Traducir(SessionManager.Instance.User.Idioma);
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
