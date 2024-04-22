using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FUNCION
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime horario;

        public DateTime Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        private PELICULA pelicula;

        public PELICULA Pelicula
        {
            get { return pelicula; }
            set { pelicula = value; }
        }

        private List<SALA> salas;

        public List<SALA> Salas
        {
            get { return salas; }
            set { salas = value; }
        }


    }
}
