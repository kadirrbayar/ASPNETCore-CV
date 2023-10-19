using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void delete(T entity)
        {
            using var c = new Context();
            c.Remove(entity);
            c.SaveChanges();
        }

        public T get(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> getList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public List<T> getListbyFinder(Expression<Func<T, bool>> finder)
        {
            using var c = new Context();
            return c.Set<T>().Where(finder).ToList();
        }

        public void insert(T entity)
        {
            using var c = new Context();
            c.Add(entity);
            c.SaveChanges();
        }

        public void update(T entity)
        {
            using var c = new Context();
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
