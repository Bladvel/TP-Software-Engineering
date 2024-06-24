using EjemploArquitectura.Abstractions;
using EjemploArquitectura.ApplicationService;
using EjemploArquitectura.Domain;
using EjemploArquitectura.Services;
using EjemploArquitectura.Services.Multiidioma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploArquitectura.UI
{
    public partial class frmMain : Form, IIdiomaObserver
    {
        UsuarioAppService _usuarios;
        LoginAppService _login;

        public frmMain()
        {
            InitializeComponent();
            ValidarFormulario();
            MostrarIdiomas();
            MarcarIdioma();
            Traducir();
             _usuarios = new UsuarioAppService();
            _login = new LoginAppService();
        }

        private void MnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuLogout_Click(object sender, EventArgs e)
        {
            _login.Logout();
            ValidarFormulario();
        }


        void MarcarIdioma()
        {

            if (!ManejadorDeSesion.IsLogged())
            {
                foreach (var item in mnuIdiomas.DropDownItems)
                {

                    var i = ((IIdioma)((ToolStripMenuItem)item).Tag);

                    ((ToolStripMenuItem)item).Checked = i.Default;
                    ((ToolStripMenuItem)item).Enabled = false;

                }
            }
            else
            {
                foreach (var item in mnuIdiomas.DropDownItems)
                {

                    ((ToolStripMenuItem)item).Enabled = true;
                    ((ToolStripMenuItem)item).Checked = ManejadorDeSesion.Session.Idioma.Id.Equals(((IIdioma)((ToolStripMenuItem)item).Tag).Id);
                }
            }


           

        }
        private void MostrarIdiomas()
        {
            var idiomas = Traductor.ObtenerIdiomas();

            foreach (var item in idiomas)
            {
                var t = new ToolStripMenuItem();
                t.Text = item.Nombre;
                t.Tag = item;
                this.mnuIdiomas.DropDownItems.Add(t);

                t.Click += idioma_Click;
            }
         
        }


        private void idioma_Click(object sender, EventArgs e)
        {

            ManejadorDeSesion.CambiarIdioma(((IIdioma)((ToolStripMenuItem)sender).Tag));
            MarcarIdioma();
        }

        public void ValidarFormulario()
        {
          
            this.mnuLogin.Enabled = !ManejadorDeSesion.IsLogged();
            this.mnuLogout.Enabled = ManejadorDeSesion.IsLogged();
            MarcarIdioma();
            Traducir();
        }

        public void UpdateLanguage(IIdioma idioma)
        {

            
            MarcarIdioma();
            Traducir();

        }
        private void Traducir()
        {
            IIdioma idioma = null;
            if (ManejadorDeSesion.IsLogged())
                idioma = ManejadorDeSesion.Session.Idioma;
            

            var traducciones = Traductor.ObtenerTraducciones(idioma);

            if (mnuSesion.Tag!=null && traducciones.ContainsKey(mnuSesion.Tag.ToString()))
               this.mnuSesion.Text = traducciones[mnuSesion.Tag.ToString()].Texto;


            if (mnuLogin.Tag != null && traducciones.ContainsKey(mnuLogin.Tag.ToString()))
                this.mnuLogin.Text = traducciones[mnuLogin.Tag.ToString()].Texto;


            if (mnuLogout.Tag != null && traducciones.ContainsKey(mnuLogout.Tag.ToString()))
                this.mnuLogout.Text = traducciones[mnuLogout.Tag.ToString()].Texto;

            if (mnuIdiomas.Tag != null && traducciones.ContainsKey(mnuIdiomas.Tag.ToString()))
                this.mnuIdiomas.Text = traducciones[mnuIdiomas.Tag.ToString()].Texto;

            if (!ManejadorDeSesion.IsLogged())
            {
                if (traducciones.ContainsKey("please"))
                    this.lblSession.Text = traducciones["please"].Texto;
              
            }
            else
            {
                if (traducciones.ContainsKey("username"))
                    this.lblSession.Text = $"{traducciones["username"].Texto}: {ManejadorDeSesion.Session.Username}";
                
              
                MarcarIdioma();
            }

        }

       
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            ManejadorDeSesion.SuscribirObservador(this);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManejadorDeSesion.DesuscribirObservador(this);
        }

        private void formDePruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrueba frm = new frmPrueba();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuIdiomas_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
