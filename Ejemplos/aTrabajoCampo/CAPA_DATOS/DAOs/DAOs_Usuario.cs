using CAPA_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS.DAOs
{
    internal class DAOs_Usuario : ICRUD<Usuario>
    {
        private static DAOs_Usuario instance;

        public static DAOs_Usuario GetInstance()
        {
            if (instance == null)
            {
                instance = new DAOs_Usuario();
            }

            return instance;
        }

        public int Add(Usuario alta, out string msj)
        {
            int IdUsuarioGenerado = 0;
            msj = string.Empty;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", conexion);

                   
                    cmd.Parameters.AddWithValue("nombre", alta.Nombre);
                    cmd.Parameters.AddWithValue("apellido", alta.Apellido);
                    cmd.Parameters.AddWithValue("DNI", alta.Dni);
                    cmd.Parameters.AddWithValue("email", alta.Email);
                    cmd.Parameters.AddWithValue("nombreUsuario", alta.NombreUsuario);
                    cmd.Parameters.AddWithValue("contrasena", alta.Clave);
                    cmd.Parameters.AddWithValue("estado", alta.Estado);
                    cmd.Parameters.AddWithValue("dvh", alta.DVH);
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    cmd.ExecuteNonQuery();

                    IdUsuarioGenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
                    msj = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                IdUsuarioGenerado = 0;
                msj = ex.Message;
            }



            return IdUsuarioGenerado;

        }

        /*public bool ActualizarDVV(string tablaNombre, int dvv)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    string query = @"
                            IF EXISTS (SELECT 1 FROM DVV WHERE TablaNombre = @nombreTabla)
                            BEGIN
                                UPDATE DVV
                                SET ValorDVV = @dvv, Fecha_Actualizacion = GETDATE()
                                WHERE TablaNombre = @nombreTabla;
                            END
                            ELSE
                            BEGIN
                                INSERT INTO DVV (TablaNombre, ValorDVV, Fecha_Actualizacion)
                                VALUES (@nombreTabla, @dvv, GETDATE());
                            END";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@dvv", dvv);
                    cmd.Parameters.AddWithValue("@nombreTabla", tablaNombre);

                    cmd.CommandType = CommandType.Text;


                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el DVV en la base de datos", ex);
            }
        }*/





        public bool Delete(Usuario delete, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", conexion);

                    cmd.Parameters.AddWithValue("cod_usuario", delete.IdUsuario);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    msj = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                msj = ex.Message;
            }



            return respuesta;
        }

        public List<Usuario> GetAll()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select cod_usuario,nombre,apellido,DNI,email,nombre_usuario,contrasena,estado,DVH from Usuario";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Usuario
                            {

                                IdUsuario = Convert.ToInt32(dr["cod_usuario"]),
                                Nombre = dr["nombre"].ToString(),
                                Apellido = dr["apellido"].ToString(),
                                Dni = Convert.ToInt32(dr["DNI"]),
                                Email = dr["email"].ToString(),
                                NombreUsuario = dr["nombre_usuario"].ToString(),
                                Clave = dr["contrasena"].ToString(),
                                Estado = Convert.ToBoolean(dr["estado"]),
                                DVH = Convert.ToInt32(dr["DVH"])


                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                    throw new Exception("Error al Obtener la lista de los Usuarios en la base de datos", ex);

                }
            }

            return lista;
        }

        public bool Update(Usuario update, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", conexion);

                    cmd.Parameters.AddWithValue("cod_usuario", update.IdUsuario);
                    cmd.Parameters.AddWithValue("nombre", update.Nombre);
                    cmd.Parameters.AddWithValue("apellido", update.Apellido);
                    cmd.Parameters.AddWithValue("DNI", update.Dni);
                    cmd.Parameters.AddWithValue("email", update.Email);
                    cmd.Parameters.AddWithValue("nombre_usuario", update.NombreUsuario);
                    cmd.Parameters.AddWithValue("estado", update.Estado);
                    cmd.Parameters.AddWithValue("DVH", update.DVH);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    msj = cmd.Parameters["Mensaje"].Value.ToString();
                }

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
