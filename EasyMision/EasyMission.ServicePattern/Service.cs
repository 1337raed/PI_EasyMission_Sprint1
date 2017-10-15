using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EasyMission.Data.Infrastructure;

namespace EasyMission.ServicePattern
{
    class Service<T> : IService<T> where T:class 
    {
        private UnityOfWork utw;
        public Service(UnityOfWork utw)
        {
            this.utw = utw;
        }

        public void Commit()
        {
            utw.Commit();
        }

        public void Create(T entity)
        {
            utw.GetRepository<T>().Add(entity);
        }

        public T GetById(int id)
        {
            return utw.GetRepository<T>().GetById(id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> orderBy = null)
        {
            return utw.GetRepository<T>().GetMany(condition, orderBy);
        }

        public void Remove(T entity)
        {
            utw.GetRepository<T>().Delete(entity);
        }

        public void Remove(Expression<Func<T, bool>> condition)
        {
            utw.GetRepository<T>().delete(condition);
        }

        public void Update(T entity)
        {
            utw.GetRepository<T>().Update(entity);
        }
    }
}
