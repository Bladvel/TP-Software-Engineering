using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;

namespace BLL
{
    public class ItemProducto
    {
        MP_ItemProducto mp = MpItemProductoCreator.GetInstance.CreateMapper() as MP_ItemProducto;

        public string Concatenar(BE.ItemProducto item)
        {
            return item.Producto.CodProducto + item.Pedido.NroPedido + item.Cantidad + item.PrecioCompra.ToString() + item.Id;
        }

        public List<BE.ItemProducto> Listar()
        {
           return mp.GetAll();
        }
    }
}
