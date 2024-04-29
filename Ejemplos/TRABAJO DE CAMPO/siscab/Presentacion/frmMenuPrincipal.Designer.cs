namespace Presentacion
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            perfilesToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem = new ToolStripMenuItem();
            asignarToolStripMenuItem = new ToolStripMenuItem();
            idiomasToolStripMenuItem = new ToolStripMenuItem();
            bitácoraToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeRespaldosToolStripMenuItem = new ToolStripMenuItem();
            maestrosToolStripMenuItem = new ToolStripMenuItem();
            habitacionesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            clientesHistoricoToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            cambiarClaveToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            cambiarIdiomaToolStripMenuItem = new ToolStripMenuItem();
            reservasToolStripMenuItem = new ToolStripMenuItem();
            reservarToolStripMenuItem = new ToolStripMenuItem();
            facturarToolStripMenuItem = new ToolStripMenuItem();
            gestionHospedajeToolStripMenuItem = new ToolStripMenuItem();
            checkInToolStripMenuItem = new ToolStripMenuItem();
            checkoutToolStripMenuItem = new ToolStripMenuItem();
            facturarToolStripMenuItem1 = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            reporte1ToolStripMenuItem = new ToolStripMenuItem();
            reporte2ToolStripMenuItem = new ToolStripMenuItem();
            reporte3ToolStripMenuItem = new ToolStripMenuItem();
            ayudaEnLíneaToolStripMenuItem = new ToolStripMenuItem();
            manualDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            manualDeAdministradorToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStripSesion = new ToolStripStatusLabel();
            crearModificarToolStripMenuItem1 = new ToolStripDropDownMenu();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, maestrosToolStripMenuItem, usuarioToolStripMenuItem, reservasToolStripMenuItem, gestionHospedajeToolStripMenuItem, reportesToolStripMenuItem, ayudaEnLíneaToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, perfilesToolStripMenuItem, idiomasToolStripMenuItem, bitácoraToolStripMenuItem, gestiónDeRespaldosToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(95, 20);
            adminToolStripMenuItem.Text = "Administrador";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(186, 22);
            usuariosToolStripMenuItem.Text = "Gestión de Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // perfilesToolStripMenuItem
            // 
            perfilesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem, asignarToolStripMenuItem });
            perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            perfilesToolStripMenuItem.Size = new Size(186, 22);
            perfilesToolStripMenuItem.Text = "Gestión de Perfiles";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(114, 22);
            crearToolStripMenuItem.Text = "Crear";
            crearToolStripMenuItem.Click += crearToolStripMenuItem_Click;
            // 
            // asignarToolStripMenuItem
            // 
            asignarToolStripMenuItem.Name = "asignarToolStripMenuItem";
            asignarToolStripMenuItem.Size = new Size(114, 22);
            asignarToolStripMenuItem.Text = "Asignar";
            asignarToolStripMenuItem.Click += asignarToolStripMenuItem_Click;
            // 
            // idiomasToolStripMenuItem
            // 
            idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            idiomasToolStripMenuItem.Size = new Size(186, 22);
            idiomasToolStripMenuItem.Text = "Gestión de Idiomas";
            idiomasToolStripMenuItem.Click += idiomasToolStripMenuItem_Click;
            // 
            // bitácoraToolStripMenuItem
            // 
            bitácoraToolStripMenuItem.Name = "bitácoraToolStripMenuItem";
            bitácoraToolStripMenuItem.Size = new Size(186, 22);
            bitácoraToolStripMenuItem.Text = "Bitácora";
            bitácoraToolStripMenuItem.Click += bitácoraToolStripMenuItem_Click;
            // 
            // gestiónDeRespaldosToolStripMenuItem
            // 
            gestiónDeRespaldosToolStripMenuItem.Name = "gestiónDeRespaldosToolStripMenuItem";
            gestiónDeRespaldosToolStripMenuItem.Size = new Size(186, 22);
            gestiónDeRespaldosToolStripMenuItem.Text = "Gestión de Respaldos";
            gestiónDeRespaldosToolStripMenuItem.Click += gestiónDeRespaldosToolStripMenuItem_Click;
            // 
            // maestrosToolStripMenuItem
            // 
            maestrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { habitacionesToolStripMenuItem, clientesToolStripMenuItem, clientesHistoricoToolStripMenuItem });
            maestrosToolStripMenuItem.Name = "maestrosToolStripMenuItem";
            maestrosToolStripMenuItem.Size = new Size(67, 20);
            maestrosToolStripMenuItem.Text = "Maestros";
            // 
            // habitacionesToolStripMenuItem
            // 
            habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            habitacionesToolStripMenuItem.Size = new Size(175, 22);
            habitacionesToolStripMenuItem.Text = "Habitaciones";
            habitacionesToolStripMenuItem.Click += habitacionesToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(175, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // clientesHistoricoToolStripMenuItem
            // 
            clientesHistoricoToolStripMenuItem.Name = "clientesHistoricoToolStripMenuItem";
            clientesHistoricoToolStripMenuItem.Size = new Size(175, 22);
            clientesHistoricoToolStripMenuItem.Text = "Clientes - Histórico";
            clientesHistoricoToolStripMenuItem.Click += clientesHistoricoToolStripMenuItem_Click;
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cambiarClaveToolStripMenuItem, logoutToolStripMenuItem, cambiarIdiomaToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(59, 20);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cambiarClaveToolStripMenuItem
            // 
            cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            cambiarClaveToolStripMenuItem.Size = new Size(159, 22);
            cambiarClaveToolStripMenuItem.Text = "Cambiar Clave";
            cambiarClaveToolStripMenuItem.Click += cambiarClaveToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(159, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // cambiarIdiomaToolStripMenuItem
            // 
            cambiarIdiomaToolStripMenuItem.Name = "cambiarIdiomaToolStripMenuItem";
            cambiarIdiomaToolStripMenuItem.Size = new Size(159, 22);
            cambiarIdiomaToolStripMenuItem.Text = "Cambiar Idioma";
            // 
            // reservasToolStripMenuItem
            // 
            reservasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reservarToolStripMenuItem, facturarToolStripMenuItem });
            reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            reservasToolStripMenuItem.Size = new Size(64, 20);
            reservasToolStripMenuItem.Text = "Reservas";
            // 
            // reservarToolStripMenuItem
            // 
            reservarToolStripMenuItem.Name = "reservarToolStripMenuItem";
            reservarToolStripMenuItem.Size = new Size(118, 22);
            reservarToolStripMenuItem.Text = "Reservar";
            reservarToolStripMenuItem.Click += reservarToolStripMenuItem_Click;
            // 
            // facturarToolStripMenuItem
            // 
            facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            facturarToolStripMenuItem.Size = new Size(118, 22);
            facturarToolStripMenuItem.Text = "Facturar";
            facturarToolStripMenuItem.Click += facturarToolStripMenuItem_Click;
            // 
            // gestionHospedajeToolStripMenuItem
            // 
            gestionHospedajeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkInToolStripMenuItem, checkoutToolStripMenuItem, facturarToolStripMenuItem1 });
            gestionHospedajeToolStripMenuItem.Name = "gestionHospedajeToolStripMenuItem";
            gestionHospedajeToolStripMenuItem.Size = new Size(134, 20);
            gestionHospedajeToolStripMenuItem.Text = "Gestión de Hospedaje";
            // 
            // checkInToolStripMenuItem
            // 
            checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            checkInToolStripMenuItem.Size = new Size(130, 22);
            checkInToolStripMenuItem.Text = "Check-In";
            checkInToolStripMenuItem.Click += checkInToolStripMenuItem_Click;
            // 
            // checkoutToolStripMenuItem
            // 
            checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            checkoutToolStripMenuItem.Size = new Size(130, 22);
            checkoutToolStripMenuItem.Text = "Check-out";
            checkoutToolStripMenuItem.Click += checkoutToolStripMenuItem_Click;
            // 
            // facturarToolStripMenuItem1
            // 
            facturarToolStripMenuItem1.Name = "facturarToolStripMenuItem1";
            facturarToolStripMenuItem1.Size = new Size(130, 22);
            facturarToolStripMenuItem1.Text = "Facturar";
            facturarToolStripMenuItem1.Click += facturarToolStripMenuItem1_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporte1ToolStripMenuItem, reporte2ToolStripMenuItem, reporte3ToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporte1ToolStripMenuItem
            // 
            reporte1ToolStripMenuItem.Name = "reporte1ToolStripMenuItem";
            reporte1ToolStripMenuItem.Size = new Size(124, 22);
            reporte1ToolStripMenuItem.Text = "Reporte 1";
            reporte1ToolStripMenuItem.Click += reporte1ToolStripMenuItem_Click;
            // 
            // reporte2ToolStripMenuItem
            // 
            reporte2ToolStripMenuItem.Name = "reporte2ToolStripMenuItem";
            reporte2ToolStripMenuItem.Size = new Size(124, 22);
            reporte2ToolStripMenuItem.Text = "Reporte 2";
            reporte2ToolStripMenuItem.Click += reporte2ToolStripMenuItem_Click;
            // 
            // reporte3ToolStripMenuItem
            // 
            reporte3ToolStripMenuItem.Name = "reporte3ToolStripMenuItem";
            reporte3ToolStripMenuItem.Size = new Size(124, 22);
            reporte3ToolStripMenuItem.Text = "Reporte 3";
            reporte3ToolStripMenuItem.Click += reporte3ToolStripMenuItem_Click;
            // 
            // ayudaEnLíneaToolStripMenuItem
            // 
            ayudaEnLíneaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manualDeUsuarioToolStripMenuItem, manualDeAdministradorToolStripMenuItem });
            ayudaEnLíneaToolStripMenuItem.Name = "ayudaEnLíneaToolStripMenuItem";
            ayudaEnLíneaToolStripMenuItem.Size = new Size(100, 20);
            ayudaEnLíneaToolStripMenuItem.Text = "Ayuda en Línea";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            manualDeUsuarioToolStripMenuItem.Size = new Size(209, 22);
            manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            manualDeUsuarioToolStripMenuItem.Click += manualDeUsuarioToolStripMenuItem_Click;
            // 
            // manualDeAdministradorToolStripMenuItem
            // 
            manualDeAdministradorToolStripMenuItem.Name = "manualDeAdministradorToolStripMenuItem";
            manualDeAdministradorToolStripMenuItem.Size = new Size(209, 22);
            manualDeAdministradorToolStripMenuItem.Text = "Manual de Administrador";
            manualDeAdministradorToolStripMenuItem.Click += manualDeAdministradorToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, toolStripSesion });
            statusStrip1.Location = new Point(0, 392);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(47, 17);
            toolStripStatusLabel.Text = "Usuario";
            // 
            // toolStripSesion
            // 
            toolStripSesion.Name = "toolStripSesion";
            toolStripSesion.Size = new Size(110, 17);
            toolStripSesion.Text = "[Sesión no iniciada]";
            // 
            // crearModificarToolStripMenuItem1
            // 
            crearModificarToolStripMenuItem1.AutoClose = false;
            crearModificarToolStripMenuItem1.Name = "crearModificarToolStripMenuItem1";
            crearModificarToolStripMenuItem1.Size = new Size(61, 4);
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 414);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión para Cabañas - SISCAB";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem maestrosToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private ToolStripMenuItem gestionHospedajeToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripStatusLabel toolStripSesion;
        private ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem reservarToolStripMenuItem;
        private ToolStripMenuItem facturarToolStripMenuItem;
        private ToolStripMenuItem habitacionesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem perfilesToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem asignarToolStripMenuItem;
        private ToolStripMenuItem idiomasToolStripMenuItem;
        private ToolStripMenuItem cambiarIdiomaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripDropDownMenu crearModificarToolStripMenuItem1;
        private ToolStripMenuItem reporte1ToolStripMenuItem;
        private ToolStripMenuItem bitácoraToolStripMenuItem;
        private ToolStripMenuItem gestiónDeRespaldosToolStripMenuItem;
        private ToolStripMenuItem checkInToolStripMenuItem;
        private ToolStripMenuItem checkoutToolStripMenuItem;
        private ToolStripMenuItem facturarToolStripMenuItem1;
        private ToolStripMenuItem clientesHistoricoToolStripMenuItem;
        private ToolStripMenuItem reporte2ToolStripMenuItem;
        private ToolStripMenuItem reporte3ToolStripMenuItem;
        private ToolStripMenuItem ayudaEnLíneaToolStripMenuItem;
        private ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem manualDeAdministradorToolStripMenuItem;
    }
}