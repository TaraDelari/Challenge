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
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureForUser(modelBuilder);
            ConfigureForRole(modelBuilder);
            ConfigureForUserRole(modelBuilder);
        }

        private void ConfigureForUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(c => c.Email).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<User>().Property(c => c.PasswordHash).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<User>().Ignore(x => x.Roles);
        }

        private void ConfigureForRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasKey(x => x.Name);
            modelBuilder.Entity<Role>().Property(x => x.Name).HasMaxLength(200);
            modelBuilder.Entity<Role>().Property(x => x.DisplayName).HasMaxLength(500);
        }

        private void ConfigureForUserRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>().HasKey(x => new { x.UserId, x.RoleName });
            modelBuilder.Entity<UserRole>().HasOne(x => x.User).WithMany(x => x.UserRoles).HasForeignKey(x => x.UserId).IsRequired();
            modelBuilder.Entity<UserRole>().HasOne(x => x.Role).WithMany().HasForeignKey(x => x.RoleName).IsRequired();
        }
    }
}