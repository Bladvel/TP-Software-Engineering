using BE;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mp_clienteBitacora
    {

        private Acceso ac = new Acceso();
        private mp_cliente cliente = new mp_cliente();
        private mp_usuario usuario =new mp_usuario();

        public List<ClienteBitacora> Listar()
        {
            List<Cliente> clientes = cliente.ListarTodos();
            List<Usuario> usuarios = usuario.ListarTotal();
            List<ClienteBitacora> registrosClientesBit = new List<ClienteBitacora>();

            ac.Abrir();
            DataTable tabla = ac.Leer("select * from cliente_bitacora");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                ClienteBitacora clienteBit = new ClienteBitacora();
                clienteBit.Id = int.Parse(registro["id"].ToString());
                clienteBit.UltimaModificacion = DateTime.Parse(registro["ultima_modificacion"].ToString());
                clienteBit.Activo = int.Parse(registro["activo"].ToString());
                clienteBit.Tipo = registro["tipo"].ToString();
                clienteBit.Usuario = (from Usuario u in usuarios
                                     where u.Id == int.Parse(registro["id_usuario"].ToString())
                                     select u).First();
                clienteBit.Cliente = (from Cliente c in clientes
                                      where c.Id == int.Parse(registro["id_cliente"].ToString())
                                      select c).First();
                
                clienteBit.Nombre = registro["nombre"].ToString();
                clienteBit.Apellido = registro["apellido"].ToString();
                clienteBit.Dni = int.Parse(registro["dni"].ToString());
                clienteBit.Telefono_Fijo = registro["telefono_fijo"].ToString();
                clienteBit.Telefono_Movil = registro["telefono_movil"].ToString();
                clienteBit.Email = registro["email"].ToString();
                clienteBit.Domicilio = registro["domicilio"].ToString();
                clienteBit.Borrado = int.Parse(registro["borrado"].ToString());


                registrosClientesBit.Add(clienteBit);
            }
            return registrosClientesBit;
        }

        public int Insertar (Servicios.ClienteBitacora clienteBit)
        {
            string sql = "Select isnull(max(id),0) + 1 from cliente_bitacora";
            ac.Abrir();
            clienteBit.Id = ac.DevolverEscalar(sql);


            sql = "Insert into cliente_bitacora (id, ultima_modificacion, activo, tipo, id_usuario, id_cliente, nombre, apellido, dni, telefono_fijo, telefono_movil, email, domicilio, borrado)" +
                  " values (@i, @um, @a, @t, @iu, @ic, @nc, @ac, @dc, @tfc, @tmc, @ec, @dom, @bc)";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", clienteBit.Id));
            parametros.Add(ac.CrearParametro("@um", clienteBit.UltimaModificacion));
            parametros.Add(ac.CrearParametro("@a", clienteBit.Activo));
            parametros.Add(ac.CrearParametro("@t", clienteBit.Tipo));
            parametros.Add(ac.CrearParametro("@iu", clienteBit.Usuario.Id));
            parametros.Add(ac.CrearParametro("@ic", clienteBit.Cliente.Id));
            parametros.Add(ac.CrearParametro("@nc", clienteBit.Cliente.Nombre));            
            parametros.Add(ac.CrearParametro("@ac", clienteBit.Cliente.Apellido));
            parametros.Add(ac.CrearParametro("@dc", clienteBit.Cliente.Dni));
            parametros.Add(ac.CrearParametro("@tfc", clienteBit.Cliente.Telefono_Fijo));
            parametros.Add(ac.CrearParametro("@tmc", clienteBit.Cliente.Telefono_Movil));
            parametros.Add(ac.CrearParametro("@ec", clienteBit.Cliente.Email));
            parametros.Add(ac.CrearParametro("@dom", clienteBit.Cliente.Domicilio));
            parametros.Add(ac.CrearParametro("@bc", clienteBit.Cliente.Borrado));

            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }

       

        public int Desactivar(ClienteBitacora clienteBit)
        {
            string sql = "Update cliente_bitacora set activo = 0 where id =@i";
            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", clienteBit.Id));                                 
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }

        public int Reactivar(ClienteBitacora clienteBit)
        {
            string sql = "Update cliente_bitacora set activo = 1 where id =@i";
            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", clienteBit.Id));                       
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }






    }
}
