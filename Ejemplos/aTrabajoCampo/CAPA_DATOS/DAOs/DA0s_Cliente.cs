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
    internal class DA0s_Cliente : ICRUD<Cliente>
    {
        private static DA0s_Cliente instance;

        public static DA0s_Cliente GetInstance()
        {
            if (instance == null)
            {
                instance = new DA0s_Cliente();
            }

            return instance;
        }
        public int Add(Cliente alta, out string msj)
        {
            int IdGenerado = 0;
            msj =  string.Empty;

            try
            {
                using(SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCLIENTE", conexion);

                    cmd.Parameters.AddWithValue("nombre", alta.Nombre);
                    cmd.Parameters.AddWithValue("apellido", alta.Apellido);
                    cmd.Parameters.AddWithValue("correo", alta.Correo);
                    cmd.Parameters.AddWithValue("DNI", alta.Dni);
                    cmd.Parameters.AddWithValue("celular", alta.Celular);
                    cmd.Parameters.AddWithValue("direccion", alta.Direccion);
                    cmd.Parameters.AddWithValue("DVH", alta.DVH);
                    cmd.Parameters.Add("IdClienteResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    IdGenerado = Convert.ToInt32(cmd.Parameters["IdClienteResultado"].Value);
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

        public bool Delete(Cliente delete, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            using(SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARCLIENTE", conexion);

                    cmd.Parameters.AddWithValue("cod_cliente", delete.IdCliente);
                    cmd.Parameters.AddWithValue("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    msj = cmd.Parameters["Mensaje"].Value.ToString();


                }
                catch (Exception ex)
                {

                    respuesta = false;
                    msj = ex.Message;
                }
            }

            return respuesta;

        }

        public List<Cliente> GetAll()
        {
            List<Cliente> lista =  new List<Cliente>();

            using(SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT cod_cliente,nombre,apellido,correo,DNI,celular,direccion,DVH FROM Cliente";
                    SqlCommand cmd = new SqlCommand(query,conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            lista.Add(new Cliente
                            {
                                IdCliente = Convert.ToInt32(dr["cod_cliente"]),
                                Nombre = dr["nombre"].ToString(),
                                Apellido = dr["apellido"].ToString(),
                                Correo = dr["correo"].ToString(),
                                Dni = dr["DNI"].ToString(),
                                Celular = dr["celular"].ToString(),
                                Direccion = dr["direccion"].ToString(),
                                DVH = Convert.ToInt32(dr["DVH"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Cliente>();
                    throw new Exception("Error al Obtener la lista de los Clientes en la base de datos",ex);
                }

                return lista;
            }
        }

        public bool Update(Cliente update, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            using(SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARCLIENTE", conexion);

                    cmd.Parameters.AddWithValue("cod_cliente", update.IdCliente);
                    cmd.Parameters.AddWithValue("nombre", update.Nombre);
                    cmd.Parameters.AddWithValue("apellido", update.Apellido);
                    cmd.Parameters.AddWithValue("correo", update.Correo);
                    cmd.Parameters.AddWithValue("DNI", update.Dni);
                    cmd.Parameters.AddWithValue("celular", update.Celular);
                    cmd.Parameters.AddWithValue("direccion", update.Direccion);
                    cmd.Parameters.AddWithValue("DVH", update.DVH);
                    cmd.Parameters.AddWithValue("Respuesta",SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    msj = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {

                    respuesta = false;
                    msj = ex.Message;
                }
            }

            return respuesta;

        }
    }
}
