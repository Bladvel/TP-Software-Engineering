using CAPA_ENTIDADES;
using CAPA_NEGOCIO;
using ClosedXML.Excel;
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
    public partial class FrmArticulos : Form
    {
        public FrmArticulos()
        {
            
            InitializeComponent();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(new OpcionCombo() { Texto = "Activo", Valor = 1 });
            cmbEstado.Items.Add(new OpcionCombo() { Texto = "No Activo", Valor = 0 });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;


            List<Categoria> lista = CN_Categoria.GetInstance().GetAll();

            foreach (Categoria a in lista)
            {
                cmbCategoria.Items.Add(new OpcionCombo () { Valor = a.IdCategoria, Texto = a.Descripcion });
            }
            cmbCategoria.DisplayMember = "Texto";
            cmbCategoria.ValueMember = "Valor";
            cmbCategoria.SelectedIndex = 0;


            foreach (DataGridViewColumn column in dtgListaArticulo.Columns)
            {
                if (column.Visible == true && column.Name != "btnSeleccionarUsuario")
                {
                    cmbBusqueda.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }
            cmbBusqueda.DisplayMember = "Texto";
            cmbBusqueda.ValueMember = "Valor";
            cmbBusqueda.SelectedIndex = 0;

            //Mostrar Todos los Articulos

            List<Articulo> listaA = CN_Articulo.GetInstance().GetAll();

            foreach (Articulo item in listaA)
            {
                

                dtgListaArticulo.Rows.Add(new object[] {
                     "",
                     item.IdArticulo,
                     item.codigo,
                     item.Nombre,
                     item.Descripcion,
                     item.Precio,
                     item.Stock,
                     item.ocategoria.IdCategoria,
                     item.ocategoria.Descripcion,
                     item.estado == true ? 1 : 0,
                     item.estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;


            // Validaciones de usuario
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Tienes que ingresar el codigo del Articulo");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Tienes que ingresar el Nombre del Articulo");
                return;
            }

            Articulo obj = new Articulo
            {
                IdArticulo = Convert.ToInt32(txtArticulo.Text),
                codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = Convert.ToDecimal(txtPrecio.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                ocategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cmbCategoria.SelectedItem).Valor) },
                estado = Convert.ToInt32(((OpcionCombo)cmbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdArticulo == 0)
            {
                //llamo a la capa de negocio para agregar el Articulo
                int idGenerado = CN_Articulo.GetInstance().Add(obj, out mensaje);


                if (idGenerado != 0)
                {


                    dtgListaArticulo.Rows.Add(new object[] {
                        "",
                        idGenerado,
                        txtCodigo.Text,
                        txtNombre.Text,
                        txtDescripcion.Text,
                        txtPrecio.Text,
                        txtStock.Text,
                        ((OpcionCombo)cmbCategoria.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cmbCategoria.SelectedItem).Texto.ToString(),
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
                bool editar = CN_Articulo.GetInstance().Update(obj, out mensaje);

                if (editar)
                {
                    DataGridViewRow row = dtgListaArticulo.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["IdArticulo"].Value = txtArticulo.Text;
                    row.Cells["Codigo"].Value = txtCodigo.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Descripcion"].Value = txtDescripcion.Text;
                    row.Cells["Precio"].Value = txtPrecio.Text;
                    row.Cells["Stock"].Value = txtStock.Text;
                    row.Cells["IdCategoria"].Value = ((OpcionCombo)cmbCategoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)cmbCategoria.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cmbEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cmbEstado.SelectedItem).Texto.ToString();


                    Limpiar();

                    MessageBox.Show("Articulo editado con exito");
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
            txtArticulo.Text = "0";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            cmbEstado.SelectedIndex = 0;
            cmbCategoria.SelectedIndex = 0;

            txtCodigo.Select();

        }

        private void dtgListaArticulo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dtgListaArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgListaArticulo.Columns[e.ColumnIndex].Name == "btnSeleccionarUsuario")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtArticulo.Text = dtgListaArticulo.Rows[indice].Cells["IdArticulo"].Value.ToString();
                    txtCodigo.Text = dtgListaArticulo.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombre.Text = dtgListaArticulo.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtDescripcion.Text = dtgListaArticulo.Rows[indice].Cells["Descripcion"].Value.ToString();
                    txtPrecio.Text = dtgListaArticulo.Rows[indice].Cells["Precio"].Value.ToString();
                    txtStock.Text = dtgListaArticulo.Rows[indice].Cells["Stock"].Value.ToString();


                    foreach (OpcionCombo oc in cmbCategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dtgListaArticulo.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = cmbCategoria.Items.IndexOf(oc);
                            cmbCategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in cmbEstado.Items)
                    {
                        if(Convert.ToInt32(oc.Valor) == Convert.ToInt32(dtgListaArticulo.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo =  cmbEstado.Items.IndexOf(oc);
                            cmbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtArticulo.Text) != 0)
            {
                if (MessageBox.Show("Desea Eliminar el Articulo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Articulo obj = new Articulo()
                    {
                        IdArticulo = Convert.ToInt32(txtArticulo.Text)
                    };

                    bool articuloEliminar = CN_Articulo.GetInstance().Delete(obj, out mensaje);

                    if (articuloEliminar)
                    {
                        dtgListaArticulo.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje , "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes Seleccionar el Articulo que deseas eliminar");
            }

            Limpiar();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cmbBusqueda.SelectedItem).Valor.ToString();

            if (dtgListaArticulo.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgListaArticulo.Rows)
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

            foreach (DataGridViewRow row in dtgListaArticulo.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (dtgListaArticulo.Rows.Count < 1)
            {
                MessageBox.Show("No hay Datos para exportar", "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dtgListaArticulo.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                        dt.Columns.Add(columna.HeaderText,typeof(string));
                }

                foreach (DataGridViewRow row in dtgListaArticulo.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[]{
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[10].Value.ToString()
                        });
                        
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteArticulo_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if(savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe Articulos");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Genreado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al Generar el reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
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

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtStock.Text.Trim().Length == 0)
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
    }
}
