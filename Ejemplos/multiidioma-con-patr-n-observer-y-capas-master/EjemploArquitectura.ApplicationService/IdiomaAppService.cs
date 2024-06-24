using EjemploArquitectura.Abstractions;
using EjemploArquitectura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArquitectura.ApplicationService
{
    public class IdiomaAppService
    {
        IdiomaRepository _idiomas;
        public IdiomaAppService()
        {
            _idiomas = new IdiomaRepository();
        }
       
    }
}
