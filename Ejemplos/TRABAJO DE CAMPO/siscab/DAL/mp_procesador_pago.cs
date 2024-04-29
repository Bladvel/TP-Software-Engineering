using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mp_procesador_pago
    {
        private Acceso ac = new Acceso();

        public List<BE.Procesador_Pago> Listar()
        {
            List<BE.Procesador_Pago> procesadoresPago = new List<BE.Procesador_Pago>();
            ac.Abrir();
            DataTable tabla = ac.Leer("select * from procesador_pago");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Procesador_Pago pp = new BE.Procesador_Pago();
                pp.Id = int.Parse(registro["id"].ToString());
                pp.Descripcion = registro["descripcion"].ToString();
                procesadoresPago.Add(pp);
            }
            return procesadoresPago;
        }
    }
}
