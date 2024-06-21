using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class MetodoDePago
    {
        public int id { get; set; }
        public PaymentMethodType tipo { get; set; }
    }
}
