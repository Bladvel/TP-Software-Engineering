using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Interfaces;
using Services.Multiidioma;

namespace TPRestaurante
{
    public partial class frmManageLanguages : Form
    {
        public frmManageLanguages()
        {
            InitializeComponent();
            etiquetaBll = new BLL.EtiquetaBLL();
            idiomaBLL = new BLL.IdiomaBLL();
            traduccionBll = new BLL.TraduccionBLL();
        }

        private List<Etiqueta> etiquetas;
        private BLL.EtiquetaBLL etiquetaBll;
        private BLL.IdiomaBLL idiomaBLL;
        private BLL.TraduccionBLL traduccionBll;
        private void frmManageLanguages_Load(object sender, EventArgs e)
        {
            etiquetas = etiquetaBll.Listar();

            grdTraducciones.AutoGenerateColumns = false;
            grdTraducciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Etiqueta",
                DataPropertyName = "Nombre",
                ReadOnly = true
            });
            grdTraducciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Traduccion",
                HeaderText = "Traducción"
            });

            foreach (var etiqueta in etiquetas)
            {
                grdTraducciones.Rows.Add(etiqueta.Nombre, string.Empty);
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreIdioma = txtNombre.Text;

            

            if (string.IsNullOrEmpty(nombreIdioma))
            {
                MessageBox.Show("El nombre del idioma es obligatorio.");
                return;
            }

            Idioma idiomaNuevo = new Idioma();
            idiomaNuevo.Nombre = nombreIdioma;
            idiomaNuevo.Default = false;

            int idiomaId = idiomaBLL.Insertar(idiomaNuevo);
            if (idiomaId > 0)
            {
                var traducciones = new List<Traduccion>();
                
                foreach (DataGridViewRow row in grdTraducciones.Rows)
                {
                    if (row.IsNewRow) continue;

                    string traduccion = row.Cells["Traduccion"].Value.ToString();
                    if (string.IsNullOrWhiteSpace(traduccion))
                    {
                        traduccion = row.Cells["Nombre"].Value.ToString();
                    }


                    traducciones.Add(new Traduccion
                    {
                        idioma = new Idioma()
                        {
                            Id = idiomaId,
                            Nombre = nombreIdioma
                        },
                        Etiqueta = new Etiqueta()
                        {
                            Id = etiquetas[row.Index].Id,
                            Nombre = row.Cells["Nombre"].Value.ToString()
                        },

                        Texto = traduccion
                    });




                }
                traduccionBll.GuardarTraducciones(traducciones);

                MessageBox.Show("Idioma y traducciones guardados correctamente. Por favor reiniciar el programa");

            }
            else
            {
                MessageBox.Show("Error al guardar el idioma");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
