using System.ComponentModel.DataAnnotations;

namespace Taufik_Hasan.Models
{
    public class PersonalInformation
    {
        [Key]
        public int UserID { get; set; }
        public  string Name { get; set; }
        public  string Image { get; set; }
        public  string Profession { get; set; }
        public  string Objective { get; set; }
        public  string PresentAddress { get; set; }
        public  string PermanentAddress { get; set; }
        public  string Email { get; set; }
        public  string Phone { get; set; }
        public  string DOB { get; set; }
        public  string Website { get; set; }
        public  string FbLink { get; set; }
        public  string LinkDinLink { get; set; }
        public  string TwiterLink { get; set; }
    }
}
