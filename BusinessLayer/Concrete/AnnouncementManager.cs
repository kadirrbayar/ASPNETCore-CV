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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;
        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public Announcement get(int id)
        {
            return _announcementDal.get(id);
        }

        public List<Announcement> GetAll()
        {
            return _announcementDal.getList();
        }

        public List<Announcement> getListbyFinder(Expression<Func<Announcement, bool>> finder)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Announcement t)
        {
            _announcementDal.insert(t);
        }

        public void TDelete(Announcement t)
        {
            _announcementDal.delete(t);
        }

        public void TUpdate(Announcement t)
        {
            _announcementDal.update(t);
        }
    }
}
