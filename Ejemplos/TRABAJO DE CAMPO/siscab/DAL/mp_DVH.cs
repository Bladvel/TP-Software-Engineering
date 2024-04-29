using BE;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mp_DVH
    {
        private Acceso ac = new Acceso();

        public List<DVH> Listar()
        {
            List<DVH> dVHs= new List<DVH>();
            ac.Abrir();
            DataTable tabla = ac.Leer("select * from DVH");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                DVH dvh = new DVH();
                dvh.Modulo = registro["modulo"].ToString();
                dvh.Registro = int.Parse(registro["registro"].ToString());
                
                // probar si necesito algo mayor que un string
                dvh.DV = registro["dv"].ToString();
                dVHs.Add(dvh);
            }

            return dVHs;
        }

        public int Insertar(DVH dvh)
        {
           
            ac.Abrir();          
            string sql = "Insert into DVH (modulo, registro, dv) values (@m, @r, @d)";
                 
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@m", dvh.Modulo));
            parametros.Add(ac.CrearParametro("@r", dvh.Registro));
            parametros.Add(ac.CrearParametro("@d", dvh.DV));     
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;

        }

        public int Modificar (DVH dvh)
        {
            string sql = "Update DVH set dv = @d where modulo = @m and registro = @r";

            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@d", dvh.DV));
            parametros.Add(ac.CrearParametro("@m", dvh.Modulo));
            parametros.Add(ac.CrearParametro("@r", dvh.Registro));
           
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;

        }

        public int BorrarRegistros()
        {
            string sql = "Delete DVH";

            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();            
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;

        }

    }
}
