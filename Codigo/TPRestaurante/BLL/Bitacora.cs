using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Interfaces;

namespace BLL
{
    public class Bitacora
    {
        MP_Bitacora mpBitacora = new MP_Bitacora();

        public List<Services.Bitacora> Listar()
        {
            return mpBitacora.GetAll();
        }

        public List<Services.Bitacora> Filtrar(DateTime fi, DateTime ff, Guid? guidUser, string modulo, string operacion, int? criticidad )
        {
            return mpBitacora.Filter(fi, ff, guidUser, modulo, operacion, criticidad);
        }

        public int Insertar(Services.Bitacora bitacora)
        {
            return mpBitacora.Insert(bitacora);
        }



    }
}
