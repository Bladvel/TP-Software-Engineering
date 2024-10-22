using Interfaces;
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
    public partial class frmSolicitarCotizacion : Form
    {
        public frmSolicitarCotizacion()
        {
            InitializeComponent();
            bllSolicitudDeCompra = new BLL.SolicitudDeCompra();
            bllProveedor = new BLL.Proveedor();
        }

        private BLL.SolicitudDeCompra bllSolicitudDeCompra;
        private BLL.Proveedor bllProveedor;
        private BE.SolicitudDeCompra solicitudSeleccionada;

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            foreach (DataGridViewRow row in grdProveedores.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Seleccionar"].Value);
                
                if (isSelected)
                {
                    string nombreProveedor = row.Cells["Nombre"].Value.ToString();
                    Proveedor proveedor = bllProveedor.Listar().FirstOrDefault(p => p.Nombre == nombreProveedor);

                    if (proveedor != null && solicitudSeleccionada != null)
                    {
                        resultado += bllSolicitudDeCompra.EnviarCorreoSolicitud(solicitudSeleccionada, proveedor) + "\n";
                        bllSolicitudDeCompra.CambiarEstado(solicitudSeleccionada, EstadoSolicitudCompra.Enviada);

                       


                    }
                }
            }

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmSolicitarCotizacion_Load(object sender, EventArgs e)
        {
            grdSolicitudes.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSolicitudes.MultiSelect = false;
            grdSolicitudes.RowHeadersVisible = false;

            grdProveedores.RowHeadersVisible = false;
            grdProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdProveedores.AllowUserToAddRows = false;



            cmbFiltroEstado.DataSource = Enum.GetValues(typeof(EstadoSolicitudCompra));
            cmbFiltroEstado.SelectedIndex = -1;

            ActualizarGrillaSolicitud();
            List<Proveedor> proveedores = bllProveedor.Listar();
            ActualizarGrillaProveedor(proveedores);

            btnSolicitar.Enabled = false;
        }


        void ActualizarGrillaSolicitud()
        {
            grdSolicitudes.DataSource = null;
            grdSolicitudes.DataSource = bllSolicitudDeCompra.Listar();
        }


        void ActualizarGrillaSolicitud(EstadoSolicitudCompra estado)
        {
            grdSolicitudes.DataSource = null;
            grdSolicitudes.DataSource = bllSolicitudDeCompra.ListarPorEstado(estado);
        }

        void ActualizarGrillaProveedor(List<Proveedor> proveedores)
        {
            
            grdProveedores.Columns.Clear();
            grdProveedores.DataSource = null;

            
            grdProveedores.Columns.Add("Nombre", "Nombre");
            grdProveedores.Columns.Add("Email", "Email");

            // Columna de CheckBox para seleccionar proveedores
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Seleccionar";
            chk.Name = "Seleccionar";
            grdProveedores.Columns.Add(chk);

            
            foreach (var proveedor in proveedores)
            {
                grdProveedores.Rows.Add(proveedor.Nombre, proveedor.Email, false);
            }
            

        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFiltroEstado.SelectedItem != null)
            {
                EstadoSolicitudCompra estado = (EstadoSolicitudCompra)cmbFiltroEstado.SelectedItem;

                ActualizarGrillaSolicitud(estado);
            }
        }

        private void grdProveedores_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(grdProveedores.Columns[e.ColumnIndex].Name != "Seleccionar")
            {
                e.Cancel = true;
            }
        }

        private void chkMarcarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMarcarTodos.Checked)
            {
                
                foreach (DataGridViewRow row in grdProveedores.Rows)
                {
                    row.Cells["Seleccionar"].Value = true;
                }

                
                chkDesmarcarTodos.Checked = false;
            }
        }

        private void chkDesmarcarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDesmarcarTodos.Checked)
            {

                foreach (DataGridViewRow row in grdProveedores.Rows)
                {
                    row.Cells["Seleccionar"].Value = false;
                }


                chkMarcarTodos.Checked = false;
            }
        }

        private void grdSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdSolicitudes.CurrentRow != null)
            {
                solicitudSeleccionada = (SolicitudDeCompra)grdSolicitudes.CurrentRow.DataBoundItem;

                if (solicitudSeleccionada != null)
                {

                    
                    if (solicitudSeleccionada.Estado == EstadoSolicitudCompra.EvaluacionAprobada)
                    {
                        btnSolicitar.Enabled = true;
                    }
                    else
                    {
                        btnSolicitar.Enabled = false;
                    }

                }
            }

            
        }
    }
}
