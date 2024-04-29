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

namespace Presentacion
{
    public partial class frmLogin : Form, IIdiomaObserver
    {
        BLL.BLLUsuario _usuarioBLL;
        BLL.BLLSesion _sesionBLL;
        Bitacora registroBitacora;
        BLLBitacora gestorBitacora;

        BLLDVH gestorDVH;
        BLLDVV gestorDVV;




        public frmLogin()
        {
            InitializeComponent();
            _usuarioBLL = new BLL.BLLUsuario();
            _sesionBLL = new BLL.BLLSesion();
            registroBitacora = new Bitacora();
            gestorBitacora = new BLLBitacora();
            gestorDVH = new BLLDVH();
            gestorDVV = new BLLDVV();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            IngresarUsuario();
        }

        private bool ValidarIngreso()
        {
            return ((!string.IsNullOrWhiteSpace(txt_usenarme.Text)) && !string.IsNullOrWhiteSpace(txt_password.Text));
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                IngresarUsuario();
            }
        }

        void IngresarUsuario()
        {
            if (ValidarIngreso())
            {
                string passEnc = Encriptador.Hash(txt_password.Text);
                Servicios.Usuario us = _usuarioBLL.LoginUsuario(txt_usenarme.Text);


                if (us != null)
                {
                    if (us.Borrado != 1)
                    {
                        if (us.Bloqueo != 1)
                        {
                            if (us.Password == passEnc)
                            {
                                SingletonSesion.Instancia.Login(us);
                                _sesionBLL.LoginCargarPermisos(us);


                                if (gestorDVH.ValidarDigitoVerificador())
                                {
                                    if (gestorDVV.ValidarDigitoVerificador())
                                    {
                                        MessageBox.Show("Bienvenido", "Acceso permitido", MessageBoxButtons.OK);
                                        _usuarioBLL.ReiniciarIntentos(us);
                                        ReportarBitacoraLoginOK(us);
                                        frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                                        this.Hide();
                                        frmMenuPrincipal.ValidarForm();
                                        frmMenuPrincipal.ShowDialog();
                                    }
                                    else
                                    {
                                        if (us.Rol == "Administrador")
                                        {
                                            frmInconcistenciaBD frm = new frmInconcistenciaBD();
                                            frm.ShowDialog();
                                            frm.BringToFront();
                                        }
                                        else
                                        {
                                            frmInconsistenciaUsuario frm = new frmInconsistenciaUsuario();
                                            frm.ShowDialog();
                                            frm.BringToFront();
                                        }
                                    }
                                }
                                else
                                {
                                    // Aca deberia poner un if si es adminitrador o usuario comun

                                    if (us.Rol == "Administrador")
                                    {
                                        frmInconcistenciaBD frm = new frmInconcistenciaBD();
                                        frm.ShowDialog();
                                        frm.BringToFront();
                                    }
                                    else
                                    {
                                        frmInconsistenciaUsuario frm = new frmInconsistenciaUsuario();
                                        frm.ShowDialog();
                                        frm.BringToFront();
                                    }

                                }
                            }
                            else
                            {
                                _usuarioBLL.VerificarBloqueo(us);
                                if (us.Intentos == 3)
                                {
                                    MessageBox.Show("Contraseña errónea, intentos fallidos : " + us.Intentos, " Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña errónea, intentos fallidos : " + us.Intentos, "Acceso incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    ReportarBitacoraLoginIncorrecto(us);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario se encuentra bloqueado, contacte con el Administrador del Sistema.", "Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario esta dado de baja.", "Usuario de baja", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Acceso denegado");
                }
            }
            else
            {
                MessageBox.Show("Complete los campos");
            }
        }

        private void ReportarBitacoraLoginOK(Usuario us)
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = us;
            registroBitacora.Modulo = EnumModulo.Usuarios;
            registroBitacora.Operacion = EnumOperacion.Login;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

        private void ReportarBitacoraLoginIncorrecto(Usuario us)
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = us;
            registroBitacora.Modulo = EnumModulo.Usuarios;
            registroBitacora.Operacion = EnumOperacion.LoginIncorrecto;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

        public void UpdateLanguage(IIdioma idioma)
        {
            //Traducir(idioma);
        }

        private void llabel_ayuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAyudaPrimerosPasos frm = frmAyudaPrimerosPasos.Ventana_Unica();            
            frm.Show();
            frm.BringToFront();
        }
    }
}
