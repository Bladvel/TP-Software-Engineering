using CompositePersistente.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePersistente
{
   public class BllVentas
    {
        public void Facturar()
        {
            if (!SimuladorSesion.GetInstance.IsInRole(TipoPermiso.PuedeHacerE)) throw new Exception("No tiene permisos");
        }
    }
}
