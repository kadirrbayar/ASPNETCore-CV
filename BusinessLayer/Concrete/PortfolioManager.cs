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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            this.portfolioDal = portfolioDal;
        }

        public Portfolio get(int id)
        {
            return portfolioDal.get(id);
        }

        public List<Portfolio> GetAll()
        {
            return portfolioDal.getList();
        }

        public List<Portfolio> getListbyFinder(Expression<Func<Portfolio, bool>> finder)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Portfolio t)
        {
            portfolioDal.insert(t);
        }

        public void TDelete(Portfolio t)
        {
            portfolioDal.delete(t);
        }

        public void TUpdate(Portfolio t)
        {
            portfolioDal.update(t);
        }
    }
}
