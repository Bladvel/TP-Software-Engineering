using CompositePersistente.BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePersistente.DAL
{
    public class UsuariosRepository
    {

        //PermisosRepository repoPermisos;
        public UsuariosRepository()
        {
           // repoPermisos = new PermisosRepository();
        }
        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = ".";
            cs.InitialCatalog = "upf";
            return cs.ConnectionString;
        }

        public List<Usuario> GetAll()
        {
            var cnn = new SqlConnection(GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var sql = $@"select * from usuarios;";

            cmd.CommandText = sql;

            var reader = cmd.ExecuteReader();

            var lista = new List<Usuario>();

            while (reader.Read())
            {
                Usuario c = new Usuario();
                c.Id = reader.GetInt32(reader.GetOrdinal("id_usuario"));
                c.Nombre = reader.GetString(reader.GetOrdinal("nombre"));
                lista.Add(c);
            }

            reader.Close();
            cnn.Close();

            //vinculo los usuarios con las patentes y familias que tiene configuradas.
            //foreach (var item in lista)
            //{
            //   repoPermisos.FillUserPermissions(item);
            //}



            return lista;
        }
        public void GuardarPermisos(Usuario u)
        {

            try
            {
                var cnn = new SqlConnection(GetConnectionString());
                cnn.Open();

                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $@"delete from usuarios_permisos where id_usuario=@id;";
                cmd.Parameters.Add(new SqlParameter("id", u.Id));
                cmd.ExecuteNonQuery();

                foreach (var item in u.Permisos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    cmd.CommandText = $@"insert into usuarios_permisos (id_usuario,id_permiso) values (@id_usuario,@id_permiso) "; ;
                    cmd.Parameters.Add(new SqlParameter("id_usuario", u.Id));
                    cmd.Parameters.Add(new SqlParameter("id_permiso", item.Id));

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
   
}
