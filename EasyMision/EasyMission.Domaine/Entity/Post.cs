using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Domaine.Entity
{
    public class Post
    {
        public int PostId { get; set; }
        public int ForumId { get; set; }
        public int SubjectId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        [ForeignKey("ForumId")]
        public Forum MyForum { get; set; }
        [ForeignKey("SubjectId")]
        public Subject MySubject { get; set; }
        [ForeignKey("UserId")]
        public User Myuser { get; set; }
    }
}
