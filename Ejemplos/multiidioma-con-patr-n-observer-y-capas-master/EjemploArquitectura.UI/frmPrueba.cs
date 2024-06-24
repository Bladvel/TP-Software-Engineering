using EjemploArquitectura.Abstractions;
using EjemploArquitectura.Services;
using EjemploArquitectura.Services.Multiidioma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploArquitectura.UI
{
    public partial class frmPrueba : Form , IIdiomaObserver
    {
        public frmPrueba()
        {
            InitializeComponent();

            if (ManejadorDeSesion.IsLogged())
                Traducir(ManejadorDeSesion.Session.Idioma);
            else
                Traducir(); //trae el idioma por default
            
        }


        private void Traducir(IIdioma idioma = null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);

            if (this.Tag != null && traducciones.ContainsKey(this.Tag.ToString()))
                this.Text = traducciones[this.Tag.ToString()].Texto;

            if (lblPrueba.Tag != null && traducciones.ContainsKey(lblPrueba.Tag.ToString()))
                lblPrueba.Text = traducciones[lblPrueba.Tag.ToString()].Texto;

            if (btnGracias.Tag != null && traducciones.ContainsKey(btnGracias.Tag.ToString()))
                btnGracias.Text = traducciones[btnGracias.Tag.ToString()].Texto;


            if (this.checkBox1.Tag != null && traducciones.ContainsKey(checkBox1.Tag.ToString()))
                checkBox1.Text = traducciones[checkBox1.Tag.ToString()].Texto;
        }
        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            ManejadorDeSesion.SuscribirObservador(this);
        }

        private void frmPrueba_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManejadorDeSesion.DesuscribirObservador(this);
        }
    }
}
