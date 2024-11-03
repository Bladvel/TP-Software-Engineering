using Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Backup
    {
        DAL.BackupRepository backupRepository = new DAL.BackupRepository();
        Bitacora bllBitacora = new Bitacora();
        public int CreateBackup(string ruta)
        {
            int resultado = backupRepository.CreateBackup(ruta);

            if (resultado != -1)
            {
                
                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.Backup,
                    Operacion = TipoOperacion.Backup,
                    Criticidad = 1
                };

                bllBitacora.Insertar(logEntry);
            }


            return resultado;
        }


        public void RestoreBackup(string ruta)
        {
            backupRepository.RestoreBackup(ruta);
        }


    }
}
