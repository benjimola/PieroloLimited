namespace Pierolo.com.Model
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string? Author { get; set; }
        public bool IsPublished { get; set; } = false;
    }
}
