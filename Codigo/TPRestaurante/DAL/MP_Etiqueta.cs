using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Multiidioma;

namespace DAL
{
    public class MP_Etiqueta: Mapper<Etiqueta>
    {
        public override Etiqueta GetById(object id)
        {
            throw new NotImplementedException();
        }

        public override Etiqueta Transform(DataRow dr)
        {
            Etiqueta etiqueta = new Etiqueta();
            etiqueta.Id = int.Parse(dr["ID"].ToString());
            etiqueta.Nombre = dr["NOMBRE"].ToString();

            return etiqueta;
        }

        public override List<Etiqueta> GetAll()
        {
            List<Etiqueta> etiquetas = new List<Etiqueta>();

            access.Open();
            DataTable dt = access.Read("LISTAR_ETIQUETA");
            access.Close();

            foreach (DataRow dr in dt.Rows)
            {
                etiquetas.Add(Transform(dr));
            }

            return etiquetas;

        }

        public override int Insert(Etiqueta entity)
        {
            throw new NotImplementedException();
        }

        public override int Update(Etiqueta entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(Etiqueta entity)
        {
            throw new NotImplementedException();
        }

        public MP_Etiqueta(Access access) : base(access)
        {
        }
    }
}
