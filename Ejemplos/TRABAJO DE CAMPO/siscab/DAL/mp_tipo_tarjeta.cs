using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mp_tipo_tarjeta
    {
        private Acceso ac = new Acceso();

        public List<BE.Tipo_Tarjeta> Listar()
        {
            List<BE.Tipo_Tarjeta> tipotarjetas = new List<BE.Tipo_Tarjeta>();
            ac.Abrir();
            DataTable tabla = ac.Leer("select * from tipo_tarjeta");
            ac.Cerrar();
            foreach (DataRow registro in tabla.Rows)
            {
                BE.Tipo_Tarjeta tt = new BE.Tipo_Tarjeta();
                tt.Id = int.Parse(registro["id"].ToString());
                tt.Tipo = registro["tipo"].ToString();
                tipotarjetas.Add(tt);
            }
            return tipotarjetas;
        }


    }
}
