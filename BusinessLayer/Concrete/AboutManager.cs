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
    public class AboutManager : IAboutService
    {
        IAboutDal aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            this.aboutDal = aboutDal;
        }

        public About get(int id)
        {
            return aboutDal.get(id);
        }

        public List<About> GetAll()
        {
            return aboutDal.getList();
        }

        public List<About> getListbyFinder(Expression<Func<About, bool>> finder)
        {
            throw new NotImplementedException();
        }

        public void TAdd(About t)
        {
            aboutDal.insert(t);
        }

        public void TDelete(About t)
        {
            aboutDal.delete(t);
        }

        public void TUpdate(About t)
        {
            aboutDal.update(t);
        }
    }
}
