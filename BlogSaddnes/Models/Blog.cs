namespace BlogSaddnes.Models
{
    public class Blog
    {
        public int Id { get; set; } 
        public string? Name { get; set; } = null;
        public virtual User? Owner { get; set; } = null;
        public string? OwnerId { get; set; } = string.Empty;
        public string? Description { get; set; } 
        public virtual ICollection<Post>? Posts { get; set; } 
    }
}
