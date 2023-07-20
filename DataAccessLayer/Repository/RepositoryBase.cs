using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter = null)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        public T GetById(int id)
        {
            using var context = new Context();
            return context.Set<T>().Find(id);
           
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
            
        }

        public void Insert(T entity)
        {
            using var c = new Context();
            c.Add(entity);
            c.SaveChanges();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
