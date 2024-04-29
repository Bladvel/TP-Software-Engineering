using Org.BouncyCastle.Asn1.Tsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLBackupService
    {
        private DAL.BackupRepository backup = new DAL.BackupRepository();

        public void CreateBackup(string path)
        {
            backup.CreateBackup(path);
        }

        public void RestoresBackup(string path)
        {
            backup.RestoresBackup(path);
        }
        

    }
}
