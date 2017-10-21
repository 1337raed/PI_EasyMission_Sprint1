using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMission.Domaine.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EasyMission.Data
{
    public class EasyMissionContext:DbContext
    {
        public EasyMissionContext()
        {
        }
    }
}
