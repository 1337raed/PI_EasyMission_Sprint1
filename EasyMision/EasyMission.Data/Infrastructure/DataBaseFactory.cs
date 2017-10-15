using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Data.Infrastructure
{
    public class DataBaseFactory : Disposable ,IDataBaseFactory
    {
        private EasyMissionContext context;

        public EasyMissionContext MyContext { get { return context; } }

        public DataBaseFactory()
        {

            context = new EasyMissionContext();
        }
        protected override void DisposeCore()
        {
            if (MyContext != null)
                MyContext.Dispose();
        }
    }
}
