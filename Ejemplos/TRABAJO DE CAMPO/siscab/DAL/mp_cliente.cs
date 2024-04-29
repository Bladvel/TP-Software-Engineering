using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class mp_cliente
    {
        private Acceso ac = new Acceso();

        public List<BE.Cliente> ListarTodos()
        {
            List<BE.Cliente> clientes = new List<BE.Cliente>();
            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from cliente");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Cliente cliente = new BE.Cliente();
                cliente.Id = int.Parse(registro["id"].ToString());
                cliente.Nombre = registro["nombre"].ToString();
                cliente.Apellido = registro["apellido"].ToString();
                cliente.Dni = int.Parse(registro["dni"].ToString());
                cliente.Telefono_Fijo = registro["telefono_fijo"].ToString();
                cliente.Telefono_Movil = registro["telefono_movil"].ToString();
                cliente.Domicilio = registro["domicilio"].ToString();
                cliente.Email = registro["email"].ToString();
                cliente.Borrado = int.Parse(registro["borrado"].ToString());

                clientes.Add(cliente);

            }
            return clientes;
        }


        public List<BE.Cliente> ListarActivos()
        {
            List<BE.Cliente> clientes = new List<BE.Cliente>();
            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from cliente where borrado = 0");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Cliente cliente = new BE.Cliente();
                cliente.Id = int.Parse(registro["id"].ToString());
                cliente.Nombre = registro["nombre"].ToString();
                cliente.Apellido = registro["apellido"].ToString();
                cliente.Dni = int.Parse(registro["dni"].ToString());
                cliente.Telefono_Fijo = registro["telefono_fijo"].ToString();
                cliente.Telefono_Movil = registro["telefono_movil"].ToString();
                cliente.Domicilio = registro["domicilio"].ToString();
                cliente.Email = registro["email"].ToString();
                cliente.Borrado = int.Parse(registro["borrado"].ToString());
                
                clientes.Add(cliente);

            }
            return clientes;
        }

        public List<BE.Cliente> ListarBorrados()
        {
            List<BE.Cliente> clientes = new List<BE.Cliente>();
            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from cliente where borrado = 1");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Cliente cliente = new BE.Cliente();
                cliente.Id = int.Parse(registro["id"].ToString());
                cliente.Nombre = registro["nombre"].ToString();
                cliente.Apellido = registro["apellido"].ToString();
                cliente.Dni = int.Parse(registro["dni"].ToString());
                cliente.Telefono_Fijo = registro["telefono_fijo"].ToString();
                cliente.Telefono_Movil = registro["telefono_movil"].ToString();
                cliente.Domicilio = registro["domicilio"].ToString();
                cliente.Email = registro["email"].ToString();
                cliente.Borrado = int.Parse(registro["borrado"].ToString());

                clientes.Add(cliente);

            }
            return clientes;
        }



        public int Insertar(BE.Cliente cliente)
        {
            string sql = "Select isnull(max(id),0) + 1 from cliente";
            ac.Abrir();
            cliente.Id = ac.DevolverEscalar(sql);
            sql = "Insert into cliente (id, nombre, apellido, dni, telefono_fijo, telefono_movil, domicilio, email, borrado) values" +
                "(@i, @n, @a, @d, @tf, @tm, @dom, @e, 0)";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", cliente.Id));
            parametros.Add(ac.CrearParametro("@n", cliente.Nombre));
            parametros.Add(ac.CrearParametro("@a", cliente.Apellido));
            parametros.Add(ac.CrearParametro("@d", cliente.Dni));
            parametros.Add(ac.CrearParametro("@tf", cliente.Telefono_Fijo));
            parametros.Add(ac.CrearParametro("tm", cliente.Telefono_Movil));
            parametros.Add(ac.CrearParametro("@dom", cliente.Domicilio));
            parametros.Add(ac.CrearParametro("@e", cliente.Email));
            //parametros.Add(ac.CrearParametro("@in", cliente.Borrado));

            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }

        public int Modificar(BE.Cliente cliente)
        {
            string sql = "Update cliente set nombre = @no, apellido = @a, dni = @d, telefono_fijo = @tf, telefono_movil = @tm, " +
                "domicilio = @dom, email = @e, borrado = @b where id = @i";
            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", cliente.Id));
            parametros.Add(ac.CrearParametro("@no", cliente.Nombre));
            parametros.Add(ac.CrearParametro("@a", cliente.Apellido));
            parametros.Add(ac.CrearParametro("@d", cliente.Dni));
            parametros.Add(ac.CrearParametro("@tf", cliente.Telefono_Fijo));
            parametros.Add(ac.CrearParametro("@tm", cliente.Telefono_Movil));
            parametros.Add(ac.CrearParametro("@dom", cliente.Domicilio));
            parametros.Add(ac.CrearParametro("@e", cliente.Email));
            parametros.Add(ac.CrearParametro("@b", cliente.Borrado));
           
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }

    }
}
