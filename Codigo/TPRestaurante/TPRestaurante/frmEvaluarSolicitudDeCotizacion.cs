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

namespace TPRestaurante
{
    public partial class frmEvaluarSolicitudDeCotizacion : Form
    {
        public frmEvaluarSolicitudDeCotizacion()
        {
            InitializeComponent();
            bllSolicitudDeCotizacion = new BLL.SolicitudDeCotizacion();

        }

        private BLL.SolicitudDeCotizacion bllSolicitudDeCotizacion;
        BE.SolicitudDeCotizacion solicitudSeleccionada;

        private void ucButtonPrimary1_Click(object sender, EventArgs e)
        {

            List<ItemIngrediente> seleccionados = ObtenerInsumosSeleccionados(solicitudSeleccionada.Ingredientes);

            solicitudSeleccionada.Ingredientes = seleccionados;

            if (bllSolicitudDeCotizacion.ActualizarEstadoSolicitud(solicitudSeleccionada, EstadoSolicitudCotizacion.EvaluacionAprobada) != -1)
            {
                MessageBox.Show("Solicitud aprobada correctamente");
                ActualizarGrillaSolicitud(EstadoSolicitudCotizacion.Pendiente);
                grdInsumos.Columns.Clear();
            }


            //Elimina de la solicitud las que no tengan el check seleccionado
            //Genera la orden de compra con los insumos seleccionados
            //Actualiza el status de la solicitud a aprobada
        }


       
        private List<ItemIngrediente> ObtenerInsumosSeleccionados(List<ItemIngrediente> items)
        {
            List<ItemIngrediente> seleccionados = new List<ItemIngrediente>();

            foreach (DataGridViewRow row in grdInsumos.Rows)
            {
                
                bool isSelected = Convert.ToBoolean(row.Cells["Aprobar"].Value);
                if (isSelected)
                {
                    string nombreIngrediente = row.Cells["Ingrediente"].Value.ToString();
                    ItemIngrediente seleccionado = items.FirstOrDefault(i => i.Ingrediente.Nombre == nombreIngrediente);

                    
                    if (seleccionado != null)
                    {
                        seleccionados.Add(seleccionado);
                    }
                }
            }

            return seleccionados;
        }



        private void frmEvaluarSolicitudDeCompra_Load(object sender, EventArgs e)
        {
            grdSolicitudes.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdSolicitudes.RowHeadersVisible = false;
            grdSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grdInsumos.RowHeadersVisible = false;
            grdInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdInsumos.AllowUserToAddRows = false;



            ActualizarGrillaSolicitud(EstadoSolicitudCotizacion.Pendiente);

            btnAprobar.Enabled = false;
            btnRechazar.Enabled = false;
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


        


        private void grdSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            solicitudSeleccionada = (SolicitudDeCotizacion)grdSolicitudes.CurrentRow.DataBoundItem;

            if (solicitudSeleccionada != null)
            {
                
                LlenarGridInsumos(solicitudSeleccionada.Ingredientes);
                if(solicitudSeleccionada.Estado == EstadoSolicitudCotizacion.Pendiente)
                {
                    btnAprobar.Enabled = true;
                    btnRechazar.Enabled = true;
                }
                else
                {
                    btnAprobar.Enabled = false;
                    btnRechazar.Enabled = false;
                }
                
            }


        }

        
        private void LlenarGridInsumos(List<ItemIngrediente> items)
        {
            
            grdInsumos.Columns.Clear();
            grdInsumos.DataSource = null;

            
            grdInsumos.Columns.Add("Ingrediente", "Ingrediente");
            grdInsumos.Columns.Add("Cantidad", "Cantidad");

            // Columna de CheckBox para seleccionar insumos
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Aprobar";
            chk.Name = "Aprobar";
            grdInsumos.Columns.Add(chk);

            
            foreach (var item in items)
            {
                grdInsumos.Rows.Add(item.Ingrediente.Nombre, item.CantidadRequerida, false);
            }


        }


        // Verifica si la columna es la del checkbox, y si no lo es, no te deja editarla
        private void grdInsumos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (grdInsumos.Columns[e.ColumnIndex].Name != "Aprobar")
            {
                e.Cancel = true;
            }
        }

        private void grdInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreIngrediente = e.RowIndex >= 0 ? grdInsumos.Rows[e.RowIndex].Cells[0].Value.ToString() : "";
            ItemIngrediente item = solicitudSeleccionada.Ingredientes.FirstOrDefault(x => x.Ingrediente.Nombre == nombreIngrediente);


            if (item != null)
            {
                txtExistencia.Text = item.Ingrediente.Cantidad.ToString();
                txtMinimo.Text = item.Ingrediente.StockMin.ToString();
                txtMaximo.Text = item.Ingrediente.StockMax.ToString();
            }

        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (bllSolicitudDeCotizacion.ActualizarEstadoSolicitud(solicitudSeleccionada, EstadoSolicitudCotizacion.Rechazada) != -1)
            {
                MessageBox.Show("Solicitud rechazada correctamente");
                ActualizarGrillaSolicitud(EstadoSolicitudCotizacion.Pendiente);
                grdInsumos.Columns.Clear();
            }
        }
    }
}
