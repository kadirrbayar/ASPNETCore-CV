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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            this.socialMediaDal = socialMediaDal;
        }

        public SocialMedia get(int id)
        {
            return socialMediaDal.get(id);
        }

        public List<SocialMedia> GetAll()
        {
            return socialMediaDal.getList(); 
        }

        public List<SocialMedia> getListbyFinder(Expression<Func<SocialMedia, bool>> finder)
        {
            throw new NotImplementedException();
        }

        public void TAdd(SocialMedia t)
        {
            socialMediaDal.insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            socialMediaDal.delete(t);
        }

        public void TUpdate(SocialMedia t)
        {
            socialMediaDal.update(t);
        }
    }
}
