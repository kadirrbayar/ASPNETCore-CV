using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void insert(T entity);
        void update(T entity);
        void delete(T entity);
        List<T> getList();
        T get(int id);
        List<T> getListbyFinder(Expression<Func<T, bool>> finder);
    }
}
