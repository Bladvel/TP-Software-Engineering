using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Services
{
    public class Bitacora
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


        private IUser usuario;

        public IUser Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Username 
        { 
            get => usuario.Username; 
        }


        private TipoModulo modulo;
        public TipoModulo Modulo 
        { 
            get { return modulo; }
            set { modulo = value; }
        }

        private TipoOperacion operacion;

        public TipoOperacion Operacion
        {
            get { return operacion; }
            set { operacion = value; }
        }

        private int criticidad;

        public int Criticidad
        {
            get { return criticidad; }
            set { criticidad = value; }
        }

    }
}
