using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class MP_PagoEfectivo: Mapper<PagoEfectivo>
    {
        public override PagoEfectivo GetById(object id)
        {
            int ID = int.Parse(id.ToString());
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@id", ID),
            };

            access.Open();
            DataTable dt = access.Read("OBTENER_PAGO_EFECTIVO_POR_ID", parameters);
            access.Close();

            PagoEfectivo efectivo = new PagoEfectivo();
            foreach (DataRow row in dt.Rows)
            {
                efectivo = Transform(row);
            }

            return efectivo;
        }

        public override PagoEfectivo Transform(DataRow dr)
        {
            PagoEfectivo efectivo = new PagoEfectivo();

            efectivo.id = int.Parse(dr["ID"].ToString());
            efectivo.Monto = float.Parse(dr["MONTO"].ToString());

            return efectivo;
        }

        public override List<PagoEfectivo> GetAll()
        {
            List<PagoEfectivo> pagos = new List<PagoEfectivo>();
            access.Open();
            DataTable dt = access.Read("LISTAR_PAGOS_EFECTIVO");

            access.Close();
            foreach (DataRow dr in dt.Rows)
            {
                pagos.Add(Transform(dr));
            }
            return pagos;
        }

        public override int Insert(PagoEfectivo entity)
        {
            List<SqlParameter> parms = new List<SqlParameter>()
            {
                access.CreateParameter("@MetodoDePagoId", entity.id),
                access.CreateParameter("@Monto", entity.Monto),
            };

            access.Open();
            int filasAfectadas = access.Write("INSERTAR_PAGO_EFECTIVO",parms);
            access.Close();

            return filasAfectadas;


        }

        public override int Update(PagoEfectivo entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(PagoEfectivo entity)
        {
            throw new NotImplementedException();
        }

        public MP_PagoEfectivo(Access access) : base(access)
        {
        }
    }
}
