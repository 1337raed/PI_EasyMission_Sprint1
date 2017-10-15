using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Data.Infrastructure
{
    public class UnityOfWork : IUnityOfWork
    {
        private DataBaseFactory dbf;

        public DataBaseFactory Dbfactory
        {
            get
            {
                return dbf;
            }

        }
        public void Commit()
        {
            dbf.MyContext.SaveChanges();
        }

        public void Dispose()
        {
            dbf.MyContext.Dispose();
            
        }

        public IRepositoryBase<T> GetRepository<T>() where T : class
        {
            return new RepositoryBase<T>(Dbfactory);
        }
    }
}
