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
    internal class DAOs_Categoria : ICRUD<Categoria>
    {
        private static DAOs_Categoria instance;

        public static DAOs_Categoria GetInstance()
        {
            if (instance == null)
            {
                instance = new DAOs_Categoria();
            }

            return instance;
        }

        public int Add(Categoria alta, out string msj)
        {
            int IdCategoriaGenerado = 0;
            msj = string.Empty;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCATEGORIA", conexion);


                    cmd.Parameters.AddWithValue("Descripcion", alta.Descripcion);
                    cmd.Parameters.AddWithValue("estado", alta.estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    cmd.ExecuteNonQuery();

                    IdCategoriaGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    msj = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                IdCategoriaGenerado = 0;
                msj = ex.Message;
            }



            return IdCategoriaGenerado;

        }

        public bool Delete(Categoria delete, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARCATEGORIA", conexion);

                    cmd.Parameters.AddWithValue("IdCategoria", delete.IdCategoria);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
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

        public List<Categoria> GetAll()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select IdCategoria,Descripcion,estado from Categoria";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Categoria
                            {

                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Descripcion = dr["Descripcion"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Categoria>();
                    throw new Exception("Error al Obtener la lista de los Categorias en la base de datos", ex);

                }
            }

            return lista;
        }

        public bool Update(Categoria update, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARCATEGORIA", conexion);

                    cmd.Parameters.AddWithValue("IdCategoria", update.IdCategoria);
                    cmd.Parameters.AddWithValue("Descripcion", update.Descripcion);
                    cmd.Parameters.AddWithValue("estado", update.estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
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
