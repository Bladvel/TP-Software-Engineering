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
    public class MP_Producto: Mapper<Producto>
    {
        public override Producto GetById(object id)
        {
            int codigo = int.Parse(id.ToString());
            return GetAll().FirstOrDefault(c => c.CodProducto.Equals(codigo));
        }

        MP_Ingrediente mpIngrediente;

        public override Producto Transform(DataRow dr)
        {
            Producto producto = new Producto();
            producto.CodProducto = int.Parse(dr["COD_PRODUCTO"].ToString());
            producto.Nombre = dr["NOMBRE"].ToString();
            producto.Descripcion = dr["DESCRIPCION"].ToString();
            producto.PrecioActual = float.Parse(dr["PRECIO_ACTUAL"].ToString());
            producto.Borrado = bool.Parse(dr["BORRADO"].ToString());

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
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nombre", entity.Nombre),
                access.CreateParameter("@descripcion", entity.Descripcion),
                access.CreateParameter("@precioActual", entity.PrecioActual),
            };

            access.Open();
            int filasAfectadas = access.Write("INSERTAR_PRODUCTO", parameters);
            access.Close();
            return filasAfectadas;



        }

        public override int Update(Producto entity)
        {
            int filasAfectadas = 0;
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@cod", entity.CodProducto),
                access.CreateParameter("@nombre", entity.Nombre),
                access.CreateParameter("@descripcion", entity.Descripcion),
                access.CreateParameter("@precio", entity.PrecioActual),
                access.CreateParameter("@borrado", entity.Borrado),
            };

            access.Open();
            filasAfectadas = access.Write("ACTUALIZAR_PRODUCTO", parameters);
            access.Close();

            return filasAfectadas;


        }

        public override int Delete(Producto entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@codigo", entity.CodProducto),
            };

            access.Open();
            int filasAfectadas = access.Write("ELIMINAR_PRODUCTO", parameters);
            access.Close();

            return filasAfectadas;
        }

        public MP_Producto(Access access, MP_Ingrediente mpIngrediente) : base(access)
        {
            this.mpIngrediente = mpIngrediente;
        }
    }
}
