using Microsoft.EntityFrameworkCore;
using Taufik_Hasan.Data;
using Taufik_Hasan.Models;
using Taufik_Hasan.Repository.Interface;

namespace Taufik_Hasan.Repository.Service
{
    public class EducationService : IEducation
    {
        private readonly ApplicationDbContext context;

        public EducationService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Education>> GetEducations()
        {
            var data = await context.Educations.ToListAsync();
            return data;
        }
    }
}
