using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class MP_PELICULA : MAPPER<BE.PELICULA>
    {
        ACCESO acceso = new ACCESO();
        public override int Borrar(PELICULA obj)
        {
            throw new NotImplementedException();
        }

        public override int Editar(PELICULA obj)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                acceso.CrearParametro("@id",obj.ID),
                acceso.CrearParametro("@nom", obj.Duracion),
                acceso.CrearParametro("@dur",obj.Duracion)
            };

            acceso.Abrir();
            int filasAfectadas = acceso.Escribir("PELICULA_MODIFICAR",parameters);
            acceso.Cerrar();

            return filasAfectadas;

        }

        public override PELICULA Convertir(DataRow dr)
        {
            
            PELICULA  pelicula = new PELICULA();

            pelicula.ID = int.Parse(dr["ID"].ToString());
            pelicula.Nombre = dr["NOMBRE"].ToString();
            pelicula.Duracion = int.Parse(dr["DURACION"].ToString());
             
            return pelicula;
        }

        public override int Insertar(PELICULA pel)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.CrearParametro("@nom", pel.Nombre));
            parameters.Add(acceso.CrearParametro("@dur",pel.Duracion));
            acceso.Abrir();
            int filasAfectadas= acceso.Escribir("PELICULA_ALTA", parameters);
            acceso.Cerrar();
            return filasAfectadas;

        }

        public override List<PELICULA> Listar()
        {
            List<PELICULA> peliculas = new List<PELICULA>();
            
            acceso.Abrir();

            DataTable dt = acceso.Leer("PELICULA_LISTAR");
            acceso.Cerrar();

            foreach(DataRow dataRow in dt.Rows)
            {
                peliculas.Add(Convertir(dataRow));
            }
            
            return peliculas;

        }
    }
}