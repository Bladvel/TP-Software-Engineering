using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics.Eventing.Reader;

namespace Presentacion
{
    public partial class frmSerializacionFactura : Form
    {
        private static frmSerializacionFactura instancia = null;

        public static frmSerializacionFactura VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmSerializacionFactura();
            }
            return instancia;
        }

        BE.Factura factura;



        public frmSerializacionFactura()
        {
            InitializeComponent();
        }
          
        private void btn_deserializacionRollBack_Click(object sender, EventArgs e)
        {

            // Carpeta donde se buscarán los archivos
            string carpeta = @"serializacionRollBack\";

            // Verificar si la carpeta existe
            if (Directory.Exists(carpeta))
            {
                try
                {
                    // Obtener la lista de archivos ordenados por fecha de escritura
                    var directoryInfo = new DirectoryInfo(carpeta);
                    var archivos = directoryInfo.GetFiles()
                        .OrderByDescending(f => f.LastWriteTime)
                        .ToList();

                    // Si hay archivos en la carpeta
                    if (archivos.Count > 0)
                    {
                        factura = new BE.Factura();

                        // Seleccionar el último archivo creado
                        string ultimoArchivo = archivos.First().FullName;

                        // Mostrar la ruta del último archivo en el TextBox
                        txt_ruta.Text = ultimoArchivo;

                        // ACA TIENE QUE VENIR LA DESERIALIZACION ROLLBACK

                        string cadenaJSON = File.ReadAllText(txt_ruta.Text);

                        factura = JsonSerializer.Deserialize<BE.Factura>(cadenaJSON);       

                        txt_objeto.Text = "Número de Factura: " + factura.Numero + " - Fecha: " + factura.Fecha + " - Lugar: " + factura.Lugar + " - Cliente: " + factura.Cliente 
                            + " - Reserva: " + factura.Reserva + " - Subtotal: " + factura.Subtotal + " - I.V.A.: " + factura.Iva + " - Total: " + factura.Total;

                        
                    }
                    else
                    {
                        MessageBox.Show("La carpeta está vacía.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al acceder a la carpeta: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("La carpeta no existe.");
            }

        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSerializacionFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void frmSerializacionFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
