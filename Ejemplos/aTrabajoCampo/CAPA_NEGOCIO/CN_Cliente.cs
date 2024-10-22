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
    public class CN_Cliente : ICRUD<Cliente>
    {
        private static CN_Cliente instance;

        public static CN_Cliente GetInstance()
        {
            if(instance == null)
            {
                instance = new CN_Cliente();
            }

            return instance;
        }
        public int Add(Cliente alta, out string msj)
        {
            msj = string.Empty;

            // Validaciones de usuario
            if (string.IsNullOrWhiteSpace(alta.Nombre))
            {
                msj += "Tienes que ingresar el Nombre del Cliente\n";
            }
            if (string.IsNullOrWhiteSpace(alta.Apellido))
            {
                msj += "Tienes que ingresar el Apellido del Cliente\n";
            }
            if (string.IsNullOrEmpty(alta.Correo))
            {
                msj += "Debes Ingresar el email\n";
            }
            if (string.IsNullOrEmpty(alta.Dni))
            {
                msj += "Debes Ingresar el Dni del Cliente \n";
            }
            if (string.IsNullOrEmpty(alta.Celular))
            {
                msj += "Debes Ingresar el Telefono\n";
            }

            var clienteExistente = GetAll();
            if(clienteExistente.Any(c => c.Correo == alta.Correo)) { msj += "Ya existe un Cliente con este correo \n"; }
            if(clienteExistente.Any(c => c.Dni == alta.Dni )) { msj += "Ya existe un cliente con el mismo Dni \n"; }
            if(clienteExistente.Any(c => c.Celular == alta.Celular)) { msj += "Ya existe un cliente con el mismo numero de telefono \n"; }

            alta.Correo = Password.Encrypt(alta.Correo);
            alta.Dni = Password.Encrypt(alta.Dni);
            alta.Celular = Password.Encrypt(alta.Celular);

            if (msj != string.Empty) { return 0; }

            alta.DVH = DigitosVerificador.CalcularDVH(alta);

            int resultado = CD_Cliente.GetInstance().Add(alta, out msj);

            if(resultado > 0)
            {
                ActualizarDVV();
                msj = "Usuario Registrado con exito";
            }
            else
            {
                msj += msj;
            }

            return resultado;


        }

        public bool Delete(Cliente delete, out string msj)
        {
            bool resultado = CD_Cliente.GetInstance().Delete(delete, out msj);

            if (resultado)
            {
                ActualizarDVV();
            }

            return resultado;

            
        }

        public List<Cliente> GetAll()
        {
            try
            {
                return CD_Cliente.GetInstance().GetAll();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Obtener los datos de los clientes", ex);
            }
        }

        public bool Update(Cliente update, out string msj)
        {
            msj = string.Empty;

            // Validaciones de usuario
            if (string.IsNullOrWhiteSpace(update.Nombre))
            {
                msj += "Tienes que ingresar el Nombre del Cliente\n";
            }
            if (string.IsNullOrWhiteSpace(update.Apellido))
            {
                msj += "Tienes que ingresar el Apellido del Cliente\n";
            }
            if (string.IsNullOrEmpty(update.Correo))
            {
                msj += "Debes Ingresar el email\n";
            }
            if (string.IsNullOrEmpty(update.Dni))
            {
                msj += "Debes Ingresar el Dni del Cliente \n";
            }
            if (string.IsNullOrEmpty(update.Celular))
            { 
                msj += "Debes Ingresar el Telefono\n";
            }

            var clienteExistente = CD_Cliente.GetInstance().GetAll();
            if (clienteExistente.Any(c => c.Correo == update.Correo && c.IdCliente != update.IdCliente))
            {
                msj += "Ya existe un Cliente con este correo \n";
            }
            if (clienteExistente.Any(c => c.Dni == update.Dni && c.IdCliente != update.IdCliente))
            {
                msj += "Ya existe un cliente con el mismo Dni \n";
            }
            if (clienteExistente.Any(c => c.Celular == update.Celular && c.IdCliente != update.IdCliente))
            {
                msj += "Ya existe un cliente con el mismo numero de telefono \n"; 
            }

            if (msj != string.Empty) { return false; }

            update.Correo = Password.Encrypt(update.Correo);
            update.Dni = Password.Encrypt(update.Dni);
            update.Celular = Password.Encrypt(update.Celular);

            update.DVH = DigitosVerificador.CalcularDVH(update);

            bool resultado = CD_Cliente.GetInstance().Update(update, out msj);

            if (resultado)
            {
                ActualizarDVV();
                msj = "Usuario editado con exito";
            }

            return resultado;
        }

        private void ActualizarDVV()
        {
            try
            {
                var clientes = CD_Cliente.GetInstance().GetAll();

                // Log de los DVH actuales para asegurarte de que los valores sean correctos
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"Usuario: {cliente.Nombre}, DVH: {cliente.DVH}");
                }

                // Llama a la función que actualiza el DVV usando la entidad actual
                DigitosVerificador.ActualizardDVV(() => clientes, "Cliente");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el DVV", ex);
            }
        }


    }
}
