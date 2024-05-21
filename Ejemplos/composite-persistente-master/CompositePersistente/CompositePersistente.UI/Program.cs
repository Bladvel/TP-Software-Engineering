using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePersistente.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            var repo = new Repository();
            var lista = repo.GetAll(string.Empty);
            var puedeHacerBackup = repo.IsInRole(1);
        }
    }
}
