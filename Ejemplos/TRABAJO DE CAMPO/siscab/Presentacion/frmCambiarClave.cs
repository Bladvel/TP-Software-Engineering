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
    public partial class frmCambiarClave : Form
    {

        private static frmCambiarClave instancia = null;

        public static frmCambiarClave Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmCambiarClave();
            }
            return instancia;
        }
        public frmCambiarClave()
        {
            InitializeComponent();
        }

        private void frmCambiarClave_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        public void ValidarForm()
        {
            if (SingletonSesion.Instancia.IsLogged())
            {
                txt_usuario.Text = SingletonSesion.Instancia.Usuario.Username;
            }
            else
            {
                txt_usuario.Text = "Usuario no logueado";
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        BLL.BLLUsuario gestor = new BLL.BLLUsuario();
        Servicios.Usuario usuario = new Servicios.Usuario();

        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();

        private void btn_cambiar_Click(object sender, EventArgs e)
        {      
            CambiarContraseña();
            ReportarBitacoraCambioConstraseña();

        }

        private void ReportarBitacoraCambioConstraseña()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Usuarios;
            registroBitacora.Operacion = EnumOperacion.CambioContraseña;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

        private bool ValidarIngreso()
        {
            return !string.IsNullOrWhiteSpace(txt_contraseña.Text) && !string.IsNullOrWhiteSpace(txt_nueva_contraseña.Text) && !string.IsNullOrWhiteSpace(txt_reingrese_nueva_contraseña.Text);
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            limpiarTextBoxs();
        }

        void limpiarTextBoxs()
        {
            txt_contraseña.Text = "";
            txt_nueva_contraseña.Text = "";
            txt_reingrese_nueva_contraseña.Text = "";
            txt_contraseña.Focus();
        }

        void CambiarContraseña()
        {
            if (ValidarIngreso())
            {
                string passEnc = Encriptador.Hash(txt_contraseña.Text);
                if (passEnc == SingletonSesion.Instancia.Usuario.Password)
                {
                    if (txt_nueva_contraseña.Text == txt_reingrese_nueva_contraseña.Text)
                    {
                        if (txt_reingrese_nueva_contraseña.Text == txt_contraseña.Text)
                        {
                            MessageBox.Show("La nueva contraseña debe ser distinta a la actual.","Cambio de contraseña",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            limpiarTextBoxs();
                        }
                        else
                        {
                            if (MessageBox.Show("¿Está seguro de cambiar su contraseña?", "Cambio de Contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                usuario = SingletonSesion.Instancia.Usuario;
                                usuario.Password = Encriptador.Hash(txt_reingrese_nueva_contraseña.Text);                       
                                gestor.ModificarContraseña(usuario);                                
                                MessageBox.Show("Cambio de contraseña exitosa.", "Cambio de contraseña");
                                limpiarTextBoxs();
                            }
                            limpiarTextBoxs();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las nuevas contraseñas no son iguales", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpiarTextBoxs();
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiarTextBoxs();
                }
            }
            else
            {
                MessageBox.Show("Complete los datos");
                limpiarTextBoxs();
            }
        }

        private void txt_reingrese_nueva_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CambiarContraseña();
            }
        }
    }
}
