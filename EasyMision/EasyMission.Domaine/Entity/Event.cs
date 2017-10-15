using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Domaine.Entity
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventLabel { get; set; }
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }
        public int EventCost { get; set; }
        public int userId { get; set; }
        public virtual Recruter recruter { get; set; }
    }
}
