using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using Taufik_Hasan.Models;
using Taufik_Hasan.Repository.Interface;

namespace Taufik_Hasan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonalInfromation userRepository;
        private readonly ISkill skillRepository;
        private readonly IEducation educationRepository;
        private readonly IExperience experienceRepository;
        private readonly IBlog blogRepository;

        public HomeController(ILogger<HomeController> logger, IPersonalInfromation userRepository, ISkill skillRepository,
            IEducation educationRepository, IExperience experienceRepository, IBlog blogRepository)
        {
            _logger = logger;
            this.userRepository = userRepository;
            this.skillRepository = skillRepository;
            this.educationRepository = educationRepository;
            this.experienceRepository = experienceRepository;
            this.blogRepository = blogRepository;
        }

        public async Task<IActionResult> Index()
        {
            var data = await userRepository.GetPersonalInformation();
            var skill = await skillRepository.GetSkills();
            var education = await educationRepository.GetEducations();
            var experience = await experienceRepository.GetExperiences();
            var result = new Tuple<PersonalInformation, IEnumerable<Skill>, IEnumerable<Education>, IEnumerable<Experience>>(data, skill, education, experience );
            return View(result);
        }

        public async Task<IActionResult> Privacy()
        {
            var data = await userRepository.GetPersonalInformation();
            var skill = await skillRepository.GetSkills();
            var education = await educationRepository.GetEducations();
            var experience = await experienceRepository.GetExperiences();
            var result = new Tuple<PersonalInformation, IEnumerable<Skill>, IEnumerable<Education>, IEnumerable<Experience>>(data, skill, education, experience);
            return View(result);
        }

		public async Task<IActionResult> Blog()
		{
			var data = await userRepository.GetPersonalInformation();
            var blog = await blogRepository.GetBlogs();
			var result = new Tuple<PersonalInformation, Blog>(data,blog);
			return View(result);
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
