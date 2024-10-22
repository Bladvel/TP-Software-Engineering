using CAPA_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class CD_Articulo : ICRUD<Articulo>
    {
        private static CD_Articulo instance;

        public static CD_Articulo GetInstance()
        {
            if (instance == null)
            {
                instance = new CD_Articulo();
            }

            return instance;
        }
        public int Add(Articulo alta, out string msj)
        {
            int idArticuloGenreado = 0;
            msj = string.Empty;
            try
            {
                int resultado = DAOs.DAOs_Artiuculo.GetInstance().Add(alta, out msj);
                if(string.IsNullOrEmpty(msj))
                {
                    msj = "Articulo agregado correctamente";
                }

                return resultado;
            }
            catch (Exception ex)
            {
                idArticuloGenreado = 0;
                msj = ex.Message ?? "Ocurrió un error inesperado.";
            }

            return idArticuloGenreado;
        }

        public bool Delete(Articulo delete, out string msj)
        {
            bool resultado = false;
            msj = string.Empty;

            try
            {

                return DAOs.DAOs_Artiuculo.GetInstance().Delete(delete, out msj);

            }
            catch (Exception ex)
            {
                resultado = false;
                msj = ex.Message;
            }

            return resultado;
        }

        public List<Articulo> GetAll()
        {
            try
            {
                return DAOs.DAOs_Artiuculo.GetInstance().GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public bool Update(Articulo update, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {

                return DAOs.DAOs_Artiuculo.GetInstance().Update(update, out msj);

            }
            catch (Exception ex)
            {
                respuesta = false;
                msj = ex.Message;
            }



            return respuesta;
        }
    }
}
