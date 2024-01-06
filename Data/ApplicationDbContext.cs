using Microsoft.EntityFrameworkCore;
using Taufik_Hasan.Models;

namespace Taufik_Hasan.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        
    }
}
