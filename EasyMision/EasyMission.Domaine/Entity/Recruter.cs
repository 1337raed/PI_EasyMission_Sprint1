using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Domaine.Entity
{
    public class Recruter
    {
        public RecruterType MyType { get; set; }
        public string Description { get; set; }
        public DateTime DatePostualtionOffer { get; set; }
        public int Salary { get; set; }
        public int area { get; set; }
        public virtual ICollection<Offer> MyOffer { get; set; }
        public virtual ICollection<Event> listEvent { get; set; }

    }
}
