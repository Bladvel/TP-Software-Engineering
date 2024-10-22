using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTIDADES;

namespace CAPA_DATOS.DAOs
{
    public static class DAOS_DVV
    {
        public static bool ActualizarDVV(DVV dvv)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    string query = @"
                            IF EXISTS (SELECT 1 FROM DVV WHERE TablaNombre = @nombreTabla)
                            BEGIN
                                UPDATE DVV
                                SET ValorDVV = @dvv, Fecha_Actualizacion = GETDATE()
                                WHERE TablaNombre = @nombreTabla;
                            END
                            ELSE
                            BEGIN
                                INSERT INTO DVV (TablaNombre, ValorDVV, Fecha_Actualizacion)
                                VALUES (@nombreTabla, @dvv, GETDATE());
                            END";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@dvv", dvv.ValorDVV);
                    cmd.Parameters.AddWithValue("@nombreTabla", dvv.TablaNombre);

                    // Log de los valores antes de ejecutar la consulta
                    Console.WriteLine($"Actualizando DVV: TablaNombre = {dvv.TablaNombre}, ValorDVV = {dvv.ValorDVV}");

                    cmd.CommandType = CommandType.Text;


                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el DVV en la base de datos", ex);
            }
        }

    }
}
