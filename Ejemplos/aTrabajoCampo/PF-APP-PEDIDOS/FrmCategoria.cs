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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(new OpcionCombo() { Texto = "Activo", Valor = 1 });
            cmbEstado.Items.Add(new OpcionCombo() { Texto = "No Activo", Valor = 0 });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;

            foreach (DataGridViewColumn column in dtgListaCategoria.Columns)
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

            List<Categoria> lista = CN_Categoria.GetInstance().GetAll();

            foreach (Categoria item in lista)
            {

                dtgListaCategoria.Rows.Add(new object[] {
                     "",
                     item.IdCategoria,
                     item.Descripcion,
                     item.estado == true ? 1 : 0,
                     item.estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;


            // Validaciones de usuario
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Tienes que ingresar La descripcion");
                return;
            }

            Categoria obj = new Categoria
            {
                IdCategoria = Convert.ToInt32(txtId.Text),
                Descripcion = txtDescripcion.Text.Trim(),
                estado = Convert.ToInt32(((OpcionCombo)cmbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdCategoria == 0)
            {
                //llamo a la capa de negocio para agregar a el usuario
                ;
                int idGenerado = CN_Categoria.GetInstance().Add(obj, out mensaje);


                if (idGenerado != 0)
                {


                    dtgListaCategoria.Rows.Add(new object[] {
                        "",
                        idGenerado,
                        txtDescripcion.Text,
                        ((OpcionCombo)cmbEstado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cmbEstado.SelectedItem).Texto.ToString()
                    });

                    Limpiar();
                    MessageBox.Show("Categoria Creado con exito");
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                bool editar = CN_Categoria.GetInstance().Update(obj, out mensaje);

                if (editar)
                {
                    DataGridViewRow row = dtgListaCategoria.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Descripcion"].Value = txtDescripcion.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cmbEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cmbEstado.SelectedItem).Texto.ToString();


                    Limpiar();

                    MessageBox.Show("Categoria editada con exito");
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
            txtDescripcion.Text = "";
            
            txtDescripcion.Select();
        }

        private void dtgListaCategoria_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("Deseas eliminar la Categoria?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Categoria obj = new Categoria()
                    {
                        IdCategoria = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = CN_Categoria.GetInstance().Delete(obj, out mensaje);

                    if (respuesta)
                    {
                        dtgListaCategoria.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes Seleccionar la categoria que deseas eliminar");
            }

            Limpiar();
        }

        private void dtgListaCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgListaCategoria.Columns[e.ColumnIndex].Name == "btnSeleccionarUsuario")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dtgListaCategoria.Rows[indice].Cells["Id"].Value.ToString();
                    txtDescripcion.Text = dtgListaCategoria.Rows[indice].Cells["Descripcion"].Value.ToString();


                    foreach (OpcionCombo oc in cmbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dtgListaCategoria.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cmbEstado.Items.IndexOf(oc);
                            cmbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                }
            }


        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cmbBusqueda.SelectedItem).Valor.ToString();

            if (dtgListaCategoria.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgListaCategoria.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpia_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";

            foreach (DataGridViewRow row in dtgListaCategoria.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
