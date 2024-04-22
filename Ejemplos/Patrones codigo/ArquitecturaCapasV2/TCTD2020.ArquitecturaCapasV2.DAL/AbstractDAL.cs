using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV2.BE;
using TCTD2020.ArquitecturaCapasV2.Interfaces;

namespace TCTD2020.ArquitecturaCapasV2.DAL
{
    public abstract class AbstractDAL<T> : ICrud<T> where T : IEntity
    {
        protected IList<T> dataContext;
        public AbstractDAL()
        {
            dataContext = new List<T>();
        }

        public void Delete(T entity)
        {
            this.dataContext.Remove(entity);
        }

        public IList<T> GetAll()
        {
            return dataContext;
        }

        public T GetById(Guid id)
        {
            return dataContext.Where(i => i.Id.Equals(id)).FirstOrDefault();
        }

        public void Save(T entity)
        {
            if (dataContext.Contains(entity))
            {
                 //si no fuesen objetos, habria que invocar la forma de actualizar el dato en el entorno de persistencia
            }
            else
            {
                dataContext.Add(entity);
            }
         
        }
    }
}
