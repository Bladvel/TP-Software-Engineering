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
    public partial class frmGenerarOrdenDeCompra : Form
    {
        public frmGenerarOrdenDeCompra()
        {
            InitializeComponent();
        }

        private void frmGenerarOrdenDeCompra_Load(object sender, EventArgs e)
        {

        }



        //El nroDeOrden se genera automaticamente y lo guardo en la base de datos como PK, verificando primero que no exista.
        //Debo colocar en el documento el usuario que lo genero pero no lo asocio en la base de datos (lo puedo ver en la bitacora de eventos)
    }
}
