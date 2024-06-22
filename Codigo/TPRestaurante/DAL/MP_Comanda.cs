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
    public class MP_Comanda: Mapper<Comanda>
    {
        public override Comanda GetById(object id)
        {
            throw new NotImplementedException();
        }

        public override Comanda Transform(DataRow dr)
        {
            throw new NotImplementedException();
        }

        public override List<Comanda> GetAll()
        {
            throw new NotImplementedException();
        }

        public override int Insert(Comanda entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@Descripcion", entity.Descripcion),
                access.CreateParameter("@idPedido", entity.PedidoAsignado.NroPedido),
                access.CreateParameter("@idCocinero", entity.Cocinero.ID)
            };

            access.Open();
            int id = access.WriteScalar("INSERTAR_COMANDA", parameters);
            access.Close();

            return id;

        }

        public override int Update(Comanda entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(Comanda entity)
        {
            throw new NotImplementedException();
        }
    }
}
