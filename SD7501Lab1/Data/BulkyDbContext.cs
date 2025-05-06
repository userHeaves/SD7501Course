using Microsoft.EntityFrameworkCore;
using SD7501Lab1.Models;

namespace SD7501Lab1.Data
{
    public class BulkyDbContext :DbContext
    {
        public BulkyDbContext(DbContextOptions<BulkyDbContext> options) : base(options)
        {

        }
            public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                 new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                  new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
        }
    }
}
