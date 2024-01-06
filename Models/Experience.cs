using System.ComponentModel.DataAnnotations;

namespace Taufik_Hasan.Models
{
    public class Experience
    {
        [Key]
        public int ExperienceID { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
    }
}
