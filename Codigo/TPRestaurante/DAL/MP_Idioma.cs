using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Multiidioma;

namespace DAL
{
    public class MP_Idioma: Mapper<Idioma>
    {
        public override Idioma GetById(object id)
        {
            int ID = int.Parse(id.ToString());
            Idioma idioma = GetAll().FirstOrDefault(i => i.Id.Equals(ID));
            return idioma;
        }

        public override Idioma Transform(DataRow dr)
        {
            Idioma idioma = new Idioma();
            idioma.Id = int.Parse(dr["ID"].ToString());
            idioma.Nombre = dr["IDIOMA"].ToString();
            idioma.Default = bool.Parse(dr["PREESTABLECIDO"].ToString());

            return idioma;
        }

        public override List<Idioma> GetAll()
        {
            List<Idioma> idiomas = new List<Idioma>();

            access.Open();
            DataTable dt = access.Read("LISTAR_IDIOMA");
            access.Close();


            foreach (DataRow dr in dt.Rows)
            {
                idiomas.Add(Transform(dr));
            }

            return idiomas;
        }

        public override int Insert(Idioma entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@IDIOMA", entity.Nombre),
                access.CreateParameter("@PREESTABLECIDO", entity.Default),
            };

            access.Open();
            int id = access.WriteScalar("INSERTAR_IDIOMA", parameters);
            access.Close();

            return id;
        }

        public override int Update(Idioma entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(Idioma entity)
        {
            throw new NotImplementedException();
        }

        public MP_Idioma(Access access) : base(access)
        {
        }
    }
}
