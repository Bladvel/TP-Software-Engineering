using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mp_reserva
    {
        private Acceso ac = new Acceso();

        private mp_cliente cliente = new mp_cliente();  
        private mp_habitacion habitacion = new mp_habitacion();

        public List<BE.Reserva> Listar()
        {
            List<BE.Cliente> clientes = cliente.ListarTodos();
            List<BE.Habitacion> habitaciones = habitacion.ListarTotal();
            List<BE.Reserva> reservas = new List<BE.Reserva>();

            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from reserva");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Reserva reserva = new BE.Reserva();
                reserva.Id = int.Parse(registro["id"].ToString());
                reserva.Fecha_Inicio = DateTime.Parse(registro["fecha_inicio"].ToString());
                reserva.Fecha_Fin = DateTime.Parse(registro["fecha_fin"].ToString());
                reserva.Cliente = (from Cliente c in clientes
                                  where c.Id == int.Parse(registro["id_cliente"].ToString())
                                  select c).First();
                reserva.Cantidad_Huespedes = int.Parse(registro["cantidad_huespedes"].ToString());
                reserva.Cantidad_Dias = int.Parse(registro["cantidad_dias"].ToString());
                reserva.Habitacion = (from Habitacion h in habitaciones
                                      where h.Id == int.Parse(registro["id_habitacion"].ToString())
                                      select h).First();
                reserva.Facturada = registro["facturada"].ToString();
                reservas.Add(reserva);
            }
            return reservas;
        }

        public int Insertar(BE.Reserva reserva)
        {
            string sql = "Select isnull(max(id),0) + 1 from reserva";
            ac.Abrir();
            reserva.Id = ac.DevolverEscalar(sql);
            sql = "Insert into reserva (id, fecha_inicio, fecha_fin, id_cliente, cantidad_huespedes, cantidad_dias," +
                  "id_habitacion,facturada) values (@i, @fi, @ff, @ic, @ch, @cd, @ih,@fa)";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", reserva.Id));
            parametros.Add(ac.CrearParametro("@fi", reserva.Fecha_Inicio));
            parametros.Add(ac.CrearParametro("@ff", reserva.Fecha_Fin));
            parametros.Add(ac.CrearParametro("@ic", reserva.Cliente.Id));
            parametros.Add(ac.CrearParametro("@ch", reserva.Cantidad_Huespedes));
            parametros.Add(ac.CrearParametro("@cd", reserva.Cantidad_Dias));
            parametros.Add(ac.CrearParametro("@ih", reserva.Habitacion.Id));
            parametros.Add(ac.CrearParametro("@fa", reserva.Facturada));
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }

        public int Modificar (BE.Reserva reserva)
        {
            string sql = "Update reserva set fecha_inicio = @fi, fecha_fin = @ff, id_cliente = @ic, cantidad_huespedes = @ch, cantidad_dias = @cd, " +
               "id_habitacion = @ih, facturada = @fa where id = @i ";
            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", reserva.Id));
            parametros.Add(ac.CrearParametro("@fi", reserva.Fecha_Inicio));
            parametros.Add(ac.CrearParametro("@ff", reserva.Fecha_Fin));
            parametros.Add(ac.CrearParametro("@ic", reserva.Cliente.Id));
            parametros.Add(ac.CrearParametro("@ch", reserva.Cantidad_Huespedes));
            parametros.Add(ac.CrearParametro("@cd", reserva.Cantidad_Dias));
            parametros.Add(ac.CrearParametro("@ih", reserva.Habitacion.Id));
            parametros.Add(ac.CrearParametro("@fa", reserva.Facturada));           

            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }




    }
}
