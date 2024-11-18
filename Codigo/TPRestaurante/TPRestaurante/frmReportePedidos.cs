using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPRestaurante
{
    public partial class frmReporteProductos : Form
    {
        public frmReporteProductos()
        {
            InitializeComponent();
        }

        BLL.Producto bllProducto = new BLL.Producto();
        private DataTable dtProductos;


        private void frmReporteProductos_Load(object sender, EventArgs e)
        {

            grdProductosVendidos.RowHeadersVisible = false;
            grdProductosVendidos.EditMode = DataGridViewEditMode.EditProgrammatically;

            dtProductos = bllProducto.ListarProductosVendidos();

            grdProductosVendidos.DataSource = null;
            grdProductosVendidos.DataSource = dtProductos;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            
            txtPromociones.Clear();
            
            List<string> promociones = bllProducto.ObtenerPromociones(dtProductos);


            foreach (var promocion in promociones)
            {
                txtPromociones.AppendText(promocion);
                txtPromociones.AppendText("\n--------------------------------------\n");
            }


        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Guardar reporte como PDF"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    pdfDoc.Add(new Paragraph("Reporte de Promociones Recomendadas"));
                    pdfDoc.Add(new Paragraph("--------------------------------------"));
                    pdfDoc.Add(new Paragraph(txtPromociones.Text));

                    pdfDoc.Close();
                    MessageBox.Show("PDF exportado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
