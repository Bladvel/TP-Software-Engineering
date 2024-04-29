using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;



namespace Presentacion
{
    public partial class frmReporte1 : Form
    {
        private static frmReporte1 instancia = null;

        public static frmReporte1 Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmReporte1();
            }
            return instancia;
        }

        public frmReporte1()
        {
            InitializeComponent();
            IniciarDateTimePickers();
           
        }

        private void frmReporte1_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;                  
        }

      
        BLL.BLLFactura gestorFactura = new BLL.BLLFactura();        
        //BE.Reporte reporte = new BE.Reporte();
        Servicios.Reporte reporte = new Servicios.Reporte();
        BLL.BLLReporte gestorReporte = new BLL.BLLReporte();

        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();

        string fecha = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
        string rutaDirectorio = string.Empty;

        private void btn_listar_Click(object sender, EventArgs e)
        {
            if (ValidarDateTimePickers(dateTimePicker_desde.Value, dateTimePicker_hasta.Value))
            {                
                reporte.Facturas = gestorReporte.FiltrarFechas(dateTimePicker_desde.Value, dateTimePicker_hasta.Value, gestorFactura.Listar());
                dgv_reporte1.DataSource = null;
                dgv_reporte1.DataSource = reporte.Facturas;
                reporte.TotalDepositoReservas = gestorReporte.ObtenerTotalDepositoReservas(reporte.Facturas);
                reporte.Fecha = DateTime.Now;
                lbl_totalfacturacion.Text = "Facturación Total de depósitos: $ " + reporte.TotalDepositoReservas;
                btn_examinar.Enabled = true;
            }                       
        }

        void IniciarDateTimePickers()
        {
            dateTimePicker_desde.Value = DateTime.Today;                      
            dateTimePicker_hasta.Value = dateTimePicker_desde.Value.AddDays(1);            
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

        private void ReportarBitacoraExportarPDF()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Reporte;
            registroBitacora.Operacion = EnumOperacion.ExportarReporte1;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
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
                DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-Reporte1.pdf");

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

                doc.Add(new Paragraph("Reporte de facturación de reservas"));
                doc.Add(Chunk.NEWLINE);

                doc.Add(new Paragraph("Fecha: " + reporte.Fecha));
                doc.Add(Chunk.NEWLINE);

                //Encabezado de Columnas

                PdfPTable tblEjemplo = new PdfPTable(10);
                tblEjemplo.WidthPercentage = 100;

                //Configurando el titulo de nuestras columnas

                PdfPCell c1Id = new PdfPCell(new Phrase("Id", standarfont));
                c1Id.BorderWidth = 0; ;
                c1Id.BorderWidth = 0.75f;

                PdfPCell c1Numero = new PdfPCell(new Phrase("Número de Factura", standarfont));
                c1Numero.BorderWidth = 0; ;
                c1Numero.BorderWidth = 0.75f;

                PdfPCell c1Cliente = new PdfPCell(new Phrase("IDCliente", standarfont));
                c1Cliente.BorderWidth = 0; ;
                c1Cliente.BorderWidth = 0.75f;

                PdfPCell c1Fecha = new PdfPCell(new Phrase("Fecha", standarfont));
                c1Fecha.BorderWidth = 0; ;
                c1Fecha.BorderWidth = 0.75f;

                PdfPCell c1Lugar = new PdfPCell(new Phrase("Lugar", standarfont));
                c1Lugar.BorderWidth = 0; ;
                c1Lugar.BorderWidth = 0.75f;

                PdfPCell c1Reserva = new PdfPCell(new Phrase("Id Reserva", standarfont));
                c1Reserva.BorderWidth = 0; ;
                c1Reserva.BorderWidth = 0.75f;

                PdfPCell c1Subtotal = new PdfPCell(new Phrase("Subtotal", standarfont));
                c1Subtotal.BorderWidth = 0; ;
                c1Subtotal.BorderWidth = 0.75f;

                PdfPCell c1Iva = new PdfPCell(new Phrase("Iva", standarfont));
                c1Iva.BorderWidth = 0; ;
                c1Iva.BorderWidth = 0.75f;

                PdfPCell c1Total = new PdfPCell(new Phrase("Total", standarfont));
                c1Total.BorderWidth = 0; ;
                c1Total.BorderWidth = 0.75f;

                PdfPCell c1Deposito = new PdfPCell(new Phrase("Depósito", standarfont));
                c1Deposito.BorderWidth = 0; ;
                c1Deposito.BorderWidth = 0.75f;

                tblEjemplo.AddCell(c1Id);
                tblEjemplo.AddCell(c1Numero);
                tblEjemplo.AddCell(c1Cliente);
                tblEjemplo.AddCell(c1Fecha);
                tblEjemplo.AddCell(c1Lugar);
                tblEjemplo.AddCell(c1Reserva);
                tblEjemplo.AddCell(c1Subtotal);
                tblEjemplo.AddCell(c1Iva);
                tblEjemplo.AddCell(c1Total);
                tblEjemplo.AddCell(c1Deposito);


                foreach (var factura in reporte.Facturas)
                {
                    c1Id = new PdfPCell(new Phrase(factura.Id.ToString(), standarfont));
                    c1Id.BorderWidth = 0;

                    c1Numero = new PdfPCell(new Phrase(factura.Numero, standarfont));
                    c1Numero.BorderWidth = 0;

                    c1Cliente = new PdfPCell(new Phrase(factura.Cliente.ToString(), standarfont));
                    c1Cliente.BorderWidth = 0;

                    c1Fecha = new PdfPCell(new Phrase(factura.Fecha.ToString(), standarfont));
                    c1Fecha.BorderWidth = 0;

                    c1Lugar = new PdfPCell(new Phrase(factura.Lugar, standarfont));
                    c1Lugar.BorderWidth = 0;

                    c1Reserva = new PdfPCell(new Phrase(factura.Reserva.ToString(), standarfont));
                    c1Reserva.BorderWidth = 0;

                    c1Subtotal = new PdfPCell(new Phrase(factura.Subtotal.ToString(), standarfont));
                    c1Subtotal.BorderWidth = 0;

                    c1Iva = new PdfPCell(new Phrase(factura.Iva.ToString(), standarfont));
                    c1Iva.BorderWidth = 0;

                    c1Total = new PdfPCell(new Phrase(factura.Total.ToString(), standarfont));
                    c1Total.BorderWidth = 0;

                    c1Deposito = new PdfPCell(new Phrase(factura.Deposito.ToString(), standarfont));
                    c1Deposito.BorderWidth = 0;


                    tblEjemplo.AddCell(c1Id);
                    tblEjemplo.AddCell(c1Numero);
                    tblEjemplo.AddCell(c1Cliente);
                    tblEjemplo.AddCell(c1Fecha);
                    tblEjemplo.AddCell(c1Lugar);
                    tblEjemplo.AddCell(c1Reserva);
                    tblEjemplo.AddCell(c1Subtotal);
                    tblEjemplo.AddCell(c1Iva);
                    tblEjemplo.AddCell(c1Total);
                    tblEjemplo.AddCell(c1Deposito);

                }

                doc.Add(Chunk.NEWLINE);
                doc.Add(new Paragraph("Periodo - Desde: " + dateTimePicker_desde.Value + " - Hasta: " + dateTimePicker_hasta.Value));
                doc.Add(Chunk.NEWLINE);
                doc.Add(new Paragraph("Total de facturación por depósito: $ " + reporte.TotalDepositoReservas.ToString()));
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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmReporte1_Load(object sender, EventArgs e)
        {
            IniciarFecha();
        }
        private void IniciarFecha()
        {
            txt_fechaHoy.Text = fecha;
        }
    }
}
