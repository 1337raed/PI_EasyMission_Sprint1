using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMission.Domaine.Entity
{
    public class CurriculumVitae
    {
        public int CurriculumVitaeId { get; set; }
        public string CurentFunction { get; set; }
        public string CurrentBusinessSector { get; set; }
        public Expereince MyExpereince { get; set; }
        public string TypeOfContract { get; set; }
        public string Fonctions { get; set; }
        public string BusinessLine { get; set; }
        public DateTime DateOfAvailability { get; set; }
        public string DesiredSalary { get; set; }
        public string TypeOfStudiesDiplomas { get; set; }
        public string OtherTraining { get; set; }
        public string LanguageReadWrittenSpoken { get; set; }
        public string LanguageUnderstood { get; set; }
        public Adress GeographiqueArea { get; set; }
        public virtual JobSeker jobSeker { get; set; }
    }
}
