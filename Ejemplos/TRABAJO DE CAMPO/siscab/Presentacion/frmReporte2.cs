using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using BE;
using Servicios;

namespace Presentacion
{
    public partial class frmReporte2 : Form
    {

        private static frmReporte2 instancia = null;

        public static frmReporte2 Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmReporte2();
            }
            return instancia;
        }


        public frmReporte2()
        {
            InitializeComponent();
            IniciarDateTimePickers();
        }

        Servicios.Reporte reporte= new Servicios.Reporte();
        BLLReporte gestorReporte = new BLLReporte();
        BLLFactura_Hospedaje gestorFacturaHospedaje = new BLLFactura_Hospedaje();

        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();

        string fecha = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
        string rutaDirectorio = string.Empty;
       
        private void IniciarFecha()
        {
            txt_fechaHoy.Text = fecha;
        }
        private void IniciarDateTimePickers()
        {
            dateTimePicker_desde.Value = DateTime.Today;
            dateTimePicker_hasta.Value = dateTimePicker_desde.Value.AddDays(1);
            dateTimePicker_hasta.Value = dateTimePicker_desde.Value.AddDays(1);
            dateTimePicker_hasta.Value = dateTimePicker_hasta.Value.AddHours(23);
            dateTimePicker_hasta.Value = dateTimePicker_hasta.Value.AddMinutes(59);
            dateTimePicker_hasta.Value = dateTimePicker_hasta.Value.AddSeconds(59);
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {            
            if (ValidarDateTimePickers(dateTimePicker_desde.Value, dateTimePicker_hasta.Value))
            {               
                reporte.FacturasHospedajes = gestorReporte.FiltrarFechas(dateTimePicker_desde.Value, dateTimePicker_hasta.Value, gestorFacturaHospedaje.Listar_Pagos());                
                dataGridView_facturas.DataSource = null;
                dataGridView_facturas.DataSource = reporte.FacturasHospedajes;

                reporte.TotalRestoEstadia = gestorReporte.ObtenerTotalRestoAbonado(reporte.FacturasHospedajes);
                reporte.Fecha = DateTime.Now;
                lbl_total.Text = "Facturación Total de la recaudación de Checkouts: $ " + reporte.TotalRestoEstadia;
                btn_examinar.Enabled = true;
            }                       
        }

        private void frmReporte2_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReporte2_Load(object sender, EventArgs e)
        {
            IniciarFecha();
        }

        private void ReportarBitacoraExportarPDF()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Reporte;
            registroBitacora.Operacion = EnumOperacion.ExportarReporte2;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }


        private bool ValidarDateTimePickers(DateTime fd, DateTime fh)
        {
            bool ok = true;
            if (fd >= fh)
            {
                MessageBox.Show("Las fechas ingresadas son incorrectas", "Fechas Incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                IniciarDateTimePickers();
                ok = false;
            }
            return ok;
        }

        

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = fbd.SelectedPath;
            }
            txt_ruta.Text = rutaDirectorio;
        }

        private bool ValidarValorRutaDirectorio()
        {
            return (!string.IsNullOrWhiteSpace(txt_ruta.Text));
        }

        private void btn_exportarPDF_Click(object sender, EventArgs e)
        {
            if (ValidarValorRutaDirectorio())
            {
                string nombreCopia = (DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString() + "-" +
                 DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-Reporte2.pdf");

                FileStream fs = new FileStream(rutaDirectorio + "\\" + nombreCopia, FileMode.Create);

                Document doc = new Document(PageSize.A4, 2, 2, 2, 2);
                PdfWriter pw = PdfWriter.GetInstance(doc, fs);

                doc.Open();

                //Titulo y autor

                doc.AddAuthor("SISCAB");
                doc.AddTitle("PDF generado");

                //Definir la fuente

                iTextSharp.text.Font standarfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                //Encabezado

                doc.Add(new Paragraph("Reporte de Facturación de los Checkouts"));
                doc.Add(Chunk.NEWLINE);

                doc.Add(new Paragraph("Fecha: " + reporte.Fecha));
                doc.Add(Chunk.NEWLINE);

                //Encabezado de Columnas

                PdfPTable tblEjemplo = new PdfPTable(11);
                tblEjemplo.WidthPercentage = 100;

                //Configurando el titulo de nuestras columnas

                PdfPCell c1Id = new PdfPCell(new Phrase("Id", standarfont));
                c1Id.BorderWidth = 0; ;
                c1Id.BorderWidth = 0.75f;

                PdfPCell c1Numero = new PdfPCell(new Phrase("Número", standarfont));
                c1Numero.BorderWidth = 0; ;
                c1Numero.BorderWidth = 0.75f;

                PdfPCell c1Fecha = new PdfPCell(new Phrase("Fecha", standarfont));
                c1Fecha.BorderWidth = 0; ;
                c1Fecha.BorderWidth = 0.75f;

                PdfPCell c1Lugar = new PdfPCell(new Phrase("Lugar", standarfont));
                c1Lugar.BorderWidth = 0; ;
                c1Lugar.BorderWidth = 0.75f;

                PdfPCell c1FacturaReserva = new PdfPCell(new Phrase("IdFacturaReserva", standarfont));
                c1FacturaReserva.BorderWidth = 0; ;
                c1FacturaReserva.BorderWidth = 0.75f;

                PdfPCell c1IdEstadia = new PdfPCell(new Phrase("IdEstadia", standarfont));
                c1IdEstadia.BorderWidth = 0; ;
                c1IdEstadia.BorderWidth = 0.75f;

                PdfPCell c1IdCliente = new PdfPCell(new Phrase("IdCliente", standarfont));
                c1IdCliente.BorderWidth = 0; ;
                c1IdCliente.BorderWidth = 0.75f;

                PdfPCell c1TotalPagar = new PdfPCell(new Phrase("Total_Pagar", standarfont));
                c1TotalPagar.BorderWidth = 0; ;
                c1TotalPagar.BorderWidth = 0.75f;

                PdfPCell c1Deposito = new PdfPCell(new Phrase("Deposito", standarfont));
                c1Deposito.BorderWidth = 0; ;
                c1Deposito.BorderWidth = 0.75f;

                PdfPCell c1TotalEstadia = new PdfPCell(new Phrase("Total_Estadia", standarfont));
                c1TotalEstadia.BorderWidth = 0; ;
                c1TotalEstadia.BorderWidth = 0.75f;

                PdfPCell c1Estado = new PdfPCell(new Phrase("Estado", standarfont));
                c1Estado.BorderWidth = 0; ;
                c1Estado.BorderWidth = 0.75f;

                tblEjemplo.AddCell(c1Id);
                tblEjemplo.AddCell(c1Numero);
                tblEjemplo.AddCell(c1Fecha);
                tblEjemplo.AddCell(c1Lugar);
                tblEjemplo.AddCell(c1FacturaReserva);
                tblEjemplo.AddCell(c1IdEstadia);
                tblEjemplo.AddCell(c1IdCliente);
                tblEjemplo.AddCell(c1TotalPagar);
                tblEjemplo.AddCell(c1Deposito);
                tblEjemplo.AddCell(c1TotalEstadia);
                tblEjemplo.AddCell(c1Estado);

                foreach (var factura in reporte.FacturasHospedajes)
                {
                    c1Id = new PdfPCell(new Phrase(factura.Id.ToString(), standarfont));
                    c1Id.BorderWidth = 0;

                    c1Numero = new PdfPCell(new Phrase(factura.Numero, standarfont));
                    c1Numero.BorderWidth = 0;

                    c1Fecha = new PdfPCell(new Phrase(factura.Fecha.ToString(), standarfont));
                    c1Fecha.BorderWidth = 0;

                    c1Lugar = new PdfPCell(new Phrase(factura.Lugar, standarfont));
                    c1Lugar.BorderWidth = 0;

                    c1FacturaReserva = new PdfPCell(new Phrase(factura.FacturaReserva.ToString(), standarfont));
                    c1FacturaReserva.BorderWidth = 0;

                    c1IdEstadia = new PdfPCell(new Phrase(factura.Estadia.ToString(), standarfont));
                    c1IdEstadia.BorderWidth = 0;

                    c1IdCliente = new PdfPCell(new Phrase(factura.Cliente.ToString(), standarfont));
                    c1IdCliente.BorderWidth = 0;

                    c1TotalPagar = new PdfPCell(new Phrase(factura.TotalPagar.ToString(), standarfont));
                    c1TotalPagar.BorderWidth = 0;

                    c1Deposito = new PdfPCell(new Phrase(factura.Deposito.ToString(), standarfont));
                    c1Deposito.BorderWidth = 0;

                    c1TotalEstadia = new PdfPCell(new Phrase(factura.TotalEstadia.ToString(), standarfont));
                    c1TotalEstadia.BorderWidth = 0;

                    c1Estado = new PdfPCell(new Phrase(factura.Estado.ToString(), standarfont));
                    c1Estado.BorderWidth = 0;




                    tblEjemplo.AddCell(c1Id);
                    tblEjemplo.AddCell(c1Numero);
                    tblEjemplo.AddCell(c1Fecha);
                    tblEjemplo.AddCell(c1Lugar);
                    tblEjemplo.AddCell(c1FacturaReserva);
                    tblEjemplo.AddCell(c1IdEstadia);
                    tblEjemplo.AddCell(c1IdCliente);
                    tblEjemplo.AddCell(c1TotalPagar);
                    tblEjemplo.AddCell(c1Deposito);
                    tblEjemplo.AddCell(c1TotalEstadia);
                    tblEjemplo.AddCell(c1Estado);

                }

                doc.Add(Chunk.NEWLINE);
                doc.Add(new Paragraph("Periodo - Desde: " + dateTimePicker_desde.Value + " - Hasta: " + dateTimePicker_hasta.Value));
                doc.Add(Chunk.NEWLINE);
                doc.Add(new Paragraph("Facturación Total de la recaudación de Checkouts: $ " + reporte.TotalRestoEstadia.ToString()));
                doc.Add(Chunk.NEWLINE);
                

                doc.Add(tblEjemplo);
                doc.Close();
                pw.Close();

                MessageBox.Show("Documento generado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReportarBitacoraExportarPDF();
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un directorio para generar el reporte", "Directorio", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
