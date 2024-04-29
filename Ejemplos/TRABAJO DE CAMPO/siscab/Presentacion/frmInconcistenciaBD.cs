using BE;
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
    public partial class frmInconcistenciaBD : Form
    {
        public frmInconcistenciaBD()
        {
            InitializeComponent();
        }

        DVH dvh= new DVH();
        BLLDVH gestorDVH =  new BLLDVH();
        
        DVV dvv = new DVV();
        BLLDVV gestorDVV = new BLLDVV();

        BLLReserva gestorReserva = new BLLReserva();

        


        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_restore_backup_Click(object sender, EventArgs e)
        {
            frmRespaldos frm =new frmRespaldos();
            frm.Show();
            frm.BringToFront();
            frm.AjustarFormulario();
        }

        private void btn_recomponer_Click(object sender, EventArgs e)
        {
            List<Reserva> reservas = new List<Reserva>();
            reservas = gestorReserva.Listar();

            List<DVH> dVHs = new List<DVH>();
            dVHs = gestorDVH.Listar();

            if (gestorDVH.ValidarCantidadRegistros(reservas, dVHs))
            {
                gestorDVH.RecalcularDigitoVerificador(dvh, dVHs);
                gestorDVV.RecalcularDigitoVerificador();
                MessageBox.Show("Se han recalculado los dígitos verificadores", "Dígitos Verificadores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {               
                gestorDVH.BorrarRegistros();
                dVHs = gestorDVH.Listar();           
                gestorDVH.RecalcularDigitoVerificador(dvh, dVHs);                                
                gestorDVV.RecalcularDigitoVerificador();
                MessageBox.Show("Se han recalculado los dígitos verificadores","Dígitos Verificadores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
