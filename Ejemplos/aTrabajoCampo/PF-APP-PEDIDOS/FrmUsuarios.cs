using CAPA_ENTIDADES;
using CAPA_NEGOCIO;
using PF_APP_PEDIDOS.Utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PF_APP_PEDIDOS
{
    public partial class FrmUsuarios : Form
    {
        //private CN_Usuario usuario;
        public FrmUsuarios()
        {
            InitializeComponent();
            //usuario = CN_Usuario.GetInstance();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(new OpcionCombo() { Texto = "Activo", Valor = 1 });
            cmbEstado.Items.Add(new OpcionCombo() { Texto = "No Activo", Valor = 0 });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;

            foreach (DataGridViewColumn column in dtgListaUsuario.Columns)
            {
                if (column.Visible == true && column.Name != "btnSeleccionarUsuario")
                {
                    cmbBusqueda.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }
            cmbBusqueda.DisplayMember = "Texto";
            cmbBusqueda.ValueMember = "Valor";
            cmbBusqueda.SelectedIndex = 0;

            //Mostrar Todos los usuarios

            List<Usuario> listaUsuario = CN_Usuario.GetInstance().GetAll();

            foreach (Usuario item in listaUsuario)
            {
                // Desencriptar el Nombre y Apellido antes de agregarlo al DataGridView
                string nombreDesencriptado = Seguridad.Password.Decrypt(item.Nombre);
                string apellidoDesencriptado = Seguridad.Password.Decrypt(item.Apellido);

                dtgListaUsuario.Rows.Add(new object[] {
                     "",
                     item.IdUsuario,
                     nombreDesencriptado,
                     apellidoDesencriptado,
                     item.Dni,
                     item.Email,
                     item.NombreUsuario,
                     item.Estado == true ? 1 : 0,
                     item.Estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;
            

            // Validaciones de usuario
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Tienes que ingresar el Nombre del Usuario");
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Tienes que ingresar el Apellido del Usuario");
            }

            Usuario oUsuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Dni = int.TryParse(txtDni.Text, out int dni) ? dni : 0,
                Email = txtEmail.Text.Trim(),
                NombreUsuario = txtNombreUsuario.Text.Trim(),
                Estado = Convert.ToInt32(((OpcionCombo)cmbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (oUsuario.IdUsuario == 0)
            {
                //llamo a la capa de negocio para agregar a el usuario
                ;
                int idUsuarioGenerado = CN_Usuario.GetInstance().Add(oUsuario, out mensaje);


                if (idUsuarioGenerado != 0)
                {
          

                    dtgListaUsuario.Rows.Add(new object[] {"",idUsuarioGenerado,txtNombre.Text,txtApellido.Text,txtDni.Text,txtEmail.Text,txtNombreUsuario.Text,
                ((OpcionCombo)cmbEstado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cmbEstado.SelectedItem).Texto.ToString()
                 });

                    Limpiar();
                    MessageBox.Show("Usuario Creado con exito");
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                bool editarUsuario = CN_Usuario.GetInstance().Update(oUsuario, out mensaje);

                if (editarUsuario)
                {
                    DataGridViewRow row = dtgListaUsuario.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Apellido"].Value = txtApellido.Text;
                    row.Cells["Dni"].Value = txtDni.Text;
                    row.Cells["Email"].Value = txtEmail.Text;
                    row.Cells["NombreUsuario"].Value = txtNombreUsuario.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cmbEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cmbEstado.SelectedItem).Texto.ToString();


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
            txtNombreUsuario.Text = "";
            cmbEstado.SelectedIndex = 0;

            txtNombre.Select();

        }

        private void dtgListaUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dtgListaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgListaUsuario.Columns[e.ColumnIndex].Name == "btnSeleccionarUsuario")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dtgListaUsuario.Rows[indice].Cells["Id"].Value.ToString();
                    txtNombre.Text = dtgListaUsuario.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dtgListaUsuario.Rows[indice].Cells["Apellido"].Value.ToString();
                    txtDni.Text = dtgListaUsuario.Rows[indice].Cells["Dni"].Value.ToString();
                    txtEmail.Text = dtgListaUsuario.Rows[indice].Cells["Email"].Value.ToString();
                    txtNombreUsuario.Text = dtgListaUsuario.Rows[indice].Cells["NombreUsuario"].Value.ToString();


                    foreach (OpcionCombo oc in cmbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dtgListaUsuario.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cmbEstado.Items.IndexOf(oc);
                            cmbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("Desea Eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje;
                    Usuario ousuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtId.Text)
                    };

                    bool usuarioEliminar = CN_Usuario.GetInstance().Delete(ousuario, out mensaje);

                    if (usuarioEliminar)
                    {
                        dtgListaUsuario.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes Seleccionar el usuario que deseas eliminar");
            }

            Limpiar();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cmbBusqueda.SelectedItem).Valor.ToString();

            if (dtgListaUsuario.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgListaUsuario.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";

            foreach (DataGridViewRow row in dtgListaUsuario.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
