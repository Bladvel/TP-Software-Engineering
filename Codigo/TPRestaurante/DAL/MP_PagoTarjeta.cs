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
    public class MP_PagoTarjeta: Mapper<PagoTarjeta>
    {
        public override PagoTarjeta GetById(object id)
        {
            int ID = int.Parse(id.ToString());
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@id", ID),
            };

            access.Open();
            DataTable dt = access.Read("OBTENER_TARJETA_POR_ID",parameters);
            access.Close();

            PagoTarjeta tarjeta = new PagoTarjeta();
            foreach (DataRow row in dt.Rows)
            {
                tarjeta = Transform(row);
            }

            return tarjeta;

        }

        public override PagoTarjeta Transform(DataRow dr)
        {
            PagoTarjeta tarjeta = new PagoTarjeta();
            tarjeta.id = int.Parse(dr["ID"].ToString());
            tarjeta.NumeroTarjeta = long.Parse(dr["NUMERO"].ToString());
            tarjeta.FechaVencimiento = DateTime.Parse(dr["VENCIMIENTO"].ToString());
            tarjeta.Cvv = int.Parse(dr["CVV"].ToString());
            tarjeta.Titular = dr["TITULAR"].ToString();

            return tarjeta;
        }

        public override List<PagoTarjeta> GetAll()
        {
            List<PagoTarjeta> pagos = new List<PagoTarjeta>();

            access.Open();
            DataTable dt = access.Read("LISTAR_PAGOS_TARJETA");
            access.Close();
            foreach (DataRow dr in dt.Rows)
            {
                pagos.Add(Transform(dr));
            }
            return pagos;



        }

        public override int Insert(PagoTarjeta entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@MetodoDePagoId", entity.id),
                access.CreateParameter("@Numero", entity.NumeroTarjeta),
                access.CreateParameter("@Vencimiento", entity.FechaVencimiento),
                access.CreateParameter("@Cvv", entity.Cvv),
                access.CreateParameter("@Titular", entity.Titular),

            };

            access.Open();
            int filasAfectadas = access.Write("INSERTAR_PAGO_TARJETA", parameters);
            access.Close();

            return filasAfectadas;


        }

        public override int Update(PagoTarjeta entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(PagoTarjeta entity)
        {
            throw new NotImplementedException();
        }

        public MP_PagoTarjeta(Access access) : base(access)
        {
        }
    }
}
