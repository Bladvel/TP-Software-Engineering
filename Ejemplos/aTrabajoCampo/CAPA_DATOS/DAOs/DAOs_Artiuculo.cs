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
    internal class DAOs_Artiuculo : ICRUD<Articulo>
    {
        private static DAOs_Artiuculo instance;

        public static DAOs_Artiuculo GetInstance()
        {
            if (instance == null)
            {
                instance = new DAOs_Artiuculo();
            }

            return instance;
        }

        public int Add(Articulo alta, out string msj)
        {
            int IdGenerado = 0;
            msj = string.Empty;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARARTICULO", conexion);


                    cmd.Parameters.AddWithValue("codigo", alta.codigo);
                    cmd.Parameters.AddWithValue("nombre", alta.Nombre);
                    cmd.Parameters.AddWithValue("descripcion", alta.Descripcion);
                    cmd.Parameters.AddWithValue("precio", alta.Precio);
                    cmd.Parameters.AddWithValue("stock", alta.Stock);
                    cmd.Parameters.AddWithValue("estado", alta.estado);
                    cmd.Parameters.AddWithValue("IdCategoria", alta.ocategoria.IdCategoria);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    cmd.ExecuteNonQuery();

                    IdGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    msj = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                IdGenerado = 0;
                msj = ex.Message;
            }



            return IdGenerado;

        }

        public bool Delete(Articulo delete, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARARTICULO", conexion);

                    cmd.Parameters.AddWithValue("Id_Articulo", delete.IdArticulo);
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

        public List<Articulo> GetAll()
        {
            List<Articulo> lista = new List<Articulo>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select Id_Articulo,codigo,nombre,precio,a.descripcion,stock,a.estado,c.IdCategoria,c.Descripcion" +
                        "[DescripcionCategoria] from Articulo a");
                    query.AppendLine("inner join Categoria c on c.IdCategoria = a.IdCategoria");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Articulo
                            {

                                IdArticulo = Convert.ToInt32(dr["Id_Articulo"]),
                                codigo = dr["codigo"].ToString(),
                                Nombre = dr["nombre"].ToString(),
                                Precio = Convert.ToDecimal(dr["precio"]),
                                Descripcion = dr["descripcion"].ToString(),
                                Stock = Convert.ToInt32(dr["stock"]),
                                estado = Convert.ToBoolean(dr["estado"]),
                                ocategoria = new Categoria() { IdCategoria = Convert.ToInt32(dr["IdCategoria"]), Descripcion = dr["DescripcionCategoria"].ToString() }

                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Articulo>();
                    throw new Exception("Error al Obtener la lista de los Articulos en la base de datos", ex);

                }
            }

            return lista;

        }

        public bool Update(Articulo update, out string msj)
        {

            bool respuesta = false;
            msj = string.Empty;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARARTICULO", conexion);

                    cmd.Parameters.AddWithValue("Id_Articulo", update.IdArticulo);
                    cmd.Parameters.AddWithValue("codigo", update.codigo);
                    cmd.Parameters.AddWithValue("nombre", update.Nombre);
                    cmd.Parameters.AddWithValue("descripcion", update.Descripcion);
                    cmd.Parameters.AddWithValue("precio", update.Precio);
                    cmd.Parameters.AddWithValue("stock", update.Stock);
                    cmd.Parameters.AddWithValue("estado", update.estado);
                    cmd.Parameters.AddWithValue("IdCategoria", update.ocategoria.IdCategoria);
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
