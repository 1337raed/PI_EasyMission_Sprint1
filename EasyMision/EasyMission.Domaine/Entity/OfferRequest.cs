using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Domaine.Entity
{
    class OfferRequest
    {
        [Key]
        public int jobSeekerId { get; set; }
        [Key]
        public int OfferId { get; set; }
        public int IsApproved { get; set; }
        public DateTime RequestDate { get; set; }
        public string MotivationLetter { get; set; }
        public virtual ICollection<JobSeker> listJoobSeeker { get; set; }
        public virtual ICollection<Offer> MyProperty { get; set; }

    }
}
