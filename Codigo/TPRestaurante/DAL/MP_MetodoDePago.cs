using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Interfaces;

namespace DAL
{
    public class MP_MetodoDePago: Mapper<MetodoDePago>
    {
        MP_PagoEfectivo mpPagoEfectivo;
        MP_PagoTarjeta mpPagoTarjeta;
        public override MetodoDePago GetById(object id)
        {
            int ID = int.Parse(id.ToString());
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@id", ID),
            };

            access.Open();
            DataTable dt = access.Read("OBTENER_METODO_POR_ID", parameters);
            access.Close();
            int metodoID;
            PaymentMethodType tipo;
            DataRow row = dt.Rows[0];

            metodoID = int.Parse(row["ID"].ToString());
            tipo = (PaymentMethodType)Enum.Parse(typeof(PaymentMethodType), row["TIPO"].ToString());
            
            if (tipo == PaymentMethodType.Efectivo)
            {
                return mpPagoEfectivo.GetById(metodoID);
            }
            else
            {
                return mpPagoTarjeta.GetById(metodoID);
            }



            

      
        }

        public override MetodoDePago Transform(DataRow dr)
        {
            MetodoDePago metodo = new MetodoDePago();
            metodo.id = int.Parse(dr["ID"].ToString());
            metodo.tipo = (PaymentMethodType)Enum.Parse(typeof(PaymentMethodType), dr["TIPO"].ToString());
            return metodo;
        }

        public override List<MetodoDePago> GetAll()
        {
            List<MetodoDePago> metodos = new List<MetodoDePago>();
            access.Open();
            DataTable dt = access.Read("LISTAR_METODOS_DE_PAGO");
            access.Close();
            foreach (DataRow dr in dt.Rows)
                metodos.Add(Transform(dr));

            return metodos;
        }

        public override int Insert(MetodoDePago entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@tipo", entity.tipo.ToString())
            };

            access.Open();
            entity.id = access.WriteScalar("INSERTAR_METODO_DE_PAGO", parameters);
            access.Close();

            


            if (entity.id > 0)
            {
                if (entity is PagoTarjeta)
                {

                    mpPagoTarjeta.Insert((PagoTarjeta)entity);

                }
                else if (entity is PagoEfectivo)
                {


                    mpPagoEfectivo.Insert((PagoEfectivo)entity);

                }

            }
            return entity.id;

        }

        public override int Update(MetodoDePago entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(MetodoDePago entity)
        {
            throw new NotImplementedException();
        }

        public MP_MetodoDePago(Access access, MP_PagoEfectivo mpPagoEfectivo, MP_PagoTarjeta mpPagoTarjeta) : base(access)
        {
            this.mpPagoEfectivo = mpPagoEfectivo;
            this.mpPagoTarjeta = mpPagoTarjeta;
        }
    }
}
