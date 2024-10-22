using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CAPA_ENTIDADES;
using System.Collections;
using System.Net;

namespace CAPA_DATOS
{
    public class CD_Usuario : ICRUD<Usuario>
    {
        private static CD_Usuario instance;


        public static CD_Usuario GetInstance()
        {
            if (instance == null)
            {
                instance = new CD_Usuario();
            }

            return instance;
        }
        public int Add(Usuario alta, out string msj)
        {
            int IdUsuarioGenerado = 0; // Inicializar con valor predeterminado
            msj = string.Empty; // Inicializar msj

            try
            {
                // Llamar al método Add del DAO y devolver el resultado
                int resultado = DAOs.DAOs_Usuario.GetInstance().Add(alta, out msj);
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


        /*public void ActualizarDVV(string tablaNombre, int dvv)
        {
            try
            {
               DAOs.DAOs_Usuario.GetInstance().ActualizarDVV(tablaNombre, dvv);
  
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el DVV en la base de datos", ex);
            }
        }*/





        public bool Delete(Usuario delete, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {

                return DAOs.DAOs_Usuario.GetInstance().Delete(delete, out msj);

            }
            catch (Exception ex)
            {
                respuesta = false;
                msj = ex.Message;
            }



            return respuesta;
        }

        public List<Usuario> GetAll()
        {
            try
            {
                return DAOs.DAOs_Usuario.GetInstance().GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(Usuario update, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {

                return DAOs.DAOs_Usuario.GetInstance().Update(update, out msj);

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
