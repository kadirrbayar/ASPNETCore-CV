using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterMessageService : IGenericService<WriterMessage>
    {
        List<WriterMessage> getReceiverMessage(Expression<Func<WriterMessage, bool>> finder);
        List<WriterMessage> getSenderMessage(Expression<Func<WriterMessage, bool>> finder);

    }
}
