using c_.git.razorweb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace razorweb.Models {
    public class MyBlogContext : IdentityDbContext<AppUser> {
        public MyBlogContext (DbContextOptions<MyBlogContext> options) : base (options) 
        { 

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          base.OnModelCreating(builder);
          foreach (var entityType in builder.Model.GetEntityTypes())
          {
              var entity=  entityType.GetTableName();
              if(entity.StartsWith("AspNet"))
              {
                entityType.SetTableName(entity.Substring(6));
              }

          }
        }
        public DbSet<Article> articles { get; set; }
    }
}