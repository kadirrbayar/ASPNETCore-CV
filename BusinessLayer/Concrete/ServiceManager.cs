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
    public class ServiceManager : IServiceService
    {
        IServiceDal serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            this.serviceDal = serviceDal;
        }

        public Service get(int id)
        {
            return serviceDal.get(id);
        }

        public List<Service> GetAll()
        {
            return serviceDal.getList();
        }

        public List<Service> getListbyFinder(Expression<Func<Service, bool>> finder)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Service t)
        {
            serviceDal.insert(t);
        }

        public void TDelete(Service t)
        {
            serviceDal.delete(t);
        }

        public void TUpdate(Service t)
        {
            serviceDal.update(t);
        }
    }
}
