using Taufik_Hasan.Models;

namespace Taufik_Hasan.Repository.Interface
{
    public interface IEducation
    {
        Task<IEnumerable<Education>> GetEducations();
    }
}
