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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            this.experienceDal = experienceDal;
        }

        public Experience get(int id)
        {
            return experienceDal.get(id);
        }

        public List<Experience> GetAll()
        {
            return experienceDal.getList();
        }

        public List<Experience> getListbyFinder(Expression<Func<Experience, bool>> finder)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Experience t)
        {
            experienceDal.insert(t);
        }

        public void TDelete(Experience t)
        {
            experienceDal.delete(t);
        }

        public void TUpdate(Experience t)
        {
            experienceDal.update(t);
        }
    }
}
