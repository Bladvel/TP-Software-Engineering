using CAPA_ENTIDADES;
using CAPA_NEGOCIO;
using PF_APP_PEDIDOS.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_APP_PEDIDOS
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            List<Cliente> lista = CN_Cliente.GetInstance().GetAll();

            foreach (Cliente item in lista)
            {
                string Des_correo = Seguridad.Password.Decrypt(item.Correo);
                string Des_dni = Seguridad.Password.Decrypt(item.Dni);
                string Des_celular = Seguridad.Password.Decrypt(item.Celular);

                dtgListaCliente.Rows.Add(new object[]
                {
                    "",
                    item.IdCliente,
                    item.Nombre,
                    item.Apellido,
                    Des_correo,
                    Des_dni,
                    Des_celular,
                    item.Direccion
                });
            }

            foreach (DataGridViewColumn column in dtgListaCliente.Columns)
            {
                if (column.Visible == true && column.Name != "btnSeleccionar")
                {
                    cmbBusqueda.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }
            cmbBusqueda.DisplayMember = "Texto";
            cmbBusqueda.ValueMember = "Valor";
            cmbBusqueda.SelectedIndex = 0;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;

            List<string> errores = ValidarCampos();

            // Si hay errores, mostrar mensaje y retornar
            if(errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores));
                    return; ;
            }

            Cliente obj = new Cliente
            {
                IdCliente  = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Correo = txtEmail.Text.Trim(),
                Dni = txtDni.Text.Trim(),
                Celular = txtCelular.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
            };

            if (obj.IdCliente == 0)
            {
                //llamo a la capa de negocio para agregar a el usuario
                ;
                int idGenerado = CN_Cliente.GetInstance().Add(obj, out mensaje);


                if (idGenerado != 0)
                {
                    dtgListaCliente.Rows.Add(new object[]
                    {
                        "",
                        idGenerado,
                        txtNombre.Text,
                        txtApellido.Text,
                        txtEmail.Text,
                        txtDni.Text,
                        txtCelular.Text,
                        txtDireccion.Text,
                
                 });

                    Limpiar();
                    MessageBox.Show("Usuario creado con exito");
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                bool editarCliente = CN_Cliente.GetInstance().Update(obj, out mensaje);

                if (editarCliente)
                {
                    DataGridViewRow row = dtgListaCliente.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Apellido"].Value = txtApellido.Text;
                    row.Cells["Email"].Value = txtEmail.Text;
                    row.Cells["Dni"].Value = txtDni.Text;
                    row.Cells["Telefono"].Value = txtCelular.Text;
                    row.Cells["Direccion"].Value=txtDireccion.Text;

                    Limpiar();

                    MessageBox.Show("Usuario editado con exito");
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }


        }
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtCelular.Text = "";
            txtNombre.Select();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("Desea Eliminar el Cliente?","Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje;
                    Cliente obj = new Cliente()
                    {
                        IdCliente = Convert.ToInt32(txtId.Text)
                    };

                    bool usuarioEliminar = CN_Cliente.GetInstance().Delete(obj, out mensaje);

                    if (usuarioEliminar)
                    {
                        dtgListaCliente.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar el cliente a eliminar");
            }

            Limpiar();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cmbBusqueda.SelectedItem).Valor.ToString();

            if(dtgListaCliente.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgListaCliente.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";

            foreach (DataGridViewRow row in dtgListaCliente.Rows)
            {
                row.Visible = true;
            }
        }

        private void dtgListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgListaCliente.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if(indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dtgListaCliente.Rows[indice].Cells["Id"].Value.ToString();
                    txtNombre.Text = dtgListaCliente.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dtgListaCliente.Rows[indice].Cells["Apellido"].Value.ToString();
                    txtEmail.Text = dtgListaCliente.Rows[indice].Cells["Email"].Value.ToString();
                    txtDni.Text = dtgListaCliente.Rows[indice].Cells["Dni"].Value.ToString();
                    txtCelular.Text = dtgListaCliente.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtDireccion.Text = dtgListaCliente.Rows[indice].Cells["Direccion"].Value.ToString();

                }
            }
        }

        private void dtgListaCliente_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check2.Width;
                var h = Properties.Resources.check2.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check2, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private List<string> ValidarCampos()
        {
            List<string> errores = new List<string>();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errores.Add("Tienes que ingresar el Nombre del Cliente");
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                errores.Add("Tienes que ingresar el Apellido del Cliente");
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errores.Add("Tienes que ingresar el Email del Cliente");
            }
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                errores.Add("Tienes que ingresar el DNI del Cliente");
            }
            if (string.IsNullOrWhiteSpace(txtCelular.Text))
            {
                errores.Add("Tienes que ingresar el Numero de Telefono del Cliente");
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                errores.Add("Tienes que ingresar la Direccion del cliente");
            }

            return errores;
        }
    }
}
