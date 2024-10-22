using CAPA_DATOS.DAOs;
using CAPA_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class CD_Bitacora
    {
        private static CD_Bitacora instance;

        public static CD_Bitacora GetInstance()
        {
            if(instance == null)
            {
                instance = new CD_Bitacora();
            }
            return instance;
        }

        public void RegistrarMovimiento(Bitacora bitacora)
        {
            try
            {
                DAOs_Bitacora.GetInstance().RegistrarMovimiento(bitacora);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al registrar movimiento en CD_Bitacora: " + ex.Message);
            }
        }

        public List<Bitacora> GetAll()
        {
            try
            {
                return DAOs_Bitacora.GetInstance().GetAll();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Obtener todos los registros de la Bitacora: " + ex.Message);
            }
        }
    }
}
