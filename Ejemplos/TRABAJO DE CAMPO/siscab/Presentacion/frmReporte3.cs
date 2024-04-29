using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class frmReporte3 : Form
    {
        private static frmReporte3 instancia = null;

        public static frmReporte3 Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmReporte3();
            }
            return instancia;
        }


        int[] habitacion = new int[23];
        int[] dias = new int[23];
        float[] porcentaje = new float[23];


        string fecha = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
        string rutaDirectorio = string.Empty;

        BLLHabitacion gestorHabitaciones = new BLLHabitacion();
        BLLEstadia gestorEstadias = new BLLEstadia();

        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();

        int cantDias = new int();

        Reporte reporte = new Reporte();
        BLLReporte gestorReporte = new BLLReporte();

        public frmReporte3()
        {
            InitializeComponent();
            IniciarDateTimePickers();
        }

        private void frmReporte3_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void RellenoVector()
        {
            List<BE.Habitacion> habitaciones = gestorHabitaciones.ListarTotal();

            for (int i = 0; i < habitaciones.Count; i++)
            {
                //series[i] = "Hab Nº " + habitaciones[i].Numero;
                habitacion[i] = habitaciones[i].Numero;
            }
        }

        private void IniciarFecha()
        {
            txt_fechaHoy.Text = fecha;
        }

        private void IniciarDateTimePickers()
        {
            dateTimePicker_desde.Value = DateTime.Today;
            dateTimePicker_hasta.Value = dateTimePicker_desde.Value.AddDays(1);
            dateTimePicker_hasta.Value = dateTimePicker_hasta.Value.AddHours(23);
            dateTimePicker_hasta.Value = dateTimePicker_hasta.Value.AddMinutes(59);
            dateTimePicker_hasta.Value = dateTimePicker_hasta.Value.AddSeconds(59);
        }

        private void frmReporte3_Load(object sender, EventArgs e)
        {
            IniciarFecha();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            if (ValidarDateTimePickers(dateTimePicker_desde.Value, dateTimePicker_hasta.Value))
            {
                List<BE.Estadia> estadias = gestorEstadias.Listar();
                reporte.Estadias = gestorReporte.FiltrarFechasEstadias(dateTimePicker_desde.Value, dateTimePicker_hasta.Value, estadias);
                cantDias = gestorReporte.ObtenerDias(dateTimePicker_desde.Value, dateTimePicker_hasta.Value);

                ConfigurarChart();
                RellenoVector();
                AgregarDatosAlChart();

                btn_Mostrar.Enabled = false;
                dateTimePicker_desde.Enabled = false;
                dateTimePicker_hasta.Enabled = false;
            }
        }

        private string FechaSinHora(DateTime fecha)
        {            
            string fechaTMP = fecha.Day + "/" + fecha.Month + "/" + fecha.Year;
            return fechaTMP;
        }

        private void ConfigurarChart()
        {
            chart1.Titles.Add("Porcentaje de ocupación por habitación desde el " + FechaSinHora(dateTimePicker_desde.Value) + " al " + FechaSinHora(dateTimePicker_hasta.Value) + " inclusive");
            chart1.Series.Add("Datos");
            chart1.Series["Datos"].ChartType = SeriesChartType.Column;
            chart1.ChartAreas[0].AxisX.Title = "Habitaciones";
            chart1.ChartAreas[0].AxisY.Title = "Porcentaje";
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
        }

        private void AgregarDatosAlChart()
        {
            for (int i = 0; i < reporte.Estadias.Count; i++)
            {
                dias[(reporte.Estadias[i].Habitacion.Id) - 1] += gestorReporte.DiferenciaDias(reporte.Estadias[i], dateTimePicker_desde.Value, dateTimePicker_hasta.Value);
            }

            for (int i = 0; i < dias.Length; i++)
            {
                porcentaje[i] = gestorReporte.ObtenerPorcentajeOcupacion(cantDias, dias[i]);
            }

            for (int i = 0; i < habitacion.Length; i++)
            {
                chart1.Series["Datos"].Points.AddXY(habitacion[i], porcentaje[i]);
            }
        }



        private void btn_nuevaConsulta_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            btn_Mostrar.Enabled = true;
            IniciarDateTimePickers();
            Array.Clear(habitacion, 0, habitacion.Length);
            Array.Clear(dias, 0, dias.Length);
            Array.Clear(porcentaje, 0, porcentaje.Length);
            dateTimePicker_desde.Enabled = true;
            dateTimePicker_hasta.Enabled = true;
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

        private bool ValidarValorRutaDirectorio()
        {
            return (!string.IsNullOrWhiteSpace(txt_ruta.Text));
        }

        private void btn_exportarGrafico_Click(object sender, EventArgs e)
        {
            if (ValidarValorRutaDirectorio())
            {
                string nombreCopia = (DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString() + "-" +
                 DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-Reporte3.png");

                FileStream fs = new FileStream(rutaDirectorio + "\\" + nombreCopia, FileMode.Create);

                // Crear un objeto Bitmap para almacenar la imagen del gráfico
                using (Bitmap bmp = new Bitmap(chart1.Width, chart1.Height))
                {
                    // Dibujar el gráfico en el Bitmap
                    chart1.DrawToBitmap(bmp, new Rectangle(0, 0, chart1.Width, chart1.Height));

                    // Guardar el Bitmap como un archivo
                    bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Png);

                    MessageBox.Show("Documento generado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReportarBitacoraExportarGrafico();
                }
            }
            else 
            {
                MessageBox.Show("Debe seleccionar un directorio para generar el reporte", "Directorio", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }            
        }

        private void ReportarBitacoraExportarGrafico()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Reporte;
            registroBitacora.Operacion = EnumOperacion.ExportarReporte3;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

    }
}
