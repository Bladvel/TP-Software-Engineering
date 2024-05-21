using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer1.UI
{
    public partial class Form1 : Form
    {
        public void Notificar(string s)
        {
            this.lstNotificaciones.Items.Add(s);
        }
        private List<ISujetoProducto> _productos;
        private List<IObserverUsuario> _usuarios;


        private ISujetoProducto _producto;
        private IObserverUsuario _usuario;


        public Form1()
        {
            InitializeComponent();

            _productos = new List<ISujetoProducto>();
            _usuarios = new List<IObserverUsuario>();
            simularDatos();
        }

      
        private void simularDatos()
        {
            _productos.Add(new Producto("producto a", 100));
            _productos.Add(new Producto("producto b", 200));
            _productos.Add(new Producto("producto c", 300));
            _productos.Add(new Producto("producto d", 400));
            _usuarios.Add(new Usuario("Diego", "Maradona"));
            _usuarios.Add(new Usuario("Leonel", "Messi"));
            _usuarios.Add(new Usuario("Paulo", "Silas"));

            mostrarProductos();
            mostrarUsuarios();
        }

        private void mostrarProductos()
        {
            this.lstProductos.DataSource = null;
            this.lstProductos.DataSource = _productos;

        }
        private void mostrarUsuarios()
        {
            this.lstUsuarios.DataSource = null;
            this.lstUsuarios.DataSource = _usuarios;
        }

        private void lstProductos_SelectedValueChanged(object sender, EventArgs e)
        {

             _producto = (ISujetoProducto)((ListBox)sender).SelectedItem;

        }

        private void lstUsuarios_SelectedValueChanged(object sender, EventArgs e)
        {
            _usuario = (IObserverUsuario)((ListBox)sender).SelectedItem;
        }

        private void btnSuscribir_Click(object sender, EventArgs e)
        {
            if (_producto!=null && _usuario != null)
            {
                try
                {
                    _producto.Agregar(_usuario);
                    MessageBox.Show("Suscripción correcta");

                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar producto y usuario");
            }
        }

        private void btnDesuscribir_Click(object sender, EventArgs e)
        {
            if (_producto != null && _usuario != null)
            {
                try
                {
                    _producto.Quitar(_usuario);
                   MessageBox.Show("Desuscripción correcta");

                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
               
            }
            else
            {
                MessageBox.Show("Debe seleccionar producto y usuario");
            }
        }

        private void lstProductos_DoubleClick(object sender, EventArgs e)
        {

            double p;

            if (double.TryParse(Interaction.InputBox("Ingrese el nuevo precio: "), out p))
            {
                ((Producto)_producto).Precio = p;
                mostrarProductos();
            }

         
        }
    }
}
