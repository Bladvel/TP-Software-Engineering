﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPRestaurante
{
    public partial class frmEvaluarSolicitudDeCompra : Form
    {
        public frmEvaluarSolicitudDeCompra()
        {
            InitializeComponent();
        }

        private void ucButtonPrimary1_Click(object sender, EventArgs e)
        {
            //Elimina de la solicitud las que no tengan el check seleccionado
            //Genera la orden de compra con los insumos seleccionados
            //Actualiza el status de la solicitud a aprobada
        }
    }
}
