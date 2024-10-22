using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using static iTextSharp.text.pdf.AcroFields;

namespace DAL
{
    public class MP_ItemProducto: Mapper<BE.ItemProducto>
    {
        public override ItemProducto GetById(object id)
        {
            throw new NotImplementedException();
        }

        private MP_Producto mpProducto;

        public override ItemProducto Transform(DataRow dr)
        {
            ItemProducto item = new ItemProducto();
            item.Id = int.Parse(dr["ID"].ToString());
            item.Pedido = new Pedido();
            item.Pedido.NroPedido =int.Parse(dr["NRO_PEDIDO"].ToString());
            item.Producto = mpProducto.GetById(dr["COD_PRODUCTO"].ToString());
            item.Cantidad = int.Parse(dr["CANTIDAD"].ToString());
            item.PrecioCompra = float.Parse(dr["PRECIO_COMPRA"].ToString());

            return item;
        }

        public override List<ItemProducto> GetAll()
        {
            List<ItemProducto> items = new List<ItemProducto>();

            access.Open();
            DataTable dt = access.Read("LISTAR_ITEM_PRODUCTO");
            access.Close();

            foreach (DataRow dr in dt.Rows)
                items.Add(Transform(dr));


            return items;
        }


        public override int Insert(ItemProducto item)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@cod", item.Producto.CodProducto),
                access.CreateParameter("@nro", item.Pedido.NroPedido),
                access.CreateParameter("@cant", item.Cantidad),
                access.CreateParameter("@pre", item.PrecioCompra)
            };
            access.Open();
            int resultado = access.Write("INSERTAR_ITEM_PRODUCTO", parameters);
            access.Close();

            return resultado;
        }

        public override int Update(ItemProducto entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(ItemProducto entity)
        {
            throw new NotImplementedException();
        }

        public MP_ItemProducto(Access access, MP_Producto mpProducto) : base(access)
        {
            this.mpProducto = mpProducto;
        }
    }
}
