using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class GRUPO: PERMISO
    { 
        private List<PERMISO> permisos = new List<PERMISO>();

        public List<PERMISO> Permisos
        {
            get { return permisos; }            
        }         

        public override bool Validar(PERMISO permiso)
        {
            bool encontrado = false;
            if (permisos.Count>0)
            { 
                int indice = 0;
                do
                {
                    encontrado = permisos[indice].Validar(permiso);
                    indice++;
                } while (encontrado && indice < permisos.Count);
            }
            return encontrado;
        }
    }
}
