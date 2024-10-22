using CAPA_DATOS.DAOs;
using CAPA_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class CD_Negocio
    {
        private static CD_Negocio instance;

        public static CD_Negocio GetInstance()
        {
            if (instance == null)
            {
                instance = new CD_Negocio();
            }
            return instance;
        }

        public Negocio ObtenerDatos()
        {
            Negocio objNeg = new Negocio();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "SELECT IdNegocio, Nombre, CUIT, Direccion FROM Negocio WHERE IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objNeg.IdNegocio = int.Parse(reader["IdNegocio"].ToString());
                            objNeg.Nombre = reader["Nombre"].ToString();
                            objNeg.Cuit = reader["CUIT"].ToString();
                            objNeg.Direccion = reader["Direccion"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                objNeg = null;
                Console.WriteLine("Error: " + ex.Message);
            }
            return objNeg;
        }

        public bool GuardarDatos(Negocio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Negocio SET Nombre = @Nombre, CUIT = @CUIT, Direccion = @Direccion WHERE IdNegocio = 1");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@CUIT", objeto.Cuit);
                    cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo guardar los datos";
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }
            return respuesta;
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] logoBytes = new byte[0];

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "SELECT Logo FROM Negocio WHERE IdNegocio = 1;";
                    SqlCommand cmd = new SqlCommand(query, conexion);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            logoBytes = (byte[])reader["Logo"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                obtenido = false;
                Console.WriteLine("Error: " + ex.Message);
            }
            return logoBytes;
        }

        public bool ActualizarLogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Negocio SET Logo = @Imagen WHERE IdNegocio = 1");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Imagen", image);

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el logo";
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }
            return respuesta;
        }
    }
}
