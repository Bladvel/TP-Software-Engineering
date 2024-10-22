using CAPA_ENTIDADES;
using CAPA_NEGOCIO;
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
    public partial class FrmNegocio : Form
    {
        public FrmNegocio()
        {
            InitializeComponent();
        }

        private void FrmNegocio_Load(object sender, EventArgs e)
        {
            // obtener los datos del negocio
            Negocio datosNegocio = CN_Negocio.GetInstance().ObtenerDatos();

            if(datosNegocio != null )
            {
                // mostrar los datos en los controles correspondientes
                txtNombre.Text = datosNegocio.Nombre;
                txtCUIT.Text = datosNegocio.Cuit;
                txtDireccion.Text = datosNegocio.Direccion;
            }
            else
            {
                MessageBox.Show("Error al Cargar los datos del negocio", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            //obtener el logo del negocio
            bool obtenido = true;
            byte[] byteImagen = CN_Negocio.GetInstance().ObtenerLogo(out obtenido);

            if(obtenido && byteImagen.Length > 0 )
            {
                //convertir el array de bytes a imagen y asignarlo al picturebox
                using(var ms = new MemoryStream(byteImagen))
                {
                    picLogo.Image= Image.FromStream(ms);
                }
            }
            else
            {
                // Si no se pudo obtener la imagen o no existe, mostrar un mensaje o una imagen por defecto
                MessageBox.Show("No se pudo obtener el Logo del Negocio","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                picLogo.Image = null;
            }
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Archivos de imagen (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png;";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(openFileDialog.FileName);

                bool respuesta = CN_Negocio.GetInstance().ActualizarLogo(byteimage, out mensaje);

                if (respuesta)
                {
                    using(var ms = new MemoryStream(byteimage))
                    {
                        picLogo.Image = Image.FromStream(ms);
                    }
                }
                else 
                {
                    MessageBox.Show(mensaje,"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnGauradarCambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Negocio objNegocio = new Negocio()
            {
                Nombre = txtNombre.Text,
                Cuit = txtCUIT.Text,
                Direccion = txtDireccion.Text,
            };

            bool respuesta = CN_Negocio.GetInstance().GuardarDatos(objNegocio, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Se guardaron los cambios correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron Guardar los cambios","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
    }
}
