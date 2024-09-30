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
        public int CreateBackup(string ruta)
        {
            return backupRepository.CreateBackup(ruta);
        }


        public void RestoreBackup(string ruta)
        {
            backupRepository.RestoreBackup(ruta);
        }


    }
}
