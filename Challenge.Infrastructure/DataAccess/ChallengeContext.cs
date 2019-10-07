using Microsoft.EntityFrameworkCore;
using Challenge.Core.Models;

namespace Challenge.Infrastructure.DataAccess
{
    public class ChallengeContext : DbContext
    {
        public ChallengeContext(DbContextOptions<ChallengeContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureForUser(modelBuilder);
        }

        private void ConfigureForUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(c => c.FirstName).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<User>().Property(c => c.LastName).HasMaxLength(255).IsRequired();

        }
    }
}