using System.ComponentModel.DataAnnotations;

namespace Taufik_Hasan.Models
{
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }
        public string SkillName { get; set; }
        public string SkillLevel { get; set; }
        public string SkillDescription { get; set; }
        public int Catagory { get; set; }
            
    }
}
