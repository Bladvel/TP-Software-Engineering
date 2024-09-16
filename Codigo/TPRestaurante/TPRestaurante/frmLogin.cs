﻿using System;
using BE;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using Services;

namespace TPRestaurante
{
    public partial class frmLogin : Form, IIdiomaObserver
    {
        BLL.User bllUser;
        private Bitacora bitacora;
        private BLL.Bitacora bllBitacora;
        public frmLogin()
        {
            InitializeComponent();
            bllUser = new BLL.User();
            bitacora = new Bitacora();
            bllBitacora = new BLL.Bitacora();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    user.Username = txtUsername.Text;
                    user.Password = txtPassword.Text;
                    var result = bllUser.Login(user);
                    if (result == LoginResult.ValidUser)
                    {
                        RegistroBitacoraLoginCorrecto(user);
                    }


                    frmMDI parent = (frmMDI)this.MdiParent;
                    parent.ValidarForm();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor complete los campos");
                    VaciarTextBoxs();
                }

            }
            catch (LoginException ex)
            {
                switch (ex.Result)
                {
                    case LoginResult.InvalidUsername:
                        MessageBox.Show("User incorrecto");
                        break;
                    case LoginResult.InvalidPassword:
                        User userAttempts = bllUser.GetUser(user.Username);
                        RegistroBitacoraLoginInorrecto(user);
                        MessageBox.Show($"Password Incorrecto\nTe quedan {3 - userAttempts.Attempts} intento/s");
                        break;
                    case LoginResult.BlockedUser:
                        RegistroBitacoraBloqueoDeUsuario(user);
                        MessageBox.Show("Limite de intentos superados. Ha sido Bloqueado\nContacte a un administrador");
                        break;
                    case LoginResult.AlreadyBlockedUser:
                        RegistroBitacoraLoginUsuarioBloqueado(user);
                        MessageBox.Show("User bloqueado");
                        break;
                    default:
                        break;
                }

                VaciarTextBoxs();
            }
            

           
        }

        public void VaciarTextBoxs()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {


            if (this.MdiParent != null)
            {
                
                int x = (this.MdiParent.ClientSize.Width - this.Width) / 2;
                int y = (this.MdiParent.ClientSize.Height - this.Height) / 2;

                
                this.Location = new Point(x, y);
            }


            SessionManager.SuscribirObservador(this);

            if (SessionManager.Instance.IsLoggedIn())
            {
                Traducir(SessionManager.Instance.User.Idioma);
            }
            else
            {
                Traducir();
            }


        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma = null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);

            //Menu sesion
            if (lblIniciarSesion.Tag != null && traducciones.ContainsKey(lblIniciarSesion.Tag.ToString()))
                lblIniciarSesion.Text = traducciones[lblIniciarSesion.Tag.ToString()].Texto;
            if (lblUsername.Tag != null && traducciones.ContainsKey(lblUsername.Tag.ToString()))
                lblUsername.Text = traducciones[lblUsername.Tag.ToString()].Texto;
            if (lblPassword.Tag != null && traducciones.ContainsKey(lblPassword.Tag.ToString()))
                lblPassword.Text = traducciones[lblPassword.Tag.ToString()].Texto;
            if (btnEntrar.Tag != null && traducciones.ContainsKey(btnEntrar.Tag.ToString()))
                btnEntrar.Text = traducciones[btnEntrar.Tag.ToString()].Texto;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }

        private void RegistroBitacoraLoginCorrecto(User user)
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = bllUser.GetUser(user.Username);
            bitacora.Modulo = TipoModulo.InicioSesion;
            bitacora.Operacion = TipoOperacion.Login;
            bitacora.Criticidad = 1; //TEST
            bllBitacora.Insertar(bitacora);
        }

        private void RegistroBitacoraLoginInorrecto(User user)
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = bllUser.GetUser(user.Username);
            bitacora.Modulo = TipoModulo.InicioSesion;
            bitacora.Operacion = TipoOperacion.LoginIncorrecto;
            bitacora.Criticidad = 1; //TEST
            bllBitacora.Insertar(bitacora);
        }


        private void RegistroBitacoraLoginUsuarioBloqueado(User user)
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = bllUser.GetUser(user.Username);
            bitacora.Modulo = TipoModulo.InicioSesion;
            bitacora.Operacion = TipoOperacion.LoginUsuarioBloqueado;
            bitacora.Criticidad = 1; //TEST
            bllBitacora.Insertar(bitacora);
        }

        private void RegistroBitacoraBloqueoDeUsuario(User user)
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = bllUser.GetUser(user.Username);
            bitacora.Modulo = TipoModulo.InicioSesion;
            bitacora.Operacion = TipoOperacion.BloqueoDeUsuario;
            bitacora.Criticidad = 1; //TEST
            bllBitacora.Insertar(bitacora);
        }



        //private void RegistroBitacoraLoginIncorrecto(User user)
        //{
        //    bitacora.Fecha = DateTime.Now;
        //    bitacora.Usuario = user;
        //    bitacora.Modulo = TipoModulo.InicioSesion;
        //    bitacora.Operacion = TipoOperacion.LoginIncorrecto;
        //    bitacora.Criticidad = 1; //TEST
        //    bllBitacora.Insertar(bitacora);
        //}



    }
}
