using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTipo_Habitacion
    {
        private DAL.mp_tipo_habitacion mapper = new DAL.mp_tipo_habitacion();

        public List<BE.Tipo_Habitacion> Listar()
        {
            return mapper.Listar();
        }

        public void Grabar(BE.Tipo_Habitacion tipo_Habitacion)
        {           
                mapper.Modificar(tipo_Habitacion);
        }
    }
}
