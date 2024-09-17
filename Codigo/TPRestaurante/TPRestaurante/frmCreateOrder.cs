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
using Interfaces;
using Services;


namespace TPRestaurante
{
    public partial class frmCreateOrder : Form, IIdiomaObserver
    {
        public frmCreateOrder()
        {
            InitializeComponent();
            catalogo = new BLL.Producto();
            controllerCajero = new BLL.ControllerCajero();
            bllPedido = new BLL.Pedido();
        }

        private void ucButtonSecondary1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private BLL.Producto catalogo;
        private BLL.ControllerCajero controllerCajero;
        private BLL.Pedido bllPedido;
        private void frmCreateOrder_Load(object sender, EventArgs e)
        {
            lstCatalogoProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lstCatalogoProductos.EditMode = DataGridViewEditMode.EditProgrammatically;
            lstCatalogoProductos.RowHeadersVisible = false;


            lstCatalogoProductos.AutoGenerateColumns = false;
            lstCatalogoProductos.DataSource = null;
            lstCatalogoProductos.DataSource = catalogo.Listar();


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

            SessionManager.SuscribirObservador(this);
            Traducir(SessionManager.Instance.User.Idioma);
            
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

                ActualizarTotal();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto a agregar");
            }
        }


        private void ActualizarTotal()
        {
            float total = 0;

            foreach (ItemProducto item in lstProductosAgregados.Items)
            {
                total += item.Cantidad * item.PrecioCompra;
            }

            lblTotal.Text = total.ToString("C");
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
                RegistroBitacoraCrearOrden();
            }
            else
            {
                MessageBox.Show("Error al crear el pedido");
            }

        }
        private void RegistroBitacoraCrearOrden()
        {
            var user = SessionManager.Instance.User;
            var logEntry = new Services.Bitacora
            {
                Usuario = user,
                Fecha = DateTime.Now,
                Modulo = TipoModulo.CreacionDePedidos,
                Operacion = TipoOperacion.CrearOrden,
                Criticidad = 3
            };

            BLL.Bitacora bllBitacora = new BLL.Bitacora();
            bllBitacora.Insertar(logEntry);
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

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma = null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);

            //Menu sesion
            if (groupBox1.Tag != null && traducciones.ContainsKey(groupBox1.Tag.ToString()))
                groupBox1.Text = traducciones[groupBox1.Tag.ToString()].Texto;
            if (groupBox2.Tag != null && traducciones.ContainsKey(groupBox2.Tag.ToString()))
                groupBox2.Text = traducciones[groupBox2.Tag.ToString()].Texto;
            if (groupBox3.Tag != null && traducciones.ContainsKey(groupBox3.Tag.ToString()))
                groupBox3.Text = traducciones[groupBox3.Tag.ToString()].Texto;

            if (label1.Tag != null && traducciones.ContainsKey(label1.Tag.ToString()))
                label1.Text = traducciones[label1.Tag.ToString()].Texto;
            if (label2.Tag != null && traducciones.ContainsKey(label2.Tag.ToString()))
                label2.Text = traducciones[label2.Tag.ToString()].Texto;
            if (label3.Tag != null && traducciones.ContainsKey(label3.Tag.ToString()))
                label3.Text = traducciones[label3.Tag.ToString()].Texto;
            if (label4.Tag != null && traducciones.ContainsKey(label4.Tag.ToString()))
                label4.Text = traducciones[label4.Tag.ToString()].Texto;
            if (label5.Tag != null && traducciones.ContainsKey(label5.Tag.ToString()))
                label5.Text = traducciones[label5.Tag.ToString()].Texto;
            if (label6.Tag != null && traducciones.ContainsKey(label6.Tag.ToString()))
                label6.Text = traducciones[label6.Tag.ToString()].Texto;


            if (btnCancelar.Tag != null && traducciones.ContainsKey(btnCancelar.Tag.ToString()))
                btnCancelar.Text = traducciones[btnCancelar.Tag.ToString()].Texto;
            if (btnAgregar.Tag != null && traducciones.ContainsKey(btnAgregar.Tag.ToString()))
                btnAgregar.Text = traducciones[btnAgregar.Tag.ToString()].Texto;
            if (btnQuitar.Tag != null && traducciones.ContainsKey(btnQuitar.Tag.ToString()))
                btnQuitar.Text = traducciones[btnQuitar.Tag.ToString()].Texto;
            if (btnCrear.Tag != null && traducciones.ContainsKey(btnCrear.Tag.ToString()))
                btnCrear.Text = traducciones[btnCrear.Tag.ToString()].Texto;
        }

        private void frmCreateOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }
    }
}
