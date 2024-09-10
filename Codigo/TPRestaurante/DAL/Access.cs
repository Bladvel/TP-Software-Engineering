using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Access
    {
        SqlConnection conn;

        public void Open()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-DAN";
            builder.InitialCatalog = "TpRESTAURANTE";
            builder.IntegratedSecurity = true;
            conn = new SqlConnection(builder.ConnectionString);
            conn.Open();
        }

        public void Close()
        {
            conn.Close();
            conn = null;
            GC.Collect();
        }

        public SqlParameter CreateParameter(string name, string value)
        {
            SqlParameter param = new SqlParameter(name,value);
            param.DbType = DbType.String;

            return param;
        }

        public SqlParameter CreateParameter(string name, Guid value)
        {
            SqlParameter param = new SqlParameter(name, value);
            param.DbType = DbType.Guid;

            return param;
        }

        public SqlParameter CreateParameter(string name, int value)
        {
            SqlParameter param = new SqlParameter(name,value);
            param.DbType = DbType.Int32;
            return param;
        }

        public SqlParameter CreateParameter(string name, bool value)
        {
            SqlParameter param = new SqlParameter(name, value);
            param.DbType = DbType.Boolean;
            return param;
        }

        public SqlParameter CreateParameter(string name, float value)
        {
            SqlParameter param = new SqlParameter(name, value);
            param.DbType = DbType.Decimal;
            return param;
        }

        public SqlParameter CreateParameter(string name, long value)
        {
            SqlParameter param = new SqlParameter(name, value);
            param.DbType = DbType.Int64;
            return param;
        }


        public SqlParameter CreateParameter(string name, DateTime value)
        {
            SqlParameter parameter = new SqlParameter(name, value);
            parameter.DbType = DbType.DateTime;
            return parameter;

        }



        private SqlCommand CreateCommand(string sql, List<SqlParameter> parameters = null) 
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (parameters != null)
            {
                foreach (SqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }
            }
            return cmd;

        }

        public int Write(string sql, List<SqlParameter> parameters = null)
        {
            int filasAfectadas = 0;
            SqlCommand cmd = CreateCommand(sql, parameters);

            try
            {
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                filasAfectadas = -1;
            }

            return filasAfectadas;

        }

        public int WriteScalar(string sql, List<SqlParameter> parameters = null)
        {
            int id;
            var cmd = CreateCommand(sql, parameters);
            try
            {
                id  = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch
            {
                id = -1;
            }
            return id;
        }

        public Guid WriteScalarGuid(string sql, List<SqlParameter> parameters = null)
        {
            object id;
            var cmd = CreateCommand(sql, parameters);
            try
            {
                id = cmd.ExecuteScalar();
            }
            catch
            {
                id = -1;
            }
            return (Guid)id;
        }


        public DataTable Read(string sql, List<SqlParameter> parameters = null)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = CreateCommand(sql, parameters);
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dt);
                adapter.Dispose();
            }
            return dt;
        }



    }
}
