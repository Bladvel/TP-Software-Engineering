using Servicios;
using System.Windows.Forms;
using System;
using BLL;
using System.Diagnostics;

namespace Presentacion
{
    public partial class frmMenuPrincipal : Form
    {

        BLL.BLLUsuario _bllUsuarios;
        BLL.BLLPermisos _bllPermisos;
        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();

        public frmMenuPrincipal()
        {
            InitializeComponent();
            _bllUsuarios = new BLL.BLLUsuario();
            _bllPermisos = new BLL.BLLPermisos();
            ValidarPermisos();

        }

        public void ValidarForm()
        {
            if (SingletonSesion.Instancia.IsLogged())
            {
                this.toolStripSesion.Text = SingletonSesion.Instancia.Usuario.Username;
            }
            else
            {
                this.toolStripSesion.Text = "[Sesi�n no iniciada]";
            }

        }

        void ValidarPermisos()
        {
            if (SingletonSesion.Instancia.IsLogged())
            {
                this.usuariosToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorUsuario);
                this.perfilesToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorPerfiles);
                this.idiomasToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorIdioma);
                this.habitacionesToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorHabitacion);
                this.clientesToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorCliente);
                this.clientesHistoricoToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorBitacoraCliente);
                this.reservarToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorReservas);
                this.facturarToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorFacturas);
                this.reporte1ToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorReportes);
                this.reporte2ToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorReportes);
                this.reporte3ToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorReportes);
                this.usuarioToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorSalidaSistema);
                this.checkInToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorCheckin);
                this.checkoutToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorCheckout);
                this.facturarToolStripMenuItem1.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorFacturarEstadia);
                this.bitácoraToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorBitacora);
                this.gestiónDeRespaldosToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorRespaldos);
                this.manualDeAdministradorToolStripMenuItem.Enabled = SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorUsuario);
            }
            else
            {
                this.usuariosToolStripMenuItem.Enabled = false;
                this.perfilesToolStripMenuItem.Enabled = false;
                this.idiomasToolStripMenuItem.Enabled = false;
                this.habitacionesToolStripMenuItem.Enabled = false;
                this.clientesToolStripMenuItem.Enabled = false;
                this.clientesHistoricoToolStripMenuItem.Enabled = false;
                this.reservarToolStripMenuItem.Enabled = false;
                this.facturarToolStripMenuItem.Enabled = false;
                this.reporte1ToolStripMenuItem.Enabled = false;
                this.reporte2ToolStripMenuItem.Enabled = false;
                this.reporte3ToolStripMenuItem.Enabled = false;
                this.usuarioToolStripMenuItem.Enabled = false;
                this.checkInToolStripMenuItem.Enabled = false;
                this.checkoutToolStripMenuItem.Enabled = false;
                this.facturarToolStripMenuItem1.Enabled = false;
                this.bitácoraToolStripMenuItem.Enabled = false;
                this.gestiónDeRespaldosToolStripMenuItem.Enabled = false;
                this.manualDeAdministradorToolStripMenuItem.Enabled = false;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�Est� seguro de cerrar su sesi�n?", "Confirme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ReportarBitacoraLogout();
                _bllUsuarios.Logout();
                ValidarForm();
                ValidarPermisos();
            }
        }


        private void ReportarBitacoraLogout()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Usuarios;
            registroBitacora.Operacion = EnumOperacion.Logout;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarClave frm = frmCambiarClave.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.ValidarForm();
            frm.BringToFront();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frm = frmClientes.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHabitaciones frm = frmHabitaciones.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SingletonSesion.Instancia.IsInRole(TipoPermiso.GestorReservas))
            {
                frmReserva frm = frmReserva.VentanaUnica();
                frm.MdiParent = this;
                frm.Show();
                frm.BringToFront();
            }
            else
            {
                MessageBox.Show("No tiene permisos");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportarBitacoraLogout();
            _bllUsuarios.Logout();
            ValidarForm();
            ValidarPermisos();
            this.Close();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturarReserva frm = frmFacturarReserva.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionUsuario frm = frmGestionUsuario.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearPerfil frm = frmCrearPerfil.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void asignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignarPerfil frm = frmAsignarPerfil.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte1 frm = frmReporte1.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearIdioma frm = frmCrearIdioma.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacoraEventos frm = frmBitacoraEventos.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void gestiónDeRespaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRespaldos frm = frmRespaldos.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckin frm = frmCheckin.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckout frm = frmCheckout.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void facturarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFacturarHospedaje frm = frmFacturarHospedaje.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void clientesHistoricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteBitacora frm = frmClienteBitacora.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void reporte2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte2 frm = frmReporte2.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void reporte3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte3 frm = frmReporte3.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }
      
        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyudaManualUsuario frm = frmAyudaManualUsuario.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void manualDeAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyudaManualAdministrador frm = frmAyudaManualAdministrador.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }
    }
}