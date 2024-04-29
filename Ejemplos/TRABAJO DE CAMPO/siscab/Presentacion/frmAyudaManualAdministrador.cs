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
    public partial class frmAyudaManualAdministrador : Form
    {
        private static frmAyudaManualAdministrador instancia = null;

        public static frmAyudaManualAdministrador Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmAyudaManualAdministrador();
            }
            return instancia;
        }



        public frmAyudaManualAdministrador()
        {
            InitializeComponent();
        }

        private void frmAyudaManualAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void frmAyudaManualAdministrador_Load(object sender, EventArgs e)
        {
            PdfViewer pdf = new PdfViewer();
            this.Controls.Add(pdf);
            pdf.Dock = DockStyle.Fill;

            string rutaPDF = @"pdfAyuda\Manual de Administrador.pdf";

            byte[] bytes = System.IO.File.ReadAllBytes(rutaPDF);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;

        }
    }
}
