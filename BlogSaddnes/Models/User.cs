using Microsoft.AspNetCore.Identity;

namespace BlogSaddnes.Models
{
    public class User : IdentityUser
    {
        public virtual List<Blog>? Blogs { get; set; }
        public virtual ICollection<Post>? Posts { get; set; }
    }
}
