using EjemploArquitectura.Domain;
using EjemploArquitectura.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArquitectura.SqlServerDataProvider
{
    public class UsuarioSqlServerDataProvider
    {
        public Usuario ObtenerUsuarioPorUsernamePassword(string username, string password)
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.InitialCatalog = "EjemploArquitectura";
            cs.DataSource = ".";
            cs.IntegratedSecurity = true;

            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = cs.ConnectionString;
            IDataReader reader = null;
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = "select id_usuario, username,password, i.id_idioma,nombre as nombre_idioma from usuarios u inner join idiomas i on u.id_idioma=i.id_idioma where username = @username and password=@password";
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                reader = cmd.ExecuteReader();

                if (!reader.Read()) return null;
                return new Usuario()
                {
                    Id = Guid.Parse(reader["id_usuario"].ToString()),
                    Username = reader["username"].ToString(),
                    Password = reader["password"].ToString(),
                    Idioma = new Idioma()
                    {
                        Id = Guid.Parse(reader["id_idioma"].ToString()),
                        Nombre = reader["nombre_idioma"].ToString(),
                    }
                    
                };



            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (sql != null)
                    sql.Close();
            }
        }
        public Usuario ObtenerUsuarioPorId(Guid id)
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.InitialCatalog = "EjemploArquitectura";
            cs.DataSource = ".";
            cs.IntegratedSecurity = true;

            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = cs.ConnectionString;
            IDataReader reader = null;
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = "select id_usuario, username,password, i.id_idioma,nombre as nombre_idioma from usuarios u inner join idiomas i on u.id_idioma=i.id_idioma where id_usuario = @id";
              
                cmd.Parameters.AddWithValue("id", id);
                reader = cmd.ExecuteReader();

                if (!reader.Read()) return null;
                return new Usuario()
                {
                    Id = Guid.Parse(reader["id_usuario"].ToString()),
                    Username = reader["username"].ToString(),
                    Password = reader["password"].ToString(),
                    Idioma = new Idioma()
                    {
                        Id = Guid.Parse(reader["id_idioma"].ToString()),
                        Nombre = reader["nombre_idioma"].ToString(),
                    }

                };


            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (sql != null)
                    sql.Close();
            }
        }
    }
}
