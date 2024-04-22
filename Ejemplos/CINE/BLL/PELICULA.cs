using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PELICULA
    {

        MP_PELICULA mp;

        public PELICULA()
        {
            mp = new MP_PELICULA();
        }


        public List<BE.PELICULA> ObtenerPeliculas()
        {
            List<BE.PELICULA> peliculas = mp.Listar();
            return peliculas;
        }
    }
}
