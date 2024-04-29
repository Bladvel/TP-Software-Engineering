using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;
using BE;

namespace DAL
{
    public class mp_habitacion
    {
     private Acceso ac = new Acceso();
     private mp_tipo_habitacion tipo_habitacion = new mp_tipo_habitacion();
        public List<BE.Habitacion> ListarTotal()
        {
            List<BE.Tipo_Habitacion> tipo_habitaciones = tipo_habitacion.Listar();
            List<BE.Habitacion> habitaciones = new List<BE.Habitacion>();
            
            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from habitacion");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Habitacion habitacion = new BE.Habitacion();               
                habitacion.Id = int.Parse(registro["id"].ToString());
                habitacion.Numero = int.Parse(registro["numero"].ToString());
                habitacion.Tipo = (from Tipo_Habitacion th in tipo_habitaciones
                                  where th.Id == int.Parse(registro["id_tipo_habitacion"].ToString())
                                  select th).First();
                habitaciones.Add(habitacion);
                
            }
            return habitaciones;
        }

        public List<BE.Habitacion> ListarSimples()
        {
            List<BE.Tipo_Habitacion> tipo_habitaciones = tipo_habitacion.Listar();
            List<BE.Habitacion> habitaciones = new List<BE.Habitacion>();

            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from habitacion where id_tipo_habitacion = 1");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Habitacion habitacion = new BE.Habitacion();
                habitacion.Id = int.Parse(registro["id"].ToString());
                habitacion.Numero = int.Parse(registro["numero"].ToString());
                habitacion.Tipo = (from Tipo_Habitacion th in tipo_habitaciones
                                   where th.Id == int.Parse(registro["id_tipo_habitacion"].ToString())
                                   select th).First();
                habitaciones.Add(habitacion);

            }
            return habitaciones;
        }
        public List<BE.Habitacion> ListarDobles()
        {
            List<BE.Tipo_Habitacion> tipo_habitaciones = tipo_habitacion.Listar();
            List<BE.Habitacion> habitaciones = new List<BE.Habitacion>();

            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from habitacion where id_tipo_habitacion = 2");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Habitacion habitacion = new BE.Habitacion();
                habitacion.Id = int.Parse(registro["id"].ToString());
                habitacion.Numero = int.Parse(registro["numero"].ToString());
                habitacion.Tipo = (from Tipo_Habitacion th in tipo_habitaciones
                                   where th.Id == int.Parse(registro["id_tipo_habitacion"].ToString())
                                   select th).First();
                habitaciones.Add(habitacion);

            }
            return habitaciones;
        }

        public List<BE.Habitacion> ListarTriples()
        {
            List<BE.Tipo_Habitacion> tipo_habitaciones = tipo_habitacion.Listar();
            List<BE.Habitacion> habitaciones = new List<BE.Habitacion>();

            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from habitacion where id_tipo_habitacion = 3");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Habitacion habitacion = new BE.Habitacion();
                habitacion.Id = int.Parse(registro["id"].ToString());
                habitacion.Numero = int.Parse(registro["numero"].ToString());
                habitacion.Tipo = (from Tipo_Habitacion th in tipo_habitaciones
                                   where th.Id == int.Parse(registro["id_tipo_habitacion"].ToString())
                                   select th).First();
                habitaciones.Add(habitacion);

            }
            return habitaciones;
        }

        public List<BE.Habitacion> ListarCuadruples()
        {
            List<BE.Tipo_Habitacion> tipo_habitaciones = tipo_habitacion.Listar();
            List<BE.Habitacion> habitaciones = new List<BE.Habitacion>();

            ac.Abrir();
            DataTable tabla = ac.Leer("Select * from habitacion where id_tipo_habitacion = 4");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Habitacion habitacion = new BE.Habitacion();
                habitacion.Id = int.Parse(registro["id"].ToString());
                habitacion.Numero = int.Parse(registro["numero"].ToString());
                habitacion.Tipo = (from Tipo_Habitacion th in tipo_habitaciones
                                   where th.Id == int.Parse(registro["id_tipo_habitacion"].ToString())
                                   select th).First();
                habitaciones.Add(habitacion);

            }
            return habitaciones;
        }



        public int Insertar(BE.Habitacion habitacion)
        {
            string sql = "Select isnull(max(id),0) + 1 from habitacion";
            ac.Abrir();
            habitacion.Id = ac.DevolverEscalar(sql);
            sql = "Insert into habitacion (id, numero, id_tipo_habitacion) values" +
                "(@i, @n, @th)";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@i", habitacion.Id));
            parametros.Add(ac.CrearParametro("@n", habitacion.Numero));
            parametros.Add(ac.CrearParametro("@a", habitacion.Tipo.Id));          
            int resultado = ac.Escribir(sql, parametros);
            ac.Cerrar();
            return resultado;
        }


    }
}
