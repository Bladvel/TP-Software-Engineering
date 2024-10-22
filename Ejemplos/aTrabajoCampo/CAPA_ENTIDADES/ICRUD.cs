using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public interface ICRUD<T>
    {
        int Add(T alta, out string msj);

        List<T> GetAll();

        bool Update(T update, out string msj);
        bool Delete(T delete, out string msj);
    }
}
