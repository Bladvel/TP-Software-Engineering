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
    public class MP_Producto_Bitacora: Mapper<BE.ProductoBitacora>
    {
        public override ProductoBitacora GetById(object id)
        {
            throw new NotImplementedException();
        }

        MP_Producto mpProducto;

        public override ProductoBitacora Transform(DataRow dr)
        {
            ProductoBitacora bitacoraProducto = new ProductoBitacora();
            bitacoraProducto.Id = int.Parse(dr["ID"].ToString());
            bitacoraProducto.CodProducto = int.Parse(dr["COD_PRODUCTO"].ToString());
            bitacoraProducto.Nombre = dr["NOMBRE"].ToString();
            bitacoraProducto.Descripcion = dr["DESCRIPCION"].ToString();
            bitacoraProducto.PrecioActual = float.Parse(dr["PRECIO_ACTUAL"].ToString());
            bitacoraProducto.Fecha = DateTime.Parse(dr["FECHA"].ToString());
            bitacoraProducto.Hora = DateTime.Parse(dr["HORA"].ToString());
            bitacoraProducto.Activo = bool.Parse(dr["ACTIVO"].ToString());

            bitacoraProducto.Producto = mpProducto.GetById(bitacoraProducto.CodProducto);

            return bitacoraProducto;

        }

        public override List<ProductoBitacora> GetAll()
        {
            List<ProductoBitacora> productoBitacoras = new List<ProductoBitacora>();


            access.Open();
            DataTable dt = access.Read("LISTAR_PRODUCTO_BITACORA");
            access.Close();

            foreach (DataRow dr in dt.Rows)
            {
                productoBitacoras.Add(Transform(dr));
            }
            return productoBitacoras;


        }

        public override int Insert(ProductoBitacora entity)
        {
            throw new NotImplementedException();
        }

        public override int Update(ProductoBitacora entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(ProductoBitacora entity)
        {
            throw new NotImplementedException();
        }

        public List<ProductoBitacora> Filter(DateTime fi, DateTime ff, string nombre, int? codProducto)
        {
            List<ProductoBitacora> productoBitacoras = new List<ProductoBitacora>();

            
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@fechaInicio", fi),
                access.CreateParameter("@fechaFin", ff),
                new SqlParameter("@nombre", nombre ?? (object)DBNull.Value),
                
            };

            if (codProducto.HasValue)
                parameters.Add(access.CreateParameter("@codigo", codProducto.Value));
            else
                parameters.Add(new SqlParameter("@codigo", DBNull.Value));


            access.Open();
            DataTable dt = access.Read("FILTRAR_BITACORA_CAMBIOS", parameters);
            access.Close();

            foreach (DataRow dr in dt.Rows)
            {
                productoBitacoras.Add(Transform(dr));
            }

            return productoBitacoras;
        }

        public MP_Producto_Bitacora(Access access, MP_Producto mpProducto) : base(access)
        {
            this.mpProducto = mpProducto;
        }
    }
}
