using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            //using var context = new Context();
            //return context.Set<T>().Find(id);
            throw new NotImplementedException();
        }

        public List<T> GetList()
        {
            //using var c = new Context();
            //return c.Set<T>().ToList();
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
