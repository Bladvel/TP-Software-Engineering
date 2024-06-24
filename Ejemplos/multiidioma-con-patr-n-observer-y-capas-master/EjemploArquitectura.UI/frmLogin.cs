using EjemploArquitectura.Abstractions;
using EjemploArquitectura.ApplicationService;
using EjemploArquitectura.Services;
using EjemploArquitectura.Services.Multiidioma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploArquitectura.UI
{
    public partial class frmLogin : Form,IIdiomaObserver
    {


        LoginAppService _login;
        public frmLogin()
        {
            _login = new LoginAppService();
            InitializeComponent();
            
            
            if (ManejadorDeSesion.IsLogged())
                Traducir(ManejadorDeSesion.Session.Idioma);
            else
                Traducir();


        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }


        private void Traducir(IIdioma idioma=null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);

            if (this.Tag != null && traducciones.ContainsKey(this.Tag.ToString()))
                this.Text = traducciones[this.Tag.ToString()].Texto;



            if (lblUsername.Tag != null && traducciones.ContainsKey(lblUsername.Tag.ToString()))
                lblUsername.Text = traducciones[lblUsername.Tag.ToString()].Texto;

            if (lblPassword.Tag != null && traducciones.ContainsKey(lblPassword.Tag.ToString()))
                lblPassword.Text = traducciones[lblPassword.Tag.ToString()].Texto;


            if (btnIngresar.Tag != null && traducciones.ContainsKey(btnIngresar.Tag.ToString()))
                btnIngresar.Text = traducciones[btnIngresar.Tag.ToString()].Texto;

            //    this.mnuSesion.Text = traducciones[mnuSesion.Tag.ToString()].Texto;



        }


        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {               
             
         
               _login.Login(this.txtUsername.Text, this.txtPassword.Text);
                frmMain frm = (frmMain)this.MdiParent;
                frm.ValidarFormulario();
                this.Close();

            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ManejadorDeSesion.SuscribirObservador(this);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManejadorDeSesion.DesuscribirObservador(this);
        }
    }
}
