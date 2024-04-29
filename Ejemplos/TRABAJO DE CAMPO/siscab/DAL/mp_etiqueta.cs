using Servicios.Multiidioma;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mp_etiqueta
    {

        private Acceso ac = new Acceso();
        private List<Etiqueta> etiquetas = new List<Etiqueta>();

        public List<Etiqueta> Listar()
        {
            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from etiqueta");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Etiqueta etiqueta = new Etiqueta();

                etiqueta.Id = int.Parse(registro["id_etiqueta"].ToString());
                etiqueta.Nombre = registro["id_etiqueta"].ToString();

                etiquetas.Add(etiqueta);

            }
            return etiquetas;
        }



    }
}
