using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Multiidioma
{
    public class Traductor
    {
        public static IIdioma ObtenerIdiomaDefault()
        {
            return ObtenerIdiomas().Where(i => i.Default).FirstOrDefault();
        }

        public static IList<IIdioma> ObtenerIdiomas()
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.InitialCatalog = "TpRESTAURANTE";
            cs.DataSource = "DESKTOP-DAN";
            cs.IntegratedSecurity = true;

            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = cs.ConnectionString;
            IDataReader reader = null;
            IList<IIdioma> _idiomas = new List<IIdioma>();
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = "select * from IDIOMA";


                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    _idiomas.Add(
                     new Idioma()
                     {
                         Id = int.Parse(reader["ID"].ToString()),
                         Nombre = reader["IDIOMA"].ToString(),
                         Default = bool.Parse(reader["PREESTABLECIDO"].ToString())

                     });
                }
                return _idiomas;

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (sql != null)
                    sql.Close();


            }
        }

        public static IDictionary<string, ITraduccion> ObtenerTraducciones(IIdioma pIdioma = null)
        {
            //si no hay idioma definido, traigo el idioma por default
            if (pIdioma == null)
            {
                pIdioma = ObtenerIdiomaDefault();
            }




            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.InitialCatalog = "TpRESTAURANTE";
            cs.DataSource = "DESKTOP-DAN";
            cs.IntegratedSecurity = true;

            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = cs.ConnectionString;
            IDataReader reader = null;
            IDictionary<string, ITraduccion> _traducciones = new Dictionary<string, ITraduccion>();
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = "SELECT t.ID_IDIOMA,   t.TRADUCCION AS traduccion_traduccion,    e.ID AS id_etiqueta,   e.NOMBRE AS nombre_etiqueta FROM    TRADUCCION t INNER JOIN ETIQUETA e ON t.ID_ETIQUETA = e.ID WHERE     t.ID_IDIOMA = @id_idioma;";
                cmd.Parameters.AddWithValue("id_idioma", pIdioma.Id);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var etiqueta = reader["nombre_etiqueta"].ToString();
                    _traducciones.Add(etiqueta,
                     new Traduccion()
                     {
                         idioma = pIdioma,
                         Texto = reader["traduccion_traduccion"].ToString(),

                         Etiqueta = new Etiqueta()
                         {
                             Id = int.Parse(reader["id_etiqueta"].ToString()),
                             Nombre = etiqueta
                         }

                     });
                }
                return _traducciones;

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (sql != null)
                    sql.Close();


            }



        }
    }
}
