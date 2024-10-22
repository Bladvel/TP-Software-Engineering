using CAPA_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class CD_Categoria : ICRUD<Categoria>
    {
        private static CD_Categoria instance;

        public static CD_Categoria GetInstance()
        {
            if (instance == null)
            {
                instance = new CD_Categoria();
            }

            return instance;
        }
        public int Add(Categoria alta, out string msj)
        {
            int IdUsuarioGenerado = 0; // Inicializar con valor predeterminado
            msj = string.Empty; // Inicializar msj

            try
            {
                // Llamar al método Add del DAO y devolver el resultado
                int resultado = DAOs.DAOs_Categoria.GetInstance().Add(alta, out msj);
                if (string.IsNullOrEmpty(msj))
                {
                    msj = "Usuario agregado correctamente.";
                }
                return resultado;
            }
            catch (Exception ex)
            {
                IdUsuarioGenerado = 0;
                msj = ex.Message ?? "Ocurrió un error inesperado."; // Asegurarse de que siempre haya un valor en msj
            }

            return IdUsuarioGenerado; // Siempre devolver un valor, incluso en caso de error
        }


        public bool Delete(Categoria delete, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {

                return DAOs.DAOs_Categoria.GetInstance().Delete(delete, out msj);

            }
            catch (Exception ex)
            {
                respuesta = false;
                msj = ex.Message;
            }



            return respuesta;
        }

        public List<Categoria> GetAll()
        {
            try
            {
                return DAOs.DAOs_Categoria.GetInstance().GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(Categoria update, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {

                return DAOs.DAOs_Categoria.GetInstance().Update(update, out msj);

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
