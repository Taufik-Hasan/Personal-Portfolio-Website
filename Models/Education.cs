using System.ComponentModel.DataAnnotations;

namespace Taufik_Hasan.Models
{
    public class Education
    {
        [Key]
        public int EducationID { get; set; }
        public string Degree { get; set; }
        public string Institute { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public string Result { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
    }
}
