using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Domaine.Entity
{
    public class Message
    {
        public string MessageCore { get; set; }
        public DateTime SendDate { get; set; }
        public Boolean IsRead { get; set; }
        [Key]
        public int userSendId { get; set; }
        [Key]
        public int userRceiverId { get; set; }
        [ForeignKey("userSendId")]
        public virtual User sendUser { get; set; }
        [ForeignKey("userRceiverId")]
        public virtual User ReceiveUser { get; set; }

    }
}
