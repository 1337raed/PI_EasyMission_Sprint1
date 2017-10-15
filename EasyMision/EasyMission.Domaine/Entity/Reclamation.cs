using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Domaine.Entity
{
    public class Reclamation
    {
        public int ReclamationId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int AdministratorId{ get; set; }
        public int JobSeekerId { get; set; }
        [ForeignKey("AdministratorId")]
        public virtual Administrator admin { get; set; }
        [ForeignKey("JobSeekerId")]
        public virtual JobSeker jobseeker { get; set; }
    }
}
