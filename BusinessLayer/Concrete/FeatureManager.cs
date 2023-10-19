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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            this.featureDal = featureDal;
        }

        public Feature get(int id)
        {
            return featureDal.get(id);
        }

        public List<Feature> GetAll()
        {
            return featureDal.getList();
        }

        public List<Feature> getListbyFinder(Expression<Func<Feature, bool>> finder)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Feature t)
        {
            featureDal.insert(t);
        }

        public void TDelete(Feature t)
        {
            featureDal.delete(t);
        }

        public void TUpdate(Feature t)
        {
            featureDal.update(t);
        }
    }
}
