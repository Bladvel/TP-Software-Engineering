using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        BLL.ESTADO bllEstado;
        BLL.USUARIO bllUsuario;
        public Form1()
        {
            InitializeComponent();
            bllEstado = new BLL.ESTADO();
            bllUsuario = new BLL.USUARIO();
        }

        private void btnMostrarEstado_Click(object sender, EventArgs e)
        {
            ActualizarEstados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarEstados();
            ActualizarUsuarios();
        }

        public void ActualizarEstados()
        {
            lstEstado.DataSource = null;
            lstEstado.DataSource = bllEstado.ObtenerEstados();

            comboBox1.DataSource = null;
            comboBox1.DataSource = bllEstado.ObtenerEstados();
        }

        private void btnCargarEstado_Click(object sender, EventArgs e)
        {
            BE.ESTADO eSTADO = new BE.ESTADO();

            eSTADO.Estado = txtEstado.Text;

            bllEstado.Grabar(eSTADO);

            ActualizarEstados();
        }

        private void btnModificarEstado_Click(object sender, EventArgs e)
        {
            if(lstEstado.SelectedItem != null)
            {
                BE.ESTADO estado =(BE.ESTADO)lstEstado.SelectedItem;
                estado.Estado = txtEstado.Text;
                bllEstado.Grabar(estado);
                ActualizarEstados();

            }
        }

        private void btnEliminarEstado_Click(object sender, EventArgs e)
        {
            if (lstEstado.SelectedItem != null)
            {
                BE.ESTADO estado = (BE.ESTADO)lstEstado.SelectedItem;
                bllEstado.Eliminar(estado);
                ActualizarEstados();

            }
        }

        private void btnCargarUsuario_Click(object sender, EventArgs e)
        {
            BE.USUARIO uSUARIO = new BE.USUARIO();
            uSUARIO.Nombre = txtNombre.Text;
            uSUARIO.DNI = int.Parse(txtDNI.Text);
            uSUARIO.EstadoCivil = comboBox1.SelectedItem as BE.ESTADO;

            bllUsuario.Grabar(uSUARIO);

            ActualizarUsuarios();
            
        }

        private void ActualizarUsuarios()
        {
            lstUsuarios.DataSource = null;
            lstUsuarios.DataSource = bllUsuario.ObtenerUsuarios();
        }

        private void btnMostrarUsuario_Click(object sender, EventArgs e)
        {
            ActualizarUsuarios();
        }
    }
}
