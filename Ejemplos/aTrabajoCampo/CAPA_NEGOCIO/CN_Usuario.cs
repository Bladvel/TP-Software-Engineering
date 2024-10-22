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
    public class CN_Usuario : ICRUD<Usuario>
    {
        private static CN_Usuario instance;
        
        public static CN_Usuario GetInstance()
        {
            if (instance == null)
            {
                instance = new CN_Usuario();
            }

            return instance;

        }

        public int Add(Usuario alta, out string msj)
        {
            msj = string.Empty;

            // Validaciones de usuario
            if (string.IsNullOrWhiteSpace(alta.Nombre)) 
            {
                msj += "Tienes que ingresar el Nombre del Usuario\n";
            }
            if (string.IsNullOrWhiteSpace(alta.Apellido))
            { 
                msj += "Tienes que ingresar el Apellido del Usuario\n";
            }
            else if (alta.Apellido.Length < 2)
            {
                msj += "El Apellido debe tener al menos 2 caracteres\n";
            }
            if (alta.Dni <= 0)
            { 
                msj += "El DNI debe ser un número positivo\n"; 
            }
            else if (alta.Dni.ToString().Length != 8) { msj += "El DNI debe tener 8 dígitos\n"; }

            var usuariosExistentes = GetAll();
            if (usuariosExistentes.Any(u => u.Dni == alta.Dni)) { msj += "Ya existe un usuario con el mismo DNI\n"; }

            alta.Nombre = Seguridad.Password.Encrypt(alta.Nombre);
            alta.Apellido = Seguridad.Password.Encrypt(alta.Apellido);

            string claveGenerada = Seguridad.Password.GenerarClaveAleatoria();

            alta.Clave = Seguridad.Password.HashClave(claveGenerada);

            if (msj != string.Empty) { return 0; } // Indica que hay errores

            alta.DVH = Seguridad.DigitosVerificador.CalcularDVH(alta);

            int resultado = CD_Usuario.GetInstance().Add(alta, out msj);

            if (resultado > 0)
            {
                EnviarCorreoBienvenida(alta.Email, Seguridad.Password.Decrypt(alta.Nombre), claveGenerada);

                ActualizarDVV();

                msj =  claveGenerada;

            }

            return resultado;
        }


        public bool Delete(Usuario delete, out string msj)
        {
            
            bool resultado = CD_Usuario.GetInstance().Delete(delete, out msj);

            if (resultado)
            {
                ActualizarDVV();
            }

            return resultado;

            
            
        }

        public List<Usuario> GetAll()
        {

            return CD_Usuario.GetInstance().GetAll();
        }

        public bool Update(Usuario update, out string msj)
        {
            msj = string.Empty;


            if (string.IsNullOrWhiteSpace(update.Nombre))
            {
                msj += "El Nombre es obligatorio\n";
            }

            if (string.IsNullOrWhiteSpace(update.Apellido))
            {
                msj += "El Apellido es obligatorio\n";
            }

            if (update.Dni <= 0)
            {
                msj += "El DNI debe ser un número positivo\n";
            }

            // Validar si existe otro usuario con el mismo DNI
            var usuariosExistentes = CD_Usuario.GetInstance().GetAll();
            if (usuariosExistentes.Any(u => u.Dni == update.Dni && u.IdUsuario != update.IdUsuario))
            {
                msj += "Ya existe un usuario con el mismo DNI\n";
            }

            if (msj != string.Empty) { return false; } // Indica que hay errores

            update.Nombre = Password.Encrypt(update.Nombre);
            update.Apellido = Password.Encrypt(update.Apellido);

           

            // Recalcular el DVH antes de actualizar en la base de datos
            update.DVH = DigitosVerificador.CalcularDVH(update);
            Console.WriteLine($"DVH Calculado: {update.DVH}");

            bool resultado = CD_Usuario.GetInstance().Update(update, out msj);


            if (resultado)
            {
                try
                {
                    ActualizarDVV();
                }
                catch (Exception ex)
                {
                    msj += $"Error al recalcular el DVV: {ex.Message}\n";
                    return false;
                }
            }

            return resultado;

        }



        private void EnviarCorreoBienvenida(string email, string nombreDesencriptado, string claveGenerada)
        {
            EnvioCorreo correoService = new Seguridad.EnvioCorreo();
            string asunto = "Bienvenido a nuestra plataforma";
            string cuerpo = $"Hola {nombreDesencriptado},<br/><br/>Tu cuenta ha sido creada exitosamente.<br/>Tu contraseña es: {claveGenerada}<br/>Por favor, cámbiala en tu primer inicio de sesión.";
            correoService.EnviarCorreo(email, asunto, cuerpo);
        }

        private void ActualizarDVV()
        {
            try
            {
                var usuarios = CD_Usuario.GetInstance().GetAll();

                // Log de los DVH actuales para asegurarte de que los valores sean correctos
                foreach (var usuario in usuarios)
                {
                    Console.WriteLine($"Usuario: {usuario.Nombre}, DVH: {usuario.DVH}");
                }

                // Llama a la función que actualiza el DVV usando los usuarios actuales
                DigitosVerificador.ActualizardDVV(() => usuarios, "Usuario");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el DVV", ex);
            }
        }

    }
}
