using Microsoft.AspNetCore.Mvc;
using Taufik_Hasan.Models;
using Taufik_Hasan.Repository.Interface;

namespace Taufik_Hasan.Controllers
{
    public class AdminController : Controller
    {
		private readonly IPersonalInfromation userRepository;
		private readonly IBlog blogRepository;

		public AdminController(IPersonalInfromation userRepository, IBlog blog)
        {
            this.userRepository = userRepository;
			this.blogRepository = blog;

        }



        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Dashboard()
		{
			return View();
		}

		

		public async Task<IActionResult> PersonalInformation()
        {
			var data = await userRepository.GetPersonalInformation();
			return View(data);
		}

		[HttpPost]
		public async Task<IActionResult> PersonalInformation(PersonalInformation user)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					TempData["ErrorMessage"] = "ModelState is Not Valid";
					return View(user);
				}
				else
				{
					bool isUpdated = await userRepository.UpdateUser(user);
					if (isUpdated)
					{
						TempData["Message"] = "User Updated Successfully";
					}
					else
					{
						TempData["ErrorMessage"] = "Something went wrong";
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
			return RedirectToAction("PersonalInformation");
		}



        public IActionResult Skill()
        {
            return View();
        }

		public IActionResult Education()
		{
			return View();
		}

		public IActionResult Experience()
		{
			return View();
		}

		public IActionResult Project()
		{
			return View();
		}

		public IActionResult Services()
		{
			return View();
		}

		public async Task<IActionResult> Blog()
		{
			var data = await blogRepository.GetBlogs();
			Console.WriteLine(data);
			return View(data);
		}

        public async Task<IActionResult> AddBlog()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBlog(Blog blog)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(blog);
                }
                else
                {
                    await blogRepository.AddBlog(blog);
                    if (blog.BlogID > 0)
                    {
                        TempData["Message"] = "Blog Added Successfully";
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Something went wrong";
                    }
                    return RedirectToAction("Blog");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return View();
        }



        public IActionResult Settings()
		{
			return View();
		}

		public IActionResult Logout()
		{
			return LocalRedirect("/Home/");
		}
	}
}
