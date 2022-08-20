using Pierolo.com.Model;

namespace Pierolo.com.IServices
{
    public class BlogServiceRepository : IBlogService
    {
        public List<BlogPost> blogPost { get; set; } = new List<BlogPost>(){
            new BlogPost{
                Title = "Mango seeds",
                Id = 1,
                Description = "A mango thing",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Eu augue ut lectus arcu bibendum. Ut sem viverra aliquet eget. Sed tempus urna et pharetra pharetra."

            },
            new BlogPost{
                Title = "Pierolo Limited",
                Id=2,
                Description = "Company",
                Content = "Lorem ipsum dolor sit amet, consectetur ad",
            },
            new BlogPost{
                Title = "Pierolo Limited",
                Id = 3,
                Description = "Company",
                Content = "Lorem ipsum dolor sit amet, consectetur ad",
            },
            new BlogPost{
                Title = "Pierolo Limited",
                Id = 4,
                Description = "Company",
                Content = "Lorem ipsum dolor sit amet, consectetur ad",
            }
        };

        public BlogPost GetBlogPost(int Id)
        {
            throw new NotImplementedException();
        }

        public  List<BlogPost> GetBlogPosts()
        {
            return blogPost;
        }
    }
}
