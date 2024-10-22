using CAPA_DATOS;
using CAPA_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO
{
    public class CN_Categoria : ICRUD<Categoria>
    {
        private static CN_Categoria instance;

        public static CN_Categoria GetInstance()
        {
            if (instance == null)
            {
                instance = new CN_Categoria();
            }

            return instance;

        }

        public int Add(Categoria alta, out string msj)
        {
            msj = string.Empty;

            // Validaciones de Categoria
            if (string.IsNullOrWhiteSpace(alta.Descripcion))
            {
                msj += "ES necesario la descripcion de la categoria\n";
            }

            var CategoriasExistentes = GetAll();
            if (CategoriasExistentes.Any(u => u.Descripcion == alta.Descripcion)) { msj += "Ya existe una Categoria\n"; }

            if (msj != string.Empty)
            {
                return 0;
            }
            else
            {
                return CD_Categoria.GetInstance().Add(alta, out msj);
            }

           
        }


        public bool Delete(Categoria delete, out string msj)
        {
            return CD_Categoria.GetInstance().Delete(delete, out msj);
        }

        public List<Categoria> GetAll()
        {

            return CD_Categoria.GetInstance().GetAll();
        }

        public bool Update(Categoria update, out string msj)
        {
            msj = string.Empty;


            if (string.IsNullOrWhiteSpace(update.Descripcion))
            {
                msj += "Debes ingresar la descripcion de la categoria\n";
            }

            if (msj != string.Empty)
            {
                return false;
            }
            else
            {
                return CD_Categoria.GetInstance().Update(update, out msj);
            }


        }
    }
}
