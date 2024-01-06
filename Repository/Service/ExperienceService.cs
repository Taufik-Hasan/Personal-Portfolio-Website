using Microsoft.EntityFrameworkCore;
using Taufik_Hasan.Data;
using Taufik_Hasan.Models;
using Taufik_Hasan.Repository.Interface;

namespace Taufik_Hasan.Repository.Service
{
    public class ExperienceService : IExperience
    {
        private readonly ApplicationDbContext context;

        public ExperienceService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Experience>> GetExperiences()
        {
            var data = await context.Experiences.ToListAsync();
            return data;
        }
    }
}
