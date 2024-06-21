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
        MP_PagoEfectivo mpPagoEfectivo = new MP_PagoEfectivo();
        MP_PagoTarjeta mpPagoTarjeta = new MP_PagoTarjeta();
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
            throw new NotImplementedException();
        }

        public override List<MetodoDePago> GetAll()
        {
            throw new NotImplementedException();
        }

        //TODO Manejar la insercion completa del pago (incluye metodo de pago y su clase derivada)
        public override int Insert(MetodoDePago entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@tipo", entity.tipo.ToString())
            };

            access.Open();
            int metodoDePagoId = access.WriteScalar("INSERTAR_METODO_DE_PAGO", parameters);
            access.Close();



            if (metodoDePagoId > 0)
            {
                if (entity is PagoTarjeta tarjeta)
                {

                    mpPagoTarjeta.Insert((PagoTarjeta)entity);

                }else if (entity is PagoEfectivo efectivo)
                {


                    mpPagoEfectivo.Insert((PagoEfectivo)entity);

                }

            }
            return metodoDePagoId;

        }

        public override int Update(MetodoDePago entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(MetodoDePago entity)
        {
            throw new NotImplementedException();
        }
    }
}
