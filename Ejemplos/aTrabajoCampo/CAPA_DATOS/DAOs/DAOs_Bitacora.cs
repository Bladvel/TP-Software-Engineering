using CAPA_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS.DAOs
{
    internal class DAOs_Bitacora
    {
        private static DAOs_Bitacora instance;

        public static DAOs_Bitacora GetInstance()
        {
            if (instance == null)
            {
                instance = new DAOs_Bitacora();
            }

            return instance;
        }

        public void RegistrarMovimiento(Bitacora bitacora)
        {
            try
            {
                using(SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarBitacora", conexion);

                    cmd.Parameters.AddWithValue("codCriticidad", bitacora.oCriticidad.IdCriticidad);
                    cmd.Parameters.AddWithValue("codUsuario", bitacora.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("descripcion", bitacora.descripcion);
                    cmd.Parameters.AddWithValue("dvh", bitacora.DVH);

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al registrar movimiento en la bitácora: " + ex.Message);
            }
        }

        public List<Bitacora> GetAll()
        {
            List<Bitacora> lista = new List<Bitacora>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select cod_bitacora,fecha_hora,cod_criticidad,cod_usuario,descripcion,DVH from Bitacora";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Bitacora
                            {
                                IdBitacora = Convert.ToInt32(dr["cod_bitacora"]),
                                Fecha_Y_Hora = dr["fecha_hora"].ToString(),
                                oCriticidad = new Criticidad { IdCriticidad = Convert.ToInt32(dr["cod_criticidad"]) },
                                oUsuario = new Usuario { IdUsuario = Convert.ToInt32(dr["cod_usuario"]) },
                                descripcion = dr["descripcion"].ToString(),
                                DVH = Convert.ToInt32(dr["DVH"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Bitacora>();
                    throw new Exception("Error al Obtener la lista de los Clientes en la base de datos", ex);
                }

                return lista;
            }
        }
    }
}
