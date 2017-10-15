using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace EasyMission.Data.Infrastructure
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private EasyMissionContext context;
        public EasyMissionContext Context { get; set; }

        static IDbSet<T> dbset;

        public RepositoryBase(DataBaseFactory dbFactory)
        {
            Context = dbFactory.MyContext;
            dbset = Context.Set<T>();
        }

        public void Commit()
        {
            Context.SaveChanges();
        }


        public void Add(T entity)
        {
            dbset.Add(entity);
        }

        public void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public void Update(T entity)
        {
            dbset.Attach(entity); 
            Context.Entry(entity).State = EntityState.Modified;
        }

        public T GetById(int id)
        {
            return dbset.Find(id);
        }

        public T GetById(string id)
        {
            return dbset.Find(id);
        }

        public void delete(Expression<Func<T, bool>> condition)
        {
            IEnumerable<T> MaListe = dbset.Where(condition);
            foreach (T item in MaListe)
                dbset.Remove(item);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> orderBy = null)
        {
            IQueryable<T> List = dbset;
            if ((condition != null) && (orderBy != null))
                return List.Where(condition).OrderBy(orderBy);
            else
                if ((condition != null) && (orderBy == null))
                return List.Where(condition);
            else
                if ((orderBy != null) && (condition == null))
                return List.OrderBy(orderBy);

            else return List;
        }
    }
}
