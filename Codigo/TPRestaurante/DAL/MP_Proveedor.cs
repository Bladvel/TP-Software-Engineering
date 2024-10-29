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
    public class MP_Proveedor: Mapper<BE.Proveedor>
    {
        public MP_Proveedor(Access access) : base(access)
        {
        }

        public override Proveedor GetById(object id)
        {
            int cuit = int.Parse(id.ToString());
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@cuit", cuit),
            };

            access.Open();
            DataTable dt = access.Read("OBTENER_PROVEEDOR_POR_CUIT", parameters);
            access.Close();
            Proveedor proveedor = Transform(dt.Rows[0]);
            return proveedor;



        }

        public override Proveedor Transform(DataRow dr)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Cuit = int.Parse(dr["CUIT"].ToString());
            proveedor.Nombre = dr["NOMBRE"].ToString();
            proveedor.Email = dr["EMAIL"].ToString();
            proveedor.Telefono = int.Parse(dr["TELEFONO"].ToString());
            proveedor.Direccion = dr["DIRECCION"].ToString();
            return proveedor;
        }

        public override List<Proveedor> GetAll()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            access.Open();
            DataTable tabla = access.Read("LISTAR_PROVEEDOR");
            access.Close();
            foreach (DataRow dr in tabla.Rows)
            {
                proveedores.Add(Transform(dr));
            }
            return proveedores;

        }

        public override int Insert(Proveedor entity)
        {
            throw new NotImplementedException();
        }

        public override int Update(Proveedor entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(Proveedor entity)
        {
            throw new NotImplementedException();
        }
    }
}
