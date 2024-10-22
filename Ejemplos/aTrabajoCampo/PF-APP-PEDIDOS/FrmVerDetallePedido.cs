using CAPA_ENTIDADES;
using CAPA_NEGOCIO;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
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


namespace PF_APP_PEDIDOS
{
    public partial class FrmVerDetallePedido : Form
    {
        public FrmVerDetallePedido()
        {
            InitializeComponent();
        }

        private void FrmVerDetallePedido_Load(object sender, EventArgs e)
        {
            txtBuscar.Select();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Pedido pedido = CN_Pedido.GetInstance().ObtenerPedido(txtBuscar.Text);

            if (pedido.IdPedido != 0)
            {
                txtNumeroDoc.Text = pedido.numeroPedido;
                txtFechaPedido.Text = pedido.FechaRegistro;
                txtUsuarioPedido.Text = pedido.oUsuario.NombreUsuario;
                txtDocumentoCliente.Text = pedido.DocumentoCliente;
                txtNombreCliente.Text = pedido.NombreCliente;
                txtApellidoCliente.Text = pedido.ApellidoCliente;

                dtgLista.Rows.Clear();
                foreach (DetallePedido dp in pedido.oDetallePedido)
                {
                    dtgLista.Rows.Add(new object[] { dp.oArticulo.Nombre, dp.PrecioUnitario, dp.Cantidad, dp.SubTotal });
                }

                txtTotalPedido.Text = pedido.MontoTotal.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Pedido no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpia_Click(object sender, EventArgs e)
        {
            txtFechaPedido.Text = "";
            txtUsuarioPedido.Text = "";
            txtDocumentoCliente.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtBuscar.Text = "";
            dtgLista.Rows.Clear();
            txtTotalPedido.Text = "";
            txtBuscar.Select();
        }

        private void btnDesacrgarPdf_Click(object sender, EventArgs e)
        {
            if(txtDocumentoCliente.Text == "")
            {
                MessageBox.Show("No se encontraron los Resultados","Mnesaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string textoHTML = Properties.Resources.plantilla.ToString();
            Negocio odatos = CN_Negocio.GetInstance().ObtenerDatos();

            textoHTML = textoHTML.Replace("@nombreNegocio",odatos.Nombre.ToUpper());
            textoHTML = textoHTML.Replace("@cuit", odatos.Cuit);
            textoHTML = textoHTML.Replace("@direccion", odatos.Direccion);

            textoHTML = textoHTML.Replace("@numeropedido", txtNumeroDoc.Text);
            textoHTML = textoHTML.Replace("@fechapedido", txtFechaPedido.Text);
            textoHTML = textoHTML.Replace("@nombreUsuario", txtUsuarioPedido.Text);
            textoHTML = textoHTML.Replace("@documentoCl", txtDocumentoCliente.Text);
            textoHTML = textoHTML.Replace("@nombreCl", txtNombreCliente.Text);
            textoHTML = textoHTML.Replace("@apellidoCl", txtApellidoCliente.Text);

            string detalleP = string.Empty;

            foreach(DataGridViewRow row in dtgLista.Rows)
            {
                detalleP += "<tr>";
                detalleP += "<td>" + row.Cells["Articulo"].Value.ToString() + "</td>";
                detalleP += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                detalleP += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                detalleP += "<td>" + row.Cells["Subtotal"].Value.ToString() + "</td>";
                detalleP += "</tr>";
            }

            textoHTML = textoHTML.Replace("@detallePedido", detalleP);
            textoHTML = textoHTML.Replace("@totalPedido",txtTotalPedido.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Pedido_{0}.pdf", txtNumeroDoc.Text);
            savefile.Filter = "Pdf Files|*.pdf"; 

            if(savefile.ShowDialog() == DialogResult.OK)
            {
                using(FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    // Crear el documento con tamaño A4
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = CN_Negocio.GetInstance().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(70, 70);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using(var sr = new StringReader(textoHTML))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

       
    }
}
