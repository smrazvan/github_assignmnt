namespace Blogger_server.Entities
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public string Tag { get; set; } = string.Empty;

        public DateTime Date { get; set; }

    }
}
