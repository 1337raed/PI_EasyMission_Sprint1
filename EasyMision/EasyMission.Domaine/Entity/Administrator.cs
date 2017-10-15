using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Domaine.Entity
{
    public class Administrator:User
    {
        public virtual ICollection<Reclamation> listReclamation { get; set; }
    }
}
