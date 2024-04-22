using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_CINE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BLL.PELICULA pel = new BLL.PELICULA();
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = pel.ObtenerPeliculas();
        }
    }
}
