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
            bllSolicitudDeCotizacion = new BLL.SolicitudDeCotizacion();
            bllProveedor = new BLL.Proveedor();
        }

        private BLL.SolicitudDeCotizacion bllSolicitudDeCotizacion;
        private BLL.Proveedor bllProveedor;
        private BE.SolicitudDeCotizacion solicitudSeleccionada;

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
                        resultado += bllSolicitudDeCotizacion.EnviarCorreoSolicitud(solicitudSeleccionada, proveedor) + "\n";
                        bllSolicitudDeCotizacion.CambiarEstado(solicitudSeleccionada, EstadoSolicitudCotizacion.Enviada);

                       


                    }
                }
            }

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarGrillaSolicitud(EstadoSolicitudCotizacion.EvaluacionAprobada);
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




            ActualizarGrillaSolicitud(EstadoSolicitudCotizacion.EvaluacionAprobada);
            List<Proveedor> proveedores = bllProveedor.Listar();
            ActualizarGrillaProveedor(proveedores);

            btnSolicitar.Enabled = false;
        }


        void ActualizarGrillaSolicitud()
        {
            grdSolicitudes.DataSource = null;
            grdSolicitudes.DataSource = bllSolicitudDeCotizacion.Listar();
        }


        void ActualizarGrillaSolicitud(EstadoSolicitudCotizacion estado)
        {
            grdSolicitudes.DataSource = null;
            grdSolicitudes.DataSource = bllSolicitudDeCotizacion.ListarPorEstado(estado);
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
                solicitudSeleccionada = (SolicitudDeCotizacion)grdSolicitudes.CurrentRow.DataBoundItem;

                if (solicitudSeleccionada != null)
                {

                    
                    if (solicitudSeleccionada.Estado == EstadoSolicitudCotizacion.EvaluacionAprobada)
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
