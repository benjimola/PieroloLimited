using Pierolo.com.Model;

namespace Pierolo.com.IServices
{
    public interface IBlogService
    {
        List<BlogPost> GetBlogPosts();
        BlogPost GetBlogPost(int id);
    }
}
