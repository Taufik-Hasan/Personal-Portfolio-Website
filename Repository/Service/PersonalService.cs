using Microsoft.EntityFrameworkCore;
using Taufik_Hasan.Data;
using Taufik_Hasan.Models;
using Taufik_Hasan.Repository.Interface;

namespace Taufik_Hasan.Repository.Service
{
    public class PersonalService : IPersonalInfromation
    {
        private readonly ApplicationDbContext context;

        public PersonalService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<PersonalInformation> GetPersonalInformation()
        {
            var data = await context.PersonalInformations.ToListAsync();
            var item= data.FirstOrDefault();
            if(item == null)
            {
                item = new PersonalInformation();
                item.UserID = 0;
                item.Name = "Default User";
                item.Image = "Default.jpg";
                item.Profession = "Default Profession";
                item.Objective= "User Default Objective";
                item.Email = "example@domain.com";
                item.Phone = "+880 ### ### ##";
                item.DOB = "Date of Birth";
                item.PresentAddress = "Bangladesh";
                item.PermanentAddress = "Bangladesh";
                item.Website = "www.example.com";
                item.FbLink = "#";
                item.TwiterLink = "#";
                item.LinkDinLink = "#";
            }
            return item;
        }

		public async Task<bool> UpdateUser(PersonalInformation user)
		{
			bool isUpdated = false;
			if (user != null)
			{
				context.PersonalInformations.Update(user);
				await context.SaveChangesAsync();
				isUpdated = true;
			}
			return isUpdated;
		}
	}
}
