using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEncriptador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            txtEncriptado.Text = Encryption.Encriptar(txtEncriptar.Text);
            txtDesencriptado.Text = Encryption.Desencriptar(txtEncriptado.Text);
        }
    }
}
