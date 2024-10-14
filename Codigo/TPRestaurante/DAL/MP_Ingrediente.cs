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
    public class MP_Ingrediente: Mapper<Ingrediente>
    {
        public override Ingrediente GetById(object id)
        {
            int codigo = int.Parse(id.ToString());
            return GetAll().FirstOrDefault(i => i.CodIngrediente.Equals(codigo));
        }

        public override Ingrediente Transform(DataRow dr)
        {
            string nombre = dr["NOMBRE"].ToString();
            int cantidad = int.Parse(dr["CANTIDAD_ACTUAL"].ToString());
            Ingrediente ingrediente = new Ingrediente(nombre, cantidad);
            ingrediente.CodIngrediente = int.Parse(dr["COD_INGREDIENTE"].ToString());
            ingrediente.CostoReferencial = float.Parse(dr["COSTO_REFERENCIAL"].ToString());
            ingrediente.StockMin = int.Parse(dr["STOCK_MINIMO"].ToString());
            ingrediente.StockMax = int.Parse(dr["STOCK_MAXIMO"].ToString());
            return ingrediente;

        }

        public override List<Ingrediente> GetAll()
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            access.Open();
            DataTable dt = access.Read("LISTAR_INGREDIENTE");
            access.Close();

            foreach (DataRow dr in dt.Rows)
            {
                ingredientes.Add(Transform(dr));
            }


            return ingredientes;
        }


        public List<Ingrediente> GetIngredientsByProduct(int productId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@cod", productId),
            };

            access.Open();
            DataTable dt = access.Read("LISTAR_INGREDIENTE_POR_PRODUCTO", parameters);
            access.Close();

            List<Ingrediente> ingredientes = new List<Ingrediente>();


            foreach (DataRow dr in dt.Rows)
            {
                ingredientes.Add(Transform(dr));
            }


            return ingredientes;




        }


        public override int Insert(Ingrediente entity)
        {
            throw new NotImplementedException();
        }

        public override int Update(Ingrediente entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@cod", entity.CodIngrediente),
                access.CreateParameter("@cant", entity.Cantidad),
            };

            access.Open();
            int filasAfectadas = access.Write("ACTUALIZAR_STOCK_INGREDIENTE", parameters);
            access.Close();

            return filasAfectadas;
        }

        public override int Delete(Ingrediente entity)
        {
            throw new NotImplementedException();
        }

        public MP_Ingrediente(Access access) : base(access)
        {
        }
    }
}
