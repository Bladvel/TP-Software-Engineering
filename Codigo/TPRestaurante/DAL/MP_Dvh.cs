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
    public class MP_Dvh: Mapper<DVH>
    {
        public override DVH GetById(object id)
        {
            throw new NotImplementedException();
        }

        public override DVH Transform(DataRow dr)
        {
            DVH dvh = new DVH();
            dvh.Tabla = dr["TABLA"].ToString();
            dvh.Registro = int.Parse(dr["REGISTRO"].ToString());
            dvh.DV = dr["DV"].ToString();

            return dvh;
        }

        public override List<DVH> GetAll()
        {
            List<DVH> dvhs = new List<DVH>();

            access.Open();
            DataTable dt = access.Read("LISTAR_DVH");
            access.Close();

            foreach (DataRow dr in dt.Rows)
            {
                dvhs.Add(Transform(dr));
            }

            return dvhs;
        }

        public override int Insert(DVH entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@tabla", entity.Tabla),
                access.CreateParameter("@reg", entity.Registro),
                access.CreateParameter("@dv", entity.DV)
            };

            access.Open();
            int id = access.Write("INSERTAR_DVH", parameters);
            access.Close();

            return id;
        }

        public override int Update(DVH entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@tabla", entity.Tabla),
                access.CreateParameter("@reg", entity.Registro),
                access.CreateParameter("@dv", entity.DV)
            };

            access.Open();
            int id = access.Write("MODIFICAR_DVH", parameters);
            access.Close();

            return id;
        }

        public override int Delete(DVH entity)
        {
            throw new NotImplementedException();
        }

        public int DeleteAll()
        {
            access.Open();
            int resultado = access.Write("ELIMINAR_TODOS_DVH");
            access.Close();

            return resultado;
        }

        public MP_Dvh(Access access) : base(access)
        {
        }
    }
}
