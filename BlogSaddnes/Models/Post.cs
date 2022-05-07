namespace BlogSaddnes.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public virtual User? Author { get; set; }
        public string? AuthorId { get; set; }
        public virtual Blog? Blog { get; set; }
        public int? BlogId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Content { get; set; } = string.Empty;
    }
}
