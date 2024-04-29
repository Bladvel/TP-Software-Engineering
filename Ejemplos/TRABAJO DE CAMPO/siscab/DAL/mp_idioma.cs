using Servicios;
using Servicios.Multiidioma;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class mp_idioma
    {
        private Acceso ac = new Acceso();

        private List<Idioma> idiomas = new List<Idioma>();
        public List<Idioma> Listar ()
        {
            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from idioma");
            ac.Cerrar();

            foreach  (DataRow registro in tabla.Rows)
            {
                Idioma idioma = new Idioma();
                idioma.Id = int.Parse(registro["id_idioma"].ToString());
                idioma.Nombre = registro["nombre"].ToString();
                idioma.Default = bool.Parse(registro["idioma_default"].ToString());

                idiomas.Add(idioma);

            }
            return idiomas;
        }



    }
}
