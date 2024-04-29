using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Servicios.Multiidioma
{
    public class Traductor
    {
        //esta capa podria estar separada en BLL de  servicios y Repo de servicios
        public static IIdioma ObtenerIdiomaDefault()
        {
            return ObtenerIdiomas().Where(i => i.Default).FirstOrDefault();
        }

        public static IList<IIdioma> ObtenerIdiomas()
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.InitialCatalog = "SISCAB";
            cs.DataSource = "DESKTOP-I7LNRPI";
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
                //cmd.CommandText = "select * from idiomas";
                cmd.CommandText = "select * from idioma";



                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    _idiomas.Add(
                     new Idioma()
                     {                         
                         Id = int.Parse(reader["id_idioma"].ToString()),
                         Nombre = reader["nombre"].ToString(),
                         Default = bool.Parse(reader["idioma_default"].ToString())

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

        public static IDictionary<string, ITraduccion> ObtenerTraducciones(IIdioma idioma = null)
        {
            //si no hay idioma definido, traigo el idioma por default
            if (idioma == null)
            {
                idioma = ObtenerIdiomaDefault();
            }


            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.InitialCatalog = "SISCAB";
            cs.DataSource = "DESKTOP-I7LNRPI";
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
                //cmd.CommandText = "select t.id_idioma,t.traduccion as traduccion_traduccion, e.id_etiqueta,e.nombre as nombre_etiqueta from traducciones t inner join etiquetas e on t.id_etiqueta=e.id_etiqueta where t.id_idioma = @id_idioma";
                cmd.CommandText = "select t.id_idioma,t.traduccion as traduccion_traduccion, e.id_etiqueta,e.nombre as nombre_etiqueta from traduccion t inner join etiqueta e on t.id_etiqueta=e.id_etiqueta where t.id_idioma = @id_idioma";
                cmd.Parameters.AddWithValue("id_idioma", idioma.Id);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var etiqueta = reader["nombre_etiqueta"].ToString();
                    _traducciones.Add(etiqueta,
                     new Traduccion()
                     {

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
