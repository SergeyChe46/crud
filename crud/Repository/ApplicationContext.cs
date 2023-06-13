using crud.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace crud.Repository
{
    public class ApplicationContext : IdentityDbContext<Author>
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
