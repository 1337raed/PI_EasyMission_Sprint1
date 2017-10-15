﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Data.Infrastructure
{
    public interface IDataBaseFactory:IDisposable
    {
        EasyMissionContext MyContext { get; }
    }
}
