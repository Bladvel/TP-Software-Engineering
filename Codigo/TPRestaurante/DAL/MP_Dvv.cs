using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace DAL
{
    public class MP_Dvv: Mapper<Services.DVV>
    {
        public override DVV GetById(object id)
        {
            throw new NotImplementedException();
        }

        public override DVV Transform(DataRow dr)
        {
            DVV dvv = new DVV();
            dvv.Tabla = dr["TABLA"].ToString();
            dvv.Columna = int.Parse(dr["COLUMNA"].ToString());
            dvv.DV = dr["DV"].ToString();

            return dvv;
        }

        public override List<DVV> GetAll()
        {
            List<DVV> dvvs = new List<DVV>();

            access.Open();
            DataTable dt = access.Read("LISTAR_DVV");
            access.Close();

            foreach (DataRow dr in dt.Rows)
            {
                dvvs.Add(Transform(dr));
            }

            return dvvs;
        }

        public override int Insert(DVV entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@tabla", entity.Tabla),
                access.CreateParameter("@col", entity.Columna),
                access.CreateParameter("@dv", entity.DV)
            };

            access.Open();
            int id = access.Write("INSERTAR_DVV", parameters);
            access.Close();

            return id;
        }

        public override int Update(DVV entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@tabla", entity.Tabla),
                access.CreateParameter("@col", entity.Columna),
                access.CreateParameter("@dv", entity.DV)
            };

            access.Open();
            int id = access.Write("MODIFICAR_DVV", parameters);
            access.Close();

            return id;
        }

        public override int Delete(DVV entity)
        {
            throw new NotImplementedException();
        }

        public int DeleteAll()
        {
            access.Open();
            int resultado = access.Write("ELIMINAR_TODOS_DVV");
            access.Close();

            return resultado;
        }

        public MP_Dvv(Access access) : base(access)
        {
        }
    }
}
