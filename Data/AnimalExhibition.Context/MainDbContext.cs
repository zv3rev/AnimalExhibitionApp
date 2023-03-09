using AnimalExhibition.ContextEntities;
using Microsoft.EntityFrameworkCore;

namespace AnimalExhibition.Context
{
    public class MainDbContext : DbContext
    {
         public DbSet<Exhibition> Exhibitions { get; set; }

        public MainDbContext(DbContextOptions<MainDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
}
