using fproject.Models;
using Microsoft.EntityFrameworkCore;

namespace fproject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options) { }

        public DbSet<Guest> guests { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { DesplayOrder = 3, Id = 1, Name = "Action" },
                new Category { DesplayOrder = 2, Id = 2, Name = "SCIFI" },
                new Category { DesplayOrder = 1, Id = 3, Name = "Adventure" }
                );
        }
    }
}
