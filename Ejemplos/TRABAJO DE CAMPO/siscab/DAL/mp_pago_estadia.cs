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
    public class mp_pago_estadia
    {
        private Acceso ac = new Acceso();

        private mp_procesador_pago procesador = new mp_procesador_pago();
        private mp_tipo_tarjeta tipotarjeta = new mp_tipo_tarjeta();
        private mp_factura_hospedaje facturaHospedaje = new mp_factura_hospedaje();
        private mp_banco banco = new mp_banco();

        public List<Pago_Estadia> Listar()
        {
            List<Pago_Estadia> pagos = new List<Pago_Estadia>();
                     
            List<Factura_Hospedaje> facturas = facturaHospedaje.Listar();            
            List<BE.Procesador_Pago> procesadores = procesador.Listar();
            List<BE.Tipo_Tarjeta> tipos = tipotarjeta.Listar();
            List<BE.Banco> bancos = banco.Listar();

            ac.Abrir();
            DataTable tabla = ac.Leer("select * from pago_estadia");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Pago_Estadia p = new Pago_Estadia();
                p.Id = int.Parse(registro["id"].ToString());
                p.Tipo = (from Tipo_Tarjeta t in tipos
                          where t.Id == int.Parse(registro["id_tipo_tarjeta"].ToString())
                          select t).First();
                p.Procesador = (from Procesador_Pago pp in procesadores
                                where pp.Id == int.Parse(registro["id_procesador_pago"].ToString())
                                select pp).First();
                p.Banco = (from Banco b in bancos
                           where b.Id == int.Parse(registro["id_banco"].ToString())
                           select b).First();
                p.Numero = int.Parse(registro["numero"].ToString());
                p.Codigo = int.Parse(registro["codigo"].ToString());
                p.Vencimiento = DateTime.Parse(registro["vencimiento"].ToString());
                p.FacturaHospedaje = (from Factura_Hospedaje f in facturas
                             where f.Id == int.Parse(registro["id_factura_hospedaje"].ToString())
                             select f).First();
                p.Cuotas = int.Parse(registro["cuotas"].ToString());

                pagos.Add(p);
            }

            return pagos;

        }

        public int Insertar(Pago_Estadia pago)
        {
            string sql = "Select isnull(max(id),0) + 1 from pago_estadia";
            ac.Abrir();
            pago.Id = ac.DevolverEscalar(sql);

            sql = "Insert into pago_estadia (id, id_tipo_tarjeta, id_procesador_pago, id_banco, numero, codigo, vencimiento," +
                  "id_factura_hospedaje, cuotas) values (@i, @it, @ip, @ib, @n, @c, @v, @ifh, @cu)";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", pago.Id));
            parametros.Add(ac.CrearParametro("@it", pago.Tipo.Id));
            parametros.Add(ac.CrearParametro("@ip", pago.Procesador.Id));
            parametros.Add(ac.CrearParametro("@ib", pago.Banco.Id));
            parametros.Add(ac.CrearParametro("@n", pago.Numero));
            parametros.Add(ac.CrearParametro("@c", pago.Codigo));
            parametros.Add(ac.CrearParametro("@v", pago.Vencimiento));
            parametros.Add(ac.CrearParametro("@ifh", pago.FacturaHospedaje.Id));
            parametros.Add(ac.CrearParametro("@cu", pago.Cuotas));
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }







    }
}
