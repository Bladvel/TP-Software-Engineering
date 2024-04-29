using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using System.IO;


namespace Presentacion
{
    public partial class frmAyudaPrimerosPasos : Form
    {
        private static frmAyudaPrimerosPasos instancia = null;

        public static frmAyudaPrimerosPasos Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmAyudaPrimerosPasos();
            }
            return instancia;
        }

        public frmAyudaPrimerosPasos()
        {
            InitializeComponent();
        }



        private void frmAyudaPrimerosPasos_Load(object sender, EventArgs e)
        {
            PdfViewer pdf = new PdfViewer();
            this.Controls.Add(pdf);
            pdf.Dock = DockStyle.Fill;


            //string rutaPDF = @"D:\Facultad\Manual Primeros Pasos.pdf";
            string rutaPDF = @"pdfAyuda\Manual Primeros Pasos.pdf";

            byte[] bytes = System.IO.File.ReadAllBytes(rutaPDF);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
        }

        private void frmAyudaPrimerosPasos_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
