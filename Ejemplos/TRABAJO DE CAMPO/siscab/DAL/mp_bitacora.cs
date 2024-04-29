using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;
using System.Security.Cryptography;

namespace DAL
{
    public class mp_bitacora
    {
        private Acceso ac = new Acceso();
        private mp_usuario mapperUsuario = new mp_usuario();
        public List<Bitacora> Listar()
        {
            List<Usuario> usuarios = mapperUsuario.ListarTotal();
            List<Bitacora> listabitacora = new List<Bitacora>();

            ac.Abrir();
            DataTable tabla = ac.Leer("select * from bitacora");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Bitacora bitacora = new Bitacora();
                bitacora.Id = int.Parse(registro["id"].ToString());
                bitacora.Fecha = DateTime.Parse(registro["fecha"].ToString());                
                bitacora.Usuario = (from Usuario us in usuarios
                                   where us.Id == int.Parse(registro["id_usuario"].ToString())
                                   select us).First();
                
                bitacora.Modulo = (EnumModulo)Enum.Parse(typeof(EnumModulo), registro["modulo"].ToString());
                bitacora.Operacion = (EnumOperacion)Enum.Parse(typeof(EnumOperacion), registro["operacion"].ToString());                
                bitacora.Criticidad = int.Parse(registro["criticidad"].ToString());
                listabitacora.Add(bitacora);
            }

            return listabitacora;

        }

        public List<Bitacora> FiltrarBitacora(DateTime fi, DateTime ff)
        {
            List<Usuario> usuarios = mapperUsuario.ListarTotal();
            List<Bitacora> listabitacora = new List<Bitacora>();

            ac.Abrir();
            DataTable tabla = ac.Leer("select * from bitacora where fecha between '" + fi + "' and '" + ff +"'");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Bitacora bitacora = new Bitacora();
                bitacora.Id = int.Parse(registro["id"].ToString());
                bitacora.Fecha = DateTime.Parse(registro["fecha"].ToString());
                bitacora.Usuario = (from Usuario us in usuarios
                                    where us.Id == int.Parse(registro["id_usuario"].ToString())
                                    select us).First();

                bitacora.Modulo = (EnumModulo)Enum.Parse(typeof(EnumModulo), registro["modulo"].ToString());
                bitacora.Operacion = (EnumOperacion)Enum.Parse(typeof(EnumOperacion), registro["operacion"].ToString());
                bitacora.Criticidad = int.Parse(registro["criticidad"].ToString());
                listabitacora.Add(bitacora);
            }

            return listabitacora;

        }



        public int Insertar (Bitacora bitacora)
        {
            string sql = "Select isnull(max(id),0) + 1 from bitacora";
            ac.Abrir();
            bitacora.Id = ac.DevolverEscalar(sql);
            sql = "Insert into bitacora (id, fecha, id_usuario, modulo, operacion, criticidad) values" +
                "(@i, @f, @u, @m, @o, @c)";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", bitacora.Id));
            parametros.Add(ac.CrearParametro("@f", bitacora.Fecha));
            parametros.Add(ac.CrearParametro("@u", bitacora.Usuario.Id));
            parametros.Add(ac.CrearParametro("@m", bitacora.Modulo.ToString()));
            parametros.Add(ac.CrearParametro("@o", bitacora.Operacion.ToString()));
            parametros.Add(ac.CrearParametro("@c", bitacora.Criticidad));

            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;

        }
    }
}
