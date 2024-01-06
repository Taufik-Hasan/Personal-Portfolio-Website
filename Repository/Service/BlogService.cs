using Microsoft.EntityFrameworkCore;
using Taufik_Hasan.Data;
using Taufik_Hasan.Models;
using Taufik_Hasan.Repository.Interface;

namespace Taufik_Hasan.Repository.Service
{
	public class BlogService: IBlog
	{
		private readonly ApplicationDbContext context;

		public BlogService(ApplicationDbContext context)
		{
			this.context = context;
		}

		public async Task<IEnumerable<Blog>> GetBlogs()
		{
			var data = await context.Blogs.ToListAsync();
			return data;
		}

		public async Task<Blog> GetBlog(int? id)
		{
			var data = await context.Blogs.FirstOrDefaultAsync(x => x.BlogID == id);
			return data;
		}

		public async Task<int> AddBlog(Blog blog)
		{
			try
			{
                await context.Blogs.AddAsync(blog);
                await context.SaveChangesAsync();
                return blog.BlogID;
            }
			catch (Exception)
			{
				return 0;
			}
		}

		public async Task<bool> UpdateBlog(Blog blog)
		{
			try
			{
				context.Blogs.Update(blog);
				await context.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<bool> DeleteBlog(int? id)
		{
			try
			{
				var data = await GetBlog(id);
				context.Blogs.Remove(data);
				await context.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
