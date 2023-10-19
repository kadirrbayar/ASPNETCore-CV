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
    public class MessageManager : IMessageService
    {
        IMessageDal messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            this.messageDal = messageDal;
        }

        public Message get(int id)
        {
            return messageDal.get(id);
        }

        public List<Message> GetAll()
        {
            return messageDal.getList();
        }

        public List<Message> getListbyFinder(Expression<Func<Message, bool>> finder)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Message t)
        {
            messageDal.insert(t);
        }

        public void TDelete(Message t)
        {
            messageDal.delete(t);
        }

        public void TUpdate(Message t)
        {
            messageDal.update(t);
        }
    }
}
