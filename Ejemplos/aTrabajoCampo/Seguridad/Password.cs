using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad
{
    public class Password
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("1234567890123456"); // Debe ser de 16 bytes para AES
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("1234567890123456"); // Debe ser de 16 bytes para AES


        public static string GenerarClaveAleatoria()
        {
            int longitud = 6;
            Random random = new Random();
            string numeros = "0123456789";
            return new string(Enumerable.Repeat(numeros, longitud)
                                        .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // Método para encriptar de forma irreversible (hash SHA-256, bcrypt, etc.)
        public static string HashClave(string clave)
        {
            // Puedes usar SHA256 o bcrypt. Aquí va un ejemplo con SHA256:
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(clave));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static string Encrypt(string plainText)
        {
            try
            {
                if (string.IsNullOrEmpty(plainText))
                    throw new ArgumentNullException(nameof(plainText), "El texto a cifrar no puede ser nulo o vacío.");

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Key;
                    aes.IV = IV;
                    aes.Padding = PaddingMode.PKCS7; // Relleno PKCS7

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(cs))
                            {
                                sw.Write(plainText);
                            }
                        }

                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la encriptación: {ex.Message}");
                throw;
            }
        }

        public static string Decrypt(string cipherText)
        {
            try
            {
                if (string.IsNullOrEmpty(cipherText))
                    throw new ArgumentNullException(nameof(cipherText), "El texto cifrado no puede ser nulo o vacío.");

                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Key;
                    aes.IV = IV;
                    aes.Padding = PaddingMode.PKCS7; // Relleno PKCS7

                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    using (MemoryStream ms = new MemoryStream(cipherBytes))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader sr = new StreamReader(cs))
                            {
                                return sr.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"Error de formato: {fe.Message}");
                throw;
            }
            catch (CryptographicException ce)
            {
                Console.WriteLine($"Error criptográfico: {ce.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la desencriptación: {ex.Message}");
                throw;
            }
        }




    }
}
