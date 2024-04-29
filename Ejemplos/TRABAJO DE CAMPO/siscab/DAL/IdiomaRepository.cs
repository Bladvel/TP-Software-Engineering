using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IdiomaRepository
    {

        IdiomaSqlServerDataProvider _idiomas;
        public IdiomaRepository()
        {
            _idiomas = new IdiomaSqlServerDataProvider();
        }


    }
}
