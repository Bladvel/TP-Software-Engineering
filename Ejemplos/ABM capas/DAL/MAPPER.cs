using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class MAPPER<T>
    {
        internal ACCESO acceso = new ACCESO();
        public abstract int Insertar(T obj);
        public abstract int Updatear(T obj);
        public abstract int Deletear(T obj);
        public abstract T Convertir(DataRow dr);
        public abstract List<T> GetList();

    }
}
