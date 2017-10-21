using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Domaine.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string name { get; set; }
        public virtual ICollection<Forum> MyForums { get; set; }
    }
}
