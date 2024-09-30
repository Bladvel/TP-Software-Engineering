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
using Services;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace TPRestaurante
{
    public partial class frmBitacoraEventos : Form
    {
        public frmBitacoraEventos()
        {
            InitializeComponent();
            bllBitacora = new BLL.Bitacora();
            bllUser = new BLL.User();
            bitacoraFiltrada = new List<Bitacora>();
        }

        BLL.Bitacora bllBitacora;
        BLL.User bllUser;
        List<Services.Bitacora> bitacoraFiltrada;


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmBitacoraEventos_Load(object sender, EventArgs e)
        {
            RellenarComboBox();
            ActualizarGrilla();

            dtpInicial.Value = DateTime.Today;
            dtpFinal.Value = DateTime.Today.AddDays(1);

            btnImprimir.Enabled = false;
        }

        void RellenarComboBox()
        {
            List<BE.User> usuarios = bllUser.ListUsers();
            usuarios.Insert(0, new BE.User { Nombre = "Todos" });
            cmbUsuarios.DataSource = null;
            cmbUsuarios.DataSource = usuarios;

            cmbOperacion.DataSource = null;
            cmbModulo.DataSource = null;





            cmbOperacion.DataSource = Enum.GetValues(typeof(TipoOperacion));
            cmbModulo.DataSource = Enum.GetValues(typeof(TipoModulo));

            cmbModulo.SelectedIndex = 0;
            cmbOperacion.SelectedIndex = 0;

            for (int i = 1; i <= 5; i++)
            {
                cmbCriticidad.Items.Add(i);
            }

            cmbCriticidad.Items.Insert(0, "Todos");
            cmbCriticidad.SelectedIndex = 0;
        }

        void ActualizarGrilla(List<Services.Bitacora> bitacoras = null)
        {

            grdBitacoraEventos.AutoGenerateColumns = false;
            grdBitacoraEventos.DataSource = null;
            grdBitacoraEventos.Columns.Clear();
            grdBitacoraEventos.Rows.Clear();
            if(bitacoras == null)
                grdBitacoraEventos.DataSource = bllBitacora.Listar();
            else
            {
                grdBitacoraEventos.DataSource = bitacoras;
            }

            grdBitacoraEventos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdBitacoraEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdBitacoraEventos.MultiSelect = false;
            grdBitacoraEventos.RowHeadersVisible = false;


            DataGridViewTextBoxColumn fechaColumn = new DataGridViewTextBoxColumn();
            fechaColumn.HeaderText = "FECHA";
            fechaColumn.DataPropertyName = "Fecha";
            fechaColumn.ReadOnly =true;
            grdBitacoraEventos.Columns.Add(fechaColumn);


            DataGridViewTextBoxColumn usuarioColumn = new DataGridViewTextBoxColumn();
            usuarioColumn.HeaderText = "USUARIO";
            usuarioColumn.DataPropertyName = "Username";
            usuarioColumn.ReadOnly =true;
            grdBitacoraEventos.Columns.Add(usuarioColumn);

            DataGridViewTextBoxColumn moduloColumn = new DataGridViewTextBoxColumn();
            moduloColumn.HeaderText = "MODULO";
            moduloColumn.DataPropertyName = "Modulo";
            moduloColumn.ReadOnly =true;
            grdBitacoraEventos.Columns.Add(moduloColumn);

            DataGridViewTextBoxColumn operacionColumn = new DataGridViewTextBoxColumn();
            operacionColumn.HeaderText = "OPERACION";
            operacionColumn.DataPropertyName = "Operacion";
            operacionColumn.ReadOnly =true;
            grdBitacoraEventos.Columns.Add(operacionColumn);

            DataGridViewTextBoxColumn criticadColumn = new DataGridViewTextBoxColumn();
            criticadColumn.HeaderText = "CRITICIDAD";
            criticadColumn.DataPropertyName = "Criticidad";
            criticadColumn.ReadOnly =true;
            grdBitacoraEventos.Columns.Add(criticadColumn);

            


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpInicial.Value;
            DateTime fechaFin = dtpFinal.Value;

            if (fechaInicio >= fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.");
                dtpInicial.Value = DateTime.Today.AddDays(-1);
                dtpFinal.Value = DateTime.Today;
                return;
            }

            Guid? idUSer = null;
            if (cmbUsuarios.SelectedItem != null)
            {
                BE.User usuario;
                usuario = (BE.User)cmbUsuarios.SelectedValue;
                if (usuario.Nombre != "Todos")
                    idUSer = usuario.ID;
            }

            int? criticidad = null;
            if (cmbCriticidad.SelectedItem != null && cmbCriticidad.SelectedItem.ToString() != "Todos")
                criticidad = (int)cmbCriticidad.SelectedItem;

            string operacion = null;
            if (cmbOperacion.SelectedItem != null && cmbOperacion.SelectedItem.ToString() != "Todos")
                operacion = cmbOperacion.SelectedItem.ToString();

            string modulo = null;
            if (cmbModulo.SelectedItem != null && cmbModulo.SelectedItem.ToString() != "Todos")
                modulo = cmbModulo.SelectedItem.ToString();

            
            bitacoraFiltrada = bllBitacora.Filtrar(fechaInicio, fechaFin, idUSer,modulo, operacion, criticidad);
            ActualizarGrilla(bitacoraFiltrada);

            btnImprimir.Enabled = true;

        }


        private void grdBitacoraEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Services.Bitacora bitacora = (Services.Bitacora)grdBitacoraEventos.CurrentRow.DataBoundItem;
            BE.User usuario = bitacora.Usuario as BE.User;


            lblUsuario.Text = usuario.NombreCompleto;
            
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            cmbOperacion.SelectedIndex = 0;
            cmbUsuarios.SelectedIndex = 0;
            cmbCriticidad.SelectedIndex = 0;
            cmbModulo.SelectedIndex = 0;
            bitacoraFiltrada = bllBitacora.Listar();
            ActualizarGrilla(bitacoraFiltrada);

            btnImprimir.Enabled = true;


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar bitácora como PDF";
                string fecha = dtpFinal.Value.ToShortDateString().Replace('/', '-');
                saveFileDialog.FileName = $"Bitacora_{fecha}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;
                    GenerarPDFbitacora(bitacoraFiltrada, path);
                    RegistroBitacoraGenerarBitacora();
                    MessageBox.Show("Comanda generada y exportada como PDF.");
                }
            }
        }

        private void GenerarPDFbitacora(List<Bitacora> bitacoras, string path)
        {
            
            Document document = new Document(PageSize.A4, 10, 10, 10, 10);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));

            
            document.Open();

            Paragraph title = new Paragraph("Reporte de Bitácora", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            
            document.Add(new Paragraph("\n"));

            
            PdfPTable table = new PdfPTable(5); // 5 columnas: Fecha, Usuario, Módulo, Operación, Criticidad
            table.WidthPercentage = 100;

            
            table.AddCell("Fecha");
            table.AddCell("Usuario");
            table.AddCell("Módulo");
            table.AddCell("Operación");
            table.AddCell("Criticidad");

            
            foreach (var bitacora in bitacoras)
            {
                table.AddCell(bitacora.Fecha.ToString());
                table.AddCell(bitacora.Usuario.Username); // Suponiendo que el Usuario tiene una propiedad Username
                table.AddCell(bitacora.Modulo.ToString());
                table.AddCell(bitacora.Operacion.ToString());
                table.AddCell(bitacora.Criticidad.ToString());
            }

            
            document.Add(table);

            
            document.Close();
            writer.Close();
        }


        private void RegistroBitacoraGenerarBitacora()
        {
            Services.Bitacora bitacora = new Services.Bitacora();
            bitacora.Fecha = DateTime.Now;
            bitacora.Modulo = TipoModulo.GestorDeBitacora;
            bitacora.Operacion = TipoOperacion.GenerarBitacora;
            bitacora.Criticidad = 5;
            bitacora.Usuario = (BE.User)SessionManager.Instance.User;
            bllBitacora.Insertar(bitacora);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
