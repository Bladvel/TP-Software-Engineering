using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;
using DAL.Properties;
using System.Configuration;


namespace DAL
{
    internal class Acceso
    {
        private SqlConnection cn;
        private SqlTransaction tx;
        
        public static string ObtenerString()
        {
            return Settings.Default.SISCABConnectionString;
        }
        
        public void Abrir ()
        {
            cn = new SqlConnection();
            //cn.ConnectionString = "data source=(local); integrated security=true; initial catalog= SISCAB";
            cn.ConnectionString = "data source=DESKTOP-DAN; integrated security=SSPI; initial catalog= SISCAB";
            //cn.ConnectionString = "data source=DESKTOP-I7LNRPI; integrated security=true; initial catalog= SISCAB";
            //cn.ConnectionString = ObtenerString();
            cn.Open ();
        }

        public void Cerrar()
        {
            cn.Close();
            cn = null;
            GC.Collect();

        }

        public void IniciarTX()
        {
            tx = cn.BeginTransaction();
        }

        public void ConfirmarTX()
        {
            tx.Commit();
            tx = null;
        }

        public void RollbackTX()
        {
            tx.Rollback();
            tx = null;
        }

        private SqlCommand CrearComando (string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = cn;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;

            if (parametros != null)
            {
                comando.Parameters.AddRange(parametros.ToArray());
            }

            if (tx != null) 
            {
                comando.Transaction= tx;
            }
            return comando;
        }

        public DataTable Leer (string sql, List<SqlParameter> parametros = null)
        {
  
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = CrearComando(sql, parametros);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            da = null;

            return tabla;

        }

        public int Escribir (string sql, List<SqlParameter> parametros = null)
        {
            int filas = 0;
            SqlCommand comando = CrearComando(sql, parametros);

            try
            {
                filas = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                filas = -1;
            }
            return filas;
        }


        public int DevolverEscalar (string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand comando = CrearComando(sql, parametros);
            int escalar;
            try
            {
                escalar = int.Parse(comando.ExecuteScalar().ToString());
            }
            catch 
            {
                escalar = -1;
            }            
            return escalar;
        }

        public SqlParameter CrearParametro (string nombre, string valor)
        {
            SqlParameter parametro = new SqlParameter(nombre, valor);
            parametro.DbType = DbType.String;
            return parametro;
        }

        public SqlParameter CrearParametro (string nombre, int valor)
        {
            SqlParameter parametro = new SqlParameter(nombre, valor);
            parametro.DbType = DbType.Int32;
            return parametro;
        }

        public SqlParameter CrearParametro (string nombre, float valor)
        {
            SqlParameter parametro = new SqlParameter(nombre, valor);
            parametro.DbType = DbType.Single;
            return parametro;
        }

        public SqlParameter CrearParametro(string nombre, DateTime valor)
        {
            SqlParameter parametro = new SqlParameter(nombre, valor);
            parametro.DbType = DbType.DateTime;
            return parametro;
        }

        public SqlParameter CrearParametro(string nombre, Int64 valor)
        {
            SqlParameter parametro = new SqlParameter(nombre, valor);
            parametro.DbType = DbType.Int64;
            return parametro;
        }
    }
}
