using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class mp_tipo_habitacion
    {
    private Acceso ac = new Acceso();

        public List<BE.Tipo_Habitacion> Listar()
        {
            List<BE.Tipo_Habitacion> tipo_habitaciones = new List<BE.Tipo_Habitacion>();
            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from tipo_habitacion");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Tipo_Habitacion tipo_habitacion = new BE.Tipo_Habitacion();
                tipo_habitacion.Id = int.Parse(registro["id"].ToString());
                tipo_habitacion.Nombre = registro["nombre"].ToString();
                tipo_habitacion.Precio = float.Parse(registro["precio"].ToString());
                tipo_habitacion.Huespedes_Maximo = int.Parse(registro["huespedes_maximo"].ToString());               
                tipo_habitaciones.Add(tipo_habitacion);
            }
            return tipo_habitaciones;
        }

        
        public int Modificar(BE.Tipo_Habitacion tipo_Habitacion)
        {
            string sql = "Update tipo_habitacion set nombre = @n, precio = @p, huespedes_maximo = @hm where id = @i ";
            ac.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", tipo_Habitacion.Id));
            parametros.Add(ac.CrearParametro("@n", tipo_Habitacion.Nombre));
            parametros.Add(ac.CrearParametro("@p", tipo_Habitacion.Precio));
            parametros.Add(ac.CrearParametro("@hm", tipo_Habitacion.Huespedes_Maximo));
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }



    }
}
