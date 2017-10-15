using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMission.Domaine.Entity;

namespace EasyMission.Data
{
    public class EasyMissionContext:DbContext 
    {
        public EasyMissionContext():base("name=DefaultConnection")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<CurriculumVitae> CurriculumVitaes { get; set; }
    }
}
