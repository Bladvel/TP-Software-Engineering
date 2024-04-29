using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLHabitacion
    {
    private DAL.mp_habitacion mapper = new DAL.mp_habitacion();

        public List<BE.Habitacion> ListarTotal()
        {
            return mapper.ListarTotal();
        }

        public List<BE.Habitacion> ListarSimples()
        {
            return mapper.ListarSimples();
        }
        public List<BE.Habitacion> ListarDobles()
        {
            return mapper.ListarDobles();
        }


        public List<BE.Habitacion> ListarTriples()
        {
            return mapper.ListarTriples();
        }

        public List<BE.Habitacion> ListarCuadruples()
        {
            return mapper.ListarCuadruples();
        }

    }
}
