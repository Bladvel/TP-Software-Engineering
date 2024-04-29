using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json.Serialization;


namespace Presentacion
{
    public partial class frmSerializacion : Form
    {

        private static frmSerializacion instancia = null;

        public static frmSerializacion VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmSerializacion();
            }
            return instancia;
        }



        public frmSerializacion()
        {
            InitializeComponent();
        }

        string rutaDirectorio = string.Empty;
        string rutaJSON = string.Empty;

        BE.Reserva reserva = new BE.Reserva();
        BLL.BLLReserva gestorReservas = new BLL.BLLReserva();
        List<BE.Reserva> reservas = new List<BE.Reserva>();



        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSerializacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = fbd.SelectedPath;
            }
            txt_ruta1.Text = rutaDirectorio;
        }

        private bool ValidarValorRutaDirectorio()
        {
            return (!string.IsNullOrWhiteSpace(txt_ruta1.Text));
        }

        private bool ValidarValorRutaArchivo()
        {
            return (!string.IsNullOrWhiteSpace(txt_ruta2.Text));
        }

        private void btn_serializar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRutaDirectorio())
            {
                string cadenaJson = JsonSerializer.Serialize(reservas);

                string nombreArchivo = (DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString() + "-" +
                 DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-ReservasJSON.json");

                File.WriteAllText(rutaDirectorio + "\\" + nombreArchivo, cadenaJson);
                MessageBox.Show("La serialización se hizo correctamente");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            reservas = gestorReservas.FiltrarMesAño(dateTimePicker_MesAño.Value.Month, dateTimePicker_MesAño.Value.Year);
            listBox_objetos.DataSource = null;
            listBox_objetos.DataSource = reservas;
        }


        private void btn_deserializar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRutaArchivo())
            {
                List<BE.Reserva> reservasTMP = new List<BE.Reserva>();
                string cadenaJSON = File.ReadAllText(rutaJSON);

                try
                {
                    reservasTMP = JsonSerializer.Deserialize<List<BE.Reserva>>(cadenaJSON);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"El archivo JSON no corresponde al tipo de objeto a deserializar: {ex.Message}");
                }
                

                listBox_objetos.DataSource = null;
                listBox_objetos.DataSource = reservasTMP;
            }
        }


        private void btn_nuevaConsulta_Click(object sender, EventArgs e)
        {
            listBox_objetos.DataSource = null;
            txt_ruta1.Text = "";
            dateTimePicker_MesAño.Value = DateTime.Now;

        }

        private void btn_examinar2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivo JSON|*.json";
            ofd.Title = "Archivos de tipo JSON";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaJSON = ofd.FileName;
            }
            txt_ruta2.Text = rutaJSON;
        }

      
    }
}
