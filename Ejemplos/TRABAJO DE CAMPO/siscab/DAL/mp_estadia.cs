using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mp_estadia
    {
        private Acceso ac = new Acceso();

        private mp_factura factura = new mp_factura();
        private mp_habitacion habitacion = new mp_habitacion(); 
        private mp_cliente cliente = new mp_cliente();  

        public List<BE.Estadia> Listar()
        {
            List<Factura> facturasReservas = factura.Listar();
            List<Habitacion> habitaciones = habitacion.ListarTotal();
            List<Cliente> clientes = cliente.ListarTodos();
            List<Estadia> estadias= new List<Estadia>();
          
            ac.Abrir();
            DataTable tabla = ac.Leer("select * from estadia");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Estadia estadia = new Estadia();
                
                estadia.Id = int.Parse(registro["id"].ToString());

                estadia.FacturaReserva = (from Factura f in facturasReservas
                                          where f.Id == int.Parse(registro["id_factura"].ToString())
                                          select f).First();

                estadia.Checkin = DateTime.Parse(registro["checkin"].ToString());
                estadia.Checkout = DateTime.Parse(registro["checkout"].ToString());
                               
                estadia.Habitacion = (from Habitacion h in habitaciones
                                     where h.Id == int.Parse(registro["id_habitacion"].ToString())
                                     select h).First();

                estadia.Cliente = (from Cliente c in clientes
                                  where c.Id == int.Parse(registro["id_cliente"].ToString())
                                  select c).First();

                estadia.CantidadHuespedes = int.Parse(registro["cantidad_huespedes"].ToString());

                estadia.Estado = (EnumEstadoEstadia)Enum.Parse(typeof(EnumEstadoEstadia), registro["estado"].ToString());

                estadias.Add(estadia);
            }
            return estadias;
        }


        public int Insertar(Estadia estadia)
        {
            string sql = "Select isnull(max(id),0) + 1 from estadia";
            ac.Abrir();
            estadia.Id = ac.DevolverEscalar(sql);
            sql = "Insert into estadia (id, id_factura, checkin, checkout, id_habitacion, id_cliente, cantidad_huespedes, estado)" +
                  " values (@i, @if, @ci, @co, @ih, @ic, @ch, @e)";
                       
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", estadia.Id));
            parametros.Add(ac.CrearParametro("@if", estadia.FacturaReserva.Id));
            parametros.Add(ac.CrearParametro("@ci", estadia.Checkin));
            parametros.Add(ac.CrearParametro("@co", estadia.Checkout));
            parametros.Add(ac.CrearParametro("@ih", estadia.Habitacion.Id));
            parametros.Add(ac.CrearParametro("@ic", estadia.Cliente.Id));
            parametros.Add(ac.CrearParametro("@ch", estadia.CantidadHuespedes));
            parametros.Add(ac.CrearParametro("@e", estadia.Estado.ToString()));

            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }

        // Continuar con esto y seguir con Checkout
        public int ModificarFechaSalida(Estadia estadia)
        {
            string sql = "Update estadia set checkout = @co, estado = @e where id = @i";
              
            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", estadia.Id));
            parametros.Add(ac.CrearParametro("@co", estadia.Checkout));
            parametros.Add(ac.CrearParametro("ic", estadia.Cliente.Id));
            parametros.Add(ac.CrearParametro("@e", estadia.Estado.ToString()));

            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;

        }

        public int Modificar(Estadia estadia)
        {
            string sql = "Update estadia set checkout = @co, estado = @e where id = @i";

            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", estadia.Id));
            parametros.Add(ac.CrearParametro("@co", estadia.Checkout));
            parametros.Add(ac.CrearParametro("ic", estadia.Cliente.Id));
            parametros.Add(ac.CrearParametro("@e", estadia.Estado.ToString()));

            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;

        }

    }
}
