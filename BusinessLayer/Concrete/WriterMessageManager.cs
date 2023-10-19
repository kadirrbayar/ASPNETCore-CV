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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public WriterMessage get(int id)
        {
            return _writerMessageDal.get(id);
        }

        public List<WriterMessage> GetAll()
        {
            return _writerMessageDal.getList();
        }

        public List<WriterMessage> getListbyFinder(Expression<Func<WriterMessage, bool>> finder)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> getReceiverMessage(Expression<Func<WriterMessage, bool>> finder)
        {
            return _writerMessageDal.getListbyFinder(finder).ToList();

        }

        public List<WriterMessage> getSenderMessage(Expression<Func<WriterMessage, bool>> finder)
        {
            return _writerMessageDal.getListbyFinder(finder).ToList();

        }

        public void TAdd(WriterMessage t)
        {
            _writerMessageDal.insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _writerMessageDal.delete(t);
        }

        public void TUpdate(WriterMessage t)
        {
            _writerMessageDal.update(t);
        }
    }
}
