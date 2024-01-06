using Taufik_Hasan.Models;

namespace Taufik_Hasan.Repository.Interface
{
    public interface IExperience
    {
        Task<IEnumerable<Experience>> GetExperiences();
    }
}
