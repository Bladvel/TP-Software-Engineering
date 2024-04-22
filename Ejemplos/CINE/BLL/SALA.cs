using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SALA
    {
        public void AgregarFuncion(BE.SALA sala, BE.FUNCION funcion)
        {
            sala.Funciones.Add(funcion);
        }

        public void AgregarAsiento(BE.SALA sala,BE.ASIENTO asiento)
        {
            sala.Asientos.Add(asiento);
        }
    }
}
