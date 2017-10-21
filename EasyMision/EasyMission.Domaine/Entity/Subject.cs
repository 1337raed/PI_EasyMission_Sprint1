using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Domaine.Entity
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public int forumId { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public int MyProperty { get; set; }
        public int viewsCount { get; set; }
        public int viewsPost { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        [ForeignKey("forumId")]
        public virtual Forum MyForum { get; set; }
        [ForeignKey("userId")]
        public virtual User MyUser { get; set; }


    }
}
