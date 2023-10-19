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
    public class ContactManager : IContactService
    {
        IContactDal contactDal;

        public ContactManager(IContactDal contactDal)
        {
            this.contactDal = contactDal;
        }

        public Contact get(int id)
        {
            return contactDal.get(id);
        }

        public List<Contact> GetAll()
        {
           return contactDal.getList();
        }

        public List<Contact> getListbyFinder(Expression<Func<Contact, bool>> finder)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Contact t)
        {
            contactDal.insert(t);
        }

        public void TDelete(Contact t)
        {
            contactDal.delete(t);
        }

        public void TUpdate(Contact t)
        {
            contactDal.update(t);
        }
    }
}
