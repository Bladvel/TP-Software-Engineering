using CAPA_DATOS;
using CAPA_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO
{
    public class CN_Negocio
    {
        private static CN_Negocio instance;

        public static CN_Negocio GetInstance()
        {
            if (instance == null)
            {
                instance = new CN_Negocio();
            }
            return instance;
        }

        public Negocio ObtenerDatos()
        {
            return CD_Negocio.GetInstance().ObtenerDatos();
        }

        public bool GuardarDatos(Negocio obj,out string mensaje)
        {
            mensaje = string.Empty;

            if(obj.Nombre == "")
            {
                mensaje += "Debes Registrar el Nombre";
            }
            if (obj.Cuit == "")
            {
                mensaje += "Debes Registrar el CUIT";
            }
            if (obj.Direccion == "")
            {
                mensaje += "Debes Registrar la Direccion";
            }

            if(mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return CD_Negocio.GetInstance().GuardarDatos(obj,out mensaje);
            }
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return CD_Negocio.GetInstance().ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return CD_Negocio.GetInstance().ActualizarLogo(imagen,out mensaje);
        }


    }
}
