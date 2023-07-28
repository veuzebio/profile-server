using Microsoft.EntityFrameworkCore;
using DomainModel = Profile.Domain.Resume.Models;

namespace Profile.Infra.Data
{
    public class ProfileDbContext: DbContext
    {
        public DbSet<DomainModel.Resume> Resumes { get; set; }
        public DbSet<DomainModel.Profile> Profiles { get; set; }
        public DbSet<DomainModel.Education> Educations { get; set; }
        public DbSet<DomainModel.Experience> Experiences { get; set; }
        public DbSet<DomainModel.Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<DomainModel.Resume>()
                .Property(e => e.Skills)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=LocalDatabase.db");
        }
    }
}