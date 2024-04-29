using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using Servicios;
using BE;

namespace DAL
{
    public class mp_usuario
    {
        private Acceso ac = new Acceso();

        public List<Servicios.Usuario> ListarTotal()
        {
            List<Servicios.Usuario> usuarios = new List<Servicios.Usuario>();
            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from Usuario");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Servicios.Usuario usuario = new Servicios.Usuario();
                usuario.Id = int.Parse(registro["id"].ToString());
                usuario.Nombre = registro["nombre"].ToString();
                usuario.Apellido = registro["apellido"].ToString();
                usuario.Dni = int.Parse(registro["dni"].ToString());
                usuario.Rol = registro["rol"].ToString();
                usuario.Username = registro["username"].ToString();
                usuario.Password = registro["password"].ToString();
                usuario.Borrado = int.Parse(registro["borrado"].ToString());
                usuario.Bloqueo = int.Parse(registro["bloqueo"].ToString());
                usuario.Intentos = int.Parse(registro["intentos"].ToString());
               // usuario.Idioma = ((IIdioma)(registro["id_idioma"].ToString()));

                usuarios.Add(usuario);

            }
            return usuarios;
        }
        public List<Servicios.Usuario> ListarActivos()
        {
            List<Servicios.Usuario> usuarios = new List<Servicios.Usuario>();
            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from Usuario where borrado = 0");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Servicios.Usuario usuario = new Servicios.Usuario();
                usuario.Id = int.Parse(registro["id"].ToString());
                usuario.Nombre = registro["nombre"].ToString();
                usuario.Apellido = registro["apellido"].ToString();
                usuario.Dni = int.Parse(registro["dni"].ToString());
                usuario.Rol = registro["rol"].ToString();
                usuario.Username = registro["username"].ToString();
                usuario.Password = registro["password"].ToString();
                usuario.Borrado = int.Parse(registro["borrado"].ToString());
                usuario.Bloqueo = int.Parse(registro["bloqueo"].ToString());
                usuario.Intentos = int.Parse(registro["intentos"].ToString());
                usuarios.Add(usuario);

            }
            return usuarios;
        }

        public List<Servicios.Usuario> ListarBloqueados()
        {
            List<Servicios.Usuario> usuarios = new List<Servicios.Usuario>();
            ac.Abrir();
            DataTable tabla = ac.Leer("select * from usuario where bloqueo = 1");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Servicios.Usuario usuario = new Servicios.Usuario();
                usuario.Id = int.Parse(registro["id"].ToString());
                usuario.Nombre = registro["nombre"].ToString();
                usuario.Apellido = registro["apellido"].ToString();
                usuario.Dni = int.Parse(registro["dni"].ToString());
                usuario.Rol = registro["rol"].ToString();
                usuario.Username = registro["username"].ToString();
                usuario.Password = registro["password"].ToString();
                usuario.Borrado = int.Parse(registro["borrado"].ToString());
                usuario.Bloqueo = int.Parse(registro["bloqueo"].ToString());
                usuario.Intentos = int.Parse(registro["intentos"].ToString());
                usuarios.Add(usuario);

            }
            return usuarios;
        }

        public List<Servicios.Usuario> ListarBorrados()
        {
            List<Servicios.Usuario> usuarios = new List<Servicios.Usuario>();
            ac.Abrir();
            DataTable tabla = ac.Leer("select * from usuario where borrado = 1");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Servicios.Usuario usuario = new Servicios.Usuario();
                usuario.Id = int.Parse(registro["id"].ToString());
                usuario.Nombre = registro["nombre"].ToString();
                usuario.Apellido = registro["apellido"].ToString();
                usuario.Dni = int.Parse(registro["dni"].ToString());
                usuario.Rol = registro["rol"].ToString();
                usuario.Username = registro["username"].ToString();
                usuario.Password = registro["password"].ToString();
                usuario.Borrado = int.Parse(registro["borrado"].ToString());
                usuario.Bloqueo = int.Parse(registro["bloqueo"].ToString());
                usuario.Intentos = int.Parse(registro["intentos"].ToString());
                usuarios.Add(usuario);

            }
            return usuarios;
        }


        public int Insertar(Servicios.Usuario usuario)
        {
            string sql = "Select isnull(max(id),0) + 1 from usuario";
            ac.Abrir();
            usuario.Id = ac.DevolverEscalar(sql);
            sql = "Insert into usuario (id, nombre, apellido, dni, rol, username, password, borrado, bloqueo, intentos) values" +
                "(@i, @n, @a, @d, @r, @u, @p, 0, 0, 0)";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", usuario.Id));
            parametros.Add(ac.CrearParametro("@n", usuario.Nombre));
            parametros.Add(ac.CrearParametro("@a", usuario.Apellido));
            parametros.Add(ac.CrearParametro("@d", usuario.Dni));
            parametros.Add(ac.CrearParametro("@r", usuario.Rol));
            parametros.Add(ac.CrearParametro("@u", usuario.Username));
            parametros.Add(ac.CrearParametro("@p", usuario.Password));
            parametros.Add(ac.CrearParametro("@b", usuario.Borrado));
            parametros.Add(ac.CrearParametro("@in", usuario.Intentos));

            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }


        public int Modificar(Servicios.Usuario usuario)
        {
            string sql = "Update usuario set nombre = @no, apellido = @a, dni = @d, rol = @r, username = @u, borrado = @b, bloqueo = @bl, intentos = @in where id = @i";
            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", usuario.Id));
            parametros.Add(ac.CrearParametro("@no", usuario.Nombre));
            parametros.Add(ac.CrearParametro("@a", usuario.Apellido));
            parametros.Add(ac.CrearParametro("@d", usuario.Dni));
            parametros.Add(ac.CrearParametro("@r", usuario.Rol));
            parametros.Add(ac.CrearParametro("@u", usuario.Username));
            parametros.Add(ac.CrearParametro("@b", usuario.Borrado));
            parametros.Add(ac.CrearParametro("@bl", usuario.Bloqueo));
            parametros.Add(ac.CrearParametro("@in", usuario.Intentos));
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }

        public int ModificarContraseña(Servicios.Usuario usuario)
        {
            string sql = "Update usuario set password = @p where id = @i";
            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", usuario.Id));
            parametros.Add(ac.CrearParametro("@p", usuario.Password));
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }
        public Servicios.Usuario BuscarUsuario(string user)
        {
            Servicios.Usuario us = null;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@usu", user));
            ac.Abrir();
            DataTable tabla = ac.Leer("select * from usuario where username = @usu", parametros);
            ac.Cerrar();
            if (tabla.Rows.Count == 1)
            {
                us = new Servicios.Usuario();
                us.Id = int.Parse(tabla.Rows[0]["id"].ToString());
                us.Nombre = tabla.Rows[0]["nombre"].ToString();
                us.Apellido = tabla.Rows[0]["apellido"].ToString();
                us.Dni = int.Parse(tabla.Rows[0]["dni"].ToString());
                us.Rol = tabla.Rows[0]["rol"].ToString();
                us.Username = tabla.Rows[0]["username"].ToString();
                us.Password = tabla.Rows[0]["password"].ToString();
                us.Borrado = int.Parse(tabla.Rows[0]["borrado"].ToString());
                us.Bloqueo = int.Parse(tabla.Rows[0]["bloqueo"].ToString());
                us.Intentos = int.Parse(tabla.Rows[0]["intentos"].ToString());
            }
            return us;
        }

        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = "DESKTOP-I7LNRPI";
            //cs.DataSource = "(local)";
            cs.InitialCatalog = "SISCAB";
            return cs.ConnectionString;
        }


        public void GuardarPermisos(Usuario u)
        {

            try
            {
                var cnn = new SqlConnection(GetConnectionString());
                cnn.Open();

                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $@"delete from usuario_permiso where id_usuario=@id;";
                cmd.Parameters.Add(new SqlParameter("id", u.Id));
                cmd.ExecuteNonQuery();

                foreach (var item in u.Permisos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    cmd.CommandText = $@"insert into usuario_permiso (id_usuario,id_permiso) values (@id_usuario,@id_permiso) "; ;
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
