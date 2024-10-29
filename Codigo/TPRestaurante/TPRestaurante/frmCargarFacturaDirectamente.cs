using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Interfaces;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace TPRestaurante
{
    public partial class frmCargarFacturaDirectamente : Form
    {
        public frmCargarFacturaDirectamente()
        {
            InitializeComponent();
            bllOrdenDeCompra = new BLL.OrdenDeCompra();
            bllFactura = new BLL.Factura();
        }

        private BLL.OrdenDeCompra bllOrdenDeCompra;
        private OrdenDeCompra ordenSeleccionada;
        private BLL.Factura bllFactura;

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada si no es un número
            }
        }

        private void frmCargarFacturaDirectamente_Load(object sender, EventArgs e)
        {
            grdOrdenes.RowHeadersVisible = false;
            grdOrdenes.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdOrdenes.MultiSelect = false;

            btnCargarFactura.Enabled = false;

            LlenarGridOrdenes();
        }

        void LlenarGridOrdenes()
        {
            grdOrdenes.DataSource = null;
            grdOrdenes.DataSource = bllOrdenDeCompra.ListarPorEstadoDeOrden(EstadoOrdenDeCompra.FacturaACargar);
        }

        private void grdOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdOrdenes.SelectedRows.Count > 0)
            {
                ordenSeleccionada = (OrdenDeCompra)grdOrdenes.SelectedRows[0].DataBoundItem;
                txtMontoTotal.Text = bllOrdenDeCompra.ObtenerTotal(ordenSeleccionada).ToString(CultureInfo.InvariantCulture);
                btnCargarFactura.Enabled = true;

                MostrarOrdenDeCompra(ordenSeleccionada, rtbOrden);


            }
            else
            {
                btnCargarFactura.Enabled = false;
            }
        }

        public void MostrarOrdenDeCompra(OrdenDeCompra orden, RichTextBox richTextBox)
        {

            richTextBox.Clear();


            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            richTextBox.SelectionColor = Color.DarkBlue;
            richTextBox.AppendText("ORDEN DE COMPRA\n\n");


            richTextBox.SelectionAlignment = HorizontalAlignment.Left;


            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            richTextBox.SelectionColor = Color.Black;
            richTextBox.AppendText("Número de Orden: ");
            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
            richTextBox.AppendText($"{orden.NroOrden}\n");

            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            richTextBox.AppendText("Fecha: ");
            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
            richTextBox.AppendText($"{orden.Fecha:dd/MM/yyyy}\n");

            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            richTextBox.AppendText("Proveedor: ");
            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
            richTextBox.AppendText($"{orden.Proveedor.Nombre}\n");

            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            richTextBox.AppendText("Estado de Orden: ");
            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
            richTextBox.AppendText($"{orden.EstadoOrden}\n");

            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            richTextBox.AppendText("Condición de Pago: ");
            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
            richTextBox.AppendText($"{orden.CondicionDePago}\n");

            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            richTextBox.AppendText("Observaciones: ");
            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
            richTextBox.AppendText($"{orden.Observaciones ?? "N/A"}\n\n");


            richTextBox.SelectionFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            richTextBox.SelectionColor = Color.DarkGreen;
            richTextBox.AppendText("DETALLE DE INSUMOS\n\n");


            foreach (var item in orden.Solicitud.Ingredientes)
            {
                richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                richTextBox.SelectionColor = Color.Black;
                richTextBox.AppendText("Insumo: ");
                richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
                richTextBox.AppendText($"{item.Ingrediente.Nombre}\n");

                richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                richTextBox.AppendText("Cantidad: ");
                richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
                richTextBox.AppendText($"{item.CantidadRequerida}\n");

                richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                richTextBox.AppendText("Precio de Cotización: ");
                richTextBox.SelectionFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
                richTextBox.AppendText($"{item.PrecioCotizacion:C}\n");

                richTextBox.AppendText(new string('-', 50) + "\n");
            }
        }


        private void btnCargarFactura_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotalCuotas.Text))
            {
                MessageBox.Show("Ingrese la cantidad de cuotas.");
                return;
            }

            if (ordenSeleccionada == null)
            {
                MessageBox.Show("Seleccione una orden de compra.");
                return;
            }


            int totalCuotas = int.Parse(txtTotalCuotas.Text);
            DateTime fecha = dtpFecha.Value;
            double montoTotal = double.Parse(txtMontoTotal.Text, CultureInfo.InvariantCulture);

            Factura factura = new Factura(fecha, ordenSeleccionada, montoTotal, totalCuotas);
            factura.NroFactura = bllFactura.Insertar(factura);

            if (factura.NroFactura != -1)
            {
                GenerarPdfFactura(factura);
                MessageBox.Show("Factura cargada correctamente.");

                Close();
            }
            else
            {
                MessageBox.Show("Error al cargar la factura.");
            }
        }

        private void GenerarPdfFactura(Factura factura)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar Factura como PDF";
                    saveFileDialog.FileName = $"Factura_{factura.NroFactura}.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Document document = new Document(PageSize.A4, 50, 50, 25, 25);
                        PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        document.Open();


                        Paragraph title = new Paragraph($"Factura N° {factura.NroFactura}",
                            FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16))
                        {
                            Alignment = Element.ALIGN_CENTER,
                            SpacingAfter = 20f
                        };
                        document.Add(title);


                        Paragraph info = new Paragraph($"Fecha de Emisión: {factura.Fecha.ToShortDateString()}\n" +
                                                       $"Número de Orden de Compra: {factura.OrdenDeCompra.NroOrden}\n" +
                                                       $"Estado de la Factura: {factura.Estado}\n\n",
                            FontFactory.GetFont(FontFactory.HELVETICA, 12));
                        document.Add(info);


                        Paragraph detallesPago = new Paragraph("Detalles de Pago:",
                            FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14))
                        {
                            SpacingAfter = 10f
                        };
                        document.Add(detallesPago);


                        PdfPTable table = new PdfPTable(2) { WidthPercentage = 100 };
                        table.SetWidths(new float[] { 3f, 2f });

                        // Encabezados de la tabla
                        table.AddCell(new Phrase("Descripción", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                        table.AddCell(new Phrase("Valor", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));

                        // Agregar filas de detalles
                        table.AddCell(new Phrase("Monto Total:", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                        table.AddCell(new Phrase($"${factura.MontoTotal:F2}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));

                        table.AddCell(new Phrase("Total de Cuotas:", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                        table.AddCell(new Phrase(factura.TotalCuotas.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 12)));

                        document.Add(table);


                        document.Close();

                        MessageBox.Show("Factura generada exitosamente en PDF.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
