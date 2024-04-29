using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BackupRepository
    {

        //SqlConnection conexion = new SqlConnection("data source=(local); integrated security= true; initial catalog= SISCAB");
        SqlConnection conexion = new SqlConnection("data source=DESKTOP-I7LNRPI; integrated security=true; initial catalog= SISCAB");
        public void CreateBackup(string consulta)
        {
            
            string comando_consulta = "BACKUP DATABASE[SISCAB] TO DISK = N'" + consulta +"' WITH NOFORMAT, NOINIT, NAME = N'SISCAB-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            SqlCommand cmd = new SqlCommand(comando_consulta,conexion);           
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        
        public void RestoresBackup(string consulta)
        {

            conexion.Open();
            
                string str1 = string.Format("ALTER DATABASE [SISCAB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1,conexion); 
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [SISCAB] FROM DISK = '" + consulta + "' WITH REPLACE;"; 
                SqlCommand cmd2 = new SqlCommand(str2,conexion);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [SISCAB] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, conexion);
                cmd3.ExecuteNonQuery();

                conexion.Close(); 
            

        }
       

    }
}
