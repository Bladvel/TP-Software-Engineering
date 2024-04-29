using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAyudaManualUsuario : Form
    {

        private static frmAyudaManualUsuario instancia = null;

        public static frmAyudaManualUsuario Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmAyudaManualUsuario();
            }
            return instancia;
        }




        public frmAyudaManualUsuario()
        {
            InitializeComponent();
        }

        private void frmAyudaManualUsuario_Load(object sender, EventArgs e)
        {
            PdfViewer pdf = new PdfViewer();
            this.Controls.Add(pdf);
            pdf.Dock = DockStyle.Fill;

            string rutaPDF = @"pdfAyuda\Manual de Usuario.pdf";

            byte[] bytes = System.IO.File.ReadAllBytes(rutaPDF);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
        }

        private void frmAyudaManualUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
