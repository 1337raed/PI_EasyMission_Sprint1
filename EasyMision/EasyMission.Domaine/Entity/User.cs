using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace EasyMission.Domaine.Entity
{
    public class User
    {
        
       
        public string FristName { get; set; }
        public string LastName { get; set; }
        
        public Sexe Sexe { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public Adress Myadress { get; set; }
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Compare("Password")]
        [NotMapped]
        public string confirmPassword { get; set; }
        public DateTime LastDateLogin { get; set; }
        [Required]
        public string numTelephone { get; set; }
        public string ImageName { get; set; }
        public Boolean IsConnected { get; set; }
        public Boolean IsBanned { get; set; }
        public Boolean IsDeleted { get; set; }
        public Boolean IsActivated { get; set; }
        public virtual ICollection<Subject> Mysubjects { get; set; }
        public virtual ICollection<Message> Message { get; set; }

    }
}
