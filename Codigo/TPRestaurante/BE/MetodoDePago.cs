using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("METODO_DE_PAGO")]
    public class MetodoDePago: IMetodoDePago
    {
        [ColumnMapping("ID")]
        public virtual int id { get; set; }

        [ColumnMapping("TIPO")]
        public virtual PaymentMethodType tipo { get; set; }
    }
}
