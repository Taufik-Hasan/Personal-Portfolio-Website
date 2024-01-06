using Microsoft.EntityFrameworkCore;
using Taufik_Hasan.Data;
using Taufik_Hasan.Models;
using Taufik_Hasan.Repository.Interface;

namespace Taufik_Hasan.Repository.Service
{
    public class SkillService:ISkill
    {
        private readonly ApplicationDbContext context;

        public SkillService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Skill>> GetSkills()
        {
            var data = await context.Skills.ToListAsync();
            return data;
        }
    }
}
