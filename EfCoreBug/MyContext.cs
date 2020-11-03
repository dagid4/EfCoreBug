using Microsoft.EntityFrameworkCore;

namespace EfCoreBug
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename=my.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Garage>().ToTable("Garage");

            modelBuilder.Entity<Car>().ToTable("Car");

            modelBuilder.Entity<Ferrari>().ToTable("Ferrari");

            modelBuilder.Entity<Special>().ToTable("Special");
        }
    }
}
