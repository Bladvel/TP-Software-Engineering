using BE;
using Servicios.Multiidioma;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mp_traduccion
    {

        private Acceso ac = new Acceso();

        public mp_idioma mapperIdioma = new mp_idioma();
        public mp_etiqueta mapperEtiqueta = new mp_etiqueta();
        

        //CREO QUE PRIMERO TENGO QUE CREAR EL MP_ETIQUETA

        public List<Traduccion> Listar()
        {
            List<Idioma> idiomas = mapperIdioma.Listar();
            List<Etiqueta> etiquetas = mapperEtiqueta.Listar();
            
            List<Traduccion> traducciones = new List<Traduccion>();

            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from traduccion");
            ac.Cerrar();

         
            foreach (DataRow registro in tabla.Rows)
            {
                Traduccion traduccion = new Traduccion();
                traduccion.idioma = (from Idioma i in idiomas
                                   where i.Id == int.Parse(registro["id_idioma"].ToString())
                                   select i).First();
                traduccion.Texto = registro["traduccion"].ToString();

                traduccion.Etiqueta = (from Etiqueta e in etiquetas
                                       where e.Id == int.Parse(registro["id_etiqueta"].ToString())
                                       select e).First();

                traducciones.Add(traduccion);
            }
            return traducciones;
        }


    }
}
