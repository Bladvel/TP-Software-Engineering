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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Security.AccessControl;

namespace TPRestaurante
{
    public partial class frmGenerarSolicitudDeCompra : Form
    {
        public frmGenerarSolicitudDeCompra()
        {
            InitializeComponent();
        }


        private List<BE.ItemIngrediente> items;
        private BE.SolicitudDeCompra solicitud;

        public frmGenerarSolicitudDeCompra(List<ItemIngrediente> items)
        {
            InitializeComponent();
            this.items = items;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGenerarSolicitudDeCompra_Load(object sender, EventArgs e)
        {
            LlenarListBoxItems();
            btnAceptar.Enabled = false;
        }

        void LlenarListBoxItems()
        {
            lstInsumos.Items.Clear();
            foreach (ItemIngrediente item in items)
            {
                lstInsumos.Items.Add(item.Ingrediente.Nombre + " - " + item.CantidadRequerida);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string comentarios = txtComentarios.Text;
            solicitud = new BE.SolicitudDeCompra(items, comentarios);

            VistaPreliminarPDF(solicitud);

        }

        public void VistaPreliminarPDF(SolicitudDeCompra solicitud)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
                document.Open();

                // Agregar información al PDF
                document.Add(new Paragraph($"Solicitud de Compra Nro: **POR ASIGNAR**"));
                document.Add(new Paragraph($"Fecha: {solicitud.Fecha.ToString("dd/MM/yyyy")}"));
                document.Add(new Paragraph($"Estado: {solicitud.Estado}"));
                document.Add(new Paragraph($"Comentarios: {solicitud.Comentarios}"));

                document.Add(new Paragraph("Ingredientes:"));
                foreach (var item in solicitud.Ingredientes)
                {
                    document.Add(new Paragraph($"{item.Ingrediente.Nombre} - Cantidad: {item.CantidadRequerida}"));
                }

                document.Close();
                writer.Close();

                // Convertir el MemoryStream a un array de bytes
                byte[] pdfBytes = memoryStream.ToArray();

                // Guardar en un archivo temporal para abrirlo en un visor
                string tempFilePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".pdf";
                File.WriteAllBytes(tempFilePath, pdfBytes);

                // Cargar el archivo PDF en el WebBrowser
                webBrowser1.Navigate(tempFilePath);
            }

            btnAceptar.Enabled = true;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            solicitud.NroSolicitud = new BLL.SolicitudDeCompra().RegistrarSolicitud(solicitud);
            GuardarPDF(solicitud);
            MessageBox.Show("Solicitud de compra generada con éxito. Nro de solicitud: " + solicitud.NroSolicitud);
        }

        public void GuardarPDF(SolicitudDeCompra solicitud)
        {
            // Mostrar el diálogo de guardar
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar Solicitud de Compra como PDF";
            saveFileDialog.FileName = $"Solicitud_{solicitud.NroSolicitud}.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta seleccionada por el usuario
                string filePath = saveFileDialog.FileName;

                // Generar el PDF en la ruta seleccionada
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
                    document.Open();

                    // Agregar la información de la solicitud al PDF
                    document.Add(new Paragraph($"Solicitud de Compra Nro: {solicitud.NroSolicitud}"));
                    document.Add(new Paragraph($"Fecha: {solicitud.Fecha.ToString("dd/MM/yyyy")}"));
                    document.Add(new Paragraph($"Estado: {solicitud.Estado}"));
                    document.Add(new Paragraph($"Comentarios: {solicitud.Comentarios}"));

                    document.Add(new Paragraph("Ingredientes:"));
                    foreach (var item in solicitud.Ingredientes)
                    {
                        document.Add(new Paragraph($"{item.Ingrediente.Nombre} - Cantidad: {item.CantidadRequerida}"));
                    }

                    document.Close();
                    writer.Close();
                }

                MessageBox.Show("El PDF ha sido guardado correctamente.");
            }
        }




    }
}
