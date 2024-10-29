using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BackupRepository
    {

        Access access = new Access();

        public int CreateBackup(string ruta)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@ruta", ruta)
            };

            access.Open();
            int resultado = access.WriteScalar("GENERAR_BACKUP", parameters);
            access.Close();

            return resultado;
        }

        public void RestoreBackup(string ruta)
        {
            //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            //builder.DataSource = "DESKTOP-DAN";
            //builder.InitialCatalog = "TpRESTAURANTE";
            //builder.IntegratedSecurity = true;


            string strConn = ConfigurationManager.ConnectionStrings["Principal"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(strConn))
            {
                conexion.Open();

                SqlCommand cmd1 = new SqlCommand("ALTER DATABASE [TpRESTAURANTE] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", conexion);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("USE MASTER RESTORE DATABASE [TpRESTAURANTE] FROM DISK = N'" + ruta + @"' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10;", conexion);
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand("ALTER DATABASE [TpRESTAURANTE] SET MULTI_USER", conexion);
                cmd3.ExecuteNonQuery();

                conexion.Close();
            }
        }
    }
}
