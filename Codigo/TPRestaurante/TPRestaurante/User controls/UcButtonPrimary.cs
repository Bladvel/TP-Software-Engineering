using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPRestaurante
{
    public partial class UcButtonPrimary : Button
    {
        Color primaryBlue = ColorTranslator.FromHtml("#0D6EFD");

        public UcButtonPrimary()
        {
            
            this.BackColor = primaryBlue;
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            Size = new Size(132, 39);
            InitializeComponent();
        }

        public UcButtonPrimary(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }



    }
}
