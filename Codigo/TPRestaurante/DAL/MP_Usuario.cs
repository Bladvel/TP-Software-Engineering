using BE;
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
        public override Usuario Convert(DataRow dr)
        {
            Usuario user = new BE.Usuario();
            user.Id = Guid.Parse( dr["ID"].ToString());
            user.Username = dr["USERNAME"].ToString();
            user.Password = dr["PASSWORD"].ToString();

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
                users.Add(Convert(dr));
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
            };

            access.Open();
            int filasAfectadas = access.Write("INSERTAR_USUARIO", parameters);
            access.Close();

            return filasAfectadas;
        }

        public override int Update(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
