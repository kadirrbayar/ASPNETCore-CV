using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            this.toDoListDal = toDoListDal;
        }

        public ToDoList get(int id)
        {
            return toDoListDal.get(id);
        }

        public List<ToDoList> GetAll()
        {
            return toDoListDal.getList();
        }

        public List<ToDoList> getListbyFinder(Expression<Func<ToDoList, bool>> finder)
        {
            throw new NotImplementedException();
        }

        public void TAdd(ToDoList t)
        {
            toDoListDal.insert(t);
        }

        public void TDelete(ToDoList t)
        {
            toDoListDal.delete(t);
        }

        public void TUpdate(ToDoList t)
        {
            toDoListDal.update(t);
        }
    }
}
