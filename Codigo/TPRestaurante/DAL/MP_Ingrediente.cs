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
            throw new NotImplementedException();
        }

        public override Ingrediente Transform(DataRow dr)
        {
            string nombre = dr["NOMBRE"].ToString();
            int cantidad = int.Parse(dr["CANTIDAD"].ToString());
            Ingrediente ingrediente = new Ingrediente(nombre, cantidad);
            ingrediente.CodIngrediente = int.Parse(dr["COD_INGREDIENTE"].ToString());

            return ingrediente;

        }

        public override List<Ingrediente> GetAll()
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            access.Open();
            DataTable dt = access.Read("LISTAR_INGREDIENTES");
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
            throw new NotImplementedException();
        }

        public override int Delete(Ingrediente entity)
        {
            throw new NotImplementedException();
        }
    }
}
