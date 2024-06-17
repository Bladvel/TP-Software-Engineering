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
    public class MP_Pedido: Mapper<Pedido>
    {
        public override Pedido GetById(object id)
        {
            throw new NotImplementedException();
        }

        public override Pedido Transform(DataRow dr)
        {
            throw new NotImplementedException();
        }

        public override List<Pedido> GetAll()
        {
            throw new NotImplementedException();
        }

        MP_Cliente mpCliente = new MP_Cliente();



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
                    InsertItem(entity, itemProducto);
                }


            }

            return entity.NroPedido;

        }


        public int InsertItem(Pedido pedido, ItemProducto item)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@cod", item.Producto.CodProducto),
                access.CreateParameter("@nro", pedido.NroPedido),
                access.CreateParameter("@cant", item.Cantidad),
                access.CreateParameter("@pre", item.PrecioCompra)
            };
            access.Open();
            int resultado = access.Write("INSERTAR_ITEM_PRODUCTO", parameters);
            access.Close();

            return resultado;

        }




        public override int Update(Pedido entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(Pedido entity)
        {
            throw new NotImplementedException();
        }
    }
}
