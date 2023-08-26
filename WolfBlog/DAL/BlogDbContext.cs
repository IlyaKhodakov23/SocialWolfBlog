using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WolfBlog.DAL.Models.Response.Comments;
using WolfBlog.DAL.Models.Response.Posts;
using WolfBlog.DAL.Models.Response.Roles;
using WolfBlog.DAL.Models.Response.Tags;
using WolfBlog.DAL.Models.Response.Users;
using System.Xml;

namespace WolfBlog.DAL
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

