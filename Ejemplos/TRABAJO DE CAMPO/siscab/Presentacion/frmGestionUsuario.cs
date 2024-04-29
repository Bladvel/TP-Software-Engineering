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
    public partial class frmGestionUsuario : Form
    {
        private static frmGestionUsuario instancia = null;

        public static frmGestionUsuario Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmGestionUsuario();
            }
            return instancia;
        }
               
        public frmGestionUsuario()
        {
            InitializeComponent();
        }


        private void frmGestionUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        Servicios.Usuario usuario = new Servicios.Usuario();
        BLL.BLLUsuario gestor = new BLL.BLLUsuario();

        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();





        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace (txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text) || string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_apellido.Text) || string.IsNullOrWhiteSpace(txt_dni.Text)) 
                 
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
               
                usuario.Nombre = txt_nombre.Text;
                usuario.Apellido = txt_apellido.Text;
                usuario.Dni = int.Parse(txt_dni.Text);
                usuario.Rol = (string)cb_rol.SelectedItem;
                usuario.Username = txt_username.Text;
                usuario.Password = Encriptador.Hash(txt_password.Text);

                if (gestor.VerificarUsuarioExistente(usuario.Dni))
                {
                    MessageBox.Show("El usuario ya se encuentra registrado","Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    gestor.Grabar(usuario);
                    btn_agregar.Enabled = false;
                    btn_nuevo.Enabled = true;
                    DesactivarTextBox();
                    limpiarTextbox();
                    EnlazarActivos();
                    cb_rol.Enabled = false;
                    ReportarBitacoraAltaUsuario();

                }                              
            }
        }

        private void CargarComboBox()
        {
            cb_rol.Items.Add("Administrador");
            cb_rol.Items.Add("Recepcionista");
            cb_rol.Items.Add("Cajero");            
        }

        public void EnlazarActivos()
        {
            dgw_usuarios.DataSource = null;
            List<Servicios.Usuario> usuarios = gestor.ListarActivos();
            dgw_usuarios.DataSource = usuarios;
            lbl_listados.Text = "Listado seleccionado: Usuarios activos. Cantidad: " + usuarios.Count;
        }
        public void EnlazarTotal()
        {
            dgw_usuarios.DataSource = null;
            List<Servicios.Usuario> usuarios = gestor.ListarTotal();
            dgw_usuarios.DataSource = usuarios;
            lbl_listados.Text = "Listado seleccionado: Total de usuarios. Cantidad: " + usuarios.Count;
        }

        public void EnlazarBloqueados()
        {
            dgw_usuarios.DataSource = null;
            List<Servicios.Usuario> usuarios = gestor.ListarBloqueados();
            dgw_usuarios.DataSource = usuarios;
            lbl_listados.Text = "Listado seleccionado: Usuarios bloqueados. Cantidad: " + usuarios.Count;
        }

        public void EnlazarBorrados()
        {
            dgw_usuarios.DataSource = null;
            List<Servicios.Usuario> usuarios = gestor.ListarBorrados();
            dgw_usuarios.DataSource = usuarios;
            lbl_listados.Text = "Listado seleccionado: Usuarios borrados. Cantidad: " + usuarios.Count;
        }

        private void ReportarBitacoraConsultarUsuarios()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.GestorUsuario;
            registroBitacora.Operacion = EnumOperacion.Consulta;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

        private void ReportarBitacoraAltaUsuario()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.GestorUsuario;
            registroBitacora.Operacion = EnumOperacion.Alta;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

        private void ReportarBitacoraModificarUsuario()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.GestorUsuario;
            registroBitacora.Operacion = EnumOperacion.Modificacion;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

        private void ReportarBitacoraBajaUsuario()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.GestorUsuario;
            registroBitacora.Operacion = EnumOperacion.Baja;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

        private void ReportarBitacoraDesbloquearUsuario()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.GestorUsuario;
            registroBitacora.Operacion = EnumOperacion.DesbloquearUsuario;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }



        private void dgw_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario = (Servicios.Usuario)dgw_usuarios.Rows[e.RowIndex].DataBoundItem;
            ActivarTextBox();
            cb_rol.Enabled = true;
            txt_nombre.Text = usuario.Nombre;
            txt_apellido.Text = usuario.Apellido;
            txt_dni.Text = usuario.Dni.ToString();
            txt_username.Text = usuario.Username;
            cb_rol.SelectedItem = usuario.Rol;
            txt_password.Text = Encriptador.Hash(usuario.Password);
            btn_agregar.Enabled = false;
            btn_modificar.Enabled = true;
            btn_borrar.Enabled = true;
            if (usuario.Bloqueo == 1)
            {
                btn_desbloquear.Enabled = true;
            }
            else
            {
                btn_desbloquear.Enabled = false;
            }
            
        }

        private void frmCrearModificarUsuario_Load(object sender, EventArgs e)
        {
            EnlazarActivos();
            CargarComboBox();
            

        }
    
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            usuario.Nombre= txt_nombre.Text;
            usuario.Apellido = txt_apellido.Text;
            usuario.Dni = int.Parse(txt_dni.Text);
            usuario.Username = txt_username.Text;
            usuario.Password = txt_password.Text;
            gestor.Grabar(usuario);
            limpiarTextbox();
            EnlazarActivos();
            cb_rol.Enabled = false;
            ReportarBitacoraModificarUsuario();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            usuario.Borrado = 1;
            gestor.Grabar(usuario);
            limpiarTextbox();
            EnlazarActivos();
            ReportarBitacoraBajaUsuario();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            cb_rol.Enabled = true;
            limpiarTextbox();
            ActivarTextBox();
            usuario = new Servicios.Usuario();
            btn_agregar.Enabled = true;
            btn_borrar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_nuevo.Enabled = false;
            
        }

        void ActivarTextBox()
        {
            txt_nombre.Enabled = true;
            txt_apellido.Enabled = true;
            txt_dni.Enabled = true;
            txt_username.Enabled = true;
            txt_password.Enabled = true;          
        }

        void DesactivarTextBox()
        {
            txt_nombre.Enabled = false;
            txt_apellido.Enabled = false;
            txt_dni.Enabled = false;
            txt_username.Enabled = false;
            txt_password.Enabled = false;
        }

        void limpiarTextbox ()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_dni.Text = "";
            txt_username.Text = "";
            txt_password.Text = "";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarTextbox();
            DesactivarTextBox();
            btn_nuevo.Enabled = true;
            btn_agregar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_borrar.Enabled = false; 

        }

        private void btn_listar_bloqueados_Click(object sender, EventArgs e)
        {
            EnlazarBloqueados();
            ReportarBitacoraConsultarUsuarios();
        }

        private void btn_desbloquear_Click(object sender, EventArgs e)
        {
            gestor.Desbloquear(usuario);
            EnlazarActivos();
            ReportarBitacoraDesbloquearUsuario();
        }

        private void btn_listar_todos_Click(object sender, EventArgs e)
        {
            EnlazarTotal();
            ReportarBitacoraConsultarUsuarios();
        }

        private void btn_listar_activos_Click(object sender, EventArgs e)
        {
            EnlazarActivos();
            ReportarBitacoraConsultarUsuarios();
        }

        private void btn_listar_borrados_Click(object sender, EventArgs e)
        {
            EnlazarBorrados();
            ReportarBitacoraConsultarUsuarios();
        }

       
    }
}
