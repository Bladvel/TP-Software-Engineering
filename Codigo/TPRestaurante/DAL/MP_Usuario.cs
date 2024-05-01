using BE;
using Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_Usuario : Mapper<Usuario>
    {
        public override Usuario Transform(DataRow dr)
        {
            Usuario user = new BE.Usuario();
            user.ID = Guid.Parse( dr["ID"].ToString());
            user.Username = dr["USERNAME"].ToString();
            user.Password = dr["PASSWORD"].ToString();
            user.DNI = CryptoManager.Decrypt(dr["DNI"].ToString());
            user.Nombre = dr["NOMBRE"].ToString();
            user.Apellido = dr["APELLIDO"].ToString();
            user.Email = dr["EMAIL"].ToString();
            user.Activo = bool.Parse(dr["ACTIVO"].ToString());
            user.Bloqueo = bool.Parse(dr["BLOQUEO"].ToString());
            user.Attempts = int.Parse(dr["INTENTOS"].ToString());

            return user;
        }

        public override int Delete(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public override List<Usuario> GetAll()
        {
            List<Usuario> users = new List<Usuario>();

            access.Open();
            DataTable dt = access.Read("LISTAR_USUARIO");
            access.Close();
            foreach (DataRow dr in dt.Rows)
            {
                users.Add(Transform(dr));
            }
            return users;
        }

        public override Usuario GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Usuario entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@username", entity.Username),
                access.CreateParameter("@password", entity.Password),
                access.CreateParameter("@dni", entity.DNI),
                access.CreateParameter("@nom", entity.Nombre),
                access.CreateParameter("@ape", entity.Apellido),
                access.CreateParameter("@email", entity.Email),
            };

            access.Open();
            int filasAfectadas = access.Write("INSERTAR_USUARIO", parameters);
            access.Close();

            return filasAfectadas;
        }

        public override int Update(Usuario entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@id", entity.ID),
                access.CreateParameter("@username", entity.Username),
                access.CreateParameter("@dni", entity.DNI),
                access.CreateParameter("@nom", entity.Nombre),
                access.CreateParameter("@ape", entity.Apellido),
                access.CreateParameter("@email", entity.Email),
                access.CreateParameter("@intentos", entity.Attempts)
            };

            access.Open();
            int filasAfectadas = access.Write("ACTUALIZAR_USUARIO", parameters);
            access.Close();

            return filasAfectadas;
        }

        public int ChangeBlockage(Usuario entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@id", entity.ID),
                access.CreateParameter("@bloqueo", entity.Bloqueo),
                access.CreateParameter("@intentos", entity.Attempts),
            };

            access.Open();
            int filasAfectadas = access.Write("CAMBIAR_BLOQUEO", parameters);
            access.Close();

            return filasAfectadas;
        }
    }
}
