using CAPA_ENTIDADES;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS.DAOs
{
    public class DAOs_Pedido
    {
        private static DAOs_Pedido instance;    

        public static DAOs_Pedido GetInstance()
        {
            if (instance == null)
            {
                instance = new DAOs_Pedido();
            }
            return instance;
        }

        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select COUNT(*) + 1 FROM Pedido");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();

                    idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());



                }
                catch (Exception ex)
                {
                    idCorrelativo = 0;
                }
            }

            return idCorrelativo;
        }

        public bool RestarStock(int idarticulo, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Articulo set stock = stock - @cantidad WHERE Id_Articulo = @idarticulo");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idarticulo", idarticulo);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;

                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool SumarStock(int idarticulo, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Articulo set stock = stock +  @cantidad WHERE Id_Articulo = @idarticulo");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idarticulo", idarticulo);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;

                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Registrar(Pedido obj,DataTable detallePedido,out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPEDIDO", conexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("numeropedido", obj.numeroPedido);
                    cmd.Parameters.AddWithValue("NombreCliente",obj.NombreCliente);
                    cmd.Parameters.AddWithValue("ApellidoCliente",obj.ApellidoCliente);
                    cmd.Parameters.AddWithValue("DocumentoCliente", obj.DocumentoCliente);
                    cmd.Parameters.AddWithValue("Total", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("dvh", obj.DVH);
                    cmd.Parameters.AddWithValue("estado", obj.oEstadoPedido.IdEstadoPedido);
                    cmd.Parameters.AddWithValue("DetallePedido", detallePedido);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
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
                msj = ex.Message;
                respuesta = false;
            }


            return respuesta;
        }


        public List<Pedido> GetAll()
        {
            List<Pedido> lista = new List<Pedido>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT Cod_pedido,NumeroPedido,NombreCl,ApellidoCl,DocumentoCl,Total,DVH from Pedido";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Pedido
                            {
                                IdPedido = Convert.ToInt32(dr["Cod_pedido"]),
                                numeroPedido = dr["NumeroPedido"].ToString(),
                                NombreCliente = dr["NombreCl"].ToString(),
                                ApellidoCliente = dr["ApellidoCl"].ToString(),
                                DocumentoCliente = dr["DocumentoCl"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["Total"].ToString()),
                                DVH = Convert.ToInt32(dr["DVH"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Pedido>();
                    throw new Exception("Error al Obtener la lista de los Clientes en la base de datos", ex);
                }

                return lista;
            }
        }


        public Pedido ObtenerPedido(string numero)
        {
            Pedido pedido = new Pedido();

            try
            {
                using(SqlConnection conexion = new SqlConnection(Conexion.cadena)){
                    
                    conexion.Open();

                    StringBuilder query = new StringBuilder();

                    query.AppendLine("Select p.Cod_pedido,u.nombre_usuario,");
                    query.AppendLine("p.NombreCl,p.ApellidoCl,p.DocumentoCl,");
                    query.AppendLine("p.NumeroPedido, p.Total,");
                    query.AppendLine("Convert(char(10),p.FechaRegistro,103)[Fecha Registro] ");
                    query.AppendLine("from Pedido p");
                    query.AppendLine("JOIN Usuario u on u.cod_usuario = p.Idusuario ");
                    query.AppendLine("where p.NumeroPedido = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            pedido = new Pedido()
                            {
                                IdPedido = int.Parse(dr["Cod_pedido"].ToString()),
                                oUsuario = new Usuario() {NombreUsuario = dr["nombre_usuario"].ToString() },
                                NombreCliente = dr["NombreCl"].ToString(),
                                ApellidoCliente = dr["ApellidoCl"].ToString(),
                                DocumentoCliente = dr["DocumentoCl"].ToString(),
                                numeroPedido = dr["NumeroPedido"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["Total"]),
                                FechaRegistro = dr["Fecha Registro"].ToString()
                            };
                        }
                    }
                }
            }
            catch
            {

                pedido = new Pedido();
            }

            return pedido;
        }


        public List<DetallePedido> ObtenerDetallePedido(int idPedido)
        {
            List<DetallePedido> detallePedidos = new List<DetallePedido>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT a.nombre,dp.Precio_unitario,dp.cantidad,dp.Subtotal from Detalle_Pedido dp");
                    query.AppendLine("join Articulo A on A.Id_Articulo = dp.Cod_articulo");
                    query.AppendLine("where dp.Cod_pedido = @idPedido");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idPedido", idPedido);
                    cmd.CommandType = CommandType.Text;

                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            detallePedidos.Add(new DetallePedido()
                            {
                                oArticulo = new Articulo() { Nombre = dr["nombre"].ToString()},
                                PrecioUnitario = Convert.ToDecimal(dr["Precio_unitario"].ToString()),
                                Cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                                SubTotal = Convert.ToDecimal(dr["Subtotal"])
                            });
                        }
                    }
                }
                catch
                {

                    detallePedidos = new List<DetallePedido>();
                }
            }

                return detallePedidos;
        }

    }
}
