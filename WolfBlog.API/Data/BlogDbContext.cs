using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WolfBlog.API.Data.Models.Response.Comments;
using WolfBlog.API.Data.Models.Response.Posts;
using WolfBlog.API.Data.Models.Response.Roles;
using WolfBlog.API.Data.Models.Response.Tags;
using WolfBlog.API.Data.Models.Response.Users;

namespace WolfBlog.API.Data
{
    public class BlogDbContext : IdentityDbContext<User, Role, string>
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }


        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

