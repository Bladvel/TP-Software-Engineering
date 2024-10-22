using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public class Backup
    {
        public int IdBackup { get; set; }
        public int Particion { get; set; }
        public string Fecha_Y_Hora { get; set; }
        public string Ruta_Archivo { get; set; }
        
    }
}
