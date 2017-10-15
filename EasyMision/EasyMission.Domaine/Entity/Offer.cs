using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Domaine.Entity
{
   public class Offer
    {
        public int offerId { get; set; }
        public int UserId { get; set; }
        public OfferType MyOffertype { get; set; }
        public string OfferDescription { get; set; }
        public DateTime DatePostulation { get; set; }
        public DateTime DateEnd { get; set; }
        public float rating { get; set; }
        public OfferArea Myarea { get; set; }
        public int viewNumber { get; set; }
        public Recruter userId { get; set; }
        public virtual Recruter MyRecruter { get; set; }

    }
}
