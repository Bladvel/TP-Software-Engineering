using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Mapper<T>
    {
        internal Access access = new Access();
        public abstract T GetById(object id);
        public abstract T Transform(DataRow dr);
        public abstract List<T> GetAll();
        public abstract int Insert(T entity);
        public abstract int Update(T entity);
        public abstract int Delete(T entity);

    }
}
