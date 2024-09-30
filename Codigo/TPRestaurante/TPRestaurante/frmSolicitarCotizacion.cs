using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPRestaurante
{
    public partial class frmSolicitarCotizacion : Form
    {
        public frmSolicitarCotizacion()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            //Debo validar que solo haya una solicitud seleccionada (no se si creacion o por validacion)
            //ACtualiza el estado de la solicitud a enviada
        }
    }
}
