using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArquitectura.Core
{
    public class UserApplication
    {



        private static Guid _session;
        public static Guid Session
        {
            get
            {
                return _session;
            }
            set
            {
                _session = value;
                //MostrarUsuario();
                //ValidarForm();
            }
        }

        private void ValidarUsuario(string username, string password)
        {


            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)) throw new Exception("Debe completar todos los campos");

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
                cmd.CommandText = "select id_usuario from usuarios where username = @username and password=@password";
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                reader = cmd.ExecuteReader();

                if (!reader.Read()) throw new Exception("Usuario o contraseña incorrecta");
                Guid id = Guid.Parse(reader[0].ToString());

                Session = id;
                //frmMain frm = (frmMain)this.MdiParent;
                //frm.Session = id;
                //this.Close();

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


        private string MostrarUsuario()
        {
            if (!_session.Equals(Guid.Empty))
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
                    cmd.CommandText = "select username from usuarios where id_usuario=@id";
                    cmd.Parameters.AddWithValue("id", _session);

                    reader = cmd.ExecuteReader();

                    if (!reader.Read()) throw new Exception("No hay datos");

                    return reader[0].ToString();

                }
                else
                {
                    return "Por favor, inicie sesión.";
                }


                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    reader.Close();
                    sql.Close();
                }
            }
        }
    }
}
