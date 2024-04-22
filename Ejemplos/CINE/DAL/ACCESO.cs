using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ACCESO
    {
        SqlConnection conn;

        public void Abrir()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-DAN\SQLEXPRESS; Initial catalog=ExCLASE6; Integrated security=SSPI";
            conn.Open();
        }

        public void Cerrar()
        {
            conn.Close();
            conn = null;
            GC.Collect();
        }

        public SqlParameter CrearParametro(string nombre, string value)
        {
            SqlParameter p = new SqlParameter(nombre, value);
            p.DbType = DbType.String;
            return p;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.Int32;
            return p;
        }

        public SqlCommand CrearComando(string sql, List<SqlParameter> parameters = null)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = sql;
            c.CommandType = CommandType.StoredProcedure;
            c.Connection = conn;

            if(parameters != null)
            {
                foreach(SqlParameter p in parameters)
                {
                    c.Parameters.Add(p);
                }
            }

            return c;
        }

        public int Escribir(string sql, List<SqlParameter> parameters = null)
        {
            SqlCommand cmd = CrearComando(sql, parameters);
            int filasAfectadas = 0;

            try
            {
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch
            {

                filasAfectadas = -1;
            }

            return filasAfectadas;
        }

        public DataTable Leer(string sql, List<SqlParameter> parameters = null)
        {
            DataTable dt = new DataTable();
            using(SqlDataAdapter adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = CrearComando(sql, parameters);
                adapter.Fill(dt);
                adapter.Dispose();
            }
            return dt;
        }

    }
}
