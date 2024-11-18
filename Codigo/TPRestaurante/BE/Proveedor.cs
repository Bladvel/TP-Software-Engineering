using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("PROVEEDOR")]
    public class Proveedor
    {
        [ColumnMapping("CUIT")]
        public int Cuit { get; set; }

        [ColumnMapping("NOMBRE")]
        public string Nombre { get; set; }

        [ColumnMapping("EMAIL")]
        public string Email { get; set; }

        [ColumnMapping("TELEFONO")]
        public int Telefono { get; set; }

        [ColumnMapping("DIRECCION")]
        public string Direccion { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
