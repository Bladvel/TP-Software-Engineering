using CAPA_DATOS;
using CAPA_ENTIDADES;
using Microsoft.Win32;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO
{
    public class CN_Bitacora
    {
        private static CN_Bitacora instance;

        public static CN_Bitacora GetInstance()
        {
            if(instance == null)
            {
                instance = new CN_Bitacora();
            }

            return instance;
        }

        public void RegistrarBitacora(string descripcion, int idUsuario, int idCriticidad)
        {
            try
            {
                // Crear una instancia de la entidad Bitacora
                Bitacora bitacora = new Bitacora
                {
                    oCriticidad =  new Criticidad { IdCriticidad = idCriticidad },  // Criticidad recibida por parámetro
                    oUsuario = new Usuario { IdUsuario = idUsuario },              // Usuario recibido por parámetro
                    descripcion = descripcion                                      // Descripción recibida por parámetro
                };

                // Calcular el DVH de la bitácora
                bitacora.DVH = DigitosVerificador.CalcularDVH(bitacora);

                // Registrar el movimiento en la base de datos (capa de datos)
                CD_Bitacora.GetInstance().RegistrarMovimiento(bitacora);

                // Actualizar el DVV tras registrar el movimiento
                ActualizarDVV();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al registrar la bitácora", ex);
            }
        }

        // Método para actualizar el DVV de la bitácora
        private void ActualizarDVV()
        {
            try
            {
                var bitacoras = CD_Bitacora.GetInstance().GetAll();
                DigitosVerificador.ActualizardDVV(() => bitacoras, "Bitacora");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el DVV de la bitácora", ex);
            }
        }

    }
}
