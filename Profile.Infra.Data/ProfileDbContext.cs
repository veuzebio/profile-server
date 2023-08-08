using Microsoft.EntityFrameworkCore;
using Profile.Domain.CharacterAggregate.Models;

namespace Profile.Infra.Data
{
    public class ProfileDbContext: DbContext
    {
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Character>()
                .HasMany(c => c.Items);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=127.0.0.1,1433;Database=LocalDatabase;User Id=sa;Password=#sa123456;TrustServerCertificate=True");
        }
    }
}