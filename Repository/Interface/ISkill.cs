using Taufik_Hasan.Models;

namespace Taufik_Hasan.Repository.Interface
{
    public interface ISkill
    {
        Task<IEnumerable<Skill>> GetSkills();
    }
}
