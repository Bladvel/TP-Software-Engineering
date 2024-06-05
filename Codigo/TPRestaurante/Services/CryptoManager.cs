using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CryptoManager
    {
        public static string Hash(string input)
        {
            using (SHA256 hash = SHA256.Create())
            {
                var bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder sb = new StringBuilder();

                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }




        }

        public static bool Compare(string passwordIngresada, string passwordGuardada)
        {
            return Hash(passwordIngresada).Equals(passwordGuardada);
        }

        private const string clave = "0123456789ABCDEF"; // Clave de 16 caracteres para el cifrado AES

        // Método para cifrar un string
        public static string Encrypt(string texto)
        {
            byte[] bytesClave = Encoding.UTF8.GetBytes(clave);
            byte[] bytesTexto = Encoding.UTF8.GetBytes(texto);

            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = bytesClave;
                aesAlg.Mode = CipherMode.CBC;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(bytesTexto, 0, bytesTexto.Length);
                        csEncrypt.FlushFinalBlock();
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        // Método para descifrar un string
        public static string Decrypt(string textoCifrado)
        {
            byte[] bytesClave = Encoding.UTF8.GetBytes(clave);
            byte[] bytesTextoCifrado = Convert.FromBase64String(textoCifrado);

            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = bytesClave;
                aesAlg.Mode = CipherMode.CBC;

                int ivLength = BitConverter.ToInt32(bytesTextoCifrado, 0);
                aesAlg.IV = bytesTextoCifrado.Skip(sizeof(int)).Take(ivLength).ToArray();

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(bytesTextoCifrado, sizeof(int) + ivLength, bytesTextoCifrado.Length - (sizeof(int) + ivLength)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }



    }
}
