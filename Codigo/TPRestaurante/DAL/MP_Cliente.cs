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
    public class MP_Cliente: Mapper<Cliente>
    {
        public override Cliente GetById(object id)
        {
            int ID = int.Parse(id.ToString());
            return GetAll().FirstOrDefault(c => c.ID.Equals(ID));
        }

        public override Cliente Transform(DataRow dr)
        {

            string nombre = dr["NOMBRE"].ToString();
            string apellido = dr["APELLIDO"].ToString();
            int dni = int.Parse(dr["DNI"].ToString());
            string tel = dr["TELEFONO"].ToString();

            Cliente cliente = new Cliente(nombre, apellido, dni, tel);
            cliente.ID = int.Parse(dr["ID"].ToString());
            cliente.Activo = bool.Parse(dr["ACTIVO"].ToString());

            return cliente;

        }

        public override List<Cliente> GetAll()
        {
            List<Cliente> clientes = new List<Cliente>();
            access.Open();
            DataTable dt = access.Read("LISTAR_CLIENTE");
            access.Close();

            foreach (DataRow dr in dt.Rows)
            {
                clientes.Add(Transform(dr));
            }



            return clientes;
        }



        //Insertar con scalar
        public override int Insert(Cliente entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nom", entity.Nombre),
                access.CreateParameter("@ape", entity.Apellido),
                access.CreateParameter("@dni", entity.DNI),
                access.CreateParameter("@tel", entity.Telefono)
            };

            access.Open();
            int id = access.WriteScalar("INSERTAR_CLIENTE", parameters);
            access.Close();
            return id;
        }

        public override int Update(Cliente entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@id", entity.ID),
                access.CreateParameter("@telefono", entity.Telefono),
                access.CreateParameter("@dni", entity.DNI),
                access.CreateParameter("@nombre", entity.Nombre),
                access.CreateParameter("@apellido", entity.Apellido),
                
            };

            access.Open();
            int filasAfectadas = access.Write("ACTUALIZAR_CLIENTE", parameters);
            access.Close();

            return filasAfectadas;
        }

        public override int Delete(Cliente entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@id", entity.ID),
            };

            access.Open();
            int filasAfectadas = access.Write("ELIMINAR_CLIENTE", parameters);
            access.Close();

            return filasAfectadas;
        }

        public MP_Cliente(Access access) : base(access)
        {
        }
    }
}
