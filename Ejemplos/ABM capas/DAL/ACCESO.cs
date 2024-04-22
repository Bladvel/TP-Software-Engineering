using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
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
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.DataSource = "DESKTOP-DAN\\SQLEXPRESS";
            cs.InitialCatalog = "ExUSUARIO";
            cs.IntegratedSecurity = true;
            conn.ConnectionString = cs.ConnectionString;
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
            SqlParameter param = new SqlParameter(nombre,value);
            param.DbType = DbType.String;

            return param;

        }

        public SqlParameter CrearParametro(string nombre, int value)
        {
            SqlParameter param = new SqlParameter(nombre, value);
            param.DbType = DbType.Int32;

            return param;

        }

        public SqlCommand CrearComando(string sql, List<SqlParameter> parameters = null)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            if(parameters != null )
            {
                foreach(SqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }
            }
            
            return cmd;
        }

        public int Escribir(string sql, List<SqlParameter> parameters = null)
        {
            int filasAfectadas = 0;
            SqlCommand cmd = CrearComando(sql, parameters);

            try
            {
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                filasAfectadas = -1;
            }

            return filasAfectadas;
        }

        public DataTable Leer(string sql, List<SqlParameter> parameters = null)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = CrearComando(sql, parameters);
            using (SqlDataAdapter adapter = new SqlDataAdapter()){
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                adapter.Dispose();
            }

            return dt;
        }

    }
}
