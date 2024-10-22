using BE;
using Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Producto = BE.Producto;

namespace TPRestaurante
{
    public partial class frmMaestroProductos : Form
    {
        public frmMaestroProductos()
        {
            InitializeComponent();
            bllProducto = new BLL.Producto();
            bitacora = new Services.Bitacora();
            bllBitacora = new BLL.Bitacora();
            bllDvh = new BLL.DVH();
        }

        BLL.Producto bllProducto;
        BLL.ModoDelGestor modo = BLL.ModoDelGestor.ModoConsulta;
        private Services.Bitacora bitacora;
        private BLL.Bitacora bllBitacora;
        private BLL.DVH bllDvh;
        DataTable dtProductos;

        private void frmMaestroProductos_Load(object sender, EventArgs e)
        {
            grdProductos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdProductos.MultiSelect = false;
            grdProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdProductos.RowHeadersVisible = false;

            rbActivos.Checked = true;

            ActualizarGrilla();
            CambiarModo(modo);
        }

        private void ActualizarGrilla()
        {
            List<BE.Producto> productos = bllProducto.Listar();
            dtProductos = ConvertirProductosADataTable(productos);

            AplicarFiltroRadioButtons(rbActivos.Checked);
        }

        private void AplicarFiltroRadioButtons(bool mostrarSoloActivos)
        {
            if (dtProductos != null)
            {
                DataView dv = new DataView(dtProductos);



                if (mostrarSoloActivos)
                {
                    dv.RowFilter = "Borrado = false";
                }
                else
                {
                    dv.RowFilter = "";
                }

                grdProductos.DataSource = null;
                grdProductos.DataSource = dv;

            }
        }

        private DataTable ConvertirProductosADataTable(List<Producto> productos)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Codigo", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Precio", typeof(float));
            dt.Columns.Add("Borrado", typeof(bool));


            foreach (Producto p in productos)
            {
                DataRow dr = dt.NewRow();
                dr["Codigo"] = p.CodProducto;
                dr["Nombre"] = p.Nombre;
                dr["Descripcion"] = p.Descripcion;
                dr["Precio"] = p.PrecioActual;
                dr["Borrado"] = p.Borrado;

                dt.Rows.Add(dr);
            }

            return dt;

        }

        private void ResetTextFields()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtCodigo.Text = string.Empty;
        }


        void CambiarModo(BLL.ModoDelGestor pModo)
        {
            switch (pModo)
            {
                case BLL.ModoDelGestor.ModoConsulta:
                    lblModo.Text = "Modo consulta";
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnAplicar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnSalir.Enabled = true;
                    HabilitarTextboxs(true);
                    break;
                case BLL.ModoDelGestor.ModoAgregar:
                    lblModo.Text = "Modo agregar";
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAplicar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSalir.Enabled = true;
                    HabilitarTextboxs(true);

                    break;
                case BLL.ModoDelGestor.ModoModificar:
                    lblModo.Text = "Modo modificar";
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAplicar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSalir.Enabled = true;
                    HabilitarTextboxs(true);

                    break;
                case BLL.ModoDelGestor.ModoEliminar:
                    lblModo.Text = "Modo eliminar";
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAplicar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSalir.Enabled = true;
                    HabilitarTextboxs(false);
                    break;

            }
        }

        private void HabilitarTextboxs(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtDescripcion.Enabled = habilitar;
            txtPrecio.Enabled = habilitar;
            txtCodigo.Enabled = habilitar;
        }

        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActivos.Checked)
            {
                AplicarFiltroRadioButtons(true);
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                AplicarFiltroRadioButtons(false);
            }
        }

        private void RegistrarBitacoraEliminarProducto()
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = SessionManager.Instance.User as BE.User;
            bitacora.Modulo = TipoModulo.MaestroProductos;
            bitacora.Operacion = TipoOperacion.Baja;
            bitacora.Criticidad = 2;
            bllBitacora.Insertar(bitacora);
        }

        private void RegistroBitacoraModificarProducto()
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = SessionManager.Instance.User as BE.User;
            bitacora.Modulo = TipoModulo.MaestroProductos;
            bitacora.Operacion = TipoOperacion.Modificacion;
            bitacora.Criticidad = 3;
            bllBitacora.Insertar(bitacora);
        }

        private void RegistroBitacoraAgregarProducto()
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = SessionManager.Instance.User as BE.User;
            bitacora.Modulo = TipoModulo.MaestroProductos;
            bitacora.Operacion = TipoOperacion.Alta;
            bitacora.Criticidad = 2;
            bllBitacora.Insertar(bitacora);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = BLL.ModoDelGestor.ModoAgregar;
            CambiarModo(modo);
            ResetTextFields();
            txtCodigo.Enabled = false;
            txtNombre.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modo = BLL.ModoDelGestor.ModoModificar;
            CambiarModo(modo);
            ResetTextFields();
            txtCodigo.Focus();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            modo = BLL.ModoDelGestor.ModoEliminar;
            CambiarModo(modo);
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Producto selectedProduct = null;
            DataRowView drv = null;

            switch (modo)
            {
                case BLL.ModoDelGestor.ModoConsulta:
                    break;
                case BLL.ModoDelGestor.ModoAgregar:
                    string nombre = txtNombre.Text;
                    string descripcion = txtDescripcion.Text;
                    
                    

                    if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(descripcion) && float.TryParse(txtPrecio.Text, out float precio))
                    {
                        BE.Producto producto = new Producto(nombre, descripcion, precio);
                        if (bllProducto.Insertar(producto) != -1)
                        {
                            bllDvh.Recalcular(bllDvh.Listar(), bllProducto.Listar(), bllProducto.Concatenar, p => p.CodProducto, "PRODUCTO");
                        }




                        ActualizarGrilla();
                        ResetTextFields();
                        RegistroBitacoraAgregarProducto();

                    }
                    else
                    {
                        MessageBox.Show("Complete todos los campos");
                    }
                    break;
                case BLL.ModoDelGestor.ModoModificar:
                    drv = grdProductos.CurrentRow?.DataBoundItem as DataRowView;

                    if (drv != null)
                    {
                        selectedProduct = convertirRowViewAProducto(drv);
                        selectedProduct.Nombre = txtNombre.Text;
                        selectedProduct.Descripcion = txtDescripcion.Text;
                        selectedProduct.PrecioActual = float.Parse(txtPrecio.Text);
                        selectedProduct.CodProducto = int.Parse(txtCodigo.Text);
                        MessageBox.Show(bllProducto.Modificar(selectedProduct));
                        bllDvh.Recalcular(bllDvh.Listar(), bllProducto.Listar(), bllProducto.Concatenar, p => p.CodProducto, "PRODUCTO");

                        ActualizarGrilla();
                        ResetTextFields();
                        RegistroBitacoraModificarProducto();
                    }
                    else
                    {
                        MessageBox.Show("No hay producto seleccionado");
                    }
                    break;
                case BLL.ModoDelGestor.ModoEliminar:
                    drv = grdProductos.CurrentRow?.DataBoundItem as DataRowView;


                    if (drv != null)
                    {
                        selectedProduct = convertirRowViewAProducto(drv);
                        DialogResult result = MessageBox.Show(
                            "¿Estás seguro de que deseas eliminar al producto seleccionado?",
                            "Confirmación de eliminación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show(bllProducto.Eliminar(selectedProduct));
                            bllDvh.Recalcular(bllDvh.Listar(), bllProducto.Listar(), bllProducto.Concatenar, p => p.CodProducto, "PRODUCTO");

                            RegistrarBitacoraEliminarProducto();
                            ActualizarGrilla();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay producto seleccionado");
                    }

                    break;
            }
        }

        private Producto convertirRowViewAProducto(DataRowView drv)
        {
            Producto producto = new Producto();
            producto.CodProducto = (int)drv["Codigo"];
            producto.Nombre = (string)drv["Nombre"];
            producto.Descripcion = (string)drv["Descripcion"];
            producto.PrecioActual = (float)drv["Precio"];
            producto.Borrado = (bool)drv["Borrado"];
            return producto;
        }

        private void grdProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(modo == BLL.ModoDelGestor.ModoModificar)
            {
                DataRowView drv = grdProductos.CurrentRow?.DataBoundItem as DataRowView;

                if (drv != null)
                {
                    txtCodigo.Text = drv["Codigo"].ToString();
                    txtNombre.Text = drv["Nombre"].ToString();
                    txtDescripcion.Text = drv["Descripcion"].ToString();
                    txtPrecio.Text = drv["Precio"].ToString();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetTextFields();
            grdProductos.ClearSelection();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (modo != BLL.ModoDelGestor.ModoConsulta)
            {
                modo = BLL.ModoDelGestor.ModoConsulta;
                CambiarModo(modo);
            }
            else
            {
                Close();
            }
        }


        private void AplicarFiltroTextboxs()
        {
            DataView dv = (DataView)grdProductos.DataSource; // Asegúrate de tener configurada correctamente la fuente de datos.

            string filtro = "";

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                filtro += $"Nombre LIKE '%{txtNombre.Text}%'";
            }

            if (!string.IsNullOrEmpty(txtDescripcion.Text))
            {
                if (filtro.Length > 0) filtro += " AND ";
                filtro += $"Descripcion LIKE '%{txtDescripcion.Text}%'";
            }

            if (!string.IsNullOrEmpty(txtPrecio.Text))
            {
                if (filtro.Length > 0) filtro += " AND ";
                filtro += $"Precio = {txtPrecio.Text}"; // Aquí no uso LIKE ya que el precio es numérico
            }


            if(!string.IsNullOrEmpty(txtCodigo.Text))
            {
                if (filtro.Length > 0) filtro += " AND ";
                filtro += $"Codigo = {txtCodigo.Text}";
            }


            dv.RowFilter = filtro;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (modo == BLL.ModoDelGestor.ModoConsulta)
                AplicarFiltroTextboxs();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (modo == BLL.ModoDelGestor.ModoConsulta)
                AplicarFiltroTextboxs();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (modo == BLL.ModoDelGestor.ModoConsulta)
                AplicarFiltroTextboxs();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (modo == BLL.ModoDelGestor.ModoConsulta)
                AplicarFiltroTextboxs();
        }
    }
}
