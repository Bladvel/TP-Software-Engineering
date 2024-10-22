using CAPA_ENTIDADES;
using CAPA_NEGOCIO;
using PF_APP_PEDIDOS.Modales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_APP_PEDIDOS
{
    public partial class FrmRegistrarPedido : Form
    {
        private Usuario _usuario;
        public FrmRegistrarPedido(Usuario ousuario = null)
        {
            InitializeComponent();
            _usuario = ousuario;
        }

        private void FrmRegistrarPedido_Load(object sender, EventArgs e)
        {
            txtFechaRegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIdArticulo.Text = "0";
            txtIdCliente.Text = "0";
            txtTotal.Text = "0";    
        }

        private void btnBusquedaCliente_Click(object sender, EventArgs e)
        {
            using(var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdCliente.Text = modal._cliente.IdCliente.ToString();
                    txtNombreCliente.Text = modal._cliente.Nombre;
                    txtApellidoCliente.Text = modal._cliente.Apellido;
                    txtDniCliente.Text = modal._cliente.Dni;
                    txtCodArticulo.Select();
                }
                else
                {
                    txtIdCliente.Select();
                }
            }
        }

        private void btnBusquedaArticulo_Click(object sender, EventArgs e)
        {
            using( var modal = new mdArticulo())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdArticulo.Text = modal._articulo.IdArticulo.ToString();
                    txtCodArticulo.Text = modal._articulo.codigo.ToString();
                    txtNombreArticulo.Text = modal._articulo.Nombre.ToString();
                    txtPrecioArticulo.Text = modal._articulo.Precio.ToString("0.00");
                    txtStockArticulo.Text = modal._articulo.Stock.ToString();
                    txtCantidadArticulo.Select();
                }
                else
                {
                    txtIdArticulo.Select();
                }
            }
        }

        private void txtCodArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Articulo oArticulo = CN_Articulo.GetInstance().GetAll().Where(a => a.codigo == txtCodArticulo.Text).FirstOrDefault();

                if (oArticulo != null)
                {
                    txtCodArticulo.BackColor = Color.Honeydew;
                    txtIdArticulo.Text = oArticulo.IdArticulo.ToString();
                    txtNombreArticulo.Text = oArticulo.Nombre;
                    txtPrecioArticulo.Text = oArticulo.Precio.ToString();
                    txtStockArticulo.Text = oArticulo.Stock.ToString();
                    txtCantidadArticulo.Select();
                }
                else
                {
                    txtCodArticulo.BackColor = Color.MistyRose;
                    txtIdArticulo.Text = "0";
                    txtNombreArticulo.Text = "";
                    txtPrecioArticulo.Text = "0.00";
                    txtStockArticulo.Text = "0";

                }
            }
        }

        private void btnAgregarArtitculo_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool articulo_existe = false;

            if(int.Parse(txtIdArticulo.Text) == 0)
            {
                MessageBox.Show("Debe Seleccionar un Producto","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if(!decimal.TryParse(txtPrecioArticulo.Text, out precio))
            {
                MessageBox.Show("Precio - Formato de moneda Incorrecto","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioArticulo.Select();
                return;
            }

            if(Convert.ToInt32(txtCantidadArticulo.Text) > Convert.ToInt32(txtStockArticulo.Text))
            {
                MessageBox.Show("La cantiad de articulos no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dtgLista.Rows)
            {
                if (fila.Cells["Id"].Value.ToString() == txtIdArticulo.Text)
                {
                    articulo_existe = true;
                    break;
                }
            }

            if(!articulo_existe)
            {
                bool respuesta = CN_Pedido.GetInstance().RestarStock(
                    Convert.ToInt32(txtIdArticulo.Text), 
                    Convert.ToInt32(txtCantidadArticulo.Text)
                    );

                if (respuesta)
                {
                    dtgLista.Rows.Add(new object[]
                    {
                        txtIdArticulo.Text,
                        txtNombreArticulo.Text,
                        precio.ToString("0.00"),
                        txtCantidadArticulo.Text,
                        (txtCantidadArticulo.Value * precio).ToString("0.00"),
                    });

                    CalcularTotal();
                    limpiarArticulo();
                    txtCodArticulo.Select();
                }

            }

        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if(dtgLista.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgLista.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value.ToString());
                }
            }
            txtTotal.Text = total.ToString("0.00");
        }

        private void limpiarArticulo()
        {
            txtIdArticulo.Text = "0";
            txtNombreArticulo.Text = "";
            txtPrecioArticulo.Text = "";
            txtCodArticulo.Text = "";
            txtStockArticulo.Text= "0";
            txtCantidadArticulo.Value = 1;
            txtCodArticulo.BackColor = Color.White;
        }

        private void dtgLista_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 5)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete.Width;
                var h = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dtgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgLista.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int index = e.RowIndex;
                if(index >= 0)
                {
                    bool respuesta = CN_Pedido.GetInstance().SumarStock(
                        Convert.ToInt32(dtgLista.Rows[index].Cells["Id"].Value.ToString()),
                        Convert.ToInt32(dtgLista.Rows[index].Cells["Cantidad"].Value.ToString()));

                    if (respuesta)
                    {
                        dtgLista.Rows.RemoveAt(index);
                        CalcularTotal();
                    }
                }
                   
            }
        }

        private void txtPrecioArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if(txtPrecioArticulo.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if(Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtStockArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecioArticulo.Text.Trim().Length == 0)
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            if(txtDniCliente.Text == "")
            {
                MessageBox.Show("Debes Ingresar el Documento del cliente","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Debes Ingresar el Nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtApellidoCliente.Text == "")
            {
                MessageBox.Show("Debes Ingresar el Apellido del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(dtgLista.Rows.Count < 1)
            {
                MessageBox.Show("Debes Ingresar los Articulos para registrar el pedido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detallePedido = new DataTable();

            detallePedido.Columns.Add("Id", typeof(int));
            detallePedido.Columns.Add("Precio",typeof(decimal));
            detallePedido.Columns.Add("Cantidad", typeof(int));
            detallePedido.Columns.Add("Subtotal", typeof(decimal));

            foreach (DataGridViewRow row in dtgLista.Rows)
            {
                detallePedido.Rows.Add(new object[]
                {
                    row.Cells["Id"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["Subtotal"].Value.ToString()
                }); ;
            }

            int idCorrelativo = CN_Pedido.GetInstance().ObtenerCorrelativo();
            string numeroPedido = string.Format("{0:00000}", idCorrelativo);

            Pedido opedido = new Pedido()
            {
                oUsuario = new Usuario() { IdUsuario = _usuario.IdUsuario},
                numeroPedido=numeroPedido,
                NombreCliente = txtNombreCliente.Text,
                ApellidoCliente = txtApellidoCliente.Text,
                DocumentoCliente = txtDniCliente.Text,
                MontoTotal = Convert.ToDecimal(txtTotal.Text)
            };

            string msj = string.Empty;
            bool respuesta = CN_Pedido.GetInstance().Registrar(opedido, detallePedido, out msj);

            if (respuesta)
            {
                var resultado = MessageBox.Show("Numero de Pedido Generado:\n" + numeroPedido +"\n\n Desea copiar al portapeles?","Mensaje",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                if(resultado == DialogResult.Yes)
                {
                    Clipboard.SetText(numeroPedido);
                }

                txtNombreCliente.Text = "";
                txtApellidoCliente.Text = "";
                txtDniCliente.Text = "";
                dtgLista.Rows.Clear();
                CalcularTotal();
            }
            else
            {
                MessageBox.Show(msj,"Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
