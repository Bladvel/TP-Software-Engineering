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
    public class MP_Pedido: Mapper<Pedido>
    {
        public override Pedido GetById(object id)
        {
            int ID = int.Parse(id.ToString());
            return GetAll().FirstOrDefault(p => p.NroPedido.Equals(ID));
        }

        public override Pedido Transform(DataRow dr)
        {
            Pedido pedido = new Pedido();
            pedido.NroPedido = int.Parse(dr["NRO_PEDIDO"].ToString());
            pedido.Estado = (OrderType)Enum.Parse(typeof(OrderType), dr["ESTADO"].ToString());
            pedido.Fecha = DateTime.Parse(dr["FECHA"].ToString());

            pedido.Cliente = mpCliente.GetById(dr["ID_CLIENTE"].ToString());

            pedido.Productos = GetItemByOrder(pedido.NroPedido);
            pedido.EstadoPago = (PaymentState)Enum.Parse(typeof(PaymentState), dr["ESTADO_PAGO"].ToString());



            
            return pedido;
        }

        public override List<Pedido> GetAll()
        {
            List<Pedido> pedidos = new List<Pedido>();
            access.Open();
            DataTable dt = access.Read("LISTAR_PEDIDO");
            access.Close();


            foreach (DataRow dr in dt.Rows)
            {
                pedidos.Add(Transform(dr));
            }


            return pedidos;
        }

        MP_Cliente mpCliente;


        public override int Insert(Pedido entity)
        {
            int idCliente = mpCliente.Insert(entity.Cliente);
            

            if (idCliente !=-1)
            {
                
                List<SqlParameter> parameters = new List<SqlParameter>()
                {
                    access.CreateParameter("@est", entity.Estado.ToString()),
                    access.CreateParameter("@fec", entity.Fecha),
                    access.CreateParameter("@cli", idCliente),
                };

                access.Open();
                entity.NroPedido = access.WriteScalar("INSERTAR_PEDIDO", parameters);
                access.Close();

                foreach (var itemProducto in entity.Productos)
                {
                    itemProducto.Pedido = entity;
                    mpItemProducto.Insert(itemProducto);
                }


            }

            return entity.NroPedido;

        }

        private MP_ItemProducto mpItemProducto;


        [Obsolete("Use Insert(Pedido entity) instead")]
        public int InsertItem(Pedido pedido, ItemProducto item)
        {
            item.Pedido = pedido;
            return mpItemProducto.Insert(item);

        }

        public List<ItemProducto> GetItemByOrder(int nroPedido)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nro", nroPedido),
            };

            access.Open();
            DataTable dt = access.Read("LISTAR_ITEM_POR_ORDEN", parameters);
            access.Close();

            List<ItemProducto> items = new List<ItemProducto>();
            
            foreach (DataRow dr in dt.Rows)
            {
                ItemProducto item = mpItemProducto.Transform(dr);

                items.Add(item);
            }

            return items;

        }



        public override int Update(Pedido entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nro", entity.NroPedido),
                access.CreateParameter("@est", entity.Estado.ToString()),
                access.CreateParameter("@pag",entity.EstadoPago.ToString()),
            };

            access.Open();
            int filasAfectadas = access.Write("ACTUALIZAR_PEDIDO", parameters);
            access.Close();

            return filasAfectadas;

        }

        public override int Delete(Pedido entity)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> GetOrderByState(OrderType estado)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@est", estado.ToString()),
            };

            access.Open();
            DataTable dt = access.Read("LISTAR_PEDIDO_POR_ESTADO", parameters);
            access.Close();


            List<Pedido> pedidos = new List<Pedido>();

            foreach (DataRow dr in dt.Rows)
            {
                pedidos.Add(Transform(dr));
            }

            return pedidos;
        }

        public List<Pedido> GetOrderByPaymentState(PaymentState estado)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@est", estado.ToString()),
            };

            access.Open();
            DataTable dt = access.Read("LISTAR_PEDIDO_POR_PAGADO", parameters);
            access.Close();


            List<Pedido> pedidos = new List<Pedido>();

            foreach (DataRow dr in dt.Rows)
            {
                pedidos.Add(Transform(dr));
            }

            return pedidos;
        }


        public MP_Pedido(Access access, MP_Cliente mpCliente, MP_ItemProducto mpItem) : base(access)
        {
            this.mpCliente = mpCliente;
            this.mpItemProducto = mpItem;
        }
    }
}
