using Taufik_Hasan.Models;
namespace Taufik_Hasan.Repository.Interface
{
    public interface IPersonalInfromation
    {
        Task<PersonalInformation> GetPersonalInformation();
        Task<bool> UpdateUser(PersonalInformation user);

    }
}
