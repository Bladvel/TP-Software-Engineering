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
using PdfiumViewer;

namespace TPRestaurante
{
    public partial class frmManualAdministrador : Form
    {
        private PdfViewer pdfViewer;

        public frmManualAdministrador()
        {
            InitializeComponent();
            ConfigurarPdfViewer();
        }

        private void ConfigurarPdfViewer()
        {
            pdfViewer = new PdfViewer
            {
                Dock = DockStyle.Fill,
                ZoomMode = PdfViewerZoomMode.FitWidth
            };

            panelPdf.Controls.Add(pdfViewer);
        }

        private void frmManualAdministrador_Load(object sender, EventArgs e)
        {
            string rutaPdf = Path.Combine(Application.StartupPath, @"Resources\Manual de Administrador.pdf");

            if (File.Exists(rutaPdf))
            {
                CargarPdf(rutaPdf);
            }
            else
            {
                MessageBox.Show("El archivo PDF no se encontró en la ruta esperada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CargarPdf(string rutaPdf)
        {
            try
            {
                var pdfDocument = PdfDocument.Load(rutaPdf);
                pdfViewer.Document = pdfDocument;
                //pdfViewer.Renderer.Load(pdfDocument);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo cargar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
