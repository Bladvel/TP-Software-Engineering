using CAPA_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class CD_Cliente : ICRUD<Cliente>
    {
        private static CD_Cliente instance;

        public static CD_Cliente GetInstance()
        {
            if (instance == null)
            {
                instance = new CD_Cliente();
            }

            return instance;
        }
        public int Add(Cliente alta, out string msj)
        {
            int IdGenerado = 0;
            msj = string.Empty;

            try
            {
                IdGenerado = DAOs.DA0s_Cliente.GetInstance().Add(alta, out msj);
                if(string.IsNullOrEmpty(msj))
                {
                    msj = "Cliente Agregado con exito";
                }
            }
            catch (Exception ex)
            {

                IdGenerado = 0;
                msj = ex.Message;
            }

            return IdGenerado;
        }

        public bool Delete(Cliente delete, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {
                respuesta = DAOs.DA0s_Cliente.GetInstance().Delete(delete, out msj);

                if (respuesta)
                {
                    msj = "Cliente eliminado con exito";
                }
            }
            catch (Exception ex)
            {

                respuesta = false;
                msj = ex.Message;
            }

            return respuesta;
        }

        public List<Cliente> GetAll()
        {
            try
            {
                return DAOs.DA0s_Cliente.GetInstance().GetAll()
;            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Cliente update, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {
                respuesta = DAOs.DA0s_Cliente.GetInstance().Update(update, out string mesj);
                msj = mesj;
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
