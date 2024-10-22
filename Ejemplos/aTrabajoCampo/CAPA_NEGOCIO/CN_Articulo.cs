using CAPA_DATOS;
using CAPA_ENTIDADES;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO
{
    public class CN_Articulo : ICRUD<Articulo>
    {
        private static CN_Articulo instance;

        public static CN_Articulo GetInstance()
        {
            if (instance == null)
            {
                instance = new CN_Articulo();
            }
            return instance;
        }

        public int Add(Articulo alta, out string msj)
        {
            msj = string.Empty;

            // Validaciones de Articulo
            if (string.IsNullOrWhiteSpace(alta.codigo))
            {
                msj += "Tienes que ingresar el codigo del Articulo\n";
            }
            if (string.IsNullOrWhiteSpace(alta.Nombre))
            {
                msj += "Tienes que ingresar el nombre del Articulo\n";
            }
            if (string.IsNullOrWhiteSpace(alta.Descripcion))
            {
                msj += "Tienes que ingresar la descripcion del Articulo \n";
            }
            var ArticulosExistentes = CD_Articulo.GetInstance().GetAll();
            if (ArticulosExistentes.Any(u => u.codigo == alta.codigo)) { msj += "Ya existe un Articulo con este codigo\n"; }

            if (msj != string.Empty)
            {
                return 0;
            }
            else
            {
               int resultado =  CD_Articulo.GetInstance().Add(alta, out msj);
               if(resultado != 0)
               {
                    // Registrar el movimiento en la bitácora
                    
                    CN_Bitacora.GetInstance().RegistrarBitacora("Alta de Articulo", 2);
               }

               return resultado;
            }
        }


        public bool Delete(Articulo delete, out string msj)
        {

            return CD_Articulo.GetInstance().Delete(delete, out msj);


        }

        public List<Articulo> GetAll()
        {

            return CD_Articulo.GetInstance().GetAll();
        }

        public bool Update(Articulo update, out string msj)
        {
            msj = string.Empty;

            if (string.IsNullOrWhiteSpace(update.codigo))
            {
                msj += "Tienes que ingresar el codigo del Articulo\n";
            }
            if (string.IsNullOrWhiteSpace(update.Nombre))
            {
                msj += "Tienes que ingresar el nombre del Articulo\n";
            }
            if (string.IsNullOrWhiteSpace(update.Descripcion))
            {
                msj += "Tienes que ingresar la descripcion del Articulo \n";
            }

            // Validar si existe otro Artículo con el mismo código (pero que no sea el mismo artículo que se está editando)
            var ArticulosExistentes = GetAll();
            if (ArticulosExistentes.Any(u => u.codigo == update.codigo && u.IdArticulo != update.IdArticulo))
            {
                msj += "Ya existe un Artículo con el mismo código\n";
            }


            if (msj != string.Empty) // Indica que hay errores
            {
                return false;
            }
            else
            {
                return CD_Articulo.GetInstance().Update(update, out msj);
            }
            
        }



    }
}
