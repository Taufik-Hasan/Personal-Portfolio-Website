using Taufik_Hasan.Models;

namespace Taufik_Hasan.Repository.Interface
{
	public interface IBlog
	{
		Task<IEnumerable<Blog>> GetBlogs();
		Task<Blog> GetBlog(int? id);
		Task<int> AddBlog(Blog blog);
		Task<bool> UpdateBlog(Blog blog);
		Task<bool> DeleteBlog(int? id);
	}
}
