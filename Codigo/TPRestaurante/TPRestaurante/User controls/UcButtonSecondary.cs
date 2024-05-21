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
    public partial class UcButtonSecondary : Button
    {
        private Color SecondaryGray = ColorTranslator.FromHtml("#6C757D");
        public UcButtonSecondary()
        {
            this.BackColor = SecondaryGray;

            this.ForeColor = Color.White;

            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            Size = new Size(132, 39);
            InitializeComponent();
            InitializeComponent();
        }

        public UcButtonSecondary(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

    }
}
