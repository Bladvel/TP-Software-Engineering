using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;



namespace TPRestaurante
{
    public partial class frmCreateOrder : Form
    {
        public frmCreateOrder()
        {
            InitializeComponent();
            catalogo = new BLL.CatalogoProductos();
            controllerCajero = new BLL.ControllerCajero();
            bllPedido = new BLL.Pedido();
        }

        private void ucButtonSecondary1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private BLL.CatalogoProductos catalogo;
        private BLL.ControllerCajero controllerCajero;
        private BLL.Pedido bllPedido;
        private void frmCreateOrder_Load(object sender, EventArgs e)
        {
            lstCatalogoProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lstCatalogoProductos.EditMode = DataGridViewEditMode.EditProgrammatically;
            lstCatalogoProductos.RowHeadersVisible = false;


            lstCatalogoProductos.AutoGenerateColumns = false;
            lstCatalogoProductos.DataSource = null;
            lstCatalogoProductos.DataSource = catalogo.ListarProductos();


            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "PRODUCTO";
            nameColumn.DataPropertyName = "Nombre";
            nameColumn.ReadOnly = true;
            lstCatalogoProductos.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.HeaderText = "PRECIO";
            priceColumn.DataPropertyName = "PrecioActual";
            priceColumn.ReadOnly = true;
            lstCatalogoProductos.Columns.Add(priceColumn);

            
        }





        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lstCatalogoProductos.CurrentRow.DataBoundItem != null)
            {
                Producto productoSeleccionado = (Producto)lstCatalogoProductos.CurrentRow.DataBoundItem;
                int cantidad =(int)numericUpDown1.Value; 
                float precioCompra = productoSeleccionado.PrecioActual;

                ItemProducto itemProducto = new ItemProducto(cantidad, precioCompra, productoSeleccionado);


                List<ItemProducto> productos = lstProductosAgregados.Items.Cast<ItemProducto>().ToList();
                bool productoEncontrado = false;

                if (lstProductosAgregados.Items.Count > 0)
                {
                   

                    foreach (ItemProducto item in productos)
                    {
                        if (item.Producto.CodProducto == itemProducto.Producto.CodProducto)
                        {
                            
                            item.Cantidad += cantidad;
                            productoEncontrado = true;
                            break;
                        }
                    }
                }

                if (!productoEncontrado)
                {
                    
                    lstProductosAgregados.Items.Add(itemProducto);
                }
                else
                {
                    
                    lstProductosAgregados.Items.Clear();
                    lstProductosAgregados.Items.AddRange(productos.ToArray());
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto a agregar");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (lstProductosAgregados.Items.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un producto antes de crear el pedido.");
                return;
            }

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dniStr = txtDNI.Text;
            string telefono = txtTelefono.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dniStr) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Debe completar todos los datos del cliente.");
                return;
            }


            if (!int.TryParse(dniStr, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.");
                return;
            }

            Cliente clienteSeleccionado =new Cliente(nombre, apellido, dni, telefono);
            List<ItemProducto> productos = lstProductosAgregados.Items.Cast<ItemProducto>().ToList();

            if (controllerCajero.RegistrarPedido(productos, clienteSeleccionado))
            {
                MessageBox.Show("Pedido creado correctamente");
            }
            else
            {
                MessageBox.Show("Error al crear el pedido");
            }

            


        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lstProductosAgregados.SelectedItem != null)
            {
                lstProductosAgregados.Items.Remove(lstProductosAgregados.SelectedItem);
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto a remover");
            }
        }
    }
}
