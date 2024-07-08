using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    public class MetodoDePago: IMetodoDePago
    {
        public int id { get; set; }
        public PaymentMethodType tipo { get; set; }
    }
}
