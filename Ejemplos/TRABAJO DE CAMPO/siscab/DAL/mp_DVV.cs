using Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mp_DVV
    {
        private Acceso ac = new Acceso();

        public List<DVV> Listar()
        {
            List<DVV> dVVs = new List<DVV>();
            ac.Abrir();
            DataTable tabla = ac.Leer("select * from DVV");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                DVV dvv = new DVV();
                dvv.Modulo = registro["modulo"].ToString();
                dvv.Columna = int.Parse(registro["columna"].ToString());               
                dvv.DV = registro["dv"].ToString();
                dVVs.Add(dvv);
            }
            return dVVs;
        }

        public int Insertar(DVV dvv)
        {
            ac.Abrir();
            string sql = "Insert into DVV (modulo, columna, dv) values (@m, @c, @d)";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@m", dvv.Modulo));
            parametros.Add(ac.CrearParametro("@c", dvv.Columna));
            parametros.Add(ac.CrearParametro("@d", dvv.DV));
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }

        public int Modificar(DVV dvv)
        {
            string sql = "Update DVV set dv = @d where modulo = @m and columna = @c";

            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();            
            parametros.Add(ac.CrearParametro("@m", dvv.Modulo));
            parametros.Add(ac.CrearParametro("@c", dvv.Columna));
            parametros.Add(ac.CrearParametro("@d", dvv.DV));

            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;

        }





    }
}
