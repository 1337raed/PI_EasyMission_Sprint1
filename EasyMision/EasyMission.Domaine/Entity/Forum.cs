using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Domaine.Entity
{
    public class Forum
    {
        public int ForumId{ get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category MyCategory { get; set; }
        public virtual ICollection<Subject> MySubjects { get; set; }
    }
}
