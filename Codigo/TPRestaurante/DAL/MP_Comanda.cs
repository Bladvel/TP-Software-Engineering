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

        MP_Pedido mpPedido;
        MP_User mpUser;
        public override Comanda Transform(DataRow dr)
        {
            Pedido pedido = mpPedido.GetById(int.Parse(dr["ID_PEDIDO"].ToString()));
            User cocinero = mpUser.GetById(dr["ID_COCINERO"].ToString());
            string descripcion = dr["DESCRIPCION"].ToString();
            Comanda comanda = new Comanda(pedido,cocinero, descripcion);
            comanda.ID = int.Parse(dr["ID"].ToString());
            return comanda;
            
        }

        public override List<Comanda> GetAll()
        {
            List<Comanda> comanda = new List<BE.Comanda>();
            access.Open();
            DataTable dt = access.Read("LISTAR_COMANDAS");
            access.Close();

            foreach (DataRow row in dt.Rows)
            {
                comanda.Add(Transform(row));
            }

            return comanda;
        }

        public List<BE.Comanda> GetAllOnGoing()
        {
            List<Comanda> comanda = new List<BE.Comanda>();
            access.Open();
            DataTable dt = access.Read("LISTAR_COMANDAS_EN_CURSO");
            access.Close();

            foreach (DataRow row in dt.Rows)
            {
                comanda.Add(Transform(row));
            }

            return comanda;
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

        public MP_Comanda(Access access, MP_Pedido mpPedido, MP_User mpUser) : base(access)
        {
            this.mpPedido = mpPedido;
            this.mpUser = mpUser;
        }
    }
}
