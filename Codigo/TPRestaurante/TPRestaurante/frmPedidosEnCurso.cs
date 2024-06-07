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
    public partial class frmPedidosEnCurso : Form
    {
        public frmPedidosEnCurso()
        {
            InitializeComponent();
        }

        private void ucButtonSecondary1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPedidosEnCurso_Load(object sender, EventArgs e)
        {
            btnNotificarPedidoListo.Visible = SessionManager.Instance.IsInRole(PermissionType.NotificarPedidoListo);
        }
    }
}
