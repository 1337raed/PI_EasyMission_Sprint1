using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace EasyMission.ServicePattern
{
    interface IService<T>
    {
        void Create(T entity);
        void Remove(T entity);
        void Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> orderBy = null);
        void Remove(Expression<Func<T, bool>> condition);
        void Commit();
    }
}
