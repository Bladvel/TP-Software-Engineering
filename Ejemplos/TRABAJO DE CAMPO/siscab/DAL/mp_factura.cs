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
    public class mp_factura
    {
        private Acceso ac = new Acceso();
        private mp_cliente cliente = new mp_cliente();
        private mp_reserva reserva = new mp_reserva();
        public List<BE.Factura> Listar()
        {
            List<BE.Cliente> clientes = cliente.ListarTodos();
            List<BE.Reserva> reservas = reserva.Listar();
            List<BE.Factura> facturas = new List<BE.Factura> ();
            
            ac.Abrir();
            DataTable tabla = ac.Leer("select * from factura");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Factura factura = new BE.Factura();
                factura.Id = int.Parse(registro["id"].ToString());
                factura.Numero = registro["numero"].ToString();
                factura.Cliente = (from Cliente c in clientes
                                   where c.Id == int.Parse(registro["id_cliente"].ToString())
                                   select c).First();
                factura.Fecha = DateTime.Parse(registro["fecha"].ToString());
                factura.Lugar = registro["lugar"].ToString();
                factura.Reserva = (from Reserva r in reservas
                                   where r.Id == int.Parse(registro["id_reserva"].ToString())
                                   select r).First();
                factura.Subtotal = float.Parse(registro["subtotal"].ToString());
                factura.Iva = float.Parse(registro["iva"].ToString());
                factura.Total = float.Parse(registro["total"].ToString());
                factura.Deposito = float.Parse(registro["deposito"].ToString());
                facturas.Add(factura);
            }
            return facturas;
        }


        public int Insertar(BE.Factura factura)
        {
            string sql = "Select isnull(max(id),0) + 1 from factura";
            ac.Abrir();
            factura.Id = ac.DevolverEscalar(sql);
            sql = "Insert into factura (id, numero, id_cliente, fecha, lugar, id_reserva, subtotal, iva, total, deposito)" +
                  " values (@i, @n, @ic, @f, @l, @ir, @s, @iv, @t, @d)";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", factura.Id));
            parametros.Add(ac.CrearParametro("@n", factura.Numero));
            parametros.Add(ac.CrearParametro("@ic", factura.Cliente.Id));
            parametros.Add(ac.CrearParametro("@f", factura.Fecha));
            parametros.Add(ac.CrearParametro("@l", factura.Lugar));
            parametros.Add(ac.CrearParametro("@ir", factura.Reserva.Id));
            parametros.Add(ac.CrearParametro("@s", factura.Subtotal));
            parametros.Add(ac.CrearParametro("@iv", factura.Iva));
            parametros.Add(ac.CrearParametro("@t", factura.Total));
            parametros.Add(ac.CrearParametro("@d", factura.Deposito));
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }

        public int Modificar (BE.Factura factura)
        {
            string sql = "Update factura set numero = @n, id_cliente = @ic, fecha = @f, lugar = @l, id_reserva = @ir, " +
                "subtotal = @s, iva = @iv, total = @t, deposito = #d where id = @i ";
            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", factura.Id));
            parametros.Add(ac.CrearParametro("@n", factura.Numero));
            parametros.Add(ac.CrearParametro("@ic", factura.Cliente.Id));
            parametros.Add(ac.CrearParametro("@f", factura.Fecha));
            parametros.Add(ac.CrearParametro("@l", factura.Lugar));
            parametros.Add(ac.CrearParametro("@ir", factura.Reserva.Id));
            parametros.Add(ac.CrearParametro("@s", factura.Subtotal));
            parametros.Add(ac.CrearParametro("@iv", factura.Iva));
            parametros.Add(ac.CrearParametro("@t", factura.Total));
            parametros.Add(ac.CrearParametro("@d", factura.Deposito));

            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;


        }


    }
}
