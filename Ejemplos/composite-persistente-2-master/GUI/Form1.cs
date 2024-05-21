using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASES;
using NEGOCIO;

namespace GUI
{
    public partial class Form1 : Form
    {
        
        GESTOR gestor ;
        List<USUARIO> usuarios = new List<USUARIO>();
        public Form1()
        {
            InitializeComponent();
            usuarios.Add(new USUARIO(1,"a") );
            usuarios.Add(new USUARIO(2,"b") );
            usuarios.Add(new USUARIO(3,"c") );

            gestor = new GESTOR();

            foreach ( USUARIO u in usuarios)
            {
                gestor.CompletarPermisos(u);
                comboBox2.Items.Add(u);
            }
            comboBox2.DisplayMember = "nombre";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource=gestor.Listar();
            comboBox1.DisplayMember = "Descripcion";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.DataSource = null;
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem is GRUPO)
            { 
                GRUPO g = (GRUPO)comboBox1.SelectedItem;
                listBox1.DataSource = g.Permisos;
                listBox1.DisplayMember = "Descripcion";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.DataSource = null;
            if (comboBox2.SelectedItem != null )
            {
                USUARIO u = (USUARIO)comboBox2.SelectedItem;
                listBox1.DataSource = u.Permisos;
                listBox1.DisplayMember = "Descripcion";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.DataSource = null;
            if (listBox1.SelectedItem != null && listBox1.SelectedItem is GRUPO)
            {
                GRUPO g = (GRUPO)listBox1.SelectedItem;
                listBox2.DataSource = g.Permisos;
                listBox2.DisplayMember = "Descripcion";
            }
        }
    }
}
