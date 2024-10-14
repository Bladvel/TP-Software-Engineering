using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Services.Multiidioma;

namespace DAL
{
    public class MP_Traduccion: Mapper<Traduccion>
    {
        public override Traduccion GetById(object id)
        {
            throw new NotImplementedException();
        }

        public override Traduccion Transform(DataRow dr)
        {
            throw new NotImplementedException();
        }

        public override List<Traduccion> GetAll()
        {
            throw new NotImplementedException();
        }

        public override int Insert(Traduccion entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@ID_IDIOMA", entity.idioma.Id),
                access.CreateParameter("@ID_ETIQUETA", entity.Etiqueta.Id),
                access.CreateParameter("@TRADUCCION", entity.Texto)
            };

            access.Open();
            int filasAfectadas = access.Write("INSERTAR_TRADUCCION", parameters);
            access.Close();

            return filasAfectadas;


        }

        public override int Update(Traduccion entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(Traduccion entity)
        {
            throw new NotImplementedException();
        }

        public MP_Traduccion(Access access) : base(access)
        {
        }
    }
}
