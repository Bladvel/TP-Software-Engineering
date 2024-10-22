using CAPA_DATOS;
using CAPA_DATOS.DAOs;
using CAPA_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad
{
    public static class DigitosVerificador
    {

        public static int CalcularDVH(IDVH entidad)
        {
            // Algoritmo FNV-1a para hash
            const int fnvPrime = 16777619;
            const int offsetBasis = 216613621;

            int hash = offsetBasis;
            var datos = entidad.ObtenerDatosParaDVH();

            foreach (var campo in datos)
            {
                string valorCampo = campo.Value?.ToString() ?? string.Empty;
                foreach (char c in valorCampo)
                {
                    hash ^= c;
                    hash *= fnvPrime;
                }
            }
            // Aplicar un módulo para reducir el tamaño del número
            int dvh = Math.Abs(hash % 1000); // Limitar a 1,000,000

            // Log del valor calculado
            Console.WriteLine($"DVH Calculado para entidad {entidad.GetType().Name}: {dvh}");

            return dvh;
        }

        public static int CalcularDVV<T>(Func<IEnumerable<T>> obtenerDatos) where T : IDVH
        {
            var entidades = obtenerDatos();
            if (entidades == null || !entidades.Any())
            {
                throw new Exception("No se encontraron datos para calcular el DVV.");
            }

            // Verificar y sumar los DVH de todas las entidades
            int dvv = 0;
            foreach (var entidad in entidades)
            {
                int dvh = entidad.DVH;
                Console.WriteLine($"Entidad: {entidad.GetType().Name}, DVH: {dvh}");
                dvv += dvh;
            }

            // Log del valor final de DVV calculado
            Console.WriteLine($"DVV Calculado: {dvv}");

            return dvv;
        }


        public static void ActualizardDVV<T>(Func<IEnumerable<T>> obtenerDatos, string nombreTabla) where T : IDVH
        {
            try
            {
                int dvv = CalcularDVV(obtenerDatos);  // Calcula el DVV sumando los DVH de todas las entidades


                Console.WriteLine($"Actualizando DVV para la tabla {nombreTabla} con el valor {dvv}");
                // Actualiza el DVV en la base de datos
                DAOS_DVV.ActualizarDVV(new DVV { TablaNombre = nombreTabla, ValorDVV = dvv });
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el DVV", ex);
            }
        }


        /*public static int CalcularDVH(Usuario usuario)
        {
            // Algoritmo FNV-1a para hash
            const int fnvPrime = 16777619;
            const int offsetBasis = 216613621;

            int hash = offsetBasis;

            string clave = usuario.Clave ?? string.Empty;

            foreach (char c in $"{usuario.Nombre}{usuario.Apellido}{usuario.Dni}{usuario.Email}{usuario.NombreUsuario}{clave}")
            {
                hash ^= c;
                hash *= fnvPrime;
            }

            // Aplicar un módulo para reducir el tamaño del número
            return Math.Abs(hash % 1000); // Por ejemplo, limitar a 1,000,000
        }

        public static int CalcularDVV()
        {
            var usuarios = CD_Usuario.GetInstance().GetAll();

            // Asegúrate de que los usuarios se están recuperando correctamente
            if (usuarios == null || !usuarios.Any())
            {
                throw new Exception("No se encontraron usuarios para calcular el DVV.");
            }

            int dvv = usuarios.Sum(u => u.DVH);

            // Log del valor calculado
            Console.WriteLine($"DVV Calculado: {dvv}");

            return dvv;
        }

        public static void ActualizardDVV()
        {
            try
            {
                string msj = string.Empty;
                int dvv = CalcularDVV();  // Calcula el DVV sumando los DVH de todos los usuarios

                // Actualiza el DVV en la base de datos
                CD_Usuario.GetInstance().ActualizarDVV("Usuario", dvv);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el DVV", ex);
            }
        }*/



    }
}
