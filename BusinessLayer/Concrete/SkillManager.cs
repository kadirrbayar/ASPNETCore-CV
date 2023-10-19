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
    public class SkillManager : ISkillService
    {
        ISkillDal skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            this.skillDal = skillDal;
        }

        public Skill get(int id)
        {
            return skillDal.get(id);
        }

        public List<Skill> GetAll()
        {
            return skillDal.getList();
        }

        public List<Skill> getListbyFinder(Expression<Func<Skill, bool>> finder)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Skill t)
        {
            skillDal.insert(t);
        }

        public void TDelete(Skill t)
        {
            skillDal.delete(t);  
        }

        public void TUpdate(Skill t)
        {
            skillDal.update(t);
        }
    }
}
