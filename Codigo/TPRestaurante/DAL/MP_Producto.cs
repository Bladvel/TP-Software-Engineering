using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class MP_Producto: Mapper<Producto>
    {
        public override Producto GetById(object id)
        {
            int codigo = int.Parse(id.ToString());
            return GetAll().FirstOrDefault(c => c.CodProducto.Equals(codigo));
        }

        MP_Ingrediente mpIngrediente = new MP_Ingrediente();

        public override Producto Transform(DataRow dr)
        {
            Producto producto = new Producto();
            producto.CodProducto = int.Parse(dr["COD_PRODUCTO"].ToString());
            producto.Nombre = dr["NOMBRE"].ToString();
            producto.Descripcion = dr["DESCRIPCION"].ToString();
            producto.CantStock = int.Parse(dr["CANTIDAD"].ToString());
            producto.PrecioActual = float.Parse(dr["PRECIO_ACTUAL"].ToString());

            producto.Ingredientes = mpIngrediente.GetIngredientsByProduct(producto.CodProducto);



            return producto;

        }

        public override List<Producto> GetAll()
        {
            List<Producto> productos = new List<Producto>();
            access.Open();
            DataTable dt = access.Read("LISTAR_PRODUCTO");
            access.Close();

            foreach (DataRow dr in dt.Rows)
            {
                productos.Add(Transform(dr));
            }

            return productos;

        }

        public override int Insert(Producto entity)
        {
            throw new NotImplementedException();
        }

        public override int Update(Producto entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(Producto entity)
        {
            throw new NotImplementedException();
        }
    }
}
