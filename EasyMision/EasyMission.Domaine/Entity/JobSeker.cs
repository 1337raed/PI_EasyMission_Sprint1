using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Domaine.Entity
{
    public class JobSeker:User
    {

        public string personalDescription { get; set; }
        public int CurriculumVitae { get; set; }
        public CurriculumVitae curriculumVitaeId { get; set; }
        public virtual CurriculumVitae cv { get; set; }
    }
}
