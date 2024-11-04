using c_.git.razorweb.Models;
using Microsoft.EntityFrameworkCore;

namespace razorweb.Models {
    public class MyBlogContext : DbContext {
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
          
        }
        public DbSet<Article> articles { get; set; }
    }
}