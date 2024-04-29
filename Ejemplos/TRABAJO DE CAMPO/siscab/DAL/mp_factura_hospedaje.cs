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
    public class mp_factura_hospedaje
    {
        private Acceso ac = new Acceso();
        private mp_cliente cliente = new mp_cliente();
        private mp_factura factura = new mp_factura();
        private mp_estadia estadia = new mp_estadia();

        public List<Factura_Hospedaje> Listar()
        {
            List<Cliente> clientes = cliente.ListarTodos();
            List<Factura> facturasReservas = factura.Listar();
            List<Estadia> estadias = estadia.Listar();

            List<Factura_Hospedaje> facturasHospedaje = new List<Factura_Hospedaje>();

            ac.Abrir();
            DataTable tabla = ac.Leer("select * from factura_hospedaje");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Factura_Hospedaje fh = new Factura_Hospedaje();

                fh.Id = int.Parse(registro["id"].ToString());
                fh.Numero = registro["numero"].ToString();
                fh.Fecha = DateTime.Parse(registro["fecha"].ToString());
                fh.Lugar = registro["lugar"].ToString();
                fh.FacturaReserva = (from Factura f in facturasReservas
                                     where f.Id == int.Parse(registro["id_factura_reserva"].ToString())
                                     select f).First();
                fh.Estadia = (from Estadia es in estadias
                             where es.Id == int.Parse(registro["id_estadia"].ToString())
                             select es).First();
                fh.Cliente = (from Cliente c in clientes
                              where c.Id == int.Parse(registro["id_cliente"].ToString())
                              select c).First();                
                               
                fh.TotalPagar = float.Parse(registro["total_pagar"].ToString());
                fh.Deposito = float.Parse(registro["deposito"].ToString());
                fh.TotalEstadia = float.Parse(registro["total_estadia"].ToString());

                fh.Estado = (EnumEstadoPago)Enum.Parse(typeof(EnumEstadoPago), registro["estado"].ToString());

                facturasHospedaje.Add(fh);
            }
            return facturasHospedaje;
        }

        public int Insertar(Factura_Hospedaje fh)
        {
            string sql = "Select isnull(max(id),0) + 1 from factura_hospedaje";
            ac.Abrir();
            fh.Id = ac.DevolverEscalar(sql);
            
            sql = "Insert into factura_hospedaje (id, numero, fecha, lugar, id_factura_reserva, id_estadia, id_cliente, total_pagar, deposito, total_estadia, estado)" +
                  " values (@i, @n, @f, @l, @if, @ie, @ic, @tp, @d, @te, @es)";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", fh.Id));
            parametros.Add(ac.CrearParametro("@n", fh.Numero));
            parametros.Add(ac.CrearParametro("@f", fh.Fecha));        
            parametros.Add(ac.CrearParametro("@l", fh.Lugar));
            parametros.Add(ac.CrearParametro("@if", fh.FacturaReserva.Id));
            parametros.Add(ac.CrearParametro("@ie", fh.Estadia.Id));
            parametros.Add(ac.CrearParametro("@ic", fh.Cliente.Id));
            parametros.Add(ac.CrearParametro("@tp", fh.TotalPagar));
            parametros.Add(ac.CrearParametro("@d", fh.Deposito));
            parametros.Add(ac.CrearParametro("@te", fh.TotalEstadia));
            parametros.Add(ac.CrearParametro("@es", fh.Estado.ToString()));

            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }

        public int Modificar(Factura_Hospedaje fh)
        {
            string sql = "Update factura_hospedaje set numero = @n, fecha = @f, lugar = @l, id_factura_reserva = @if, id_estadia = @ie, id_cliente = @ic, total_pagar = @tp, deposito = @d, total_estadia =@te, estado = @es where id = @i";
            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", fh.Id));
            parametros.Add(ac.CrearParametro("@n", fh.Numero));
            parametros.Add(ac.CrearParametro("@f", fh.Fecha));
            parametros.Add(ac.CrearParametro("@l", fh.Lugar));
            parametros.Add(ac.CrearParametro("@if", fh.FacturaReserva.Id));
            parametros.Add(ac.CrearParametro("@ie", fh.Estadia.Id));
            parametros.Add(ac.CrearParametro("@ic", fh.Cliente.Id));
            parametros.Add(ac.CrearParametro("@tp", fh.TotalPagar));
            parametros.Add(ac.CrearParametro("@d", fh.Deposito));
            parametros.Add(ac.CrearParametro("@te", fh.TotalEstadia));
            parametros.Add(ac.CrearParametro("@es", fh.Estado.ToString()));

            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }




    }
}
