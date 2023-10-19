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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            this.testimonialDal = testimonialDal;
        }

        public Testimonial get(int id)
        {
            return testimonialDal.get(id);
        }

        public List<Testimonial> GetAll()
        {
            return testimonialDal.getList();
        }

        public List<Testimonial> getListbyFinder(Expression<Func<Testimonial, bool>> finder)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Testimonial t)
        {
            testimonialDal.insert(t);
        }

        public void TDelete(Testimonial t)
        {
            testimonialDal.delete(t);
        }

        public void TUpdate(Testimonial t)
        {
            testimonialDal.update(t);
        }
    }
}
